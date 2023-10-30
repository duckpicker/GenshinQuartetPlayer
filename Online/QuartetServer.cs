using Newtonsoft.Json;
using QuartetPlayer.Online.Events;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace QuartetPlayer.Online;



public class QuartetService : WebSocketBehavior
{
    public static event Action<string> OnBroadcastRequired;

    public static event Action<int> OnKickRequired;

    public static event Action<int, string> OnSendToClient;

    public static string CurrentMidiFilePath;

    public QuartetService()
    {
        OnBroadcastRequired = BroadcastMessage;
        OnKickRequired = KickClientMessage;
        OnSendToClient = SendClientMessage;
    }

    public static void TriggerBroadCast(string str)
    {
        OnBroadcastRequired?.Invoke(str);
    }

    private void BroadcastMessage(string message)
    {
        if (Sessions != null && Sessions.Count > 0)
        {
            foreach (var session in Sessions.IDs) Console.WriteLine(session);
            foreach (var client in QuartetServer.Clients)
            {
                Sessions.SendTo(message, client.SessionID);
                Console.WriteLine(client.SessionID);
            }
            
        }
    }

    public static void TriggerKickCast(int id)
    {
        OnKickRequired?.Invoke(id);
    }

    private void KickClientMessage(int id)
    {
        KickClient(id);
    }

    public static void TriggerSendClientCast(int offset, string session)
    {
        OnSendToClient?.Invoke(offset, session);
    }

    private void SendClientMessage(int offset, string session)
    {
        Sessions.SendTo(JsonConvert.SerializeObject(new SendNewOffsetEvent(-1, offset)), session);
    }
    
    private static int NextID = 1;

    protected override void OnMessage(MessageEventArgs e)
    {
        Console.WriteLine(e.Data);
        
        BaseEvent jsonBaseClass = JsonConvert.DeserializeObject<BaseEvent>(e.Data);
        try
        {
            // CONNECT
            if (typeof(ClientModel).FullName == jsonBaseClass.ClassType)
            {
                Console.WriteLine(typeof(ClientModel).FullName);

                ClientModel jsonClientModel = JsonConvert.DeserializeObject<ClientModel>(e.Data);
                ClientModel client = new ClientModel(NextID, jsonClientModel.Username, jsonClientModel.Offset,
                    jsonClientModel.IsReady);
                var session = Sessions.IDs.Last();
                client.SessionID = session;
                QuartetServer.Clients.Add(client);

                ClientNewIdEvent clientId = new ClientNewIdEvent(NextID, QuartetServer.Clients.MaxBy(c => c.Offset).Offset);
                Send(QuartetServer.SendMidiFile(CurrentMidiFilePath));
                NextID++;
                var clientIdData = JsonConvert.SerializeObject(clientId);
                Send(clientIdData);
                SendMaxPing(QuartetServer.Clients.MaxBy(c => c.Offset).Offset);
                ServerMenuForm.TriggerFormEvent("");
            }

            // CLIENT READY CHECK
            if (typeof(ClientReadyEvent).FullName == jsonBaseClass.ClassType)
            {
                Console.WriteLine(typeof(ClientReadyEvent).FullName);

                ClientReadyEvent jsonIsReady = JsonConvert.DeserializeObject<ClientReadyEvent>(e.Data);
                var client = QuartetServer.Clients.FirstOrDefault(c => c.ID == jsonIsReady.ClientID);
                client.IsReady = jsonIsReady.ClientIsReady;
                Console.WriteLine($"{client.ID}: {client.Username}: {client.IsReady}");
                ServerMenuForm.TriggerFormEvent("");
            }

            // SEND PING(DATE TIME)
            if (typeof(GetPingEvent).FullName == jsonBaseClass.ClassType)
            {
                Console.WriteLine(typeof(GetPingEvent).FullName);
                GetPingEvent jsonGetPing = JsonConvert.DeserializeObject<GetPingEvent>(e.Data);
                GetPingEvent getPing = new GetPingEvent(DateTimeOffset.UtcNow);
                var getPingData = JsonConvert.SerializeObject(getPing);
                Send(getPingData);
            }

            // CLIENT DISCONNECT
            if (typeof(ClientDisconnectEvent).FullName == jsonBaseClass.ClassType)
            {
                Console.WriteLine(typeof(ClientDisconnectEvent).FullName);
                ClientDisconnectEvent jsonClientDisconnect = JsonConvert.DeserializeObject<ClientDisconnectEvent>(e.Data);
                var client = QuartetServer.Clients.FirstOrDefault(c => c.ID == jsonClientDisconnect.ClientID);
                QuartetServer.Clients.Remove(client);
                ServerMenuForm.TriggerFormEvent("");
                var sendDisconnect = JsonConvert.SerializeObject(new ClientDisconnectEvent());
                Send(sendDisconnect);
                Sessions.CloseSession(client.SessionID);
            }

            // CLIENT NEW PING
            if (typeof(SendPingEvent).FullName == jsonBaseClass.ClassType)
            {
                Console.WriteLine(typeof(SendPingEvent).FullName);
                SendPingEvent jsonSendPingEvent = JsonConvert.DeserializeObject<SendPingEvent>(e.Data);
                QuartetServer.Clients[jsonSendPingEvent.ClientID].Offset = jsonSendPingEvent.NewPing;
                var client = QuartetServer.Clients.MaxBy(c => c.MaxPing);
                Console.WriteLine(client.Offset);
                SendMaxPing(client.Offset);
            }
            // GET CONFIRM NEW OFFSET
            if (typeof(SendNewOffsetEvent).FullName == jsonBaseClass.ClassType)
            {
                Console.WriteLine(typeof(SendNewOffsetEvent).FullName);
                var jsonNewOffsetConfirm = JsonConvert.DeserializeObject<SendNewOffsetEvent>(e.Data);
                QuartetServer.Clients[jsonNewOffsetConfirm.ID].Offset = jsonNewOffsetConfirm.Offset;
                Sessions.Broadcast(JsonConvert.SerializeObject(new SendTestNoteEvent()));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    private void SendMaxPing(int maxPing)
    {
        Console.WriteLine(maxPing);
        string jsonGetMaxPing = JsonConvert.SerializeObject(new GetMaxPingEvent(maxPing));
        TriggerBroadCast(jsonGetMaxPing);
    }

    public void KickClient(int index)
    {
        string jsonDisconnect = JsonConvert.SerializeObject(new ClientDisconnectEvent());
        Sessions.SendTo(jsonDisconnect, QuartetServer.Clients[index].SessionID);
        QuartetServer.Clients.RemoveAt(index);
    }
}

public class QuartetServer
{
    public static List<ClientModel> Clients = new List<ClientModel>();

    public static int Port = Program.Port;
    public static string IpAddress = "0.0.0.0";
    private static WebSocketServer Listener;

    public static async Task Start()
    {
        Listener = new WebSocketServer($"ws://{IpAddress}:{Port}");
        Listener.AddWebSocketService<QuartetService>("/QuartetService");
        Listener.Start();
        Console.WriteLine("Server started");
    }

    public static string SendMidiFile(string midiPath)
    {
        Console.WriteLine(midiPath);
        SendMidiFileEvent midiFile = new SendMidiFileEvent();
        midiFile.CurrentMidiFile = File.ReadAllBytes(midiPath);
        string jsonMidiFile = JsonConvert.SerializeObject(midiFile);
        return jsonMidiFile;
    }

    public static void SendNewMidiFile(string midiPath)
    {
        Console.WriteLine(midiPath);
        SendMidiFileEvent midiFile = new SendMidiFileEvent();
        midiFile.CurrentMidiFile = File.ReadAllBytes(midiPath);
        string jsonMidiFile = JsonConvert.SerializeObject(midiFile);
        QuartetService.TriggerBroadCast(jsonMidiFile);
    }


    public static void Stop()
    {
        Listener.Stop();
    }
}
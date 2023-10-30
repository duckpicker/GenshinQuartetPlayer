using Newtonsoft.Json;
using QuartetPlayer.MidiCore;
using QuartetPlayer.Online.Events;
using QuartetPlayer.Online.OnlineWinForms;
using WebSocketSharp;

namespace QuartetPlayer.Online;

public class QuartetClient
{
    public static ClientModel MyClient;
    private static WebSocket Client;
    
    public static async Task ClientCreate(string username, int ping, string ipaddress, int port)
    {
        MyClient = new ClientModel(-1, username, ping, false);
        Client = new WebSocket($"ws://{ipaddress}:{port}/QuartetService");
        
        Client.OnMessage += ClientOnMessage;
    }

    private static void ClientOnMessage(object sender, MessageEventArgs e)
    {
        Console.WriteLine(e.Data);
        
        BaseEvent jsonBaseClass = JsonConvert.DeserializeObject<BaseEvent>(e.Data);
        
        // CONNECT get ID, MidiFile, MaxPing
        if (typeof(ClientNewIdEvent).FullName == jsonBaseClass.ClassType)
        {
            Console.WriteLine(typeof(ClientNewIdEvent).FullName);
            ClientNewIdEvent jsonClientId = JsonConvert.DeserializeObject<ClientNewIdEvent>(e.Data);
            MyClient.ID = jsonClientId.NewID;
            MyClient.MaxPing = jsonClientId.MaxPing;
            GetServerToClientPing();
            ClientMenuForm.TriggerFormEvent("");

            Console.WriteLine(MyClient.ID);
        }
        
        // get MidiFile
        if (typeof(SendMidiFileEvent).FullName == jsonBaseClass.ClassType)
        {
            Console.WriteLine(typeof(SendMidiFileEvent).FullName);
            SendMidiFileEvent jsonMidiFile = JsonConvert.DeserializeObject<SendMidiFileEvent>(e.Data);
            File.WriteAllBytes(Path.Combine(Path.GetTempPath(), "temp.mid"),
                jsonMidiFile.CurrentMidiFile);
            MidiFileRun.Read($"{Path.GetTempPath()}\\temp.mid");
            ClientMenuForm.TriggerFormEvent("");

            Console.WriteLine(jsonMidiFile.CurrentMidiFile);
        }
        
        // get Ping (DATE TIME)
        if (typeof(GetPingEvent).FullName == jsonBaseClass.ClassType)
        {
            Console.WriteLine(typeof(GetPingEvent).FullName);

            GetPingEvent jsonGetPing = JsonConvert.DeserializeObject<GetPingEvent>(e.Data);
            long ping = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - jsonGetPing.Time;
            MyClient.SetServerToClientPing((int)ping);
        }
        
        // get MAX PING
        if (typeof(GetMaxPingEvent).FullName == jsonBaseClass.ClassType)
        {
            Console.WriteLine(typeof(GetMaxPingEvent).FullName);

            GetMaxPingEvent jsonGetMaxPing = JsonConvert.DeserializeObject<GetMaxPingEvent>(e.Data);
            MyClient.MaxPing = jsonGetMaxPing.MaxPing;
        }
        
        // get command to run
        if (typeof(RunEvent).FullName == jsonBaseClass.ClassType)
        {
            Console.WriteLine(typeof(RunEvent).FullName);
            WindowFinder.Find();
            Thread.Sleep(1000 + MyClient.Offset);
            MidiFileRun.Run();
            //MyClient.ServerToClientPing
        }
        // disconnect confirm
        if (typeof(ClientDisconnectEvent).FullName == jsonBaseClass.ClassType)
        {
            Console.WriteLine(typeof(ClientDisconnectEvent).FullName);
            Client.Close();
        }
        // get new offset and send confirm
        if (typeof(SendNewOffsetEvent).FullName == jsonBaseClass.ClassType)
        {
            Console.WriteLine(typeof(SendNewOffsetEvent).FullName);
            var jsonNewOffset = JsonConvert.DeserializeObject<SendNewOffsetEvent>(e.Data);
            MyClient.Offset = jsonNewOffset.Offset;
            Client.Send(JsonConvert.SerializeObject(new SendNewOffsetEvent(MyClient.ID, MyClient.Offset)));
        }
        // get test note event
        if (typeof(SendTestNoteEvent).FullName == jsonBaseClass.ClassType)
        {
            if (MyClient.IsReady = true)
            {
                Console.WriteLine(typeof(SendTestNoteEvent).FullName);
                WindowFinder.Find();
                Thread.Sleep(1000 + MyClient.Offset);
                if (WindowFinder.WindowStatus())
                {
                    Emulator.Emulation(NoteTranspos.Transpos(60));
                }
                Thread.Sleep(100);
                WindowFinder.MinimizeWindow();
            }
        }
        // get command to stop
        if (typeof(StopCommandEvent).FullName == jsonBaseClass.ClassType)
        {
            WindowFinder.MinimizeWindow();
        }
    }

    public static void ClientConnect()
    {
        Client.Connect();
        string json = JsonConvert.SerializeObject(MyClient);
        Client.Send(json);
    }

    public static void ClientDisconnect() {
        string json = JsonConvert.SerializeObject(new ClientDisconnectEvent(MyClient.ID));
        Client.Send(json);
    }

    public static void ClientIsReady()
    {
        MyClient.IsReady = !MyClient.IsReady;
        string json = JsonConvert.SerializeObject(new ClientReadyEvent(MyClient.ID, MyClient.IsReady));
        Client.Send(json);
    }

    public static void SendPing(int ping)
    {
        string json = JsonConvert.SerializeObject(new SendPingEvent(MyClient.ID ,ping));
        Client.Send(json);
    }

    public static void GetServerToClientPing()
    {
        string json = JsonConvert.SerializeObject(new GetPingEvent());
        Client.Send(json);
    }

    public static async void GetPingEvent()
    {
        await Task.Run(() =>
        {
            Thread.Sleep(1000);
            GetServerToClientPing();
        });
    }
}
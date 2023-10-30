using QuartetPlayer.Online.OnlineWinForms;

namespace QuartetPlayer.Online;

public class ClientModel : BaseEvent
{
    public string SessionID { get; set; }
    public int MaxPing { get; set; }
    public int ID { get; set; }
    public string Username { get; set; }
    public int Offset { get; set; }
    public bool IsReady { get; set; }

    public int ServerToClientPing = 0;

    public int ServerToClientPingCounts = 0;

    public ClientModel(int id, string username, int offset, bool isReady)
    {
        ID = id;
        Username = username;
        Offset = offset;
        IsReady = isReady;
    }

    public void SetServerToClientPing(int currentPing)
    {
        ServerToClientPing = currentPing;
        Console.WriteLine(ServerToClientPing);
        ClientMenuForm.TriggerPingForm(ServerToClientPing.ToString());
        //QuartetClient.GetPingEvent();
    }
}
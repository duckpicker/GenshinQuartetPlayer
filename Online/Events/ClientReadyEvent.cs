namespace QuartetPlayer.Online.Events;

public class ClientReadyEvent : BaseEvent
{
    public int ClientID { get; set; }
    public bool ClientIsReady { get; set; }

    public ClientReadyEvent(int clientId ,bool clientIsReady)
    {
        ClientID = clientId;
        ClientIsReady = clientIsReady;
    }
}
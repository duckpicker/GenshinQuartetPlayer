namespace QuartetPlayer.Online.Events;

public class GetMaxPingEvent : BaseEvent
{
    public int MaxPing { get; set; }

    public GetMaxPingEvent(int maxPing)
    {
        MaxPing = maxPing;
    }
}
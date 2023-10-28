namespace QuartetPlayer.Online.Events;

public class GetPingEvent : BaseEvent
{
    public long Time { get; set; }

    public GetPingEvent(DateTimeOffset time)
    {
        Time = time.ToUnixTimeMilliseconds();
    }

    public GetPingEvent()
    {
    }
}
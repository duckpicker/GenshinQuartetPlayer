namespace QuartetPlayer.Online;

public class BaseEvent
{
    public string ClassType { get; set; }

    public BaseEvent()
    {
        ClassType = this.GetType().FullName;
    }
}
using Melanchall.DryWetMidi.Core;
using QuartetPlayer.MidiCore;

namespace QuartetPlayer.Online.Events;

public class ClientNewIdEvent : BaseEvent
{
    public int NewID { get; set; }
    public int MaxPing { get; set; }
    public byte[] CurrentMidiFile { get; set; }

    public ClientNewIdEvent(int newId, int maxPing)
    {
        NewID = newId;
        MaxPing = maxPing;
    }
}
using Melanchall.DryWetMidi.Core;
using QuartetPlayer.MidiCore;

namespace QuartetPlayer.Online.Events;

public class SendMidiFileEvent : BaseEvent
{
    public byte[] CurrentMidiFile { get; set; }

    public SendMidiFileEvent()
    {
        
    }
}
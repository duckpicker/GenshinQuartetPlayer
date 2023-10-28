using Melanchall.DryWetMidi.Common;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
using Melanchall.DryWetMidi.Multimedia;

namespace QuartetPlayer.MidiCore
{

    public class MidiPlay : TimedEvent, IMetadata
    {
        public MidiPlay(MidiEvent midiEvent, long time, int trackChunkIndex)
            : base(midiEvent, time)
        {
            Metadata = trackChunkIndex;
        }

        public object Metadata { get; set; }
    }

    class MyPlayback : Playback
    {
        public MyPlayback(IEnumerable<ITimedObject> timedObjects, TempoMap tempoMap)
            : base(timedObjects, tempoMap)
        {
        }
        protected override bool TryPlayEvent(MidiEvent midiEvent, object metadata)
        {
            if (metadata == null)
                return false;

            if (MidiFileRun.MutedTrackChunks.Contains((int)metadata))
                return false;

            if (midiEvent is NoteOnEvent)
            {
                var noteOnEvent = midiEvent as NoteOnEvent;
                if (!WindowFinder.WindowStatus()) this.Stop();
                else Emulator.Emulation(NoteTranspos.Transpos(Convert.ToInt32(noteOnEvent.NoteNumber)));
            }
            //OutputDevice?.SendEvent(midiEvent);
            return true;
        }
    }
}

using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;

namespace QuartetPlayer.MidiCore
{
    internal class MidiFileRun
    {
        public static TempoMap TempoMap;
        public static IEnumerable<MidiPlay> TimedEvents;
        public static MidiFile MidiFile = null;
        public static List<int> MutedTrackChunks;
        public static IEnumerable<TrackChunk> Track;

        public static void Read(string midiPath)
        {
            try
            {
                MidiFile = MidiFile.Read(midiPath);
                Track = MidiFile.GetTrackChunks();
                WriteEvents();
                WriteList();
            }
            catch (Exception ex) { }
        }

        protected static void WriteEvents()
        {
            TimedEvents = MidiFile.GetTrackChunks().SelectMany((c, i) => c.GetTimedEvents().Select(e => new MidiPlay(e.Event, e.Time, i))).OrderBy(e => e.Time);
            TempoMap = MidiFile.GetTempoMap();
        }
        public static void WriteList()
        {
            MutedTrackChunks = new List<int>();
            for (int i = 0; i < Track.Count(); i++) MutedTrackChunks.Add(Track.Count());
            for (int i = 0; i < Track.Count(); i++) MutedTrackChunks[i] = Track.Count();
        }
        public static void SwitchTraks(int id)
        {
            if (MutedTrackChunks.Contains(id)) MutedTrackChunks[id] = Track.Count();
            else MutedTrackChunks[id] = id;
        }
        public static void Run()
        {
            var playback = new MyPlayback(TimedEvents, TempoMap);
            playback.Start();
        }
    }
}

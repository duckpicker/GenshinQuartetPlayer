using Melanchall.DryWetMidi.Interaction;


namespace QuartetPlayer.MidiCore
{
    internal class NoteTranspos
    {
        public static int transpos = 0;
        public static int Transpos(int note)
        {
            note += transpos;
            if (note < 48)
            {
                while (note <= 48) note += 12;
                return note;
            }
            if (note > 83)
            {
                while (note >= 83) note -= 12;
                return note;
            }
            else return note;
        }

        public static int[] bestTranspos()
        {
            int[] returnResult = new int[3];
            try
            {
                var notes = MidiCore.MidiFileRun.MidiFile.GetNotes();
                List<int> results = new List<int>();
                for (int i = -11; i < 12; i++)
                {
                    int result = 0;
                    foreach (var note in notes)
                    {
                        if (Keyboard.instrumentID == 0 && Keyboard.noteToKeyLyre.ContainsKey(Transpos(note.NoteNumber + i))) result += 1;
                        if (Keyboard.instrumentID == 1 && Keyboard.noteToKeyOldLyre.ContainsKey(Transpos(note.NoteNumber + i))) result += 1;
                    }
                    results.Add(result);
                }

                int intMin = int.MinValue;
                int bestTranspose = 0;
                int j = 0;
                foreach (var n in results)
                {
                    if (intMin <= n)
                    {
                        bestTranspose = j;
                        intMin = n;
                    }
                    j++;
                }
                returnResult[0] = bestTranspose - 11;
                returnResult[1] = intMin;
                returnResult[2] = notes.Count();
                
            }
            catch (Exception e) { }
            return returnResult;
        }
    }
}

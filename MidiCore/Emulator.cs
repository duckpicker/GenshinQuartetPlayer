using WindowsInput.Native;
using WindowsInput;

namespace QuartetPlayer.MidiCore
{
    internal class Emulator
    {
        protected static bool kickBool = true;
        //53, 55, 57, 59, 60
        private static List<int> kickNotes = new List<int>() { 48, 59 };
        protected static bool snareBool = true;
        //57
        private static List<int> snareNotes = new List<int>() { 49, 50, 51, 52 };
        public static void Emulation(int note)
        {
            InputSimulator isim = new InputSimulator();
            if (Keyboard.instrumentID == 0 && Keyboard.noteToKeyLyre.ContainsKey(note)) isim.Keyboard.KeyPress(Keyboard.noteToKeyLyre[note]);
            if (Keyboard.instrumentID == 1 && Keyboard.noteToKeyOldLyre.ContainsKey(note)) isim.Keyboard.KeyPress(Keyboard.noteToKeyOldLyre[note]);
            if (Keyboard.instrumentID == 2)
            {
                if (note == 60 || note == 61)
                {
                    if (kickBool) isim.Keyboard.KeyPress(VirtualKeyCode.VK_S);
                    else isim.Keyboard.KeyPress(VirtualKeyCode.VK_K);
                    kickBool = !kickBool;
                }
                if (note == 50 || note == 52)
                {
                    if (snareBool) isim.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                    else isim.Keyboard.KeyPress(VirtualKeyCode.VK_L);
                    snareBool = !snareBool;
                }
            }
        }
    }
}

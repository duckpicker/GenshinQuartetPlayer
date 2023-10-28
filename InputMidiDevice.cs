using NAudio.Midi;
using QuartetPlayer.MidiCore;

namespace QuartetPlayer
{
    public class InputMidiDevice
    {
        private static MidiIn midiIn;
        public static void StartInputDevice(int id) {
            midiIn = new MidiIn(id);
            midiIn.MessageReceived += MidiIn_MessageReceived;
            midiIn.Start();
        }
        
        public static void StopInputDevice() {
            if (midiIn != null) {
                midiIn.Stop();
                midiIn.MessageReceived -= MidiIn_MessageReceived;
                midiIn.Dispose();
                midiIn = null;
            }
        }

        static void MidiIn_MessageReceived(object sender, MidiInMessageEventArgs e)
        {
            try
            {
                MidiCommandCode message = e.MidiEvent.CommandCode;
                switch (message)
                {
                    case MidiCommandCode.NoteOn:
                    {
                        var noteEvent = (NoteEvent)e.MidiEvent;
                        if (noteEvent.Velocity == 0 || !WindowFinder.WindowStatus()) break;
                        Emulator.Emulation(NoteTranspos.Transpos(noteEvent.NoteNumber));
                        break;
                    }
                }
            }
            catch (Exception exception)
            {
                if (MidiIn.NumberOfDevices > 0) StopInputDevice();
            }
        }

        public static List<string> GetInputDeviceNames() {
            List<string> devices = new List<string>();
            for (int i = 0; i < MidiIn.NumberOfDevices; i++) devices.Add(MidiIn.DeviceInfo(i).ProductName);
            return devices;
        }
    }
}

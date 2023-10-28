using Melanchall.DryWetMidi.Core;
using QuartetPlayer.MidiCore;

namespace QuartetPlayer.Online.OnlineWinForms
{
    public partial class ClientMenuForm : Form
    {
        public static event Action<string> FormEvent;

        public static event Action<string> PingFormEvent;

        public static void TriggerFormEvent(string str)
        {
            FormEvent?.Invoke(str);
        }

        private void TriggerEvent(string message)
        {
            this.Invoke(new Action(() => TrackCheckBox.Items.Clear()));
            foreach (var trackChunk in MidiFileRun.Track)
            {
                this.Invoke(new Action(() => TrackCheckBox.Items.Add($"Events: {trackChunk.Events.Count} | " +
                    $"{Convert.ToString(trackChunk.Events.ElementAt(0)).Replace("Sequence/Track Name ", "")}", true)));
            }
            this.Invoke(new Action(() => TransposeUpDown.Value = 0));

            int[] bestTranspos = NoteTranspos.bestTranspos();

            this.Invoke(new Action(() => Transposition.Text = "Транспонировка\n" +
                $"Рек.: {bestTranspos[0]}/{bestTranspos[0] - 12} {bestTranspos[1]} ({bestTranspos[2]})"));

        }

        public static void TriggerPingForm(string str)
        {
            PingFormEvent?.Invoke(str);
        }

        private void TriggerPingFormEvent(string message)
        {
            this.Invoke(new Action(() => PingLabel.Text = message));
        }

        public ClientMenuForm()
        {
            InitializeComponent();
            readyButton.Text = "Не готов"; readyButton.ForeColor = Color.Red;
            InstrumentComboBox.SelectedIndex = 0;
            FormEvent += TriggerEvent;
            PingFormEvent = TriggerPingFormEvent;
        }



        private void ClientMenuForm_Load(object sender, EventArgs e)
        {
            OffsetUpDown.Value = QuartetClient.MyClient.Offset;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            OffsetUpDown.Enabled = false;
            SendPingButton.Enabled = false;
        }

        private void TrackCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MidiFileRun.SwitchTraks(TrackCheckBox.SelectedIndex);
        }

        private void readyButton_Click(object sender, EventArgs e)
        {
            if (QuartetClient.MyClient.IsReady != false)
            {
                readyButton.Text = "Не готов"; readyButton.ForeColor = Color.Red;
                QuartetClient.ClientIsReady();
            }
            else
            {
                readyButton.Text = "Готов"; readyButton.ForeColor = Color.Green;
                QuartetClient.ClientIsReady();
            }
        }

        private void windFindButton_Click(object sender, EventArgs e)
        {
            WindowFinder.Find();
        }

        private void InstrumentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Keyboard.changeInstrument(InstrumentComboBox.SelectedIndex);
            if (MidiFileRun.Track != null)
            {
                TrackCheckBox.Items.Clear();
                foreach (var trackChunk in MidiFileRun.Track)
                {
                    TrackCheckBox.Items.Add($"Events: {trackChunk.Events.Count} | " +
                        $"{Convert.ToString(trackChunk.Events.ElementAt(0)).Replace("Sequence/Track Name ", "")}", true);
                }
                int[] bestTranspos = NoteTranspos.bestTranspos();
                Transposition.Text = "Транспонировка\n" +
                    $"Рек.: {bestTranspos[0]}/{bestTranspos[0] - 12} {bestTranspos[1]} ({bestTranspos[2]})";
            }
        }

        private void TransposeUpDown_ValueChanged(object sender, EventArgs e)
        {
            NoteTranspos.transpos = (int)TransposeUpDown.Value;
        }

        private void PingLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClientMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            QuartetClient.ClientDisconnect();
            Application.Exit();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
            QuartetClient.ClientDisconnect();
        }

        private void PingBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendPingButton_Click(object sender, EventArgs e)
        {
            QuartetClient.MyClient.Offset = Convert.ToInt32(OffsetUpDown.Value);
        }
    }
}

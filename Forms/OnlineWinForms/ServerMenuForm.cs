using System.Diagnostics;
using Newtonsoft.Json;
using QuartetPlayer.MidiCore;
using QuartetPlayer.Online;
using QuartetPlayer.Online.Events;
using QuartetPlayer.Online.OnlineWinForms;

namespace QuartetPlayer
{
    public partial class ServerMenuForm : Form
    {
        MainMenuForm mainMenuForm = new MainMenuForm();

        public static event Action<string> FormEvent;

        public static void TriggerFormEvent(string str)
        {
            FormEvent?.Invoke(str);
        }

        private void TriggerEvent(string message)
        {
            this.Invoke(new Action(() => clientsListBox.Items.Clear()));
            foreach (var client in QuartetServer.Clients)
            {
                this.Invoke(new Action(() =>
                {
                    string isready = client.IsReady ? "✓" : "✕";
                    clientsListBox.Items.Add($"{client.ID} {client.Username}: {isready}");
                }));
            }
        }

        List<string> Path = new List<string>();

        public string name;
        public int ping;

        public ServerMenuForm()
        {
            InitializeComponent();
            MidiFolder.PrintFiles();

            foreach (string file in MidiFolder.files)
            {
                Path.Add(file);
                fileListBox.Items.Add(file.Replace(MidiFolder.downloadArea + "\\", ""));
            }

            InstrumentComboBox.SelectedIndex = 0;
            try
            {
                fileListBox.SetSelected(0, true);
            }
            catch (Exception ex) { }


            FormEvent += TriggerEvent;
        }

        private void windFindButton_Click(object sender, EventArgs e)
        {
            WindowFinder.Find();
        }

        bool isSelfPlay = false;
        private void startButton_Click(object sender, EventArgs e)
        {
            bool startChecker = true;
            foreach (var client in QuartetServer.Clients) if (client.IsReady == false) startChecker = false;
            if (startChecker)
            {
                Task.Run(new Action(() =>
                {
                    SendCommandRun();
                    if (!isSelfPlay)
                    {
                        WindowFinder.Find();
                        Thread.Sleep(1000 + QuartetServer.Clients[0].Offset);
                        MidiFileRun.Run();
                    }
                }));

            }

        }

        private void fileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            TransposeUpDown.Value = 0;

            MidiFileRun.Read(Path[fileListBox.SelectedIndex]);
            Console.WriteLine(Path[fileListBox.SelectedIndex]);
            QuartetService.CurrentMidiFilePath = Path[fileListBox.SelectedIndex];
            QuartetServer.SendNewMidiFile(QuartetService.CurrentMidiFilePath);

            int[] bestTranspos = NoteTranspos.bestTranspos();

            Transposition.Text = "Транспонировка\n" +
                $"Рек.: {bestTranspos[0]}/{bestTranspos[0] - 12} {bestTranspos[1]} ({bestTranspos[2]})";

            TrackCheckBox.Items.Clear();
            foreach (var trackChunk in MidiFileRun.Track)
            {
                TrackCheckBox.Items.Add($"Events: {trackChunk.Events.Count} | {Convert.ToString(trackChunk.Events.ElementAt(0)).Replace("Sequence/Track Name ", "")}", true);
            }
        }



        public void SendCommandRun()
        {
            string jsonCommandRun = JsonConvert.SerializeObject(new RunEvent());
            QuartetService.TriggerBroadCast(jsonCommandRun);
        }

        private void TrackCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MidiFileRun.SwitchTraks(TrackCheckBox.SelectedIndex);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
            };
        }

        private void TransposeUpDown_ValueChanged(object sender, EventArgs e)
        {
            NoteTranspos.transpos = (int)TransposeUpDown.Value;
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MIDI файлы (*.mid)|*.mid|Все файлы (*.*)|*.*";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Выберите файл";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = openFileDialog.SafeFileName;
                Path.Add(filePath);
                fileListBox.Items.Add(fileName);
                fileListBox.SetSelected(fileListBox.Items.Count - 1, true);
            }
        }

        private void OpenFolderStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", MidiFolder.downloadArea);
        }

        public async void ServerMenuForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            mainMenuForm.Hide();

            readyButton.ForeColor = Color.Red;
            OffsetUpDown.Enabled = false;
        }

        private void ServerMenuForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void readyButton_Click(object sender, EventArgs e)
        {
            OffsetUpDown.Enabled = true;
            OffsetUpDown.Value = QuartetServer.Clients[0].Offset;
            if (QuartetServer.Clients[0].IsReady == true)
            {
                readyButton.Text = "Не готов"; readyButton.ForeColor = Color.Red;
                QuartetServer.Clients[0].IsReady = !QuartetServer.Clients[0].IsReady;
            }
            else
            {
                readyButton.Text = "Готов"; readyButton.ForeColor = Color.Green;
                QuartetServer.Clients[0].IsReady = !QuartetServer.Clients[0].IsReady;
            }
            TriggerFormEvent("");
            Console.WriteLine(QuartetServer.Clients[0].IsReady);
        }

        private async void kickButton_Click(object sender, EventArgs e)
        {
            if (clientsListBox.SelectedIndex != 0)
            {
                QuartetService.TriggerKickCast(clientsListBox.SelectedIndex);
                TriggerFormEvent("");
            }
        }

        private void ClientsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClientsListBox_MouseDoubleClick(object sender, EventArgs e)
        {
            if (clientsListBox.SelectedItem != null && clientsListBox.SelectedIndex != 0)
            {
                ClientInfoForm client = new ClientInfoForm(clientsListBox.SelectedIndex);
                client.ShowDialog();
            }
        }

        private void PlayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            isSelfPlay = PlayCheckBox.Checked;
        }

        private void OffsetUpDown_ValueChanged(object sender, EventArgs e)
        {
            QuartetServer.Clients[0].Offset = Convert.ToInt32(OffsetUpDown.Value);
        }

        private void SendServerOffset_Click(object sender, EventArgs e)
        {
            var client = QuartetServer.Clients.MaxBy(c => c.Offset);
            QuartetService.TriggerBroadCast(JsonConvert.SerializeObject(new GetMaxPingEvent(client.Offset)));
        }

        private void TransposeUpDown_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            QuartetService.TriggerBroadCast(JsonConvert.SerializeObject(new StopCommandEvent()));
        }

        private void reloadFilesButton_Click(object sender, EventArgs e)
        {
            MidiFolder.GetMidiFiles();
            Path.Clear();
            fileListBox.Items.Clear();
            foreach (string file in MidiFolder.files)
            {
                Path.Add(file);
                fileListBox.Items.Add(file.Replace(MidiFolder.downloadArea + "\\", ""));
            }
            if (MidiFolder.files.Count != 0) fileListBox.SelectedIndex = 0;
        }

        private void TestAllButton_Click(object sender, EventArgs e)
        {
            QuartetService.TriggerBroadCast(JsonConvert.SerializeObject(new SendTestNoteEvent()));
            WindowFinder.Find();
            Thread.Sleep(1000 + QuartetServer.Clients[0].Offset);
            if (WindowFinder.WindowStatus())
            {
                Emulator.Emulation(NoteTranspos.Transpos(60));
            }
        }
    }
}

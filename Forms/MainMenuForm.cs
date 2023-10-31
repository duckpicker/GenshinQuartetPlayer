using QuartetPlayer.MidiCore;
using QuartetPlayer.Online;
using System.Diagnostics;

namespace QuartetPlayer
{
    public partial class MainMenuForm : Form
    {
        List<string> Path = new List<string>();
        public MainMenuForm()
        {
            InitializeComponent();
            MidiFolder.PrintFiles();

            foreach (string file in MidiFolder.files)
            {
                Path.Add(file);
                fileListBox.Items.Add(file.Replace(MidiFolder.downloadArea + "\\", ""));
            }

            InstrumentComboBox.SelectedIndex = 0;
        }

        private void winFindButton_Click(object sender, EventArgs e)
        {
            WindowFinder.Find();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            WindowFinder.Find();
            MidiCore.MidiFileRun.Run();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            inputDeviceComboBox.Items.Clear();
            List<string> devices = InputMidiDevice.GetInputDeviceNames();
            foreach (string device in devices) inputDeviceComboBox.Items.Add(device);
            if (Path.Count <= 0) CreateServerToolStripMenuItem.Enabled = false;
            if (MidiFolder.files.Count != 0) fileListBox.SelectedIndex = 0;
        }

        private void fileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            TransposeUpDown.Value = 0;

            MidiFileRun.Read(Path[fileListBox.SelectedIndex]);

            int[] bestTranspos = MidiCore.NoteTranspos.bestTranspos();

            Transposition.Text = "Transposition\n" +
                    $"Recd.: {bestTranspos[0]}/{bestTranspos[0] - 12} {bestTranspos[1]} ({bestTranspos[2]})";

            TrackCheckBox.Items.Clear();

            foreach (var trackChunk in MidiFileRun.Track)
            {
                TrackCheckBox.Items.Add($"Events: {trackChunk.Events.Count} | {Convert.ToString(trackChunk.Events.ElementAt(0)).Replace("Sequence/Track Name ", "")}", true);
            }
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
                Transposition.Text = "Transposition\n" +
                    $"Recd.: {bestTranspos[0]}/{bestTranspos[0] - 12} {bestTranspos[1]} ({bestTranspos[2]})";
            }
        }

        private void TransposeUpDown_ValueChanged(object sender, EventArgs e)
        {
            MidiCore.NoteTranspos.transpos = (int)TransposeUpDown.Value;
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MIDI files (*.mid)|*.mid|All files (*.*)|*.*";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select a file.";

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
            try
            {
                Process.Start("explorer.exe", MidiFolder.downloadArea);
            }
            catch (Exception ex) { }

        }

        private void Transposition_Click(object sender, EventArgs e)
        {

        }

        private void ConnectToServerStripMenuItem_Click(object sender, EventArgs e)
        {
            var connectServerMenu = new ConnectServerMenu();
            connectServerMenu.Show(this);
            this.Hide();
        }

        private void CreateServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MidiFolder.GetMidiFiles();
            if (MidiFolder.files.Count != 0)
            {
                var createServerMenu = new CreateServerMenu();
                createServerMenu.Show(this);
                this.Hide();
            }
        }

        private void inputDeviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputMidiDevice.StopInputDevice();
            InputMidiDevice.StartInputDevice(inputDeviceComboBox.SelectedIndex);
        }

        private void reloadInputDeviceButton_Click(object sender, EventArgs e)
        {
            inputDeviceComboBox.Items.Clear();
            try
            {
                InputMidiDevice.StopInputDevice();
                List<string> devices = InputMidiDevice.GetInputDeviceNames();
                foreach (string device in devices) inputDeviceComboBox.Items.Add(device);
            }
            catch (Exception ex) { }

        }

        private void ChangePort_Click(object sender, EventArgs e)
        {
            ChangePortForm changePortForm = new ChangePortForm();
            changePortForm.ShowDialog();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void участникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Contributors projectPartners = new Forms.Contributors();
            projectPartners.ShowDialog();
        }

        private void gitHubToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/duckpicker",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void поддержатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.donationalerts.com/r/ballchaser",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/@keqingbestgirl",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void discordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://discord.gg/8ge82GBPp2",
                UseShellExecute = true
            };
            Process.Start(psInfo);

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
            if (MidiFolder.files.Count != 0)
            {
                fileListBox.SelectedIndex = 0;
                CreateServerToolStripMenuItem.Enabled = true;
            }
            else CreateServerToolStripMenuItem.Enabled = false;
        }
    }
}

using QuartetPlayer.Online.OnlineWinForms;

namespace QuartetPlayer.Online
{
    public partial class ConnectServerMenu : Form
    {
        public ConnectServerMenu()
        {
            InitializeComponent();
        }

        private void ConnectedServerMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            nameTextBox.Text = Environment.UserName;
            createButton.Enabled = false;
        }

        private void ConnectedServerMenu_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ipTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (pingTextBox.Text == null && nameTextBox.Text == null && ipTextBox.Text == null || !int.TryParse(pingTextBox.Text, out _)) createButton.Enabled = false;
            else createButton.Enabled = true;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (pingTextBox.Text == null && nameTextBox.Text == null || !int.TryParse(pingTextBox.Text, out _)) createButton.Enabled = false;
            else createButton.Enabled = true;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            ClientMenuForm clientMenuForm = new ClientMenuForm();
            clientMenuForm.Text = $"QuartetPlayer | {nameTextBox.Text}";
            QuartetClient.ClientCreate(nameTextBox.Text, Convert.ToInt32(pingTextBox.Text), ipTextBox.Text, Program.Port);
            QuartetClient.ClientConnect();
            clientMenuForm.Show();
            this.Hide();

        }
    }
}

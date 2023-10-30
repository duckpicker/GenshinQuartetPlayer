namespace QuartetPlayer.Online
{
    public partial class CreateServerMenu : Form
    {
        public CreateServerMenu()
        {
            InitializeComponent();
        }

        private void CreateServerMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            nameTextBox.Text = Environment.UserName;
            createButton.Enabled = false;
        }

        private void CreateServerMenu_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (pingTextBox.Text == null && nameTextBox.Text == null || !int.TryParse(pingTextBox.Text, out _)) createButton.Enabled = false;
            else createButton.Enabled = true;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            ServerMenuForm serverMenuForm = new ServerMenuForm();
            serverMenuForm.Text = $"QuartetServer | {nameTextBox.Text}";
            serverMenuForm.Show();
            QuartetServer.Clients.Add(new ClientModel(0, nameTextBox.Text, Convert.ToInt32(pingTextBox.Text), false));
            QuartetServer.Start();
            this.Hide();
        }
    }
}

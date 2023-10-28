namespace QuartetPlayer
{
    public partial class ChangePortForm : Form
    {
        public ChangePortForm()
        {
            InitializeComponent();
            textBox1.Text = Program.Port.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out _)) Program.Port = Convert.ToInt32(textBox1.Text);
            this.Close();
        }
    }
}

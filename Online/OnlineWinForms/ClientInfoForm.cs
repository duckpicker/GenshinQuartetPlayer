using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuartetPlayer.Online.OnlineWinForms
{
    public partial class ClientInfoForm : Form
    {
        public int CurrentIndex { get; set; }
        public ClientInfoForm(int currentIndex)
        {
            InitializeComponent();
            CurrentIndex = currentIndex;
        }

        private void ClientInfoForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = $"Клиент: {QuartetServer.Clients[CurrentIndex].Username}";
            IDTextBox.Text = QuartetServer.Clients[CurrentIndex].ID.ToString();
            IDTextBox.Enabled = false;
            NameTextBox.Text = QuartetServer.Clients[CurrentIndex].Username;
            NameTextBox.Enabled = false;
            OffsetUpDown.Value = QuartetServer.Clients[CurrentIndex].Offset;
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendOffsetButton_Click(object sender, EventArgs e)
        {
            QuartetService.TriggerSendClientCast(Convert.ToInt32(OffsetUpDown.Value), QuartetServer.Clients[CurrentIndex].SessionID);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

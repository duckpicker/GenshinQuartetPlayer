namespace QuartetPlayer.Online
{
    partial class ConnectServerMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectServerMenu));
            pingTextBox = new TextBox();
            nameTextBox = new TextBox();
            createButton = new Button();
            label2 = new Label();
            label1 = new Label();
            ipTextBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // pingTextBox
            // 
            pingTextBox.Location = new Point(12, 71);
            pingTextBox.Name = "pingTextBox";
            pingTextBox.Size = new Size(100, 23);
            pingTextBox.TabIndex = 11;
            pingTextBox.TextChanged += pingTextBox_TextChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 27);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 10;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // createButton
            // 
            createButton.Location = new Point(12, 156);
            createButton.Name = "createButton";
            createButton.Size = new Size(100, 23);
            createButton.TabIndex = 9;
            createButton.Text = "Подключиться";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Оффсет";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 7;
            label1.Text = "Имя";
            // 
            // ipTextBox
            // 
            ipTextBox.Location = new Point(12, 115);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new Size(100, 23);
            ipTextBox.TabIndex = 13;
            ipTextBox.TextChanged += ipTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 12;
            label3.Text = "Адрес сервера";
            // 
            // ConnectServerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(204, 191);
            Controls.Add(ipTextBox);
            Controls.Add(label3);
            Controls.Add(pingTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(createButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConnectServerMenu";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Подключиться к комнате";
            FormClosing += ConnectedServerMenu_FormClosing;
            Load += ConnectedServerMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox pingTextBox;
        public TextBox nameTextBox;
        private Button createButton;
        private Label label2;
        private Label label1;
        public TextBox ipTextBox;
        private Label label3;
    }
}
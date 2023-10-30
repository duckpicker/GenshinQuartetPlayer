namespace QuartetPlayer.Online
{
    partial class CreateServerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateServerMenu));
            label1 = new Label();
            label2 = new Label();
            createButton = new Button();
            nameTextBox = new TextBox();
            pingTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Оффсет";
            // 
            // createButton
            // 
            createButton.Location = new Point(12, 126);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 4;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 27);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 5;
            // 
            // pingTextBox
            // 
            pingTextBox.Location = new Point(12, 71);
            pingTextBox.Name = "pingTextBox";
            pingTextBox.Size = new Size(100, 23);
            pingTextBox.TabIndex = 6;
            pingTextBox.TextChanged += pingTextBox_TextChanged;
            // 
            // CreateServerMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 161);
            Controls.Add(pingTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(createButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateServerMenu";
            Text = "Создать комнату";
            FormClosing += CreateServerMenu_FormClosing;
            Load += CreateServerMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button createButton;
        public TextBox nameTextBox;
        public TextBox pingTextBox;
    }
}
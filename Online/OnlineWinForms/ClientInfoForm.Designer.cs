namespace QuartetPlayer.Online.OnlineWinForms
{
    partial class ClientInfoForm
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
            label1 = new Label();
            ID = new Label();
            IDTextBox = new TextBox();
            label3 = new Label();
            OffsetUpDown = new NumericUpDown();
            SendOffsetButton = new Button();
            NameTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)OffsetUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(12, 53);
            ID.Name = "ID";
            ID.Size = new Size(18, 15);
            ID.TabIndex = 2;
            ID.Text = "ID";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(12, 71);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(88, 23);
            IDTextBox.TabIndex = 5;
            IDTextBox.Text = "IDTextBox";
            IDTextBox.TextChanged += IDTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 96);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Оффсет";
            // 
            // OffsetUpDown
            // 
            OffsetUpDown.Location = new Point(133, 114);
            OffsetUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            OffsetUpDown.Minimum = new decimal(new int[] { 999, 0, 0, int.MinValue });
            OffsetUpDown.Name = "OffsetUpDown";
            OffsetUpDown.Size = new Size(81, 23);
            OffsetUpDown.TabIndex = 7;
            // 
            // SendOffsetButton
            // 
            SendOffsetButton.Location = new Point(52, 114);
            SendOffsetButton.Name = "SendOffsetButton";
            SendOffsetButton.Size = new Size(75, 23);
            SendOffsetButton.TabIndex = 8;
            SendOffsetButton.Text = "Отправить";
            SendOffsetButton.UseVisualStyleBackColor = true;
            SendOffsetButton.Click += SendOffsetButton_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 27);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(88, 23);
            NameTextBox.TabIndex = 9;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // ClientInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 150);
            Controls.Add(NameTextBox);
            Controls.Add(SendOffsetButton);
            Controls.Add(OffsetUpDown);
            Controls.Add(label3);
            Controls.Add(IDTextBox);
            Controls.Add(ID);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClientInfoForm";
            ShowIcon = false;
            Text = "ClientInfoForm";
            Load += ClientInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)OffsetUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label ID;
        private TextBox IDTextBox;
        private Label label3;
        private NumericUpDown OffsetUpDown;
        private Button SendOffsetButton;
        private TextBox NameTextBox;
    }
}
namespace QuartetPlayer.Online.OnlineWinForms
{
    partial class ClientMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMenuForm));
            readyButton = new Button();
            Transposition = new Label();
            Instrument = new Label();
            TransposeUpDown = new NumericUpDown();
            InstrumentComboBox = new ComboBox();
            TrackCheckBox = new CheckedListBox();
            TrackList = new Label();
            windFindButton = new Button();
            PingLabel = new Label();
            DisconnectButton = new Button();
            SendPingButton = new Button();
            label1 = new Label();
            OffsetUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)TransposeUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OffsetUpDown).BeginInit();
            SuspendLayout();
            // 
            // readyButton
            // 
            readyButton.Location = new Point(12, 12);
            readyButton.Name = "readyButton";
            readyButton.Size = new Size(93, 23);
            readyButton.TabIndex = 38;
            readyButton.Text = "Not Ready";
            readyButton.UseVisualStyleBackColor = true;
            readyButton.Click += readyButton_Click;
            // 
            // Transposition
            // 
            Transposition.AutoSize = true;
            Transposition.Location = new Point(139, 106);
            Transposition.Name = "Transposition";
            Transposition.Size = new Size(77, 30);
            Transposition.TabIndex = 34;
            Transposition.Text = "Transposition\r\nRecd:";
            // 
            // Instrument
            // 
            Instrument.AutoSize = true;
            Instrument.Location = new Point(12, 121);
            Instrument.Name = "Instrument";
            Instrument.Size = new Size(65, 15);
            Instrument.TabIndex = 32;
            Instrument.Text = "Instrument";
            // 
            // TransposeUpDown
            // 
            TransposeUpDown.Location = new Point(139, 139);
            TransposeUpDown.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            TransposeUpDown.Minimum = new decimal(new int[] { 128, 0, 0, int.MinValue });
            TransposeUpDown.Name = "TransposeUpDown";
            TransposeUpDown.Size = new Size(125, 23);
            TransposeUpDown.TabIndex = 31;
            TransposeUpDown.ValueChanged += TransposeUpDown_ValueChanged;
            // 
            // InstrumentComboBox
            // 
            InstrumentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            InstrumentComboBox.Items.AddRange(new object[] { "Lyre/Zither", "Old lyre", "Drum" });
            InstrumentComboBox.Location = new Point(12, 139);
            InstrumentComboBox.Name = "InstrumentComboBox";
            InstrumentComboBox.Size = new Size(121, 23);
            InstrumentComboBox.TabIndex = 30;
            InstrumentComboBox.SelectedIndexChanged += InstrumentComboBox_SelectedIndexChanged;
            // 
            // TrackCheckBox
            // 
            TrackCheckBox.CheckOnClick = true;
            TrackCheckBox.FormattingEnabled = true;
            TrackCheckBox.Location = new Point(12, 183);
            TrackCheckBox.Name = "TrackCheckBox";
            TrackCheckBox.Size = new Size(310, 112);
            TrackCheckBox.TabIndex = 29;
            TrackCheckBox.SelectedIndexChanged += TrackCheckBox_SelectedIndexChanged;
            // 
            // TrackList
            // 
            TrackList.AutoSize = true;
            TrackList.Location = new Point(12, 165);
            TrackList.Name = "TrackList";
            TrackList.Size = new Size(39, 15);
            TrackList.TabIndex = 33;
            TrackList.Text = "Tracks";
            // 
            // windFindButton
            // 
            windFindButton.Location = new Point(12, 41);
            windFindButton.Name = "windFindButton";
            windFindButton.Size = new Size(93, 23);
            windFindButton.TabIndex = 27;
            windFindButton.Text = "Open window";
            windFindButton.UseVisualStyleBackColor = true;
            windFindButton.Click += windFindButton_Click;
            // 
            // PingLabel
            // 
            PingLabel.AutoSize = true;
            PingLabel.Location = new Point(290, 9);
            PingLabel.Name = "PingLabel";
            PingLabel.Size = new Size(31, 15);
            PingLabel.TabIndex = 39;
            PingLabel.Text = "ping";
            PingLabel.Click += PingLabel_Click;
            // 
            // DisconnectButton
            // 
            DisconnectButton.Location = new Point(12, 70);
            DisconnectButton.Name = "DisconnectButton";
            DisconnectButton.Size = new Size(93, 23);
            DisconnectButton.TabIndex = 41;
            DisconnectButton.Text = "Disconnect";
            DisconnectButton.UseVisualStyleBackColor = true;
            DisconnectButton.Click += DisconnectButton_Click;
            // 
            // SendPingButton
            // 
            SendPingButton.Location = new Point(187, 27);
            SendPingButton.Name = "SendPingButton";
            SendPingButton.Size = new Size(88, 23);
            SendPingButton.TabIndex = 42;
            SendPingButton.Text = "Send offset";
            SendPingButton.UseVisualStyleBackColor = true;
            SendPingButton.Click += SendPingButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 43;
            label1.Text = "Offset";
            // 
            // OffsetUpDown
            // 
            OffsetUpDown.Location = new Point(111, 27);
            OffsetUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            OffsetUpDown.Minimum = new decimal(new int[] { 999, 0, 0, int.MinValue });
            OffsetUpDown.Name = "OffsetUpDown";
            OffsetUpDown.Size = new Size(70, 23);
            OffsetUpDown.TabIndex = 44;
            OffsetUpDown.ValueChanged += PingBox_TextChanged;
            // 
            // ClientMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 305);
            Controls.Add(OffsetUpDown);
            Controls.Add(label1);
            Controls.Add(SendPingButton);
            Controls.Add(DisconnectButton);
            Controls.Add(PingLabel);
            Controls.Add(readyButton);
            Controls.Add(Transposition);
            Controls.Add(Instrument);
            Controls.Add(TransposeUpDown);
            Controls.Add(InstrumentComboBox);
            Controls.Add(TrackCheckBox);
            Controls.Add(TrackList);
            Controls.Add(windFindButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ClientMenuForm";
            Text = "ClientMenuForm";
            FormClosed += ClientMenuForm_FormClosed;
            Load += ClientMenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)TransposeUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)OffsetUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button readyButton;
        private Label Transposition;
        private Label Instrument;
        private NumericUpDown TransposeUpDown;
        private ComboBox InstrumentComboBox;
        private CheckedListBox TrackCheckBox;
        private Label TrackList;
        private Button windFindButton;
        private Label PingLabel;
        private Button DisconnectButton;
        private Button SendPingButton;
        private Label label1;
        private NumericUpDown OffsetUpDown;
    }
}
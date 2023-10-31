namespace QuartetPlayer
{
    partial class ServerMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerMenuForm));
            Transposition = new Label();
            Instrument = new Label();
            PlayList = new Label();
            TransposeUpDown = new NumericUpDown();
            InstrumentComboBox = new ComboBox();
            TrackCheckBox = new CheckedListBox();
            fileListBox = new ListBox();
            startButton = new Button();
            TrackList = new Label();
            windFindButton = new Button();
            label1 = new Label();
            kickButton = new Button();
            readyButton = new Button();
            clientsListBox = new ListBox();
            PlayCheckBox = new CheckBox();
            OffsetUpDown = new NumericUpDown();
            label2 = new Label();
            SendServerOffset = new Button();
            StopButton = new Button();
            reloadFilesButton = new Button();
            TestAllButton = new Button();
            ((System.ComponentModel.ISupportInitialize)TransposeUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OffsetUpDown).BeginInit();
            SuspendLayout();
            // 
            // Transposition
            // 
            Transposition.AutoSize = true;
            Transposition.Location = new Point(139, 173);
            Transposition.Name = "Transposition";
            Transposition.Size = new Size(77, 30);
            Transposition.TabIndex = 22;
            Transposition.Text = "Transposition\r\nRecd:";
            Transposition.Click += Transposition_Click;
            // 
            // Instrument
            // 
            Instrument.AutoSize = true;
            Instrument.Location = new Point(12, 188);
            Instrument.Name = "Instrument";
            Instrument.Size = new Size(65, 15);
            Instrument.TabIndex = 20;
            Instrument.Text = "Instrument";
            // 
            // PlayList
            // 
            PlayList.AutoSize = true;
            PlayList.Location = new Point(328, 12);
            PlayList.Name = "PlayList";
            PlayList.Size = new Size(44, 15);
            PlayList.TabIndex = 19;
            PlayList.Text = "Playlist";
            // 
            // TransposeUpDown
            // 
            TransposeUpDown.Location = new Point(139, 206);
            TransposeUpDown.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            TransposeUpDown.Minimum = new decimal(new int[] { 128, 0, 0, int.MinValue });
            TransposeUpDown.Name = "TransposeUpDown";
            TransposeUpDown.Size = new Size(125, 23);
            TransposeUpDown.TabIndex = 18;
            TransposeUpDown.ValueChanged += TransposeUpDown_ValueChanged;
            // 
            // InstrumentComboBox
            // 
            InstrumentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            InstrumentComboBox.Items.AddRange(new object[] { "Lyre/Zither", "Old lyre", "Drum" });
            InstrumentComboBox.Location = new Point(12, 206);
            InstrumentComboBox.Name = "InstrumentComboBox";
            InstrumentComboBox.Size = new Size(121, 23);
            InstrumentComboBox.TabIndex = 17;
            InstrumentComboBox.SelectedIndexChanged += InstrumentComboBox_SelectedIndexChanged;
            // 
            // TrackCheckBox
            // 
            TrackCheckBox.CheckOnClick = true;
            TrackCheckBox.FormattingEnabled = true;
            TrackCheckBox.Location = new Point(12, 250);
            TrackCheckBox.Name = "TrackCheckBox";
            TrackCheckBox.Size = new Size(310, 112);
            TrackCheckBox.TabIndex = 16;
            TrackCheckBox.SelectedIndexChanged += TrackCheckBox_SelectedIndexChanged;
            // 
            // fileListBox
            // 
            fileListBox.FormattingEnabled = true;
            fileListBox.ItemHeight = 15;
            fileListBox.Location = new Point(328, 30);
            fileListBox.Name = "fileListBox";
            fileListBox.Size = new Size(317, 334);
            fileListBox.TabIndex = 15;
            fileListBox.SelectedIndexChanged += fileListBox_SelectedIndexChanged;
            // 
            // startButton
            // 
            startButton.Enabled = false;
            startButton.Location = new Point(12, 12);
            startButton.Name = "startButton";
            startButton.Size = new Size(93, 23);
            startButton.TabIndex = 14;
            startButton.Text = "Start Play";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // TrackList
            // 
            TrackList.AutoSize = true;
            TrackList.Location = new Point(12, 232);
            TrackList.Name = "TrackList";
            TrackList.Size = new Size(39, 15);
            TrackList.TabIndex = 21;
            TrackList.Text = "Tracks";
            // 
            // windFindButton
            // 
            windFindButton.Location = new Point(12, 99);
            windFindButton.Name = "windFindButton";
            windFindButton.Size = new Size(93, 23);
            windFindButton.TabIndex = 12;
            windFindButton.Text = "Open window";
            windFindButton.UseVisualStyleBackColor = true;
            windFindButton.Click += windFindButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 43);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 24;
            label1.Text = "Players";
            // 
            // kickButton
            // 
            kickButton.Location = new Point(12, 70);
            kickButton.Name = "kickButton";
            kickButton.Size = new Size(93, 23);
            kickButton.TabIndex = 25;
            kickButton.Text = "Kick";
            kickButton.UseVisualStyleBackColor = true;
            kickButton.Click += kickButton_Click;
            // 
            // readyButton
            // 
            readyButton.Location = new Point(12, 41);
            readyButton.Name = "readyButton";
            readyButton.Size = new Size(93, 23);
            readyButton.TabIndex = 26;
            readyButton.Text = "Not Ready";
            readyButton.UseVisualStyleBackColor = true;
            readyButton.Click += readyButton_Click;
            // 
            // clientsListBox
            // 
            clientsListBox.FormattingEnabled = true;
            clientsListBox.ItemHeight = 15;
            clientsListBox.Location = new Point(111, 61);
            clientsListBox.Name = "clientsListBox";
            clientsListBox.Size = new Size(211, 109);
            clientsListBox.TabIndex = 27;
            clientsListBox.SelectedIndexChanged += ClientsListBox_SelectedIndexChanged;
            clientsListBox.DoubleClick += ClientsListBox_MouseDoubleClick;
            // 
            // PlayCheckBox
            // 
            PlayCheckBox.AutoSize = true;
            PlayCheckBox.Location = new Point(12, 157);
            PlayCheckBox.Name = "PlayCheckBox";
            PlayCheckBox.Size = new Size(67, 19);
            PlayCheckBox.TabIndex = 28;
            PlayCheckBox.Text = "No Play";
            PlayCheckBox.UseVisualStyleBackColor = true;
            PlayCheckBox.CheckedChanged += PlayCheckBox_CheckedChanged;
            // 
            // OffsetUpDown
            // 
            OffsetUpDown.Location = new Point(257, 32);
            OffsetUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            OffsetUpDown.Minimum = new decimal(new int[] { 999, 0, 0, int.MinValue });
            OffsetUpDown.Name = "OffsetUpDown";
            OffsetUpDown.Size = new Size(65, 23);
            OffsetUpDown.TabIndex = 29;
            OffsetUpDown.ValueChanged += OffsetUpDown_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 12);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 30;
            label2.Text = "Offset";
            // 
            // SendServerOffset
            // 
            SendServerOffset.Location = new Point(171, 32);
            SendServerOffset.Name = "SendServerOffset";
            SendServerOffset.Size = new Size(80, 23);
            SendServerOffset.TabIndex = 31;
            SendServerOffset.Text = "Change";
            SendServerOffset.UseVisualStyleBackColor = true;
            SendServerOffset.Click += SendServerOffset_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(12, 128);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(93, 23);
            StopButton.TabIndex = 32;
            StopButton.Text = "Stop Play";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // reloadFilesButton
            // 
            reloadFilesButton.Location = new Point(378, 4);
            reloadFilesButton.Name = "reloadFilesButton";
            reloadFilesButton.Size = new Size(21, 23);
            reloadFilesButton.TabIndex = 33;
            reloadFilesButton.Text = "🗘";
            reloadFilesButton.UseVisualStyleBackColor = true;
            reloadFilesButton.Click += reloadFilesButton_Click;
            // 
            // TestAllButton
            // 
            TestAllButton.Location = new Point(171, 4);
            TestAllButton.Name = "TestAllButton";
            TestAllButton.Size = new Size(80, 23);
            TestAllButton.TabIndex = 34;
            TestAllButton.Text = "Test";
            TestAllButton.UseVisualStyleBackColor = true;
            TestAllButton.Click += TestAllButton_Click;
            // 
            // ServerMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 374);
            Controls.Add(TestAllButton);
            Controls.Add(reloadFilesButton);
            Controls.Add(StopButton);
            Controls.Add(SendServerOffset);
            Controls.Add(label2);
            Controls.Add(OffsetUpDown);
            Controls.Add(PlayCheckBox);
            Controls.Add(clientsListBox);
            Controls.Add(readyButton);
            Controls.Add(kickButton);
            Controls.Add(label1);
            Controls.Add(Transposition);
            Controls.Add(Instrument);
            Controls.Add(PlayList);
            Controls.Add(TransposeUpDown);
            Controls.Add(InstrumentComboBox);
            Controls.Add(TrackCheckBox);
            Controls.Add(fileListBox);
            Controls.Add(startButton);
            Controls.Add(TrackList);
            Controls.Add(windFindButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ServerMenuForm";
            Text = "ServerMenuForm";
            FormClosed += ServerMenuForm_FormClosed;
            Load += ServerMenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)TransposeUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)OffsetUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label Transposition;
        private Label Instrument;
        private Label PlayList;
        private NumericUpDown TransposeUpDown;
        private ComboBox InstrumentComboBox;
        private CheckedListBox TrackCheckBox;
        private ListBox fileListBox;
        private Button startButton;
        private Label TrackList;
        private Button windFindButton;
        private Label label1;
        private Button kickButton;
        private Button readyButton;
        private ListBox clientsListBox;
        private CheckBox PlayCheckBox;
        private NumericUpDown OffsetUpDown;
        private Label label2;
        private Button SendServerOffset;
        private Button StopButton;
        private Button reloadFilesButton;
        private Button TestAllButton;
    }
}
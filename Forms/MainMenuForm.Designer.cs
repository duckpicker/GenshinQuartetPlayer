namespace QuartetPlayer
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            windFindButton = new Button();
            menuStrip1 = new MenuStrip();
            OpenFolderMenuItem = new ToolStripMenuItem();
            OpenFileMenuItem = new ToolStripMenuItem();
            OpenFolderStripMenuItem = new ToolStripMenuItem();
            мультиплеерToolStripMenuItem = new ToolStripMenuItem();
            CreateServerToolStripMenuItem = new ToolStripMenuItem();
            ConnectToServerStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            ChangePort = new ToolStripMenuItem();
            оНасToolStripMenuItem = new ToolStripMenuItem();
            ProjectPartners = new ToolStripMenuItem();
            gitHubToolStripMenuItem = new ToolStripMenuItem();
            поддержатьToolStripMenuItem = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            youTubeToolStripMenuItem = new ToolStripMenuItem();
            discordToolStripMenuItem = new ToolStripMenuItem();
            startButton = new Button();
            fileListBox = new ListBox();
            TrackCheckBox = new CheckedListBox();
            InstrumentComboBox = new ComboBox();
            TransposeUpDown = new NumericUpDown();
            PlayList = new Label();
            Instrument = new Label();
            TrackList = new Label();
            Transposition = new Label();
            label1 = new Label();
            inputDeviceComboBox = new ComboBox();
            reloadInputDeviceButton = new Button();
            reloadFilesButton = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TransposeUpDown).BeginInit();
            SuspendLayout();
            // 
            // windFindButton
            // 
            windFindButton.Location = new Point(12, 58);
            windFindButton.Name = "windFindButton";
            windFindButton.Size = new Size(93, 23);
            windFindButton.TabIndex = 0;
            windFindButton.Text = "Open window";
            windFindButton.UseVisualStyleBackColor = true;
            windFindButton.Click += winFindButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { OpenFolderMenuItem, мультиплеерToolStripMenuItem, настройкиToolStripMenuItem, оНасToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(654, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // OpenFolderMenuItem
            // 
            OpenFolderMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenFileMenuItem, OpenFolderStripMenuItem });
            OpenFolderMenuItem.Name = "OpenFolderMenuItem";
            OpenFolderMenuItem.Size = new Size(37, 20);
            OpenFolderMenuItem.Text = "File";
            // 
            // OpenFileMenuItem
            // 
            OpenFileMenuItem.Name = "OpenFileMenuItem";
            OpenFileMenuItem.Size = new Size(137, 22);
            OpenFileMenuItem.Text = "Open file";
            OpenFileMenuItem.Click += OpenFileMenuItem_Click;
            // 
            // OpenFolderStripMenuItem
            // 
            OpenFolderStripMenuItem.Name = "OpenFolderStripMenuItem";
            OpenFolderStripMenuItem.Size = new Size(137, 22);
            OpenFolderStripMenuItem.Text = "Open folder";
            OpenFolderStripMenuItem.Click += OpenFolderStripMenuItem_Click;
            // 
            // мультиплеерToolStripMenuItem
            // 
            мультиплеерToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateServerToolStripMenuItem, ConnectToServerStripMenuItem });
            мультиплеерToolStripMenuItem.Name = "мультиплеерToolStripMenuItem";
            мультиплеерToolStripMenuItem.Size = new Size(79, 20);
            мультиплеерToolStripMenuItem.Text = "Multiplayer";
            // 
            // CreateServerToolStripMenuItem
            // 
            CreateServerToolStripMenuItem.Name = "CreateServerToolStripMenuItem";
            CreateServerToolStripMenuItem.Size = new Size(166, 22);
            CreateServerToolStripMenuItem.Text = "Create lobby";
            CreateServerToolStripMenuItem.Click += CreateServerToolStripMenuItem_Click;
            // 
            // ConnectToServerStripMenuItem
            // 
            ConnectToServerStripMenuItem.Name = "ConnectToServerStripMenuItem";
            ConnectToServerStripMenuItem.Size = new Size(166, 22);
            ConnectToServerStripMenuItem.Text = "Connect to lobby";
            ConnectToServerStripMenuItem.Click += ConnectToServerStripMenuItem_Click;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ChangePort });
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(61, 20);
            настройкиToolStripMenuItem.Text = "Settings";
            // 
            // ChangePort
            // 
            ChangePort.Name = "ChangePort";
            ChangePort.Size = new Size(140, 22);
            ChangePort.Text = "Change port";
            ChangePort.Click += ChangePort_Click;
            // 
            // оНасToolStripMenuItem
            // 
            оНасToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ProjectPartners, gitHubToolStripMenuItem, поддержатьToolStripMenuItem, помощьToolStripMenuItem });
            оНасToolStripMenuItem.Name = "оНасToolStripMenuItem";
            оНасToolStripMenuItem.Size = new Size(67, 20);
            оНасToolStripMenuItem.Text = "About us";
            // 
            // ProjectPartners
            // 
            ProjectPartners.Name = "ProjectPartners";
            ProjectPartners.Size = new Size(141, 22);
            ProjectPartners.Text = "Contributors";
            ProjectPartners.Click += участникиToolStripMenuItem_Click;
            // 
            // gitHubToolStripMenuItem
            // 
            gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            gitHubToolStripMenuItem.Size = new Size(141, 22);
            gitHubToolStripMenuItem.Text = "GitHub";
            gitHubToolStripMenuItem.Click += gitHubToolStripMenuItem_Click;
            // 
            // поддержатьToolStripMenuItem
            // 
            поддержатьToolStripMenuItem.Name = "поддержатьToolStripMenuItem";
            поддержатьToolStripMenuItem.Size = new Size(141, 22);
            поддержатьToolStripMenuItem.Text = "Support";
            поддержатьToolStripMenuItem.Click += поддержатьToolStripMenuItem_Click;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { youTubeToolStripMenuItem, discordToolStripMenuItem });
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(141, 22);
            помощьToolStripMenuItem.Text = "Social Media";
            // 
            // youTubeToolStripMenuItem
            // 
            youTubeToolStripMenuItem.Name = "youTubeToolStripMenuItem";
            youTubeToolStripMenuItem.Size = new Size(120, 22);
            youTubeToolStripMenuItem.Text = "YouTube";
            youTubeToolStripMenuItem.Click += youTubeToolStripMenuItem_Click;
            // 
            // discordToolStripMenuItem
            // 
            discordToolStripMenuItem.Name = "discordToolStripMenuItem";
            discordToolStripMenuItem.Size = new Size(120, 22);
            discordToolStripMenuItem.Text = "Discord";
            discordToolStripMenuItem.Click += discordToolStripMenuItem_Click;
            // 
            // startButton
            // 
            startButton.Enabled = false;
            startButton.Location = new Point(12, 29);
            startButton.Name = "startButton";
            startButton.Size = new Size(93, 23);
            startButton.TabIndex = 2;
            startButton.Text = "Start Play";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // fileListBox
            // 
            fileListBox.FormattingEnabled = true;
            fileListBox.ItemHeight = 15;
            fileListBox.Location = new Point(325, 52);
            fileListBox.Name = "fileListBox";
            fileListBox.Size = new Size(317, 304);
            fileListBox.TabIndex = 4;
            fileListBox.SelectedIndexChanged += fileListBox_SelectedIndexChanged;
            // 
            // TrackCheckBox
            // 
            TrackCheckBox.CheckOnClick = true;
            TrackCheckBox.FormattingEnabled = true;
            TrackCheckBox.Location = new Point(9, 244);
            TrackCheckBox.Name = "TrackCheckBox";
            TrackCheckBox.Size = new Size(310, 112);
            TrackCheckBox.TabIndex = 5;
            TrackCheckBox.SelectedIndexChanged += TrackCheckBox_SelectedIndexChanged;
            // 
            // InstrumentComboBox
            // 
            InstrumentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            InstrumentComboBox.Items.AddRange(new object[] { "Lyre/Zither", "Old lyre", "Drum" });
            InstrumentComboBox.Location = new Point(9, 200);
            InstrumentComboBox.Name = "InstrumentComboBox";
            InstrumentComboBox.Size = new Size(121, 23);
            InstrumentComboBox.TabIndex = 6;
            InstrumentComboBox.SelectedIndexChanged += InstrumentComboBox_SelectedIndexChanged;
            // 
            // TransposeUpDown
            // 
            TransposeUpDown.Location = new Point(136, 200);
            TransposeUpDown.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            TransposeUpDown.Minimum = new decimal(new int[] { 128, 0, 0, int.MinValue });
            TransposeUpDown.Name = "TransposeUpDown";
            TransposeUpDown.Size = new Size(125, 23);
            TransposeUpDown.TabIndex = 7;
            TransposeUpDown.ValueChanged += TransposeUpDown_ValueChanged;
            // 
            // PlayList
            // 
            PlayList.AutoSize = true;
            PlayList.Location = new Point(325, 33);
            PlayList.Name = "PlayList";
            PlayList.Size = new Size(44, 15);
            PlayList.TabIndex = 8;
            PlayList.Text = "Playlist";
            // 
            // Instrument
            // 
            Instrument.AutoSize = true;
            Instrument.Location = new Point(9, 182);
            Instrument.Name = "Instrument";
            Instrument.Size = new Size(65, 15);
            Instrument.TabIndex = 9;
            Instrument.Text = "Instrument";
            // 
            // TrackList
            // 
            TrackList.AutoSize = true;
            TrackList.Location = new Point(9, 226);
            TrackList.Name = "TrackList";
            TrackList.Size = new Size(39, 15);
            TrackList.TabIndex = 10;
            TrackList.Text = "Tracks";
            // 
            // Transposition
            // 
            Transposition.AutoSize = true;
            Transposition.Location = new Point(136, 167);
            Transposition.Name = "Transposition";
            Transposition.Size = new Size(77, 30);
            Transposition.TabIndex = 11;
            Transposition.Text = "Transposition\r\nRecd:";
            Transposition.Click += Transposition_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 138);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 13;
            label1.Text = "Input device";
            // 
            // inputDeviceComboBox
            // 
            inputDeviceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            inputDeviceComboBox.Items.AddRange(new object[] { "Лира/Цитра", "Старая лира", "Барабан" });
            inputDeviceComboBox.Location = new Point(9, 156);
            inputDeviceComboBox.Name = "inputDeviceComboBox";
            inputDeviceComboBox.Size = new Size(93, 23);
            inputDeviceComboBox.TabIndex = 12;
            inputDeviceComboBox.SelectedIndexChanged += inputDeviceComboBox_SelectedIndexChanged;
            // 
            // reloadInputDeviceButton
            // 
            reloadInputDeviceButton.Location = new Point(109, 155);
            reloadInputDeviceButton.Name = "reloadInputDeviceButton";
            reloadInputDeviceButton.Size = new Size(21, 24);
            reloadInputDeviceButton.TabIndex = 14;
            reloadInputDeviceButton.Text = "🗘";
            reloadInputDeviceButton.UseVisualStyleBackColor = true;
            reloadInputDeviceButton.Click += reloadInputDeviceButton_Click;
            // 
            // reloadFilesButton
            // 
            reloadFilesButton.Location = new Point(375, 27);
            reloadFilesButton.Name = "reloadFilesButton";
            reloadFilesButton.Size = new Size(21, 23);
            reloadFilesButton.TabIndex = 15;
            reloadFilesButton.Text = "🗘";
            reloadFilesButton.UseVisualStyleBackColor = true;
            reloadFilesButton.Click += reloadFilesButton_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(654, 363);
            Controls.Add(reloadFilesButton);
            Controls.Add(reloadInputDeviceButton);
            Controls.Add(label1);
            Controls.Add(inputDeviceComboBox);
            Controls.Add(Transposition);
            Controls.Add(TrackList);
            Controls.Add(Instrument);
            Controls.Add(PlayList);
            Controls.Add(TransposeUpDown);
            Controls.Add(InstrumentComboBox);
            Controls.Add(TrackCheckBox);
            Controls.Add(fileListBox);
            Controls.Add(startButton);
            Controls.Add(windFindButton);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainMenuForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "QuartetPlayer";
            FormClosed += MainMenuForm_FormClosed;
            Load += MainMenuForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TransposeUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button windFindButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem мультиплеерToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private Button startButton;
        private ListBox fileListBox;
        private CheckedListBox TrackCheckBox;
        private ComboBox InstrumentComboBox;
        private NumericUpDown TransposeUpDown;
        private Label PlayList;
        private Label Instrument;
        private Label TrackList;
        private Label Transposition;
        private ToolStripMenuItem OpenFolderMenuItem;
        private ToolStripMenuItem OpenFileMenuItem;
        private ToolStripMenuItem OpenFolderStripMenuItem;
        private ToolStripMenuItem CreateServerToolStripMenuItem;
        private ToolStripMenuItem ConnectToServerStripMenuItem;
        private Label label1;
        private ComboBox inputDeviceComboBox;
        private Button reloadInputDeviceButton;
        private ToolStripMenuItem ChangePort;
        private ToolStripMenuItem оНасToolStripMenuItem;
        private ToolStripMenuItem ProjectPartners;
        private ToolStripMenuItem gitHubToolStripMenuItem;
        private ToolStripMenuItem поддержатьToolStripMenuItem;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem youTubeToolStripMenuItem;
        private ToolStripMenuItem discordToolStripMenuItem;
        private Button reloadFilesButton;
    }
}
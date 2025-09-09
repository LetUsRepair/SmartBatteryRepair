namespace SmartBatteryHack
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DebugGroupBox = new System.Windows.Forms.GroupBox();
            this.ReadROMDescriptionLabel = new System.Windows.Forms.Label();
            this.ReadROMByBytesCheckBox = new System.Windows.Forms.CheckBox();
            this.ReadROMButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.WordByteOrderOKButton = new System.Windows.Forms.Button();
            this.WordByteOrderLabel = new System.Windows.Forms.Label();
            this.WordByteOrderComboBox = new System.Windows.Forms.ComboBox();
            this.SMBusAddressSelectButton = new System.Windows.Forms.Button();
            this.SMBusAddressComboBox = new System.Windows.Forms.ComboBox();
            this.DashLabel = new System.Windows.Forms.Label();
            this.RegEndTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BattDesCapaText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RegStartTextBox = new System.Windows.Forms.TextBox();
            this.SMBusRegisterDumpButton = new System.Windows.Forms.Button();
            this.ScanSMBusButton = new System.Windows.Forms.Button();
            this.WriteDataTextBox = new System.Windows.Forms.TextBox();
            this.WriteBlockButton = new System.Windows.Forms.Button();
            this.WriteWordButton = new System.Windows.Forms.Button();
            this.BattVoltageText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WriteByteButton = new System.Windows.Forms.Button();
            this.WriteRegisterComboBox = new System.Windows.Forms.ComboBox();
            this.WriteLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BattSerialNoText = new System.Windows.Forms.TextBox();
            this.ChipManufText = new System.Windows.Forms.TextBox();
            this.ReadBatteryDataButton = new System.Windows.Forms.Button();
            this.ChipNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterLabelWrite = new System.Windows.Forms.Label();
            this.ControlGroupBox = new System.Windows.Forms.GroupBox();
            this.StatusButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.COMPortsComboBox = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.RegisterLabelRead = new System.Windows.Forms.Label();
            this.ToolsGroupBox = new System.Windows.Forms.GroupBox();
            this.ReadDataTextBox = new System.Windows.Forms.TextBox();
            this.ReadBlockButton = new System.Windows.Forms.Button();
            this.ReadWordButton = new System.Windows.Forms.Button();
            this.ReadByteButton = new System.Windows.Forms.Button();
            this.ReadRegisterComboBox = new System.Windows.Forms.ComboBox();
            this.ReadLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CommunicationGroupBox = new System.Windows.Forms.GroupBox();
            this.CommunicationTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SendComboBox = new System.Windows.Forms.ComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.DebugGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ControlGroupBox.SuspendLayout();
            this.ToolsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.CommunicationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 784);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SendButton);
            this.tabPage1.Controls.Add(this.SendComboBox);
            this.tabPage1.Controls.Add(this.DebugGroupBox);
            this.tabPage1.Controls.Add(this.MenuStrip);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.ControlGroupBox);
            this.tabPage1.Controls.Add(this.ToolsGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(967, 758);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Battery Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CommunicationGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(967, 758);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DebugGroupBox
            // 
            this.DebugGroupBox.Controls.Add(this.ReadROMDescriptionLabel);
            this.DebugGroupBox.Controls.Add(this.ReadROMByBytesCheckBox);
            this.DebugGroupBox.Controls.Add(this.ReadROMButton);
            this.DebugGroupBox.Location = new System.Drawing.Point(390, 298);
            this.DebugGroupBox.Name = "DebugGroupBox";
            this.DebugGroupBox.Size = new System.Drawing.Size(321, 227);
            this.DebugGroupBox.TabIndex = 15;
            this.DebugGroupBox.TabStop = false;
            this.DebugGroupBox.Text = "Debug";
            // 
            // ReadROMDescriptionLabel
            // 
            this.ReadROMDescriptionLabel.AutoSize = true;
            this.ReadROMDescriptionLabel.Location = new System.Drawing.Point(6, 46);
            this.ReadROMDescriptionLabel.Name = "ReadROMDescriptionLabel";
            this.ReadROMDescriptionLabel.Size = new System.Drawing.Size(307, 13);
            this.ReadROMDescriptionLabel.TabIndex = 2;
            this.ReadROMDescriptionLabel.Text = "Read interval: 0x0000-0x07FF, 0x4000-0x47FF, 0x8000-0x87FF";
            // 
            // ReadROMByBytesCheckBox
            // 
            this.ReadROMByBytesCheckBox.AutoSize = true;
            this.ReadROMByBytesCheckBox.Location = new System.Drawing.Point(89, 24);
            this.ReadROMByBytesCheckBox.Name = "ReadROMByBytesCheckBox";
            this.ReadROMByBytesCheckBox.Size = new System.Drawing.Size(195, 17);
            this.ReadROMByBytesCheckBox.TabIndex = 1;
            this.ReadROMByBytesCheckBox.Text = "Read ROM by bytes (default: block)";
            this.ReadROMByBytesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReadROMButton
            // 
            this.ReadROMButton.Location = new System.Drawing.Point(8, 20);
            this.ReadROMButton.Name = "ReadROMButton";
            this.ReadROMButton.Size = new System.Drawing.Size(75, 23);
            this.ReadROMButton.TabIndex = 0;
            this.ReadROMButton.Text = "Read ROM";
            this.ReadROMButton.UseVisualStyleBackColor = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Location = new System.Drawing.Point(3, 3);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(961, 24);
            this.MenuStrip.TabIndex = 14;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 733);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(961, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // WordByteOrderOKButton
            // 
            this.WordByteOrderOKButton.Location = new System.Drawing.Point(314, 131);
            this.WordByteOrderOKButton.Name = "WordByteOrderOKButton";
            this.WordByteOrderOKButton.Size = new System.Drawing.Size(42, 23);
            this.WordByteOrderOKButton.TabIndex = 5;
            this.WordByteOrderOKButton.Text = "OK";
            this.WordByteOrderOKButton.UseVisualStyleBackColor = true;
            // 
            // WordByteOrderLabel
            // 
            this.WordByteOrderLabel.AutoSize = true;
            this.WordByteOrderLabel.Location = new System.Drawing.Point(183, 115);
            this.WordByteOrderLabel.Name = "WordByteOrderLabel";
            this.WordByteOrderLabel.Size = new System.Drawing.Size(86, 13);
            this.WordByteOrderLabel.TabIndex = 30;
            this.WordByteOrderLabel.Text = "Word byte-order:";
            // 
            // WordByteOrderComboBox
            // 
            this.WordByteOrderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WordByteOrderComboBox.FormattingEnabled = true;
            this.WordByteOrderComboBox.Items.AddRange(new object[] {
            "No reverse",
            "Reverse read",
            "Reverse write",
            "Reverse read/write"});
            this.WordByteOrderComboBox.Location = new System.Drawing.Point(186, 132);
            this.WordByteOrderComboBox.Name = "WordByteOrderComboBox";
            this.WordByteOrderComboBox.Size = new System.Drawing.Size(120, 21);
            this.WordByteOrderComboBox.TabIndex = 29;
            // 
            // SMBusAddressSelectButton
            // 
            this.SMBusAddressSelectButton.Enabled = false;
            this.SMBusAddressSelectButton.Location = new System.Drawing.Point(146, 20);
            this.SMBusAddressSelectButton.Name = "SMBusAddressSelectButton";
            this.SMBusAddressSelectButton.Size = new System.Drawing.Size(90, 25);
            this.SMBusAddressSelectButton.TabIndex = 27;
            this.SMBusAddressSelectButton.Text = "Select Address";
            this.SMBusAddressSelectButton.UseVisualStyleBackColor = true;
            // 
            // SMBusAddressComboBox
            // 
            this.SMBusAddressComboBox.DropDownHeight = 93;
            this.SMBusAddressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SMBusAddressComboBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SMBusAddressComboBox.FormattingEnabled = true;
            this.SMBusAddressComboBox.IntegralHeight = false;
            this.SMBusAddressComboBox.Location = new System.Drawing.Point(103, 21);
            this.SMBusAddressComboBox.Name = "SMBusAddressComboBox";
            this.SMBusAddressComboBox.Size = new System.Drawing.Size(38, 23);
            this.SMBusAddressComboBox.TabIndex = 26;
            // 
            // DashLabel
            // 
            this.DashLabel.AutoSize = true;
            this.DashLabel.Location = new System.Drawing.Point(136, 115);
            this.DashLabel.Name = "DashLabel";
            this.DashLabel.Size = new System.Drawing.Size(10, 13);
            this.DashLabel.TabIndex = 25;
            this.DashLabel.Text = "-";
            // 
            // RegEndTextBox
            // 
            this.RegEndTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.RegEndTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RegEndTextBox.Location = new System.Drawing.Point(147, 110);
            this.RegEndTextBox.Multiline = true;
            this.RegEndTextBox.Name = "RegEndTextBox";
            this.RegEndTextBox.Size = new System.Drawing.Size(23, 23);
            this.RegEndTextBox.TabIndex = 24;
            this.RegEndTextBox.Text = "FF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Battery Serial No.";
            // 
            // BattDesCapaText
            // 
            this.BattDesCapaText.Location = new System.Drawing.Point(98, 94);
            this.BattDesCapaText.Name = "BattDesCapaText";
            this.BattDesCapaText.Size = new System.Drawing.Size(131, 20);
            this.BattDesCapaText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Design Capacity";
            // 
            // RegStartTextBox
            // 
            this.RegStartTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.RegStartTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RegStartTextBox.Location = new System.Drawing.Point(111, 110);
            this.RegStartTextBox.Multiline = true;
            this.RegStartTextBox.Name = "RegStartTextBox";
            this.RegStartTextBox.Size = new System.Drawing.Size(23, 23);
            this.RegStartTextBox.TabIndex = 23;
            this.RegStartTextBox.Text = "00";
            // 
            // SMBusRegisterDumpButton
            // 
            this.SMBusRegisterDumpButton.Location = new System.Drawing.Point(8, 109);
            this.SMBusRegisterDumpButton.Name = "SMBusRegisterDumpButton";
            this.SMBusRegisterDumpButton.Size = new System.Drawing.Size(90, 25);
            this.SMBusRegisterDumpButton.TabIndex = 22;
            this.SMBusRegisterDumpButton.Text = "Dump Registers";
            this.SMBusRegisterDumpButton.UseVisualStyleBackColor = true;
            // 
            // ScanSMBusButton
            // 
            this.ScanSMBusButton.Location = new System.Drawing.Point(8, 20);
            this.ScanSMBusButton.Name = "ScanSMBusButton";
            this.ScanSMBusButton.Size = new System.Drawing.Size(90, 25);
            this.ScanSMBusButton.TabIndex = 5;
            this.ScanSMBusButton.Text = "Scan SMBus";
            this.ScanSMBusButton.UseVisualStyleBackColor = true;
            // 
            // WriteDataTextBox
            // 
            this.WriteDataTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.WriteDataTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WriteDataTextBox.Location = new System.Drawing.Point(147, 80);
            this.WriteDataTextBox.Multiline = true;
            this.WriteDataTextBox.Name = "WriteDataTextBox";
            this.WriteDataTextBox.Size = new System.Drawing.Size(69, 23);
            this.WriteDataTextBox.TabIndex = 18;
            // 
            // WriteBlockButton
            // 
            this.WriteBlockButton.Location = new System.Drawing.Point(314, 79);
            this.WriteBlockButton.Name = "WriteBlockButton";
            this.WriteBlockButton.Size = new System.Drawing.Size(42, 25);
            this.WriteBlockButton.TabIndex = 17;
            this.WriteBlockButton.Text = "block";
            this.WriteBlockButton.UseVisualStyleBackColor = true;
            // 
            // WriteWordButton
            // 
            this.WriteWordButton.Location = new System.Drawing.Point(268, 79);
            this.WriteWordButton.Name = "WriteWordButton";
            this.WriteWordButton.Size = new System.Drawing.Size(42, 25);
            this.WriteWordButton.TabIndex = 16;
            this.WriteWordButton.Text = "word";
            this.WriteWordButton.UseVisualStyleBackColor = true;
            // 
            // BattVoltageText
            // 
            this.BattVoltageText.Location = new System.Drawing.Point(98, 68);
            this.BattVoltageText.Name = "BattVoltageText";
            this.BattVoltageText.Size = new System.Drawing.Size(131, 20);
            this.BattVoltageText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Battery Voltage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // WriteByteButton
            // 
            this.WriteByteButton.Location = new System.Drawing.Point(222, 79);
            this.WriteByteButton.Name = "WriteByteButton";
            this.WriteByteButton.Size = new System.Drawing.Size(42, 25);
            this.WriteByteButton.TabIndex = 14;
            this.WriteByteButton.Text = "byte";
            this.WriteByteButton.UseVisualStyleBackColor = true;
            // 
            // WriteRegisterComboBox
            // 
            this.WriteRegisterComboBox.DropDownHeight = 93;
            this.WriteRegisterComboBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WriteRegisterComboBox.FormattingEnabled = true;
            this.WriteRegisterComboBox.IntegralHeight = false;
            this.WriteRegisterComboBox.Location = new System.Drawing.Point(59, 80);
            this.WriteRegisterComboBox.Name = "WriteRegisterComboBox";
            this.WriteRegisterComboBox.Size = new System.Drawing.Size(38, 23);
            this.WriteRegisterComboBox.TabIndex = 13;
            // 
            // WriteLabel
            // 
            this.WriteLabel.AutoSize = true;
            this.WriteLabel.Location = new System.Drawing.Point(109, 84);
            this.WriteLabel.Name = "WriteLabel";
            this.WriteLabel.Size = new System.Drawing.Size(35, 13);
            this.WriteLabel.TabIndex = 15;
            this.WriteLabel.Text = "Write:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BattSerialNoText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BattDesCapaText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BattVoltageText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ChipManufText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ReadBatteryDataButton);
            this.groupBox1.Controls.Add(this.ChipNameText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(721, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 186);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Battery Data";
            // 
            // BattSerialNoText
            // 
            this.BattSerialNoText.Location = new System.Drawing.Point(98, 120);
            this.BattSerialNoText.Name = "BattSerialNoText";
            this.BattSerialNoText.Size = new System.Drawing.Size(131, 20);
            this.BattSerialNoText.TabIndex = 10;
            // 
            // ChipManufText
            // 
            this.ChipManufText.Location = new System.Drawing.Point(98, 42);
            this.ChipManufText.Name = "ChipManufText";
            this.ChipManufText.Size = new System.Drawing.Size(131, 20);
            this.ChipManufText.TabIndex = 4;
            // 
            // ReadBatteryDataButton
            // 
            this.ReadBatteryDataButton.Location = new System.Drawing.Point(55, 153);
            this.ReadBatteryDataButton.Name = "ReadBatteryDataButton";
            this.ReadBatteryDataButton.Size = new System.Drawing.Size(112, 23);
            this.ReadBatteryDataButton.TabIndex = 2;
            this.ReadBatteryDataButton.Text = "Read Battery Data";
            this.ReadBatteryDataButton.UseVisualStyleBackColor = true;
            // 
            // ChipNameText
            // 
            this.ChipNameText.Location = new System.Drawing.Point(98, 16);
            this.ChipNameText.Name = "ChipNameText";
            this.ChipNameText.Size = new System.Drawing.Size(131, 20);
            this.ChipNameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chip";
            // 
            // RegisterLabelWrite
            // 
            this.RegisterLabelWrite.AutoSize = true;
            this.RegisterLabelWrite.Location = new System.Drawing.Point(7, 84);
            this.RegisterLabelWrite.Name = "RegisterLabelWrite";
            this.RegisterLabelWrite.Size = new System.Drawing.Size(49, 13);
            this.RegisterLabelWrite.TabIndex = 12;
            this.RegisterLabelWrite.Text = "Register:";
            // 
            // ControlGroupBox
            // 
            this.ControlGroupBox.Controls.Add(this.StatusButton);
            this.ControlGroupBox.Controls.Add(this.ResetButton);
            this.ControlGroupBox.Controls.Add(this.RefreshButton);
            this.ControlGroupBox.Controls.Add(this.COMPortsComboBox);
            this.ControlGroupBox.Controls.Add(this.ConnectButton);
            this.ControlGroupBox.Location = new System.Drawing.Point(12, 468);
            this.ControlGroupBox.Name = "ControlGroupBox";
            this.ControlGroupBox.Size = new System.Drawing.Size(365, 57);
            this.ControlGroupBox.TabIndex = 12;
            this.ControlGroupBox.TabStop = false;
            this.ControlGroupBox.Text = "Control";
            // 
            // StatusButton
            // 
            this.StatusButton.Enabled = false;
            this.StatusButton.Location = new System.Drawing.Point(251, 19);
            this.StatusButton.Name = "StatusButton";
            this.StatusButton.Size = new System.Drawing.Size(50, 25);
            this.StatusButton.TabIndex = 4;
            this.StatusButton.Text = "Status";
            this.StatusButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Enabled = false;
            this.ResetButton.Location = new System.Drawing.Point(306, 19);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(50, 25);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshButton.Location = new System.Drawing.Point(156, 19);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(55, 25);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // COMPortsComboBox
            // 
            this.COMPortsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMPortsComboBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.COMPortsComboBox.FormattingEnabled = true;
            this.COMPortsComboBox.Location = new System.Drawing.Point(90, 20);
            this.COMPortsComboBox.Name = "COMPortsComboBox";
            this.COMPortsComboBox.Size = new System.Drawing.Size(60, 23);
            this.COMPortsComboBox.TabIndex = 1;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(9, 19);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 25);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            // 
            // RegisterLabelRead
            // 
            this.RegisterLabelRead.AutoSize = true;
            this.RegisterLabelRead.Location = new System.Drawing.Point(7, 55);
            this.RegisterLabelRead.Name = "RegisterLabelRead";
            this.RegisterLabelRead.Size = new System.Drawing.Size(49, 13);
            this.RegisterLabelRead.TabIndex = 1;
            this.RegisterLabelRead.Text = "Register:";
            // 
            // ToolsGroupBox
            // 
            this.ToolsGroupBox.Controls.Add(this.WordByteOrderOKButton);
            this.ToolsGroupBox.Controls.Add(this.WordByteOrderLabel);
            this.ToolsGroupBox.Controls.Add(this.WordByteOrderComboBox);
            this.ToolsGroupBox.Controls.Add(this.SMBusAddressSelectButton);
            this.ToolsGroupBox.Controls.Add(this.SMBusAddressComboBox);
            this.ToolsGroupBox.Controls.Add(this.DashLabel);
            this.ToolsGroupBox.Controls.Add(this.RegEndTextBox);
            this.ToolsGroupBox.Controls.Add(this.RegStartTextBox);
            this.ToolsGroupBox.Controls.Add(this.SMBusRegisterDumpButton);
            this.ToolsGroupBox.Controls.Add(this.ScanSMBusButton);
            this.ToolsGroupBox.Controls.Add(this.WriteDataTextBox);
            this.ToolsGroupBox.Controls.Add(this.WriteBlockButton);
            this.ToolsGroupBox.Controls.Add(this.WriteWordButton);
            this.ToolsGroupBox.Controls.Add(this.WriteByteButton);
            this.ToolsGroupBox.Controls.Add(this.WriteRegisterComboBox);
            this.ToolsGroupBox.Controls.Add(this.WriteLabel);
            this.ToolsGroupBox.Controls.Add(this.RegisterLabelWrite);
            this.ToolsGroupBox.Controls.Add(this.ReadDataTextBox);
            this.ToolsGroupBox.Controls.Add(this.ReadBlockButton);
            this.ToolsGroupBox.Controls.Add(this.ReadWordButton);
            this.ToolsGroupBox.Controls.Add(this.ReadByteButton);
            this.ToolsGroupBox.Controls.Add(this.ReadRegisterComboBox);
            this.ToolsGroupBox.Controls.Add(this.ReadLabel);
            this.ToolsGroupBox.Controls.Add(this.RegisterLabelRead);
            this.ToolsGroupBox.Enabled = false;
            this.ToolsGroupBox.Location = new System.Drawing.Point(12, 298);
            this.ToolsGroupBox.Name = "ToolsGroupBox";
            this.ToolsGroupBox.Size = new System.Drawing.Size(365, 164);
            this.ToolsGroupBox.TabIndex = 13;
            this.ToolsGroupBox.TabStop = false;
            this.ToolsGroupBox.Text = "Tools";
            // 
            // ReadDataTextBox
            // 
            this.ReadDataTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ReadDataTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReadDataTextBox.Location = new System.Drawing.Point(147, 51);
            this.ReadDataTextBox.Multiline = true;
            this.ReadDataTextBox.Name = "ReadDataTextBox";
            this.ReadDataTextBox.ReadOnly = true;
            this.ReadDataTextBox.Size = new System.Drawing.Size(69, 23);
            this.ReadDataTextBox.TabIndex = 11;
            // 
            // ReadBlockButton
            // 
            this.ReadBlockButton.Location = new System.Drawing.Point(314, 50);
            this.ReadBlockButton.Name = "ReadBlockButton";
            this.ReadBlockButton.Size = new System.Drawing.Size(42, 25);
            this.ReadBlockButton.TabIndex = 10;
            this.ReadBlockButton.Text = "block";
            this.ReadBlockButton.UseVisualStyleBackColor = true;
            // 
            // ReadWordButton
            // 
            this.ReadWordButton.Location = new System.Drawing.Point(268, 50);
            this.ReadWordButton.Name = "ReadWordButton";
            this.ReadWordButton.Size = new System.Drawing.Size(42, 25);
            this.ReadWordButton.TabIndex = 9;
            this.ReadWordButton.Text = "word";
            this.ReadWordButton.UseVisualStyleBackColor = true;
            // 
            // ReadByteButton
            // 
            this.ReadByteButton.Location = new System.Drawing.Point(222, 50);
            this.ReadByteButton.Name = "ReadByteButton";
            this.ReadByteButton.Size = new System.Drawing.Size(42, 25);
            this.ReadByteButton.TabIndex = 5;
            this.ReadByteButton.Text = "byte";
            this.ReadByteButton.UseVisualStyleBackColor = true;
            // 
            // ReadRegisterComboBox
            // 
            this.ReadRegisterComboBox.DropDownHeight = 93;
            this.ReadRegisterComboBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReadRegisterComboBox.FormattingEnabled = true;
            this.ReadRegisterComboBox.IntegralHeight = false;
            this.ReadRegisterComboBox.Location = new System.Drawing.Point(59, 51);
            this.ReadRegisterComboBox.Name = "ReadRegisterComboBox";
            this.ReadRegisterComboBox.Size = new System.Drawing.Size(38, 23);
            this.ReadRegisterComboBox.TabIndex = 3;
            // 
            // ReadLabel
            // 
            this.ReadLabel.AutoSize = true;
            this.ReadLabel.Location = new System.Drawing.Point(108, 55);
            this.ReadLabel.Name = "ReadLabel";
            this.ReadLabel.Size = new System.Drawing.Size(36, 13);
            this.ReadLabel.TabIndex = 8;
            this.ReadLabel.Text = "Read:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // CommunicationGroupBox
            // 
            this.CommunicationGroupBox.Controls.Add(this.CommunicationTextBox);
            this.CommunicationGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CommunicationGroupBox.Name = "CommunicationGroupBox";
            this.CommunicationGroupBox.Size = new System.Drawing.Size(700, 240);
            this.CommunicationGroupBox.TabIndex = 12;
            this.CommunicationGroupBox.TabStop = false;
            this.CommunicationGroupBox.Text = "SMBus Communication Logs";
            // 
            // CommunicationTextBox
            // 
            this.CommunicationTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.CommunicationTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CommunicationTextBox.Location = new System.Drawing.Point(3, 16);
            this.CommunicationTextBox.Multiline = true;
            this.CommunicationTextBox.Name = "CommunicationTextBox";
            this.CommunicationTextBox.ReadOnly = true;
            this.CommunicationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CommunicationTextBox.Size = new System.Drawing.Size(958, 286);
            this.CommunicationTextBox.TabIndex = 0;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(656, 258);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(51, 25);
            this.SendButton.TabIndex = 19;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // SendComboBox
            // 
            this.SendComboBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendComboBox.FormattingEnabled = true;
            this.SendComboBox.Location = new System.Drawing.Point(12, 259);
            this.SendComboBox.Name = "SendComboBox";
            this.SendComboBox.Size = new System.Drawing.Size(643, 23);
            this.SendComboBox.TabIndex = 18;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // FileMenuExit
            // 
            this.FileMenuExit.Name = "FileMenuExit";
            this.FileMenuExit.Size = new System.Drawing.Size(180, 22);
            this.FileMenuExit.Text = "Exit";
            this.FileMenuExit.Click += new System.EventHandler(this.FileMenuExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 808);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SB Hack - Evolved";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.DebugGroupBox.ResumeLayout(false);
            this.DebugGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ControlGroupBox.ResumeLayout(false);
            this.ToolsGroupBox.ResumeLayout(false);
            this.ToolsGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CommunicationGroupBox.ResumeLayout(false);
            this.CommunicationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox DebugGroupBox;
        private System.Windows.Forms.Label ReadROMDescriptionLabel;
        private System.Windows.Forms.CheckBox ReadROMByBytesCheckBox;
        private System.Windows.Forms.Button ReadROMButton;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BattSerialNoText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BattDesCapaText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BattVoltageText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ChipManufText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ReadBatteryDataButton;
        private System.Windows.Forms.TextBox ChipNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ControlGroupBox;
        private System.Windows.Forms.Button StatusButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ComboBox COMPortsComboBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.GroupBox ToolsGroupBox;
        private System.Windows.Forms.Button WordByteOrderOKButton;
        private System.Windows.Forms.Label WordByteOrderLabel;
        private System.Windows.Forms.ComboBox WordByteOrderComboBox;
        private System.Windows.Forms.Button SMBusAddressSelectButton;
        private System.Windows.Forms.ComboBox SMBusAddressComboBox;
        private System.Windows.Forms.Label DashLabel;
        private System.Windows.Forms.TextBox RegEndTextBox;
        private System.Windows.Forms.TextBox RegStartTextBox;
        private System.Windows.Forms.Button SMBusRegisterDumpButton;
        private System.Windows.Forms.Button ScanSMBusButton;
        private System.Windows.Forms.TextBox WriteDataTextBox;
        private System.Windows.Forms.Button WriteBlockButton;
        private System.Windows.Forms.Button WriteWordButton;
        private System.Windows.Forms.Button WriteByteButton;
        private System.Windows.Forms.ComboBox WriteRegisterComboBox;
        private System.Windows.Forms.Label WriteLabel;
        private System.Windows.Forms.Label RegisterLabelWrite;
        private System.Windows.Forms.TextBox ReadDataTextBox;
        private System.Windows.Forms.Button ReadBlockButton;
        private System.Windows.Forms.Button ReadWordButton;
        private System.Windows.Forms.Button ReadByteButton;
        private System.Windows.Forms.ComboBox ReadRegisterComboBox;
        private System.Windows.Forms.Label ReadLabel;
        private System.Windows.Forms.Label RegisterLabelRead;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ComboBox SendComboBox;
        private System.Windows.Forms.GroupBox CommunicationGroupBox;
        private System.Windows.Forms.TextBox CommunicationTextBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuExit;
    }
}


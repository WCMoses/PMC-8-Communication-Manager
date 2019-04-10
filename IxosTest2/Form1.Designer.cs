namespace IxosTest2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdCopyToClipboard = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Basic = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmdRefreshComPorts = new System.Windows.Forms.Button();
            this.cmdFindComPort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBasic2IpAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBasic2SerialPort = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbBasic2MountType = new System.Windows.Forms.ComboBox();
            this.txtBasic2IpPort = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdBasic2CheckCurrentConnection = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.cmdBasic2ViaUdp = new System.Windows.Forms.Button();
            this.cmdBasic2ViaTCP = new System.Windows.Forms.Button();
            this.cmdBasic2ViaAscom = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Advaced = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmdUploadRom = new System.Windows.Forms.Button();
            this.FindEepromFile = new System.Windows.Forms.Button();
            this.txtEepromPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbDefault = new System.Windows.Forms.RadioButton();
            this.rbDebugInfo = new System.Windows.Forms.RadioButton();
            this.rbDetailedInfo = new System.Windows.Forms.RadioButton();
            this.rbGeneralInfo = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSerial = new System.Windows.Forms.RadioButton();
            this.rbUdp = new System.Windows.Forms.RadioButton();
            this.rbTcp = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdAdvancedEsgp0 = new System.Windows.Forms.Button();
            this.cmdAdvancedESY = new System.Windows.Forms.Button();
            this.cmdAdvancedEsx = new System.Windows.Forms.Button();
            this.cmdSendCustomCommand = new System.Windows.Forms.Button();
            this.txtCommandToSend = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Instructions = new System.Windows.Forms.TabPage();
            this.rtbInstructions = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCurrentConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCurrentNetwork = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Basic.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Advaced.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Instructions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.txtOutput);
            this.splitContainer1.Size = new System.Drawing.Size(1517, 1026);
            this.splitContainer1.SplitterDistance = 687;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdCopyToClipboard);
            this.panel2.Controls.Add(this.cmdClear);
            this.panel2.Controls.Add(this.cmdClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 613);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1517, 74);
            this.panel2.TabIndex = 2;
            // 
            // cmdCopyToClipboard
            // 
            this.cmdCopyToClipboard.Location = new System.Drawing.Point(978, 14);
            this.cmdCopyToClipboard.Name = "cmdCopyToClipboard";
            this.cmdCopyToClipboard.Size = new System.Drawing.Size(220, 44);
            this.cmdCopyToClipboard.TabIndex = 3;
            this.cmdCopyToClipboard.Text = "Copy To Clipboard";
            this.cmdCopyToClipboard.UseVisualStyleBackColor = true;
            this.cmdCopyToClipboard.Click += new System.EventHandler(this.CmdCopyToClipboard_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(662, 15);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(111, 42);
            this.cmdClear.TabIndex = 1;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(1302, 15);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(115, 42);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Instructions);
            this.tabControl1.Controls.Add(this.Basic);
            this.tabControl1.Controls.Add(this.Advaced);
            this.tabControl1.Location = new System.Drawing.Point(3, 149);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1517, 428);
            this.tabControl1.TabIndex = 1;
            // 
            // Basic
            // 
            this.Basic.BackColor = System.Drawing.Color.LightGray;
            this.Basic.Controls.Add(this.groupBox5);
            this.Basic.Controls.Add(this.groupBox1);
            this.Basic.Location = new System.Drawing.Point(8, 39);
            this.Basic.Name = "Basic";
            this.Basic.Padding = new System.Windows.Forms.Padding(3);
            this.Basic.Size = new System.Drawing.Size(1501, 381);
            this.Basic.TabIndex = 0;
            this.Basic.Text = "Basic";
            this.Basic.Click += new System.EventHandler(this.Basic_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmdRefreshComPorts);
            this.groupBox5.Controls.Add(this.cmdFindComPort);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtBasic2IpAddress);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.cmbBasic2SerialPort);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.cmbBasic2MountType);
            this.groupBox5.Controls.Add(this.txtBasic2IpPort);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(50, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(486, 288);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Connection Settings";
            // 
            // cmdRefreshComPorts
            // 
            this.cmdRefreshComPorts.Location = new System.Drawing.Point(345, 239);
            this.cmdRefreshComPorts.Name = "cmdRefreshComPorts";
            this.cmdRefreshComPorts.Size = new System.Drawing.Size(110, 49);
            this.cmdRefreshComPorts.TabIndex = 19;
            this.cmdRefreshComPorts.Text = "Refresh";
            this.cmdRefreshComPorts.UseVisualStyleBackColor = true;
            this.cmdRefreshComPorts.Click += new System.EventHandler(this.CmdRefreshComPorts_Click);
            // 
            // cmdFindComPort
            // 
            this.cmdFindComPort.Location = new System.Drawing.Point(250, 239);
            this.cmdFindComPort.Name = "cmdFindComPort";
            this.cmdFindComPort.Size = new System.Drawing.Size(88, 49);
            this.cmdFindComPort.TabIndex = 18;
            this.cmdFindComPort.Text = "Find";
            this.cmdFindComPort.UseVisualStyleBackColor = true;
            this.cmdFindComPort.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "IP Port";
            // 
            // txtBasic2IpAddress
            // 
            this.txtBasic2IpAddress.Enabled = false;
            this.txtBasic2IpAddress.Location = new System.Drawing.Point(250, 89);
            this.txtBasic2IpAddress.Name = "txtBasic2IpAddress";
            this.txtBasic2IpAddress.Size = new System.Drawing.Size(195, 31);
            this.txtBasic2IpAddress.TabIndex = 8;
            this.txtBasic2IpAddress.Text = "192.168.47.1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "IP Address";
            // 
            // cmbBasic2SerialPort
            // 
            this.cmbBasic2SerialPort.FormattingEnabled = true;
            this.cmbBasic2SerialPort.Location = new System.Drawing.Point(250, 195);
            this.cmbBasic2SerialPort.Name = "cmbBasic2SerialPort";
            this.cmbBasic2SerialPort.Size = new System.Drawing.Size(195, 33);
            this.cmbBasic2SerialPort.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cmbBasic2SerialPort, "Please set this before trying to change connection method.");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "Mount Type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(-177, 190);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 25);
            this.label18.TabIndex = 14;
            this.label18.Text = "Serial Port";
            // 
            // cmbBasic2MountType
            // 
            this.cmbBasic2MountType.FormattingEnabled = true;
            this.cmbBasic2MountType.Items.AddRange(new object[] {
            "iExos100",
            "G11",
            "Exos-2"});
            this.cmbBasic2MountType.Location = new System.Drawing.Point(250, 40);
            this.cmbBasic2MountType.Name = "cmbBasic2MountType";
            this.cmbBasic2MountType.Size = new System.Drawing.Size(195, 33);
            this.cmbBasic2MountType.TabIndex = 11;
            this.toolTip1.SetToolTip(this.cmbBasic2MountType, "Please set this before trying to change connection method.\r\n");
            // 
            // txtBasic2IpPort
            // 
            this.txtBasic2IpPort.Enabled = false;
            this.txtBasic2IpPort.Location = new System.Drawing.Point(250, 139);
            this.txtBasic2IpPort.Name = "txtBasic2IpPort";
            this.txtBasic2IpPort.Size = new System.Drawing.Size(195, 31);
            this.txtBasic2IpPort.TabIndex = 13;
            this.txtBasic2IpPort.Text = "54372";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Com Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.cmdBasic2CheckCurrentConnection);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.cmdBasic2ViaUdp);
            this.groupBox1.Controls.Add(this.cmdBasic2ViaTCP);
            this.groupBox1.Controls.Add(this.cmdBasic2ViaAscom);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(651, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 338);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "How Do You Want To Connect";
            // 
            // cmdBasic2CheckCurrentConnection
            // 
            this.cmdBasic2CheckCurrentConnection.Location = new System.Drawing.Point(540, 22);
            this.cmdBasic2CheckCurrentConnection.Name = "cmdBasic2CheckCurrentConnection";
            this.cmdBasic2CheckCurrentConnection.Size = new System.Drawing.Size(167, 42);
            this.cmdBasic2CheckCurrentConnection.TabIndex = 15;
            this.cmdBasic2CheckCurrentConnection.Text = "Do It";
            this.toolTip1.SetToolTip(this.cmdBasic2CheckCurrentConnection, "Try to find the current connection method.");
            this.cmdBasic2CheckCurrentConnection.UseVisualStyleBackColor = true;
            this.cmdBasic2CheckCurrentConnection.Click += new System.EventHandler(this.CmdBasic2CheckCurrentConnection_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(48, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(333, 31);
            this.label19.TabIndex = 14;
            this.label19.Text = "Find Current Connection";
            // 
            // cmdBasic2ViaUdp
            // 
            this.cmdBasic2ViaUdp.Location = new System.Drawing.Point(540, 282);
            this.cmdBasic2ViaUdp.Name = "cmdBasic2ViaUdp";
            this.cmdBasic2ViaUdp.Size = new System.Drawing.Size(167, 50);
            this.cmdBasic2ViaUdp.TabIndex = 13;
            this.cmdBasic2ViaUdp.Text = "Do It";
            this.cmdBasic2ViaUdp.UseVisualStyleBackColor = true;
            this.cmdBasic2ViaUdp.Click += new System.EventHandler(this.CmdBasic2ViaUdp_Click);
            // 
            // cmdBasic2ViaTCP
            // 
            this.cmdBasic2ViaTCP.Location = new System.Drawing.Point(540, 180);
            this.cmdBasic2ViaTCP.Name = "cmdBasic2ViaTCP";
            this.cmdBasic2ViaTCP.Size = new System.Drawing.Size(167, 48);
            this.cmdBasic2ViaTCP.TabIndex = 12;
            this.cmdBasic2ViaTCP.Text = "Do It";
            this.cmdBasic2ViaTCP.UseVisualStyleBackColor = true;
            this.cmdBasic2ViaTCP.Click += new System.EventHandler(this.CmdBasic2ViaTCP_Click);
            // 
            // cmdBasic2ViaAscom
            // 
            this.cmdBasic2ViaAscom.Location = new System.Drawing.Point(540, 79);
            this.cmdBasic2ViaAscom.Name = "cmdBasic2ViaAscom";
            this.cmdBasic2ViaAscom.Size = new System.Drawing.Size(167, 50);
            this.cmdBasic2ViaAscom.TabIndex = 11;
            this.cmdBasic2ViaAscom.Text = "Do It";
            this.cmdBasic2ViaAscom.UseVisualStyleBackColor = true;
            this.cmdBasic2ViaAscom.Click += new System.EventHandler(this.CmdBasic2ViaAscom_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(101, 307);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(236, 25);
            this.label16.TabIndex = 10;
            this.label16.Text = "Via ExploreStars (UDP)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(89, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(277, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "Via Wireless ASCOM (TCP)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(89, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(201, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "Via ASCOM (Serial)";
            // 
            // Advaced
            // 
            this.Advaced.BackColor = System.Drawing.Color.LightGray;
            this.Advaced.Controls.Add(this.groupBox7);
            this.Advaced.Controls.Add(this.groupBox6);
            this.Advaced.Controls.Add(this.groupBox3);
            this.Advaced.Controls.Add(this.groupBox2);
            this.Advaced.Controls.Add(this.groupBox4);
            this.Advaced.Location = new System.Drawing.Point(8, 39);
            this.Advaced.Name = "Advaced";
            this.Advaced.Padding = new System.Windows.Forms.Padding(3);
            this.Advaced.Size = new System.Drawing.Size(1501, 381);
            this.Advaced.TabIndex = 1;
            this.Advaced.Text = "Advanced";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmdUploadRom);
            this.groupBox7.Controls.Add(this.FindEepromFile);
            this.groupBox7.Controls.Add(this.txtEepromPath);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Location = new System.Drawing.Point(21, 269);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(760, 91);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Load ROM";
            // 
            // cmdUploadRom
            // 
            this.cmdUploadRom.Location = new System.Drawing.Point(510, 27);
            this.cmdUploadRom.Name = "cmdUploadRom";
            this.cmdUploadRom.Size = new System.Drawing.Size(161, 42);
            this.cmdUploadRom.TabIndex = 3;
            this.cmdUploadRom.Text = "Upload ROM";
            this.cmdUploadRom.UseVisualStyleBackColor = true;
            this.cmdUploadRom.Click += new System.EventHandler(this.CmdUploadRom_Click);
            // 
            // FindEepromFile
            // 
            this.FindEepromFile.Location = new System.Drawing.Point(388, 30);
            this.FindEepromFile.Name = "FindEepromFile";
            this.FindEepromFile.Size = new System.Drawing.Size(75, 44);
            this.FindEepromFile.TabIndex = 2;
            this.FindEepromFile.Text = "...";
            this.FindEepromFile.UseVisualStyleBackColor = true;
            this.FindEepromFile.Click += new System.EventHandler(this.FindEepromFile_Click);
            // 
            // txtEepromPath
            // 
            this.txtEepromPath.Location = new System.Drawing.Point(106, 38);
            this.txtEepromPath.Name = "txtEepromPath";
            this.txtEepromPath.Size = new System.Drawing.Size(261, 31);
            this.txtEepromPath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "File:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbDefault);
            this.groupBox6.Controls.Add(this.rbDebugInfo);
            this.groupBox6.Controls.Add(this.rbDetailedInfo);
            this.groupBox6.Controls.Add(this.rbGeneralInfo);
            this.groupBox6.Location = new System.Drawing.Point(393, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(389, 239);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Debug Messages";
            // 
            // rbDefault
            // 
            this.rbDefault.AutoSize = true;
            this.rbDefault.Location = new System.Drawing.Point(52, 46);
            this.rbDefault.Name = "rbDefault";
            this.rbDefault.Size = new System.Drawing.Size(182, 29);
            this.rbDefault.TabIndex = 3;
            this.rbDefault.TabStop = true;
            this.rbDefault.Text = "Default (None)";
            this.rbDefault.UseVisualStyleBackColor = true;
            // 
            // rbDebugInfo
            // 
            this.rbDebugInfo.AutoSize = true;
            this.rbDebugInfo.Location = new System.Drawing.Point(52, 198);
            this.rbDebugInfo.Name = "rbDebugInfo";
            this.rbDebugInfo.Size = new System.Drawing.Size(247, 29);
            this.rbDebugInfo.TabIndex = 2;
            this.rbDebugInfo.TabStop = true;
            this.rbDebugInfo.Text = "Extensive Debug Info";
            this.rbDebugInfo.UseVisualStyleBackColor = true;
            this.rbDebugInfo.CheckedChanged += new System.EventHandler(this.RbDebugInfo_CheckedChanged);
            // 
            // rbDetailedInfo
            // 
            this.rbDetailedInfo.AutoSize = true;
            this.rbDetailedInfo.Location = new System.Drawing.Point(52, 149);
            this.rbDetailedInfo.Name = "rbDetailedInfo";
            this.rbDetailedInfo.Size = new System.Drawing.Size(232, 29);
            this.rbDetailedInfo.TabIndex = 1;
            this.rbDetailedInfo.TabStop = true;
            this.rbDetailedInfo.Text = "Detailed Debug Info";
            this.rbDetailedInfo.UseVisualStyleBackColor = true;
            this.rbDetailedInfo.CheckedChanged += new System.EventHandler(this.RbDetailedInfo_CheckedChanged);
            // 
            // rbGeneralInfo
            // 
            this.rbGeneralInfo.AutoSize = true;
            this.rbGeneralInfo.Location = new System.Drawing.Point(52, 97);
            this.rbGeneralInfo.Name = "rbGeneralInfo";
            this.rbGeneralInfo.Size = new System.Drawing.Size(229, 29);
            this.rbGeneralInfo.TabIndex = 0;
            this.rbGeneralInfo.TabStop = true;
            this.rbGeneralInfo.Text = "General Debug Info";
            this.rbGeneralInfo.UseVisualStyleBackColor = true;
            this.rbGeneralInfo.CheckedChanged += new System.EventHandler(this.RbGeneralInfo_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 237);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Common Commands";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 145);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESGp0!       Get Parameter 0\r\n###              Disable Debug Mode\r\n%%%         En" +
    "ter Debug Mode\r\nESX!           Toggle Serial/TCP\r\nESY!           Tggle TCP/UDP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSerial);
            this.groupBox2.Controls.Add(this.rbUdp);
            this.groupBox2.Controls.Add(this.rbTcp);
            this.groupBox2.Location = new System.Drawing.Point(833, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 113);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication Method";
            // 
            // rbSerial
            // 
            this.rbSerial.AutoSize = true;
            this.rbSerial.Location = new System.Drawing.Point(323, 77);
            this.rbSerial.Name = "rbSerial";
            this.rbSerial.Size = new System.Drawing.Size(98, 29);
            this.rbSerial.TabIndex = 3;
            this.rbSerial.TabStop = true;
            this.rbSerial.Text = "Serial";
            this.rbSerial.UseVisualStyleBackColor = true;
            // 
            // rbUdp
            // 
            this.rbUdp.AutoSize = true;
            this.rbUdp.Location = new System.Drawing.Point(323, 30);
            this.rbUdp.Name = "rbUdp";
            this.rbUdp.Size = new System.Drawing.Size(87, 29);
            this.rbUdp.TabIndex = 2;
            this.rbUdp.TabStop = true;
            this.rbUdp.Text = "UDP";
            this.rbUdp.UseVisualStyleBackColor = true;
            // 
            // rbTcp
            // 
            this.rbTcp.AutoSize = true;
            this.rbTcp.Location = new System.Drawing.Point(94, 66);
            this.rbTcp.Name = "rbTcp";
            this.rbTcp.Size = new System.Drawing.Size(85, 29);
            this.rbTcp.TabIndex = 1;
            this.rbTcp.TabStop = true;
            this.rbTcp.Text = "TCP";
            this.rbTcp.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdAdvancedEsgp0);
            this.groupBox4.Controls.Add(this.cmdAdvancedESY);
            this.groupBox4.Controls.Add(this.cmdAdvancedEsx);
            this.groupBox4.Controls.Add(this.cmdSendCustomCommand);
            this.groupBox4.Controls.Add(this.txtCommandToSend);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(821, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(673, 215);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Custom Command";
            // 
            // cmdAdvancedEsgp0
            // 
            this.cmdAdvancedEsgp0.Location = new System.Drawing.Point(492, 95);
            this.cmdAdvancedEsgp0.Name = "cmdAdvancedEsgp0";
            this.cmdAdvancedEsgp0.Size = new System.Drawing.Size(175, 104);
            this.cmdAdvancedEsgp0.TabIndex = 5;
            this.cmdAdvancedEsgp0.Text = "Get Parameter (ESGp0!)";
            this.toolTip1.SetToolTip(this.cmdAdvancedEsgp0, "Gets Parameter 0.");
            this.cmdAdvancedEsgp0.UseVisualStyleBackColor = true;
            this.cmdAdvancedEsgp0.Click += new System.EventHandler(this.CmdAdvancedEsgp0_Click);
            // 
            // cmdAdvancedESY
            // 
            this.cmdAdvancedESY.Location = new System.Drawing.Point(265, 95);
            this.cmdAdvancedESY.Name = "cmdAdvancedESY";
            this.cmdAdvancedESY.Size = new System.Drawing.Size(209, 104);
            this.cmdAdvancedESY.TabIndex = 4;
            this.cmdAdvancedESY.Text = "Wireless ASCOM / ExploreStars(ESY!)";
            this.toolTip1.SetToolTip(this.cmdAdvancedESY, "Toggles TCP/UDP.");
            this.cmdAdvancedESY.UseVisualStyleBackColor = true;
            this.cmdAdvancedESY.Click += new System.EventHandler(this.CmdAdvancedESY_Click);
            // 
            // cmdAdvancedEsx
            // 
            this.cmdAdvancedEsx.Location = new System.Drawing.Point(25, 95);
            this.cmdAdvancedEsx.Name = "cmdAdvancedEsx";
            this.cmdAdvancedEsx.Size = new System.Drawing.Size(213, 104);
            this.cmdAdvancedEsx.TabIndex = 3;
            this.cmdAdvancedEsx.Text = "Wired/Wireless (ESX!)";
            this.toolTip1.SetToolTip(this.cmdAdvancedEsx, "Toggles wired/wireless.");
            this.cmdAdvancedEsx.UseVisualStyleBackColor = true;
            this.cmdAdvancedEsx.Click += new System.EventHandler(this.CmdAdvancedEsx_Click);
            // 
            // cmdSendCustomCommand
            // 
            this.cmdSendCustomCommand.Location = new System.Drawing.Point(542, 35);
            this.cmdSendCustomCommand.Name = "cmdSendCustomCommand";
            this.cmdSendCustomCommand.Size = new System.Drawing.Size(107, 42);
            this.cmdSendCustomCommand.TabIndex = 2;
            this.cmdSendCustomCommand.Text = "Send";
            this.cmdSendCustomCommand.UseVisualStyleBackColor = true;
            this.cmdSendCustomCommand.Click += new System.EventHandler(this.CmdSendCustomCommand_Click);
            // 
            // txtCommandToSend
            // 
            this.txtCommandToSend.Location = new System.Drawing.Point(233, 44);
            this.txtCommandToSend.Name = "txtCommandToSend";
            this.txtCommandToSend.Size = new System.Drawing.Size(286, 31);
            this.txtCommandToSend.TabIndex = 1;
            this.txtCommandToSend.Text = "ESGp0!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Command To Send";
            // 
            // Instructions
            // 
            this.Instructions.Controls.Add(this.rtbInstructions);
            this.Instructions.Location = new System.Drawing.Point(8, 39);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(1501, 381);
            this.Instructions.TabIndex = 2;
            this.Instructions.Text = "Instructions";
            this.Instructions.UseVisualStyleBackColor = true;
            // 
            // rtbInstructions
            // 
            this.rtbInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInstructions.Location = new System.Drawing.Point(0, 0);
            this.rtbInstructions.Name = "rtbInstructions";
            this.rtbInstructions.Size = new System.Drawing.Size(1501, 381);
            this.rtbInstructions.TabIndex = 0;
            this.rtbInstructions.Text = resources.GetString("rtbInstructions.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1517, 143);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1280, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(199, 136);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1000, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(9, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsCurrentConnection,
            this.toolStripStatusLabel2,
            this.tsCurrentNetwork,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 290);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1517, 45);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(396, 40);
            this.toolStripStatusLabel1.Text = "Current Mount Connection Method";
            // 
            // tsCurrentConnection
            // 
            this.tsCurrentConnection.BackColor = System.Drawing.Color.Red;
            this.tsCurrentConnection.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCurrentConnection.Name = "tsCurrentConnection";
            this.tsCurrentConnection.Size = new System.Drawing.Size(137, 40);
            this.tsCurrentConnection.Text = "Unknown";
            this.tsCurrentConnection.ToolTipText = "Your current connection method.  You may need to refresh this after changing.";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(245, 40);
            this.toolStripStatusLabel2.Text = "Current WiFi Network";
            // 
            // tsCurrentNetwork
            // 
            this.tsCurrentNetwork.BackColor = System.Drawing.Color.Red;
            this.tsCurrentNetwork.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCurrentNetwork.Name = "tsCurrentNetwork";
            this.tsCurrentNetwork.Size = new System.Drawing.Size(211, 40);
            this.tsCurrentNetwork.Text = "Not Connected";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(154, 40);
            this.toolStripStatusLabel3.Text = "Version: 0.0.1";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(1517, 335);
            this.txtOutput.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::IxosTest2.Properties.Resources._13085_up_down_arrow;
            this.pictureBox4.Location = new System.Drawing.Point(584, 234);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::IxosTest2.Properties.Resources._13085_up_down_arrow;
            this.pictureBox5.Location = new System.Drawing.Point(584, 124);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(73, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 1026);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Explore Scientific Connection Manager";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Basic.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Advaced.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Instructions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Basic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdBasic2CheckCurrentConnection;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button cmdBasic2ViaUdp;
        private System.Windows.Forms.Button cmdBasic2ViaTCP;
        private System.Windows.Forms.Button cmdBasic2ViaAscom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbBasic2SerialPort;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBasic2IpPort;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbBasic2MountType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBasic2IpAddress;
        private System.Windows.Forms.TabPage Advaced;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSerial;
        private System.Windows.Forms.RadioButton rbUdp;
        private System.Windows.Forms.RadioButton rbTcp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cmdAdvancedEsgp0;
        private System.Windows.Forms.Button cmdAdvancedESY;
        private System.Windows.Forms.Button cmdAdvancedEsx;
        private System.Windows.Forms.Button cmdSendCustomCommand;
        private System.Windows.Forms.TextBox txtCommandToSend;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdCopyToClipboard;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbGeneralInfo;
        private System.Windows.Forms.RadioButton rbDetailedInfo;
        private System.Windows.Forms.RadioButton rbDebugInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsCurrentConnection;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsCurrentNetwork;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbDefault;
        private System.Windows.Forms.TabPage Instructions;
        private System.Windows.Forms.RichTextBox rtbInstructions;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button cmdUploadRom;
        private System.Windows.Forms.Button FindEepromFile;
        private System.Windows.Forms.TextBox txtEepromPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdFindComPort;
        private System.Windows.Forms.Button cmdRefreshComPorts;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}


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
            this.Instructions = new System.Windows.Forms.TabPage();
            this.rtbInstructions = new System.Windows.Forms.RichTextBox();
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
            this.label4 = new System.Windows.Forms.Label();
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
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Instructions.SuspendLayout();
            this.Basic.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Advaced.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.splitContainer1.Size = new System.Drawing.Size(707, 621);
            this.splitContainer1.SplitterDistance = 421;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdCopyToClipboard);
            this.panel2.Controls.Add(this.cmdClear);
            this.panel2.Controls.Add(this.cmdClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 385);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 36);
            this.panel2.TabIndex = 2;
            // 
            // cmdCopyToClipboard
            // 
            this.cmdCopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCopyToClipboard.Location = new System.Drawing.Point(79, 6);
            this.cmdCopyToClipboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdCopyToClipboard.Name = "cmdCopyToClipboard";
            this.cmdCopyToClipboard.Size = new System.Drawing.Size(110, 23);
            this.cmdCopyToClipboard.TabIndex = 3;
            this.cmdCopyToClipboard.Text = "Copy To Clipboard";
            this.cmdCopyToClipboard.UseVisualStyleBackColor = true;
            this.cmdCopyToClipboard.Click += new System.EventHandler(this.CmdCopyToClipboard_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdClear.Location = new System.Drawing.Point(14, 7);
            this.cmdClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(56, 22);
            this.cmdClear.TabIndex = 1;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdClose.Location = new System.Drawing.Point(295, 8);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(58, 22);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.Instructions);
            this.tabControl1.Controls.Add(this.Basic);
            this.tabControl1.Controls.Add(this.Advaced);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 157);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 264);
            this.tabControl1.TabIndex = 1;
            // 
            // Instructions
            // 
            this.Instructions.Controls.Add(this.rtbInstructions);
            this.Instructions.Location = new System.Drawing.Point(4, 25);
            this.Instructions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(706, 228);
            this.Instructions.TabIndex = 2;
            this.Instructions.Text = "Instructions";
            this.Instructions.UseVisualStyleBackColor = true;
            // 
            // rtbInstructions
            // 
            this.rtbInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInstructions.Location = new System.Drawing.Point(0, 0);
            this.rtbInstructions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbInstructions.Name = "rtbInstructions";
            this.rtbInstructions.Size = new System.Drawing.Size(706, 228);
            this.rtbInstructions.TabIndex = 0;
            this.rtbInstructions.Text = resources.GetString("rtbInstructions.Text");
            // 
            // Basic
            // 
            this.Basic.BackColor = System.Drawing.Color.Gainsboro;
            this.Basic.Controls.Add(this.groupBox5);
            this.Basic.Controls.Add(this.groupBox1);
            this.Basic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Basic.Location = new System.Drawing.Point(4, 25);
            this.Basic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Basic.Name = "Basic";
            this.Basic.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Basic.Size = new System.Drawing.Size(699, 235);
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
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(7, 12);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(216, 153);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Connection Settings";
            // 
            // cmdRefreshComPorts
            // 
            this.cmdRefreshComPorts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRefreshComPorts.Location = new System.Drawing.Point(142, 116);
            this.cmdRefreshComPorts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdRefreshComPorts.Name = "cmdRefreshComPorts";
            this.cmdRefreshComPorts.Size = new System.Drawing.Size(70, 25);
            this.cmdRefreshComPorts.TabIndex = 19;
            this.cmdRefreshComPorts.Text = "Refresh";
            this.cmdRefreshComPorts.UseVisualStyleBackColor = true;
            this.cmdRefreshComPorts.Click += new System.EventHandler(this.CmdRefreshComPorts_Click);
            // 
            // cmdFindComPort
            // 
            this.cmdFindComPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdFindComPort.Location = new System.Drawing.Point(94, 116);
            this.cmdFindComPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdFindComPort.Name = "cmdFindComPort";
            this.cmdFindComPort.Size = new System.Drawing.Size(44, 25);
            this.cmdFindComPort.TabIndex = 18;
            this.cmdFindComPort.Text = "Find";
            this.cmdFindComPort.UseVisualStyleBackColor = true;
            this.cmdFindComPort.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "IP Port";
            // 
            // txtBasic2IpAddress
            // 
            this.txtBasic2IpAddress.Enabled = false;
            this.txtBasic2IpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasic2IpAddress.Location = new System.Drawing.Point(97, 43);
            this.txtBasic2IpAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBasic2IpAddress.Name = "txtBasic2IpAddress";
            this.txtBasic2IpAddress.Size = new System.Drawing.Size(115, 20);
            this.txtBasic2IpAddress.TabIndex = 8;
            this.txtBasic2IpAddress.Text = "192.168.47.1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 46);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "IP Address";
            // 
            // cmbBasic2SerialPort
            // 
            this.cmbBasic2SerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBasic2SerialPort.FormattingEnabled = true;
            this.cmbBasic2SerialPort.Location = new System.Drawing.Point(97, 91);
            this.cmbBasic2SerialPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBasic2SerialPort.Name = "cmbBasic2SerialPort";
            this.cmbBasic2SerialPort.Size = new System.Drawing.Size(115, 21);
            this.cmbBasic2SerialPort.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cmbBasic2SerialPort, "Please set this before trying to change connection method.");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Mount Type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(-88, 99);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Serial Port";
            // 
            // cmbBasic2MountType
            // 
            this.cmbBasic2MountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBasic2MountType.FormattingEnabled = true;
            this.cmbBasic2MountType.Items.AddRange(new object[] {
            "iExos100",
            "G11",
            "Exos-2"});
            this.cmbBasic2MountType.Location = new System.Drawing.Point(97, 19);
            this.cmbBasic2MountType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBasic2MountType.Name = "cmbBasic2MountType";
            this.cmbBasic2MountType.Size = new System.Drawing.Size(115, 21);
            this.cmbBasic2MountType.TabIndex = 11;
            this.toolTip1.SetToolTip(this.cmbBasic2MountType, "Please set this before trying to change connection method.\r\n");
            // 
            // txtBasic2IpPort
            // 
            this.txtBasic2IpPort.Enabled = false;
            this.txtBasic2IpPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasic2IpPort.Location = new System.Drawing.Point(97, 66);
            this.txtBasic2IpPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBasic2IpPort.Name = "txtBasic2IpPort";
            this.txtBasic2IpPort.Size = new System.Drawing.Size(115, 20);
            this.txtBasic2IpPort.TabIndex = 13;
            this.txtBasic2IpPort.Text = "54372";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 94);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Com Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmdBasic2CheckCurrentConnection);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.cmdBasic2ViaUdp);
            this.groupBox1.Controls.Add(this.cmdBasic2ViaTCP);
            this.groupBox1.Controls.Add(this.cmdBasic2ViaAscom);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(227, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(294, 187);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "How Do You Want To Connect";
            // 
            // cmdBasic2CheckCurrentConnection
            // 
            this.cmdBasic2CheckCurrentConnection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBasic2CheckCurrentConnection.Location = new System.Drawing.Point(198, 16);
            this.cmdBasic2CheckCurrentConnection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdBasic2CheckCurrentConnection.Name = "cmdBasic2CheckCurrentConnection";
            this.cmdBasic2CheckCurrentConnection.Size = new System.Drawing.Size(84, 26);
            this.cmdBasic2CheckCurrentConnection.TabIndex = 15;
            this.cmdBasic2CheckCurrentConnection.Text = "Do It";
            this.toolTip1.SetToolTip(this.cmdBasic2CheckCurrentConnection, "Try to find the current connection method.");
            this.cmdBasic2CheckCurrentConnection.UseVisualStyleBackColor = true;
            this.cmdBasic2CheckCurrentConnection.Click += new System.EventHandler(this.CmdBasic2CheckCurrentConnection_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(26, 21);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(149, 16);
            this.label19.TabIndex = 14;
            this.label19.Text = "Find Current Connection";
            // 
            // cmdBasic2ViaUdp
            // 
            this.cmdBasic2ViaUdp.Enabled = false;
            this.cmdBasic2ViaUdp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBasic2ViaUdp.Location = new System.Drawing.Point(198, 106);
            this.cmdBasic2ViaUdp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdBasic2ViaUdp.Name = "cmdBasic2ViaUdp";
            this.cmdBasic2ViaUdp.Size = new System.Drawing.Size(84, 26);
            this.cmdBasic2ViaUdp.TabIndex = 13;
            this.cmdBasic2ViaUdp.Text = "Do It";
            this.cmdBasic2ViaUdp.UseVisualStyleBackColor = true;
            this.cmdBasic2ViaUdp.Click += new System.EventHandler(this.CmdBasic2ViaUdp_Click);
            // 
            // cmdBasic2ViaTCP
            // 
            this.cmdBasic2ViaTCP.Enabled = false;
            this.cmdBasic2ViaTCP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBasic2ViaTCP.Location = new System.Drawing.Point(198, 76);
            this.cmdBasic2ViaTCP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdBasic2ViaTCP.Name = "cmdBasic2ViaTCP";
            this.cmdBasic2ViaTCP.Size = new System.Drawing.Size(84, 26);
            this.cmdBasic2ViaTCP.TabIndex = 12;
            this.cmdBasic2ViaTCP.Text = "Do It";
            this.cmdBasic2ViaTCP.UseVisualStyleBackColor = true;
            this.cmdBasic2ViaTCP.Click += new System.EventHandler(this.CmdBasic2ViaTCP_Click);
            // 
            // cmdBasic2ViaAscom
            // 
            this.cmdBasic2ViaAscom.Enabled = false;
            this.cmdBasic2ViaAscom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBasic2ViaAscom.Location = new System.Drawing.Point(198, 46);
            this.cmdBasic2ViaAscom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdBasic2ViaAscom.Name = "cmdBasic2ViaAscom";
            this.cmdBasic2ViaAscom.Size = new System.Drawing.Size(84, 26);
            this.cmdBasic2ViaAscom.TabIndex = 11;
            this.cmdBasic2ViaAscom.Text = "Do It";
            this.cmdBasic2ViaAscom.UseVisualStyleBackColor = true;
            this.cmdBasic2ViaAscom.Click += new System.EventHandler(this.CmdBasic2ViaAscom_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(57, 113);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Via ExploreStars (UDP)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(39, 83);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Via Wireless ASCOM (TCP)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(77, 53);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Via ASCOM (Serial)";
            // 
            // Advaced
            // 
            this.Advaced.BackColor = System.Drawing.Color.Gainsboro;
            this.Advaced.Controls.Add(this.cmdUploadRom);
            this.Advaced.Controls.Add(this.label4);
            this.Advaced.Controls.Add(this.groupBox7);
            this.Advaced.Controls.Add(this.groupBox6);
            this.Advaced.Controls.Add(this.groupBox3);
            this.Advaced.Controls.Add(this.groupBox2);
            this.Advaced.Controls.Add(this.groupBox4);
            this.Advaced.Location = new System.Drawing.Point(4, 25);
            this.Advaced.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Advaced.Name = "Advaced";
            this.Advaced.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Advaced.Size = new System.Drawing.Size(699, 235);
            this.Advaced.TabIndex = 1;
            this.Advaced.Text = "Advanced";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "You may need to \"Find\" your mount after sending commands.";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.FindEepromFile);
            this.groupBox7.Controls.Add(this.txtEepromPath);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(10, 120);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox7.Size = new System.Drawing.Size(280, 47);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Load FIRMWARE into PMC-Eight EEPROM";
            // 
            // cmdUploadRom
            // 
            this.cmdUploadRom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdUploadRom.Location = new System.Drawing.Point(44, 173);
            this.cmdUploadRom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdUploadRom.Name = "cmdUploadRom";
            this.cmdUploadRom.Size = new System.Drawing.Size(132, 22);
            this.cmdUploadRom.TabIndex = 3;
            this.cmdUploadRom.Text = "Upload EEPROM";
            this.cmdUploadRom.UseVisualStyleBackColor = true;
            this.cmdUploadRom.Click += new System.EventHandler(this.CmdUploadRom_Click);
            // 
            // FindEepromFile
            // 
            this.FindEepromFile.Location = new System.Drawing.Point(170, 23);
            this.FindEepromFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FindEepromFile.Name = "FindEepromFile";
            this.FindEepromFile.Size = new System.Drawing.Size(38, 23);
            this.FindEepromFile.TabIndex = 2;
            this.FindEepromFile.Text = "...";
            this.FindEepromFile.UseVisualStyleBackColor = true;
            this.FindEepromFile.Click += new System.EventHandler(this.FindEepromFile_Click);
            // 
            // txtEepromPath
            // 
            this.txtEepromPath.Location = new System.Drawing.Point(34, 23);
            this.txtEepromPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEepromPath.Name = "txtEepromPath";
            this.txtEepromPath.Size = new System.Drawing.Size(132, 20);
            this.txtEepromPath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "File:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbDefault);
            this.groupBox6.Controls.Add(this.rbDebugInfo);
            this.groupBox6.Controls.Add(this.rbDetailedInfo);
            this.groupBox6.Controls.Add(this.rbGeneralInfo);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(199, 3);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox6.Size = new System.Drawing.Size(153, 104);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Debug Messages";
            // 
            // rbDefault
            // 
            this.rbDefault.AutoSize = true;
            this.rbDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDefault.Location = new System.Drawing.Point(26, 19);
            this.rbDefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbDefault.Name = "rbDefault";
            this.rbDefault.Size = new System.Drawing.Size(94, 17);
            this.rbDefault.TabIndex = 3;
            this.rbDefault.TabStop = true;
            this.rbDefault.Text = "Default (None)";
            this.rbDefault.UseVisualStyleBackColor = true;
            // 
            // rbDebugInfo
            // 
            this.rbDebugInfo.AutoSize = true;
            this.rbDebugInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDebugInfo.Location = new System.Drawing.Point(26, 81);
            this.rbDebugInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbDebugInfo.Name = "rbDebugInfo";
            this.rbDebugInfo.Size = new System.Drawing.Size(127, 17);
            this.rbDebugInfo.TabIndex = 2;
            this.rbDebugInfo.TabStop = true;
            this.rbDebugInfo.Text = "Extensive Debug Info";
            this.rbDebugInfo.UseVisualStyleBackColor = true;
            this.rbDebugInfo.CheckedChanged += new System.EventHandler(this.RbDebugInfo_CheckedChanged);
            // 
            // rbDetailedInfo
            // 
            this.rbDetailedInfo.AutoSize = true;
            this.rbDetailedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDetailedInfo.Location = new System.Drawing.Point(26, 61);
            this.rbDetailedInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbDetailedInfo.Name = "rbDetailedInfo";
            this.rbDetailedInfo.Size = new System.Drawing.Size(120, 17);
            this.rbDetailedInfo.TabIndex = 1;
            this.rbDetailedInfo.TabStop = true;
            this.rbDetailedInfo.Text = "Detailed Debug Info";
            this.rbDetailedInfo.UseVisualStyleBackColor = true;
            this.rbDetailedInfo.CheckedChanged += new System.EventHandler(this.RbDetailedInfo_CheckedChanged);
            // 
            // rbGeneralInfo
            // 
            this.rbGeneralInfo.AutoSize = true;
            this.rbGeneralInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGeneralInfo.Location = new System.Drawing.Point(26, 40);
            this.rbGeneralInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbGeneralInfo.Name = "rbGeneralInfo";
            this.rbGeneralInfo.Size = new System.Drawing.Size(118, 17);
            this.rbGeneralInfo.TabIndex = 0;
            this.rbGeneralInfo.TabStop = true;
            this.rbGeneralInfo.Text = "General Debug Info";
            this.rbGeneralInfo.UseVisualStyleBackColor = true;
            this.rbGeneralInfo.CheckedChanged += new System.EventHandler(this.RbGeneralInfo_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(192, 103);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Common Commands";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESGp0!       Get Parameter 0\r\n###              Disable Debug Mode\r\n%%%         En" +
    "ter Debug Mode\r\nESX!           Toggle Serial/TCP\r\nESY!           Tggle TCP/UDP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSerial);
            this.groupBox2.Controls.Add(this.rbUdp);
            this.groupBox2.Controls.Add(this.rbTcp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(369, 121);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(223, 42);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication Method";
            // 
            // rbSerial
            // 
            this.rbSerial.AutoSize = true;
            this.rbSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSerial.Location = new System.Drawing.Point(10, 17);
            this.rbSerial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSerial.Name = "rbSerial";
            this.rbSerial.Size = new System.Drawing.Size(51, 17);
            this.rbSerial.TabIndex = 3;
            this.rbSerial.TabStop = true;
            this.rbSerial.Text = "Serial";
            this.rbSerial.UseVisualStyleBackColor = true;
            // 
            // rbUdp
            // 
            this.rbUdp.AutoSize = true;
            this.rbUdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUdp.Location = new System.Drawing.Point(159, 17);
            this.rbUdp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbUdp.Name = "rbUdp";
            this.rbUdp.Size = new System.Drawing.Size(48, 17);
            this.rbUdp.TabIndex = 2;
            this.rbUdp.TabStop = true;
            this.rbUdp.Text = "UDP";
            this.rbUdp.UseVisualStyleBackColor = true;
            // 
            // rbTcp
            // 
            this.rbTcp.AutoSize = true;
            this.rbTcp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTcp.Location = new System.Drawing.Point(90, 17);
            this.rbTcp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTcp.Name = "rbTcp";
            this.rbTcp.Size = new System.Drawing.Size(46, 17);
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
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(356, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(336, 112);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Custom Command";
            // 
            // cmdAdvancedEsgp0
            // 
            this.cmdAdvancedEsgp0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAdvancedEsgp0.Location = new System.Drawing.Point(246, 49);
            this.cmdAdvancedEsgp0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdAdvancedEsgp0.Name = "cmdAdvancedEsgp0";
            this.cmdAdvancedEsgp0.Size = new System.Drawing.Size(88, 54);
            this.cmdAdvancedEsgp0.TabIndex = 5;
            this.cmdAdvancedEsgp0.Text = "Get Parameter (ESGp0!)";
            this.toolTip1.SetToolTip(this.cmdAdvancedEsgp0, "Gets Parameter 0.");
            this.cmdAdvancedEsgp0.UseVisualStyleBackColor = true;
            this.cmdAdvancedEsgp0.Click += new System.EventHandler(this.CmdAdvancedEsgp0_Click);
            // 
            // cmdAdvancedESY
            // 
            this.cmdAdvancedESY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAdvancedESY.Location = new System.Drawing.Point(132, 49);
            this.cmdAdvancedESY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdAdvancedESY.Name = "cmdAdvancedESY";
            this.cmdAdvancedESY.Size = new System.Drawing.Size(104, 54);
            this.cmdAdvancedESY.TabIndex = 4;
            this.cmdAdvancedESY.Text = "Wireless ASCOM / ExploreStars(ESY!)";
            this.toolTip1.SetToolTip(this.cmdAdvancedESY, "Toggles TCP/UDP.");
            this.cmdAdvancedESY.UseVisualStyleBackColor = true;
            this.cmdAdvancedESY.Click += new System.EventHandler(this.CmdAdvancedESY_Click);
            // 
            // cmdAdvancedEsx
            // 
            this.cmdAdvancedEsx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAdvancedEsx.Location = new System.Drawing.Point(12, 49);
            this.cmdAdvancedEsx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdAdvancedEsx.Name = "cmdAdvancedEsx";
            this.cmdAdvancedEsx.Size = new System.Drawing.Size(106, 54);
            this.cmdAdvancedEsx.TabIndex = 3;
            this.cmdAdvancedEsx.Text = "Wired/Wireless (ESX!)";
            this.toolTip1.SetToolTip(this.cmdAdvancedEsx, "Toggles wired/wireless.");
            this.cmdAdvancedEsx.UseVisualStyleBackColor = true;
            this.cmdAdvancedEsx.Click += new System.EventHandler(this.CmdAdvancedEsx_Click);
            // 
            // cmdSendCustomCommand
            // 
            this.cmdSendCustomCommand.Location = new System.Drawing.Point(282, 18);
            this.cmdSendCustomCommand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdSendCustomCommand.Name = "cmdSendCustomCommand";
            this.cmdSendCustomCommand.Size = new System.Drawing.Size(54, 22);
            this.cmdSendCustomCommand.TabIndex = 2;
            this.cmdSendCustomCommand.Text = "Send";
            this.cmdSendCustomCommand.UseVisualStyleBackColor = true;
            this.cmdSendCustomCommand.Click += new System.EventHandler(this.CmdSendCustomCommand_Click);
            // 
            // txtCommandToSend
            // 
            this.txtCommandToSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandToSend.Location = new System.Drawing.Point(132, 13);
            this.txtCommandToSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCommandToSend.Name = "txtCommandToSend";
            this.txtCommandToSend.Size = new System.Drawing.Size(148, 24);
            this.txtCommandToSend.TabIndex = 1;
            this.txtCommandToSend.Text = "ESGp0!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Command To Send";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 157);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(409, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 173);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(707, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(203, 20);
            this.toolStripStatusLabel1.Text = "Current Mount Connection Method";
            // 
            // tsCurrentConnection
            // 
            this.tsCurrentConnection.BackColor = System.Drawing.Color.Red;
            this.tsCurrentConnection.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCurrentConnection.ForeColor = System.Drawing.Color.White;
            this.tsCurrentConnection.Name = "tsCurrentConnection";
            this.tsCurrentConnection.Size = new System.Drawing.Size(76, 20);
            this.tsCurrentConnection.Text = "Unknown";
            this.tsCurrentConnection.ToolTipText = "Your current connection method.  You may need to refresh this after changing.";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(130, 20);
            this.toolStripStatusLabel2.Text = "Current WiFi Network";
            // 
            // tsCurrentNetwork
            // 
            this.tsCurrentNetwork.BackColor = System.Drawing.Color.Red;
            this.tsCurrentNetwork.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCurrentNetwork.ForeColor = System.Drawing.Color.White;
            this.tsCurrentNetwork.Name = "tsCurrentNetwork";
            this.tsCurrentNetwork.Size = new System.Drawing.Size(114, 20);
            this.tsCurrentNetwork.Text = "Not Connected";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(75, 20);
            this.toolStripStatusLabel3.Text = "Version: 0.0.3";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(707, 198);
            this.txtOutput.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(171, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 46);
            this.label6.TabIndex = 12;
            this.label6.Text = "Explore Scientific, LLC.\r\n1010 S. 48th Street, Springdale, AR 72762\r\nCustomer Sup" +
    "port +1 (866) 252-3811 ext 2";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Gold;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(170, 85);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(246, 20);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.explorescientificusa.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 41);
            this.label5.TabIndex = 16;
            this.label5.Text = "NOTE: To switch from UDP to Serial OR Serial to UDP, you must first switch to TCP" +
    " then back to UDP OR Serial.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 621);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Explore Scientific PMC-Eight Configuration Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Instructions.ResumeLayout(false);
            this.Basic.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Advaced.ResumeLayout(false);
            this.Advaced.PerformLayout();
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
    }
}


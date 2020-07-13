using ASCOM.Utilities;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.IO.Compression;
using System.Threading;
namespace IxosTest2
{
    public partial class Form1 : Form
    {
        #region Propellent Imports
        [DllImport("C:\\Propellent.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SaveImage(bool AsBinary, string FileName, bool ShowSaveAs);

        // Add this variable 
        string RxString;

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, IntPtr windowTitle);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern int FindWindow(string strClassName, string strWindowName);

        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        [DllImport("Propellent.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitPropellent(IntPtr winHandle, bool storePrefs, string regPath);

        public IntPtr Handle { get; set; }

        public IntPtr HandleFake = (IntPtr)20;

        [DllImport("Propellent.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetPropellerVersion();

        [DllImport("Propellent.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ShowEditPorts();

        [DllImport("Propellent.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetPorts();

        [DllImport("Propellent.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetSerialSearchRules();

        [DllImport("Propellent.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetGUIMode(int mode);

        [DllImport("Propellent.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetResetSignal();

        [DllImport("Propellent.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetResetSignal();

        [DllImport("Propellent.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void FinalizePropellent();

        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_CLOSE = 0xF060;
        #endregion

        private readonly object _lockObject = new object();
        EsMessagePriority _priorityToShow = EsMessagePriority.GeneralInfo;
        public EsMountManager MountManager { get; set; }
        public ComManager ComManager { get; set; }
        public bool SsidIsChanging { get; private set; }
        public System.Timers.Timer SsidTimer { get; set; }
        const int SSID_CHANGING_TIMEOUT = 10000;
        //public bool SsIdIsChanging { get; set; }

        public Form1()
        {
            InitializeComponent();
            MountManager = new EsMountManager();
            ComManager = new ComManager();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmbBasic2SerialPort.Items.Add(s);
            }
            if (cmbBasic2SerialPort.Items.Count > 0)
            {
                cmbBasic2SerialPort.SelectedIndex = 0;
            }
            cmbBasic2MountType.SelectedIndex = 1;
            ComManager.SsidTimerHit += ComManager_SsidTimerHit;
            EsEventManager.EsEventRaised += EsEventManager_EsEventRaised;
            //rbDefault.Checked = true;
            SsidTimer = new System.Timers.Timer(SSID_CHANGING_TIMEOUT);
            SsidTimer.Elapsed += SsidTimer_Elapsed;
            rtbInstructions.LoadFile("COnnection Utility Instructions.rtf");
            cmbDrive.Enabled = false;
        }



        #region GUI Events
        private void SsidTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            SsidTimer.Stop();
            SsidIsChanging = false;
        }
        public void TurnOnSsIdTimer()
        {
            SsidTimer.Start();
            SsidIsChanging = true;
        }

        private void UpdateChangeMethodsButtonsAccess(EsMount mount)
        {
            if (mount == null)
            {
                return;
            }
            if (mount.MountModel == MountModelEnum.iXos100)
            {
                if (mount.ConnectionSettings.IsConnected == ConnectionEnum.Serial)
                {
                    cmdBasic2ViaAscom.Enabled = false;
                    cmdBasic2ViaTCP.Enabled = true;
                    cmdBasic2ViaUdp.Enabled = false;
                }
                if (mount.ConnectionSettings.IsConnected == ConnectionEnum.TCP)
                {
                    cmdBasic2ViaAscom.Enabled = true;
                    cmdBasic2ViaTCP.Enabled = false;
                    cmdBasic2ViaUdp.Enabled = true;
                }
                if (mount.ConnectionSettings.IsConnected == ConnectionEnum.UDP)
                {
                    cmdBasic2ViaAscom.Enabled = false;
                    cmdBasic2ViaTCP.Enabled = true;
                    cmdBasic2ViaUdp.Enabled = false;
                }
            }
            else
            {
                cmdBasic2ViaAscom.Enabled = true;
                cmdBasic2ViaTCP.Enabled = true;
                cmdBasic2ViaUdp.Enabled = true;
            }
        }
        private void RbGeneralInfo_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbGeneralInfo.Checked)
            //{
            //    _priorityToShow = EsMessagePriority.GeneralInfo;
            //}
        }

        private void RbDetailedInfo_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbDetailedInfo.Checked)
            //{
            //    _priorityToShow = EsMessagePriority.DetailedInfo;
            //}
        }
        private void RbDebugInfo_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbDebugInfo.Checked)
            //{
            //    _priorityToShow = EsMessagePriority.DebugInfo;
            //}
        }

        private void CmdCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtOutput.Text))
            {
                System.Windows.Forms.Clipboard.SetText(txtOutput.Text);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string comPort = null;
            string firmWare;
            try
            {
                SetGUIMode(3);
                InitPropellent(this.Handle, false, Environment.CurrentDirectory);
                var y = GetPorts();

                var versionPtr = GetPropellerVersion();
                string version = Marshal.PtrToStringAnsi(versionPtr);
                int delimiter = version.IndexOf(':');
                if (delimiter > -1)
                {
                    comPort = version.Remove(delimiter - 1);
                    firmWare = version.Remove(0, delimiter + 2);
                    DumpLine("Com Port: " + comPort);
                }
                FinalizePropellent();
                Cursor.Current = Cursors.WaitCursor;
                Thread.Sleep(4000);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                DumpLine(ex.ToString());
                MessageBox.Show("Could not automatically find the com port for the PMC-8. Please make sure it is connected.", "Information");
            }
            if (string.IsNullOrEmpty(comPort))
            {
                MessageBox.Show("Could not automatically find the com port for the PMC-8. Please make sure it is connected.", "Information");

            }
            else
            {
                MessageBox.Show("The PMC-8 is connected on com port: " + comPort + ". NOTE - This does not mean your mount is connected via serial.", "Information");
                SetComPortDropdown(comPort);
            }
        }

        private void SetComPortDropdown(string comPort)
        {
            int index = cmbBasic2SerialPort.Items.IndexOf(comPort);
            if (index > -1)
            {
                cmbBasic2SerialPort.SelectedIndex = index;
            }

        }

        private void CmdRefreshComPorts_Click(object sender, EventArgs e)
        {
            cmbBasic2SerialPort.Items.Clear();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmbBasic2SerialPort.Items.Add(s);
            }
        }
        #endregion

        private void ComManager_SsidTimerHit(object sender, SsidEventArgs e)
        {
            if (SsidIsChanging == true)
            {
                tsCurrentNetwork.Text = "Changing";
                this.BeginInvoke((Action)(() => tsCurrentNetwork.BackColor = Color.Orange));
                return;
            }
            lock (_lockObject)
            {
                //Color oldColor = Color.DarkBlue;
                //this.BeginInvoke((Action)(() => oldColor = tsCurrentNetwork.BackColor));
                if (e.CurrentSsid != null)
                {
                    if (e.CurrentSsid.Contains("PMC"))
                    {
                        this.BeginInvoke((Action)(() => tsCurrentNetwork.BackColor = Color.Green));
                    }
                    else
                    {
                        this.BeginInvoke((Action)(() => tsCurrentNetwork.BackColor = Color.Red));
                    }
                    tsCurrentNetwork.Text = e.CurrentSsid;
                }
                else
                {
                    tsCurrentNetwork.Text = "NOT CONNECTED";
                    this.BeginInvoke((Action)(() => tsCurrentNetwork.BackColor = Color.Red));
                }

                //Console.WriteLine("Old color: " + oldColor + "   Current color: " + tsCurrentNetwork.BackColor);

                //if (oldColor == Color.Green && tsCurrentNetwork.BackColor == Color.Red)
                //{
                //    MessageBox.Show("Connection to PMC-8 network was lost.  Please reconnect.", "Important");
                //}

            }

        }

        #region Create Mount From GUI
        private EsMount GetMountFromGUI()
        {
            EsMount result = new EsMount();
            switch (cmbBasic2MountType.Text)
            {
                case "G11":
                    result.MountModel = MountModelEnum.g11;
                    break;
                case "iExos100":
                    result.MountModel = MountModelEnum.iXos100;
                    break;
                case "Xos2":
                    result.MountModel = MountModelEnum.Xos2;
                    break;
                default:
                    result.MountModel = MountModelEnum.NotSet;
                    break;
            }
            result.ConnectionSettings.IpAddr = txtBasic2IpAddress.Text;
            result.ConnectionSettings.IpPort = Convert.ToInt32(txtBasic2IpPort.Text);
            if (cmbBasic2SerialPort.Text != "")
            {
                result.ConnectionSettings.SerPort = cmbBasic2SerialPort.Text;
            }
            return result;
        }
        #endregion

        #region FInd Connection
        private void CmdBasic2CheckCurrentConnection_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                EsMount mount = GetMountFromGUI();
                mount = MountManager.ConnectMount(mount);
                if (mount == null)
                {
                    DumpLine("The mount does not appear to be connected. Please check your settings and network connection.");
                    tsCurrentConnection.Text = "NONE";
                    tsCurrentConnection.BackColor = Color.Red;
                    return;
                }

                DumpLine("Mount appears to be connected on " + mount?.ConnectionSettings.IsConnected.ToString());
                UpdateTabStripConnection(mount);
                Cursor.Current = Cursors.Default;
                UpdateChangeMethodsButtonsAccess(mount);
            }
            catch (Exception)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Could not determine the current mount connection method.");
            }
            Cursor.Current = Cursors.Default;
        }

        #endregion

        #region Dump  and Message Methods
        int lineCount = 0;

        private void EsEventManager_EsEventRaised(object sender, EsEventArgs e)
        {
            //if (rbDefault.Checked)
            //{
            //    //don't show any
            //    _priorityToShow = EsMessagePriority.None;
            //}
            if (_priorityToShow == EsMessagePriority.GeneralInfo)
            {
                _priorityToShow = EsMessagePriority.GeneralInfo;
                if (e.Priority == EsMessagePriority.GeneralInfo)
                {
                    DumpLine(e.Sender + ": " + e.Message);
                }
            }
            if (_priorityToShow == EsMessagePriority.DetailedInfo)
            {
                _priorityToShow = EsMessagePriority.DetailedInfo;
                if (e.Priority == EsMessagePriority.GeneralInfo || e.Priority == EsMessagePriority.DetailedInfo)
                {
                    DumpLine(e.Sender + ": " + e.Message);
                }
            }
            if (_priorityToShow == EsMessagePriority.DebugInfo)
            {
                _priorityToShow = EsMessagePriority.DebugInfo;
                DumpLine(e.Sender + ": " + e.Message);
            }
        }

        public void Dump(string msg)
        {
            //string l0 = txtOutput.Lines[0];
            //txtOutput.Lines[0] += msg;
            //txtOutput.Text = txtOutput.Text + " " + msg;
            int len = txtOutput.Lines[0].Length;
            string line = txtOutput.Lines[0].Substring(3);

            char c = ' ';

            line = line.Trim(c);
            DumpLine(line + "..." + msg);
        }

        public void DumpLine(string msg)
        {
            //txtOutput.Text += Environment.NewLine + lineCount.ToString() + " " + msg;
            txtOutput.Text = lineCount.ToString() + "       " + msg + Environment.NewLine + txtOutput.Text;
            lineCount++;
        }

        public void DumpLine(EsException ex)
        {
            string msg = null;
            //if (rbGeneralInfo.Checked)
            //{
            //    msg = ex?.Message;
            //}
            //if (rbDetailedInfo.Checked)
            //{
            //    msg = ex?.Message + " , " + ex?.Source;
            //}
            //if (rbDebugInfo.Checked)
            //{
            //    msg = ex?.Message + " , " + ex?.Source + " , " + ex?.StackTrace.ToString();
            //}

            DumpLine(msg);
        }

        public void UpdateTabStripConnection(EsMount mount)
        {
            if (mount == null)
            {
                tsCurrentConnection.Text = "UNKNOWN";
                tsCurrentConnection.BackColor = Color.Orange;
                return;
            }
            //Color oldColor = tsCurrentConnection.BackColor;
            switch (mount?.ConnectionSettings?.IsConnected)
            {
                case ConnectionEnum.NONE:
                    {

                        tsCurrentConnection.Text = "NONE";
                        tsCurrentConnection.BackColor = Color.Red;
                    }
                    break;
                case ConnectionEnum.Serial:
                    {
                        tsCurrentConnection.Text = "Serial";
                        tsCurrentConnection.BackColor = Color.Green;
                    }
                    break;
                case ConnectionEnum.TCP:
                    {
                        tsCurrentConnection.Text = "TCP";
                        tsCurrentConnection.BackColor = Color.Green;
                    }
                    break;
                case ConnectionEnum.UDP:
                    {
                        tsCurrentConnection.Text = "UDP";
                        tsCurrentConnection.BackColor = Color.Green;
                    }
                    break;
                default:
                    break;
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
        }

        #endregion

        #region Custom Commands
        private void CmdSendCustomCommand_Click(object sender, EventArgs e)
        {
            if (rbSerial.Checked == false && rbTcp.Checked == false && rbUdp.Checked == false)
            {
                MessageBox.Show("Please select a communication method first");
                return;
            }
            if (rbSerial.Checked && String.IsNullOrWhiteSpace(cmbBasic2SerialPort.Text))
            {
                MessageBox.Show("Please select a com port first", "ERROR");
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            SendCustomCommand(txtCommandToSend.Text);
            Cursor.Current = Cursors.Default;
        }

        private void SendCustomCommand(string cmd)
        {

            string ip = txtBasic2IpAddress.Text;
            Int32 ipPort = Convert.ToInt32(txtBasic2IpPort.Text);
            string comPort = cmbBasic2SerialPort.Text;
            try
            {
                //if (rbAutoDetect.Checked)
                //{
                //    DumpLine("Sending via Autodetect: " + cmd);

                //    //Mount.SendRawCommand(cmd);
                //}
                if (rbTcp.Checked || rbUdp.Checked)
                {
                    if (!ComManager.ConnectedToPmcNetwork)
                    {
                        DumpLine("Not connected to a PMC-8 network.  Can not send: " + cmd);
                        MessageBox.Show("Please connect to a PMC-8 network before using TCP or UDP", "Information");
                        return;
                    }
                }
                if (rbTcp.Checked)
                {
                    DumpLine("Sending via TCP: " + cmd);
                    string result = ComManager.SendTcpMessage(ip, ipPort, cmd);
                    DumpLine("Received: " + result);
                }
                if (rbSerial.Checked)
                {
                    DumpLine("Sending via Serial: " + cmd);
                    string result = ComManager.SendSerialMessage(comPort, cmd);
                    DumpLine("Received: " + result);
                }
                if (rbUdp.Checked)
                {
                    DumpLine("Sending via UDP: " + cmd);
                    string result = ComManager.SendUdpMessage(ip, ipPort, cmd);
                    DumpLine("Received: " + result);
                }
            }
            catch (Exception)
            {
                string msg = "An error has occured. Unable to send command.  Please make sure: " + Environment.NewLine;
                msg = msg + "1. you have selected the correct Communication Method below" + Environment.NewLine;
                msg = msg + "2. You are connected to the PMC-8 network, if required" + Environment.NewLine;
                msg = msg + "If that does not work, please restart the program.";
                //msg += Environment.NewLine + ex.ToString();
                Dump("Error: " + cmd);
                MessageBox.Show(msg, "Error");
            }
        }

        private void CmdAdvancedEsx_Click(object sender, EventArgs e)
        {
            if (rbSerial.Checked == false && rbTcp.Checked == false && rbUdp.Checked == false)
            {
                MessageBox.Show("Please select a communication method first");
                return;
            }
            //DumpLine("Sending ESX!");
            Cursor.Current = Cursors.WaitCursor;
            SendCustomCommand("ESX!");
            Cursor.Current = Cursors.Default;
        }

        private void CmdAdvancedESY_Click(object sender, EventArgs e)
        {
            if (rbSerial.Checked == false && rbTcp.Checked == false && rbUdp.Checked == false)
            {
                MessageBox.Show("Please select a communication method first");
                return;
            }
            //DumpLine("Sending ESY!");
            Cursor.Current = Cursors.WaitCursor;
            SendCustomCommand("ESY!");
            Cursor.Current = Cursors.Default;
        }

        private void CmdAdvancedEsgp0_Click(object sender, EventArgs e)
        {
            if (rbSerial.Checked == false && rbTcp.Checked == false && rbUdp.Checked == false)
            {
                MessageBox.Show("Please select a communication method first");
                return;
            }
            //DumpLine("Sending ESGp0!!");
            Cursor.Current = Cursors.WaitCursor;
            SendCustomCommand("ESGp0!");
            Cursor.Current = Cursors.Default;
        }
        private void CmdAdvancedESGv_Click(object sender, EventArgs e)
        {
            if (rbSerial.Checked == false && rbTcp.Checked == false && rbUdp.Checked == false)
            {
                MessageBox.Show("Please select a communication method first");
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            SendCustomCommand("ESGv!");
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Change Connection Methods
        private void CmdBasic2ViaAscom_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cmbBasic2SerialPort.Text))
            {
                MessageBox.Show("Please select a com port before switching to serial.");
                return;
            }
            DumpLine("Switching to ASCOM...");
            Cursor.Current = Cursors.WaitCursor;
            EsMount mount = GetMountFromGUI();
            try
            {
                mount = MountManager.ConnectMount(mount);
                if (mount == null)
                {
                    mount = MountManager.ConnectMount(mount);
                }
                if (mount == null)
                {
                    Console.WriteLine("error");
                    MessageBox.Show("The mount is currently busy. Please try again in a second, or use 'Find Ccurrent Connection' if required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (mount?.ConnectionSettings?.IsConnected == ConnectionEnum.Serial)
                {
                    MessageBox.Show("Mount is already connected via serial", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
                mount = MountManager.ChangeMountConnection(mount, ConnectionEnum.Serial);
                Dump("Sucessfully switched to serial (ASCOM) mode");
                UpdateChangeMethodsButtonsAccess(mount);
            }
            catch (EsException esEx)
            {
                Dump("Could not switch.");
                MessageBox.Show("Could not switch to ASCOM." + Environment.NewLine + esEx.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Dump("Could not switch.");
                MessageBox.Show("The mount is currently busy. Please try again in a second, or use 'Find Ccurrent Connection' if required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            UpdateTabStripConnection(mount);

        }

        private void CmdBasic2ViaTCP_Click(object sender, EventArgs e)
        {
            EsMount mount = GetMountFromGUI();
            bool setSsidTimer = false;
            try
            {
                if (ComManager.ConnectedToPmcNetwork == false)
                {
                    MessageBox.Show("You must be connected to a PMC-8 network. Please connect to a PMC-8 network and try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DumpLine("Switching to TCP...");
                MountManager.ConnectMount(mount);
                if (mount == null)
                {
                    mount = MountManager.ConnectMount(mount);
                }
                if (mount == null)
                {
                    MessageBox.Show("The mount is currently busy. Please try again in a second, or use 'Find Ccurrent Connection' if required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (mount.ConnectionSettings.IsConnected == ConnectionEnum.UDP)
                {
                    setSsidTimer = true;
                }
                if (mount.ConnectionSettings.IsConnected == ConnectionEnum.TCP)
                {
                    Dump("Already on TCP");
                    MessageBox.Show("Mount is already connected via TCP", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (mount.ConnectionSettings.IsConnected == ConnectionEnum.UDP)
                {
                    Dump("Switching from UDP...");
                    MessageBox.Show("Switching may disconnect computer from PMC-8 network.  Please reconnect after switching", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Cursor.Current = Cursors.WaitCursor;
                mount = MountManager.ChangeMountConnection(mount, ConnectionEnum.TCP);
                Dump("Success - switched to TCP");
                UpdateChangeMethodsButtonsAccess(mount);
            }
            catch (EsException esEx)
            {
                Dump("ERROR - could not switch to TCP");
                MessageBox.Show("The mount is currently busy. Please try again in a second, or use 'Find Ccurrent Connection' if required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Dump("ERROR - could not switch to TCP");
                MessageBox.Show("The mount is currently busy. Please try again in a second, or use 'Find Ccurrent Connection' if required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            if (setSsidTimer)
            {
                TurnOnSsIdTimer();
            }
            UpdateTabStripConnection(mount);
        }

        private void CmdBasic2ViaUdp_Click(object sender, EventArgs e)
        {
            EsMount mount = null;
            bool setSsidTimer = false;
            try
            {
                if (cmbBasic2MountType.Text == "G11" || cmbBasic2MountType.Text == "Exos-2")
                {
                    MessageBox.Show("G-11 and EXOS-2 user do not need to use UDP mode.");
                    return;
                }
                if (ComManager.ConnectedToPmcNetwork == false)
                {
                    MessageBox.Show("You must be connected to a PMC-8 network. Please connect to a PMC-8 network and try again", "Information");
                    return;
                }
                DumpLine("Switching to UDP...");
                mount = GetMountFromGUI();
                MountManager.ConnectMount(mount);
                if (mount == null)
                {
                    mount = MountManager.ConnectMount(mount);
                }
                if (mount == null)
                {
                    MessageBox.Show("The mount is currently busy. Please try again in a second, or use 'Find Ccurrent Connection' if required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (mount.ConnectionSettings.IsConnected == ConnectionEnum.TCP)
                {
                    setSsidTimer = true;
                }
                if (mount.ConnectionSettings.IsConnected == ConnectionEnum.UDP)
                {
                    Dump("Mount is already on UDP");
                    MessageBox.Show("Mount is already connected via UDP", "Information");
                    return;
                }
                if (mount.ConnectionSettings.IsConnected == ConnectionEnum.TCP)
                {
                    MessageBox.Show("Switching may disconnect computer from PMC-8 network.  Please reconnect after switching", "Information");
                }
                mount = MountManager.ChangeMountConnection(mount, ConnectionEnum.UDP);
                Dump("Succesfully switched to UDP");
                UpdateChangeMethodsButtonsAccess(mount);
            }
            catch (EsException esEx)
            {
                Dump("Could not switch to  UDP");
                MessageBox.Show("The mount is currently busy. Please try again in a second, or use 'Find Ccurrent Connection' if required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Dump("Could not switch to  UDP");
                MessageBox.Show("The mount is currently busy. Please try again in a second, or use 'Find Ccurrent Connection' if required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (setSsidTimer)
            {
                TurnOnSsIdTimer();
            }
            UpdateTabStripConnection(mount);
        }

        #endregion

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        #region EEPROM Updating
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        private void FindEepromFile_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            openFileDialog.Title = "Find .eeprom File";
            openFileDialog.Filter = "EEPROM Files (*.eeprom)|*.eeprom| All Files(*.*)|*.*";
            openFileDialog.ShowDialog();
            txtEepromPath.Text = openFileDialog.FileName;
        }

        private void CmdUploadRom_Click(object sender, EventArgs e)  //TODO: move out of gui.
        {
            if (String.IsNullOrWhiteSpace(txtEepromPath.Text))
            {
                return;
            }
            if (String.IsNullOrWhiteSpace(cmbBasic2SerialPort.Text))
            {
                MessageBox.Show("You must have a serial connection in order to upload the eeprom.", "Warning");
                return;
            }

            string msg = "Only perform this operation if you are 100% certain you know the implications." + Environment.NewLine;
            msg += "Make sure you PMC-8 is plugged in.";
            DialogResult r = MessageBox.Show(msg, "Warning - Use Carefully", MessageBoxButtons.OKCancel);
            if (r == DialogResult.Cancel)
            {
                return;
            }

            MessageBox.Show("This may take a few moments.  Press OK to start", "Information");
            DumpLine("Attempting to upload ROM");

            string file = Environment.CurrentDirectory + "\\Propellent.exe ";
            string args = "\"" + txtEepromPath.Text + "\"" + " /eeprom";
            try
            {
                Console.WriteLine("Tryiny to ececute: " + file + " " + args);
                ProcessStartInfo procStartInfo = new ProcessStartInfo(file, args);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;

                // wrap IDisposable into using (in order to release hProcess) 
                using (Process process = new Process())
                {
                    process.StartInfo = procStartInfo;
                    process.Start();

                    // Add this: wait until process does its work
                    process.WaitForExit();

                    // and only then read the result
                    string result = process.StandardOutput.ReadToEnd();
                    DumpLine("Success - results:");
                    DumpLine(result);
                }
            }
            catch (Exception ex)
            {

                DumpLine("Could not load EEPROM.  Error Code:");
                DumpLine(ex?.ToString());
            }


            //Cursor.Current = Cursors.WaitCursor;
            //try
            //{
            //    Console.WriteLine(Environment.CurrentDirectory);
            //    SetGUIMode(0);
            //    InitPropellent(this.Handle, false, null);
            //    SaveImage(true, openFileDialog.FileName, false);
            //    MessageBox.Show("ROM successfully loaded.", "Information");
            //    Dump("ROM uploaded.");
            //}
            //catch (Exception ex)
            //{
            //    Dump("Could not load ROM");
            //    string msg2 = "ROM failed to load" + Environment.NewLine + Environment.NewLine + ex?.ToString();
            //    MessageBox.Show(msg2, "Error");
            //}
            //finally
            //{ FinalizePropellent(); }
            Cursor.Current = Cursors.Default;
        }


        #endregion

        #region Profile Writing
        private void SaveToProfile()
        {
            Cursor.Current = Cursors.WaitCursor;
            string driverID = "ASCOM.ES_PMC8.Telescope";
            string comPort = null;
            bool WirelessEnabled = true;
            string WirelessProtocol = "TCP";
            string comPortProfileName = "COM Port";
            string WirelessEnabledProfileName = "Wireless Enabled";

            EsMount mount = GetMountFromGUI();
            mount = MountManager.ConnectMount(mount);
            if (mount == null)
            {
                mount = MountManager.ConnectMount(mount);
            }
            if (mount == null)
            {
                DumpLine("Configuration not saved! The mount does not appear to be connected. Please check your settings and network connection.");
                tsCurrentConnection.Text = "NONE";
                tsCurrentConnection.BackColor = Color.Red;
                return;
            }


            // Set wireless
            if (mount.ConnectionSettings.IsConnected == ConnectionEnum.Serial)
            {
                WirelessEnabled = false;
            }
            else
            {
                Console.WriteLine(mount.ConnectionSettings.IsConnected.ToString());
                WirelessProtocol = mount.ConnectionSettings.IsConnected.ToString();
            }
            comPort = mount.ConnectionSettings.SerPort;

            var driverProfile = new Profile();
            driverProfile.DeviceType = "Telescope";
            driverProfile.WriteValue(driverID, comPortProfileName, comPort.ToString());
            driverProfile.WriteValue(driverID, WirelessEnabledProfileName, WirelessEnabled.ToString());
            driverProfile.WriteValue(driverID, comPortProfileName, comPort.ToString());
            driverProfile.WriteValue(driverID, "Wireless Protocol", WirelessProtocol);
            driverProfile.Dispose();
            string msg = "Port: " + comPort + ", Use Wireless: " + WirelessEnabled + ", Protocol: " + WirelessProtocol;
            DumpLine("Saved Configuration - " + msg);
            Cursor.Current = Cursors.Default;
        }


        EsMount mount = new EsMount();
        #endregion

        private void Basic_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("http://www.explorescientificusa.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Width = 2300;
            this.MinimumSize = new Size(800, 800);
            this.Show();
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //var DialogResult = MessageBox.Show("Would you like the CM to try to automatically detect your mount connection type?", "Detect Mount", buttons);
            //if (DialogResult == DialogResult.Yes)
            //{
            //    CmdBasic2CheckCurrentConnection_Click(null, null);
            //}

            //Load combo boxes with data from Resources
            //Properties.Settings.Default.COMPORT = cmbBasic2SerialPort.Text;
            //Properties.Settings.Default.MOUNT = cmbBasic2MountType.Text;
            string mount = Properties.Settings.Default.MOUNT;
            string comport = Properties.Settings.Default.COMPORT;

            cmbBasic2MountType.Text = mount;
            cmbBasic2SerialPort.Text = comport;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            SaveToProfile();
        }

        #region New Firmware Loader

        public string desinationFolder
        {
            get
            { return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\PMC8Firmware"; }
        }


        private void CmdDownloadFirmware_Click(object sender, EventArgs e)
        {
            if (cmbBasic2MountType.SelectedItem == null)
            {
                var x = MessageBox.Show("Please select a mount before downloading firmware", "NOTICE");
            }
            //string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            lsvEepromFileNames.Clear();
            //string dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\PMC8Firmware";
            //string fullPath = dest + @"\Firmware";
            //String dest = Environment.CurrentDirectory + @"\Firmware";
            System.IO.DirectoryInfo di = new DirectoryInfo(desinationFolder);

            if (Directory.Exists(desinationFolder))
            {
                EmptyFolder(new DirectoryInfo(desinationFolder));
            }



            //create directory
            if (!Directory.Exists(desinationFolder))
            {
                Directory.CreateDirectory(desinationFolder);
            }


            string source2 = txtDownloadLocation.Text; // "http://02d3287.netsolhost.com/pmc-eight/FIRMWARE/PMC8_FirmwareEEPROM.zip";
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko)");
                //string fullDestination = dest + @"\Firmware.zip";
                Console.WriteLine(desinationFolder);
                DumpLine("Downloading firmware");
                // webClient.DownloadFile(source2, Environment.CurrentDirectory + @"/Firmware" + "/Firmware.zip");
                webClient.DownloadFile(source2, desinationFolder + @"\Firmware.zip");
                DumpLine("Firmware files successfully downloaded to " + desinationFolder + @"\Firmware.zip");
            }
            catch (UnauthorizedAccessException ex)
            {
                Dump("You do not have permissions to use this directory.");
            }
            catch (Exception ex)
            {

                DumpLine("ERROR!!  The firmware files could not be downloaded.  Please check your internet connection and try again");
                return;
            }


            //Unzip file
            DumpLine("Unzipping firmware file.");
            try
            {
                ZipFile.ExtractToDirectory(desinationFolder + @"\Firmware.zip", desinationFolder);
                DumpLine("Firmware sucessfully unzipped");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                DumpLine("ERROR!! The firmware file could not be unzipped.  Please delete the Firmware directory and try again.");
                return;
            }

            //Add to listbox
            if (Directory.Exists(desinationFolder))
            {
                di = new DirectoryInfo(desinationFolder);
                foreach (FileInfo file in di.GetFiles())
                {
                    if (file.Extension == ".eeprom")
                    {
                        if (isEepromForSelectedMount(file))
                        {
                            lsvEepromFileNames.Items.Add(file.Name);
                        }

                    }
                }
            }

        }

        private bool isEepromForSelectedMount(FileInfo file)
        {
            string mountInUse = cmbBasic2MountType.SelectedItem.ToString();
            char underscore = '_';
            char period = '.';
            int suffixIndex = GetNthIndex(file.Name, underscore, 2);
            int periodlocation = GetNthIndex(file.Name, period, 1);
            int length = file.Name.Length - periodlocation - 4;
            string mountSuffix = file.Name.Substring(suffixIndex + 1, length);
            Console.WriteLine(mountSuffix + ":  " + mountSuffix);
            if (mountInUse == "G11" && mountSuffix == "G11")
            {
                return true;
            }

            if (mountInUse == "Exos-2" && mountSuffix == "EXO")
            {
                return true;
            }

            if (mountInUse == "Titan" && mountSuffix == "TIT")
            {
                return true;
            }

            if (mountInUse == "iExos100" && mountSuffix.Length == 3 && mountSuffix != "EXO" && mountSuffix != "TIT" && mountSuffix != "G11")
            {
                return true;
            }
            //if (mountInUse == "iExos100" && mountSuffix.Length == 3)
            //{
            //    return true;
            //}

            return false;
        }

        public int GetNthIndex(string s, char t, int n)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t)
                {
                    count++;
                    if (count == n)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        private void Button2_Click(object sender, EventArgs e)  //ViewReadme
        {
            //String dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\PMC8Firmware";
            if (!Directory.Exists(desinationFolder))
            {
                MessageBox.Show("Can not find the directory.  Please download the Zip file first", "Information");
                return;
            }
            string[] files = Directory.GetFiles(desinationFolder);
            var x = from z in files
                    where z.Substring(z.Length - 4) == @".txt"
                    select z;
            string a = x.FirstOrDefault();
            Console.WriteLine(a);
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

            try
            {
                Process.Start(a);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not open the Readme.txt file", "Error");
                DumpLine("Error opening Readme.txt file");
            }

        }
        private void Button3_Click(object sender, EventArgs e)  //FLash Selected
        {
            if (lsvEepromFileNames.SelectedItems.Count == 0)
            {
                return;
            }
            string fileName = lsvEepromFileNames.SelectedItems[0].Text;


            string msg = "Only perform this operation if you are 100% certain you know the implications." + Environment.NewLine;
            msg += "Make sure you PMC-8 is plugged in.";
            DialogResult r = MessageBox.Show(msg, "Warning - Use Carefully", MessageBoxButtons.OKCancel);
            if (r == DialogResult.Cancel)
            {
                return;
            }

            MessageBox.Show("This may take a few moments.  Press OK to start", "Information");
            DumpLine("Attempting to upload ROM: " + fileName);

            string file = Environment.CurrentDirectory + @"\Propellent.exe ";
            //string args = "\"" + txtEepromPath.Text + "\"" + " /eeprom";
            //string args = @"\Firmware\" + fileName;
            //string args = desinationFolder + @"\" + fileName;
            string args = desinationFolder + @"\" + fileName;
            Console.WriteLine(args);

            //DOUBLE CHECK THAT FILES EXIST
            if (!File.Exists(file))
            {
                DumpLine("The program can not find Propellent.dll. Please reinstall or contact support.");
            }
            if (!File.Exists(args))
            {
                DumpLine("The program could not find the eeprom file.  Please try again or contact support");
            }

            try
            {
                Console.WriteLine("Tryiny to ececute: " + file + " " + args);
                ProcessStartInfo procStartInfo = new ProcessStartInfo(file, args);
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;

                // wrap IDisposable into using (in order to release hProcess) 
                using (Process process = new Process())
                {
                    process.StartInfo = procStartInfo;
                    process.Start();

                    // Add this: wait until process does its work
                    process.WaitForExit();

                    // and only then read the result
                    string result = process.StandardOutput.ReadToEnd();
                    DumpLine("Success - results:");
                    DumpLine(result);
                }
            }
            catch (Exception ex)
            {

                DumpLine("Could not load EEPROM.  Error Code:" + ex?.ToString());
                DumpLine(ex?.ToString());
            }
        }

        #endregion

        #region ExploreStars

        #endregion
        private void CmdDownloadDatabase_Click(object sender, EventArgs e)
        {
            string source = txtDatabaseINternetAddress.Text;
            string dest = txtDatabaseLocation.Text;
            //string dataDir = dest + @"/Data";

            //Create directory and make sure it is empty
            if (!Directory.Exists(dest))
            {
                Directory.CreateDirectory(dest);
                // Directory.CreateDirectory(dataDir);
            }
            else
            {
                var rootFiles = Directory.GetFiles(dest);
                foreach (var item in rootFiles)
                {
                    File.Delete(item);
                }
            }

            //Download DB



            WebClient webClient = new WebClient();
            webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko)");

            try
            {
                DumpLine("Downloading File. Please Wait...");
                MessageBox.Show("This may take a few minutes", "Information");
                this.Cursor = Cursors.WaitCursor;
                // webClient.DownloadFile("http://02d3287.netsolhost.com/pmc-eight/DATABASE/ExploreStarsComplete.zip", @"C:\DataBase.zip");
                webClient.DownloadFile(new Uri(source), dest + @"/ExploreStars.zip");
                MessageBox.Show("The Database was successfully downloaded.", "Information");
                DumpLine("The database was sucessfully downloaded.");
            }
            catch (UnauthorizedAccessException ex)
            {
                DumpLine("Error!!  Database was not downloaded.  File access exception.");
                MessageBox.Show("You do not have permission to use this location.  Please use a different location", "Error");
            }
            catch (Exception ex)
            {

                MessageBox.Show("There was an error downloading the database:" + ex?.ToString(), "Error");
                DumpLine("Error!!  Database was not downloaded.  Please try again.");
            }
            this.Cursor = Cursors.Default;

        }

        private void RdoInstallToWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoInstallToWindows.Checked == true)
            {
                txtDatabaseINternetAddress.Text = @"http://02d3287.netsolhost.com/pmc-eight/DATABASE/ExploreStarsComplete.zip";
                cmbDrive.Enabled = false;
            }
            else
            {
                txtDatabaseINternetAddress.Text = @"http://02d3287.netsolhost.com/pmc-eight/DATABASE/ExploreStars.zip";
                cmbDrive.Enabled = true;
                var drives = from drive in DriveInfo.GetDrives()
                             where drive.DriveType == DriveType.Removable
                             select drive;
                foreach (var item in drives)
                {
                    cmbDrive.Items.Add(item.Name);
                }
            }
        }

        private void RdoInstallToSdCard_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CmdInstallDB_Click(object sender, EventArgs e)
        {
            string destination = null;
            string source = txtDatabaseLocation.Text + @"/ExploreStars.zip";

            if (rdoInstallToWindows.Checked == true)   //Set destinations
            {
                destination = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                if (Directory.Exists(destination))
                {
                    DumpLine("Deleting existing DB.");
                    var di = new DirectoryInfo(destination);
                    EmptyFolder(di);
                    DumpLine("DB Deleted.");
                }
                else
                {
                    var di = new DirectoryInfo(destination);
                    Directory.CreateDirectory(di.FullName);
                }
                try
                {

                    DumpLine("Unzipping DB...");
                    //TODO: Manually creat directory on SD card
                    ZipFile.ExtractToDirectory(source, destination);
                    DumpLine("DB unzipped and installed.");
                    MessageBox.Show("The database was sucessfully unzipped", "Information");
                }
                catch (System.UnauthorizedAccessException ex)
                {
                    MessageBox.Show("You do not have permission to write to this location.  Please select a different lcation.", "Error");
                    DumpLine("ERROR!!  The DB could not be unzipped to the specified location. Please make sure you have downloaded it.");
                }


            }
            else //From SD Card
            {
                if (cmbDrive.SelectedItem == null)
                {
                    MessageBox.Show("Please select a removable drive first.", "WARNING");
                    return;
                }
                destination = cmbDrive.SelectedItem?.ToString();
                destination += @"\ExploreStars\Images";
                if (Directory.Exists(destination))
                {

                    DumpLine("Deleting existing DB.");
                    var di = new DirectoryInfo(destination);
                    EmptyFolder(di);
                    DumpLine("DB Deleted.");
                }
                else
                {
                    //string sdDestination = cmbDrive.SelectedItem?.ToString();
                    //var di = new DirectoryInfo(sdDestination);
                    //Directory.CreateDirectory(di.FullName);
                }
                try
                {

                    DumpLine("Unzipping DB...");
                    string sdDestination = cmbDrive.SelectedItem?.ToString();
                    //TODO: Manually creat directory on SD card
                    if (File.Exists(sdDestination + "\\ExploreStars\\ExploreStars.sqlite"))
                    {
                        File.Delete(sdDestination + "\\ExploreStars\\ExploreStars.sqlite");
                    }

                    ZipFile.ExtractToDirectory(source, sdDestination);
                    DumpLine("DB unzipped and installed.");
                    MessageBox.Show("The database was sucessfully unzipped", "Information");
                }
                catch (System.UnauthorizedAccessException ex)
                {
                    MessageBox.Show("You do not have permission to write to this location.  Please select a different lcation.", "Error");
                    DumpLine("ERROR!!  The DB could not be unzipped to the specified location. Please make sure you have downloaded it.");
                }
            }
            Console.WriteLine(destination);



        }

        private void CmdDeleteDatabaseZipFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtDatabaseLocation.Text + @"/Explorestars.zip"))
            {
                DumpLine("The DB has already been deleted.");
                return;
            }
            File.Delete(txtDatabaseLocation.Text + @"/Explorestars.zip");
            var di = new DirectoryInfo(txtDatabaseLocation.Text);
            EmptyFolder(di);
            DumpLine("DB deleted");
        }
        private void EmptyFolder(DirectoryInfo directoryInfo)
        {
            Directory.Delete(directoryInfo.FullName, true);
            //foreach (FileInfo file in directoryInfo.GetFiles())
            //{
            //    file.Delete();
            //}

            //foreach (DirectoryInfo subfolder in directoryInfo.GetDirectories())
            //{
            //    EmptyFolder(subfolder);
            //}
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.GitHub.com/WCMoses");
        }

        private void Label23_Click(object sender, EventArgs e)
        {

        }

        private void cmdRefreshCurrentFirmware_Click(object sender, EventArgs e)
        {
            try
            {
                string response = ComManager.SendSerialMessage(cmbBasic2SerialPort.Text, "ESGv!");
                response = response.Substring(5, response.Length - 5);
                lblFirmwareVersion.Text = response;
            }
            catch (Exception)
            {

                MessageBox.Show("Please connect via serial to see the firmware version", "Message");
            }

        }

        private void cmdChooseDatabaseLocation_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.COMPORT = cmbBasic2SerialPort.Text;
            Properties.Settings.Default.MOUNT = cmbBasic2MountType.Text;
            Properties.Settings.Default.Save();
        }
    }
}

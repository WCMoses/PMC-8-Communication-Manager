using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

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

        public Form1()
        {
            InitializeComponent();
            MountManager = new EsMountManager();
            ComManager = new ComManager();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                cmbBasic2SerialPort.Items.Add(s);
            }
            if (cmbBasic2SerialPort.Items.Count>0)
            {
                cmbBasic2SerialPort.SelectedIndex = 0;
            }
            cmbBasic2MountType.SelectedIndex = 1;
            ComManager.SsidTimerHit += ComManager_SsidTimerHit;
            EsEventManager.EsEventRaised += EsEventManager_EsEventRaised;
            rbDefault.Checked = true;
        }

        #region GUI Events

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
            if (rbGeneralInfo.Checked)
            {
                _priorityToShow = EsMessagePriority.GeneralInfo;
            }
        }

        private void RbDetailedInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDetailedInfo.Checked)
            {
                _priorityToShow = EsMessagePriority.DetailedInfo;
            }
        }
        private void RbDebugInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDebugInfo.Checked)
            {
                _priorityToShow = EsMessagePriority.DebugInfo;
            }
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
            catch (Exception)
            {
                MessageBox.Show("Could not automatically find the com port for the PMC-8. Please make sure it is connected.", "Information");
            }
            if (string.IsNullOrEmpty(comPort))
            {
                MessageBox.Show("Could not automatically find the com port for the PMC-8. Please make sure it is connected.", "Information");

            }
            else
            {
                MessageBox.Show("The PMC-8 is connected on com port: " + comPort +". NOTE - This does not mean your mount is connected via serial.", "Information");
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
            if (rbDefault.Checked)
            {
                //don't show any
                _priorityToShow = EsMessagePriority.None;
            }
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
            if (rbGeneralInfo.Checked)
            {
                msg = ex?.Message;
            }
            if (rbDetailedInfo.Checked)
            {
                msg = ex?.Message + " , " + ex?.Source;
            }
            if (rbDebugInfo.Checked)
            {
                msg = ex?.Message + " , " + ex?.Source + " , " + ex?.StackTrace.ToString();
            }
            DumpLine(msg);
        }

        public void UpdateTabStripConnection(EsMount mount)
        {
            Color oldColor = tsCurrentConnection.BackColor;
            switch (mount.ConnectionSettings.IsConnected)
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
            if (oldColor == Color.Green && tsCurrentConnection.BackColor == Color.Red)
            {
                MessageBox.Show("Connection to the PMC-8 network has been lost.", "Important");
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
                if (mount.ConnectionSettings.IsConnected == ConnectionEnum.Serial)
                {
                    MessageBox.Show("Mount is already connected via serial");
                    return;
                }
                mount = MountManager.ChangeMountConnection(mount, ConnectionEnum.Serial);
                Dump("Sucessfully switched to serial (ASCOM) mode");
                UpdateChangeMethodsButtonsAccess(mount);
            }
            catch (EsException esEx)
            {
                Dump("Could not switch.");
                MessageBox.Show("Could not switch to ASCOM." + Environment.NewLine + esEx.Message);
            }
            catch (Exception ex)
            {
                Dump("Could not switch.");
                MessageBox.Show("Could not switch to ASCOM." + Environment.NewLine + ex.ToString());
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
            try
            {
                if (ComManager.ConnectedToPmcNetwork == false)
                {
                    MessageBox.Show("You must be connected to a PMC-8 network. Please connect to a PMC-8 network and try again", "Information");
                    return;
                }
                DumpLine("Switching to TCP...");
                MountManager.ConnectMount(mount);
                if (mount.ConnectionSettings.IsConnected == ConnectionEnum.TCP)
                {
                    Dump("Already on TCP");
                    MessageBox.Show("Mount is already connected via TCP", "Information");
                    return;
                }

                if (mount.ConnectionSettings.IsConnected == ConnectionEnum.UDP)
                {
                    Dump("Switching from UDP...");
                    MessageBox.Show("Switching may disconnect computer from PMC-8 network.  Please reconnect after switching", "Information");
                }
                Cursor.Current = Cursors.WaitCursor;
                mount = MountManager.ChangeMountConnection(mount, ConnectionEnum.TCP);
                Dump("Success - switched to TCP");
                UpdateChangeMethodsButtonsAccess(mount);
            }
            catch (EsException esEx)
            {
                Dump("ERROR - could not switch to TCP");
                MessageBox.Show("Could not switch to TCP." + Environment.NewLine + esEx.Message);
            }
            catch (Exception ex)
            {
                Dump("ERROR - could not switch to TCP");
                MessageBox.Show("Could not switch to TCP." + Environment.NewLine + ex.ToString());
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            UpdateTabStripConnection(mount);
        }

        private void CmdBasic2ViaUdp_Click(object sender, EventArgs e)
        {
            EsMount mount = null;
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
                MessageBox.Show("Could not switch to UDP." + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Dump("Could not switch to  UDP");
                MessageBox.Show("Could not switch to UDP." + Environment.NewLine);
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

        private void CmdUploadRom_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEepromPath.Text))
            {
                return;
            }

            DialogResult r = MessageBox.Show("Only perform this operation if you are 100% certain you know the implications.", "Warning - Experimental Feature !!", MessageBoxButtons.OKCancel);
            if (r == DialogResult.Cancel)
            {
                return;
            }

            MessageBox.Show("This may take a few moments.  Press OK to start", "Information");
            DumpLine("Attempting to upload ROM");
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                InitPropellent(this.Handle, false, "c:\\");
                SaveImage(true, openFileDialog.FileName, false);
                MessageBox.Show("ROM successfully loaded.", "Information");
                Dump("ROM uploaded.");
            }
            catch (Exception ex)
            {
                Dump("Could not load ROM");
                string msg = "ROM failed to load" + Environment.NewLine + Environment.NewLine + ex?.ToString();
                MessageBox.Show(msg, "Error");
            }
            finally
            { FinalizePropellent(); }
            Cursor.Current = Cursors.Default;
        }


        #endregion

        private void Basic_Click(object sender, EventArgs e)
        {

        }
    }
}

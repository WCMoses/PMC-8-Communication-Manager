using ManagedNativeWifi;
using System;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Timers;

namespace IxosTest2
{

    public class ComManager
    {

        #region Properies
        public event EventHandler<SsidEventArgs> SsidTimerHit;
        public int interval = 1000;
        public System.Timers.Timer SsidTimer { get; set; }

        public ComManager()
        {
            SsidTimer = new System.Timers.Timer(interval);
            SsidTimer.Elapsed += SsidTimers_Elapsed;
            SsidTimer.Start();
        }
        public bool ConnectedToPmcNetwork
        {
            get
            {
                return IsConnectedToPmcNetwork();
            }
        }

        public string ConnectedNetwork
        {
            get
            {
                return ConnectedSsid();
            }
        }
        #endregion



        #region Send Message Methods
        public string SendMessage(EsMount mount, string msg)
        {
            return null;
        }

        public string SendTcpMessage(string ipAddr, Int32 ipPort, string msg)
        {
            EsEventManager.PublishEsEvent(EsEventSenderEnum.ComManager,EsMessagePriority.DetailedInfo , "    Start Sending TCP Message..");
            string res = SendTcpMessageOLD(ipAddr, ipPort, msg);
            return res;
        }
        public string SendTcpMessageOLD(string ipAddr, Int32 comPort, string msg)
        {
            if (!ConnectedToPmcNetwork)
            {
                throw new EsException("Must be connected to PMC=8 network.");
            }

            string message;
            try
            {

                // Create TCP client and connect
                using (var _client = new TcpClient(ipAddr, comPort))
                using (var _netStream = _client.GetStream())
                {
                    //_netStream.ReadTimeout = 2000;

                    // Write a message over the socket
                    message = Environment.NewLine + msg + Environment.NewLine;
                    byte[] dataToSend = System.Text.Encoding.ASCII.GetBytes(message);
                    _client.Client.ReceiveTimeout = 1500;
                    _netStream.Write(dataToSend, 0, dataToSend.Length);
                    Thread.Sleep(75);
                    // Read server response
                    byte[] recvData = new byte[512];
                    int bytes = _netStream.Read(recvData, 0, recvData.Length);
                    message = System.Text.Encoding.ASCII.GetString(recvData, 0, bytes);
                    Console.WriteLine(string.Format("IP Server: {0}", message));

                };// The client and stream will close as control exits the using block (Equivilent but safer than calling Close();
            }
            catch (System.Net.Sockets.SocketException ex)
            {

                throw new ApplicationException("Can not read/write TCP command", ex);
            }
            catch (System.IO.IOException ex)
            {
                throw new ApplicationException("Can not read/write TCP command", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Can not read/write TCP command", ex);
            }
            finally
            {
            }
            EsEventManager.PublishEsEvent(EsEventSenderEnum.ComManager, EsMessagePriority.DetailedInfo, "    Finished Sending TCP Message");

            return message;
        }
        public string SendUdpMessage(string ipAddr, Int32 comPort, string msg)
        {
            EsEventManager.PublishEsEvent(EsEventSenderEnum.ComManager, EsMessagePriority.DetailedInfo, "    Start Sending UDP Message");

            UdpClient udpClient = new UdpClient(54372);
            udpClient.Client.ReceiveTimeout = 1500;
            string returnData = "No Data Received";
            try
            {
                udpClient.Connect("192.168.47.1", 54372);

                // Sends a message to the host to which you have connected.
                Byte[] sendBytes = Encoding.ASCII.GetBytes(msg + Environment.NewLine);

                udpClient.Send(sendBytes, sendBytes.Length);

                // Sends a message to a different host using optional hostname and port parameters.
                UdpClient udpClientB = new UdpClient();
                Thread.Sleep(1000);
                udpClientB.Send(sendBytes, sendBytes.Length, "192.168.47.1", 54372);

                //IPEndPoint object will allow us to read datagrams sent from any source.
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Thread.Sleep(1000);
                // Blocks until a message returns on this socket from a remote host.

                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                returnData = Encoding.ASCII.GetString(receiveBytes);

                // Uses the IPEndPoint object to determine which of these two hosts responded.
                Console.WriteLine("This is the message you received " +
                                             returnData.ToString());
                Console.WriteLine("This message was sent from " +
                                            RemoteIpEndPoint.Address.ToString() +
                                            " on their port number " +
                                            RemoteIpEndPoint.Port.ToString());

                udpClient.Close();
                udpClientB.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                EsException e = new EsException("Error in :" + "SendUdpMessage", ex);
                throw e;
            }
            EsEventManager.PublishEsEvent(EsEventSenderEnum.ComManager, EsMessagePriority.DetailedInfo, "    Finished Sending UDP Message");

            return returnData.ToString();
        }

        public string SendSerialMessage(string serialPort, string msg)
        {
            EsEventManager.PublishEsEvent(EsEventSenderEnum.ComManager, EsMessagePriority.DetailedInfo, "    Start Sending Serial Message");

            Mutex mutex = new Mutex();
            mutex.WaitOne();
            if (serialPort == String.Empty)
            {
                throw new EsException("Error in :" + "SendSerialMessage - Serial Port can not be empty");
            }
            string newData;
            try
            {
                SerialPort Port = new SerialPort(serialPort, 115200, Parity.None, 8);
                Port.Open();
                Port.WriteLine(msg);
                Thread.Sleep(500);
                newData = Port.ReadExisting().ToString();
                Console.WriteLine(newData);
                Port.Close();
            }
            catch (Exception ex)
            {
                EsException e = new EsException("Error in :" + "SendSerialMessage", ex);
                throw e;
            }
            finally
            {
                mutex.ReleaseMutex();
            }
            EsEventManager.PublishEsEvent(EsEventSenderEnum.ComManager, EsMessagePriority.DetailedInfo, "    Finished Sending Serial Message");

            return newData;
        }
        #endregion

        #region Wireless Connections

        private bool IsConnectedToPmcNetwork()
        {
            bool result = false;
            NetworkIdentifier ss = NativeWifi.EnumerateConnectedNetworkSsids().FirstOrDefault();
            if (ss != null)
            {
                result = ss.ToString().Contains("PMC");
            }
            return result;
        }

        public string ConnectedSsid()
        {
            NetworkIdentifier ss = NativeWifi.EnumerateConnectedNetworkSsids().FirstOrDefault();
            string result = ss?.ToString();
            return result;
        }
        public bool IsConnectedToWirelessNetwork()
        {
            NetworkIdentifier ss = NativeWifi.EnumerateConnectedNetworkSsids().FirstOrDefault();
            if (ss == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //[System.Runtime.InteropServices.DllImport("wininet.dll")]
        //private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        //public bool IsConnectedToWirelessNetwork()
        //{
        //    int desc;
        //    bool result = InternetGetConnectedState(out desc, 0);
        //    return result;
        //}

        //private WlanClient _wlan = new WlanClient();
        //public string ConnectedSsid()
        //{
        //    Mutex mut = new Mutex();

        //    //WlanClient wlan = null;
        //    Collection<String> connectedSsids = new Collection<string>();
        //    string last = "Not set";
        //    try
        //    {
        //        mut.WaitOne();
        //        //wlan = new WlanClient();
        //        if (_wlan != null)
        //        {
        //            if (_wlan.Interfaces != null)
        //            {

        //                foreach (WlanClient.WlanInterface wlanInterface in _wlan.Interfaces)
        //                {
        //                    Wlan.Dot11Ssid ssid = wlanInterface.CurrentConnection.wlanAssociationAttributes.dot11Ssid;
        //                    connectedSsids.Add(new String(Encoding.ASCII.GetChars(ssid.SSID, 0, (int)ssid.SSIDLength)));
        //                    last = new String(Encoding.ASCII.GetChars(ssid.SSID, 0, (int)ssid.SSIDLength));
        //                }
        //            }
        //            else
        //            {
        //                last = "Not set";
        //            }
        //        }
        //        else
        //        {
        //            last = "Not set";
        //        }

        //        //wlan = null;
        //    }
        //    catch (Exception)
        //    {
        //        throw new ApplicationException("GetConnectedSsid Failed");
        //    }
        //    finally
        //    { mut.ReleaseMutex(); }

        //    return last;
        //}

        //private bool IsConnectedToPmcNetwork()
        //{
        //    bool result = false;
        //    if (IsConnectedToWirelessNetwork())
        //    {
        //        if (ConnectedSsid().Contains("PMC"))
        //        {
        //            result = true;
        //        }
        //    }
        //    return result;
        //}
        #endregion

        #region Event Methods
        private void SsidTimers_Elapsed(object sender, ElapsedEventArgs e)
        {
            SsidEventArgs ea = new SsidEventArgs();
            ea.CurrentSsid = ConnectedSsid();
            RaiseSsidTimer(ea);
            //ea.CurrentSsid = GetCurrentSsid();

        }
        protected virtual void OnSsidTimerHit(SsidEventArgs e)
        {
            EventHandler<SsidEventArgs> handler = SsidTimerHit;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public void RaiseSsidTimer(SsidEventArgs e)
        {
            //e.CurrentSsid = GetCurrentSsid();
            OnSsidTimerHit(e);
        }

        #endregion

    }
    public class SsidEventArgs : EventArgs
    {
        public string CurrentSsid = "not set";
    }

}

using System;
using System.IO.Ports;
using System.Threading;

namespace IxosTest2
{
    public class EsMountManager
    {
        #region Constants
        const string SERIAL_QUERY = "ESGp0!";
        const string SERIAL_RESPONSE = "ESGp0";

        const string TCP_QUERY = "ESGp0!";
        const string TCP_RESPONSE = "ESGp0";

        const string UDP_QUERY = "ESGp0!";
        const string UDP_RESPONSE = "ESGp0";
        #endregion
        public ComManager CommunicationsManager { get; set; }
        public bool UseSSID { get; set; }

        public EsMountManager()
        {
            CommunicationsManager = new ComManager();
        }

        #region Connect Mount
        public EsMount ConnectMount(EsMount mount)
        {
            EsEventManager.PublishEsEvent(EsEventSenderEnum.EsMountManager, EsMessagePriority.DetailedInfo, "  Start Connecting to Mount");

            EsMount result = mount;
            string ipaddress = mount.ConnectionSettings.IpAddr;
            int ipPort = mount.ConnectionSettings.IpPort;
            string serPort = mount.ConnectionSettings.SerPort;
            if (!String.IsNullOrWhiteSpace(serPort))
            {
                if (CanVerifySerialConnection(mount))
                {
                    EsEventManager.PublishEsEvent(EsEventSenderEnum.EsMountManager, EsMessagePriority.GeneralInfo, "Trying to Connect via Serial");
                    result.ConnectionSettings.IsConnected = ConnectionEnum.Serial;
                    return result;
                }
            }
            if (!String.IsNullOrWhiteSpace(ipaddress))
            {
                if (CanVerifyTcpConnection(mount))
                {
                    EsEventManager.PublishEsEvent(EsEventSenderEnum.EsMountManager, EsMessagePriority.GeneralInfo, "Trying to Connect via TCP");
                    result.ConnectionSettings.IsConnected = ConnectionEnum.TCP;
                    return result;
                }
                if (CanVerifyUdpConnection(mount))
                {
                    EsEventManager.PublishEsEvent(EsEventSenderEnum.EsMountManager, EsMessagePriority.GeneralInfo, "Trying to Connect via UDP");
                    result.ConnectionSettings.IsConnected = ConnectionEnum.UDP;
                    return result;
                }
            }
            EsEventManager.PublishEsEvent(EsEventSenderEnum.EsMountManager, EsMessagePriority.DetailedInfo, "  Finished Connecting to Mount");

            return null;
        }

        public bool CanVerifyTcpConnection(EsMount mount)
        {
            EsEventManager.PublishEsEvent(EsEventSenderEnum.EsMountManager, EsMessagePriority.DebugInfo, "    Start Verify TCP Connection");

            //Check Wireless first
            if (!CommunicationsManager.IsConnectedToWirelessNetwork())
            {

                return false;
            }
            if (!CommunicationsManager.ConnectedSsid().Contains("PMC"))
            {

                return false;
            }
            bool responseIsGood = false;
            try
            {
                string result = CommunicationsManager.SendTcpMessage(mount.ConnectionSettings.IpAddr,
                                                  mount.ConnectionSettings.IpPort, TCP_QUERY);

                responseIsGood = result.Contains(TCP_RESPONSE);
                EsEventManager.PublishEsEvent(EsEventSenderEnum.EsMountManager, EsMessagePriority.DebugInfo, "    Done Verify TCP Connection: " + responseIsGood);

                return responseIsGood;
            }
            catch (Exception ex)
            {
                EsException e = new EsException("Error in :" + "CanVerifyTcpConnection", ex);
                //TODO: 
                EsEventManager.PublishEsEvent(EsEventSenderEnum.EsMountManager, EsMessagePriority.DebugInfo, "    Done Verify TCP Connection - Failure");

                return false;
            }

        }
        public bool CanVerifyUdpConnection(EsMount mount)
        {
            EsEventManager.PublishEsEvent(EsEventSenderEnum.EsMountManager, EsMessagePriority.DebugInfo, "    Start Verify UDP Connection");

            //Check Wireless first
            if (!CommunicationsManager.IsConnectedToWirelessNetwork())
            {
                EsEventManager.PublishEsEvent(EsEventSenderEnum.EsMountManager, EsMessagePriority.DebugInfo, "    End Verify UDP Connection - Failure. Not connected to a network");

                return false;
            }
            if (!CommunicationsManager.ConnectedSsid().Contains("PMC"))
            {
                EsEventManager.PublishEsEvent(EsEventSenderEnum.EsMountManager, EsMessagePriority.DebugInfo, "    End Verify UDP Connection - Failure. Not connected to a PMC network");

                return false;
            }
            bool versionGood = false;
            try
            {
                string result = CommunicationsManager.SendUdpMessage(mount.ConnectionSettings.IpAddr,
                                                                     mount.ConnectionSettings.IpPort, UDP_QUERY);

                versionGood = result.Contains(UDP_RESPONSE);
                EsEventManager.PublishEsEvent(EsEventSenderEnum.EsMountManager, EsMessagePriority.DebugInfo, "     End Verify UDP Connection: " + versionGood);

                return versionGood;
            }
            catch (Exception ex)
            {

                EsException e = new EsException("Error in :" + "CanVerifyUdpConnection", ex);
                //TODO:
                EsEventManager.PublishEsEvent(EsEventSenderEnum.EsMountManager, EsMessagePriority.DebugInfo, "    End Verify UDP Connection - Failure. ERROR");

                return false;
            }
        }
        public bool CanVerifySerialConnection(EsMount mount)
        {
            EsEventManager.PublishEsEvent(EsEventSenderEnum.EsMountManager, EsMessagePriority.DebugInfo, "    Start Very Serial Connection");

            string[] ports = SerialPort.GetPortNames();
            bool responseIsGood = false;
            if (ports.Rank > 0 && mount.ConnectionSettings.SerPort != null)
            {

                try
                {
                    string result = CommunicationsManager.SendSerialMessage(mount.ConnectionSettings.SerPort, SERIAL_QUERY);
                    responseIsGood = result.Contains(SERIAL_RESPONSE);
                }
                catch (Exception ex)
                {
                    EsException e = new EsException("Error in :" + "CanVerifySerialConnection", ex);
                    throw e;
                }

            }
            EsEventManager.PublishEsEvent(EsEventSenderEnum.EsMountManager, EsMessagePriority.DebugInfo, "    End  Very Serial Connection: " + responseIsGood);

            return responseIsGood;
        }


        #endregion

        #region Change Connection
        private EsMount ConvertToTCPConnectedMount(EsMount mount)
        {
            string ipAddr = mount.ConnectionSettings.IpAddr;
            int ipPort = mount.ConnectionSettings.IpPort;
            string comPort = mount.ConnectionSettings.SerPort;
            if (mount == null)
            {
                throw new EsException("The mount must be connected before its connection can be changed");
            }
            if (mount.ConnectionSettings.IsConnected == ConnectionEnum.NONE)
            {
                throw new EsException("The mount must be connected before its connection can be changed");

            }
            if (mount.ConnectionSettings.IsConnected == ConnectionEnum.TCP)
            {
                throw new EsException("The mount is already in Wireless ASCOM (TCP) mode");

            }
            if (mount.ConnectionSettings.IsConnected == ConnectionEnum.Serial)
            {
                CommunicationsManager.SendSerialMessage(comPort, "ESX!");
            }
            if (mount.ConnectionSettings.IsConnected == ConnectionEnum.UDP)
            {
                CommunicationsManager.SendUdpMessage(ipAddr, ipPort, "ESY!");
            }
            //TODO: verify its now on tcp
            mount.ConnectionSettings.IsConnected = ConnectionEnum.TCP;
            return mount;
        }
        private EsMount ConvertToUDPConnectedMount(EsMount mount)
        {
            string ipAddr = mount.ConnectionSettings.IpAddr;
            int ipPort = mount.ConnectionSettings.IpPort;
            string comPort = mount.ConnectionSettings.SerPort;
            if (mount == null)
            {
                throw new EsException("The mount must be connected before its connection can be changed");
            }
            if (mount.ConnectionSettings.IsConnected == ConnectionEnum.NONE)
            {
                throw new EsException("The mount must be connected before its connection can be changed");

            }
            if (mount.ConnectionSettings.IsConnected == ConnectionEnum.UDP)
            {
                throw new EsException("The mount is already in ExploreStars (UDP) mode");

            }
            if (mount.ConnectionSettings.IsConnected == ConnectionEnum.Serial)
            {
                CommunicationsManager.SendSerialMessage(comPort, "ESX!");  //TODO: verify its now on tcp
                Thread.Sleep(250);
                mount.ConnectionSettings.IsConnected = ConnectionEnum.TCP;
            }
            if (mount.ConnectionSettings.IsConnected == ConnectionEnum.TCP)
            {
                CommunicationsManager.SendTcpMessage(ipAddr, ipPort, "ESY!");
                mount.ConnectionSettings.IsConnected = ConnectionEnum.UDP;
            }
            return mount;
        }
        private EsMount ConvertToSerialPConnectedMount(EsMount mount)
        {

            if (mount == null)
            {
                throw new EsException("The mount must be connected before its connection can be changed");
            }
            if (mount.ConnectionSettings.IsConnected == ConnectionEnum.NONE)
            {
                throw new EsException("The mount must be connected before its connection can be changed");
            }
            if (mount.ConnectionSettings.IsConnected == ConnectionEnum.Serial)
            {
                throw new EsException("The mount is already in ASCOM (serial) mode");
            }
            string ipAddr = mount.ConnectionSettings.IpAddr;
            int ipPort = mount.ConnectionSettings.IpPort;
            //If it is in udp ,ode, switch it to tcp
            if (mount.MountModel == MountModelEnum.iXos100 && mount.ConnectionSettings.IsConnected == ConnectionEnum.UDP)
            {
                CommunicationsManager.SendUdpMessage(ipAddr, ipPort, "ESY!");
            }
            //switch it to serial
            CommunicationsManager.SendTcpMessage(ipAddr, ipPort, "ESX!");

            //TODO: verify its now on serial
            mount.ConnectionSettings.IsConnected = ConnectionEnum.Serial;
            return mount;
        }

        public EsMount ChangeMountConnection(EsMount mount, ConnectionEnum newConnection)
        {
            EsMount result = null;
            switch (newConnection)
            {
                case ConnectionEnum.TCP:
                    result = ConvertToTCPConnectedMount(mount);
                    break;
                case ConnectionEnum.UDP:
                    result = ConvertToUDPConnectedMount(mount);
                    break;
                case ConnectionEnum.Serial:
                    result = ConvertToSerialPConnectedMount(mount);
                    break;
                case ConnectionEnum.NONE:
                    break;
                default:
                    break;
            }
            return result;
        }
        #endregion


    }
}

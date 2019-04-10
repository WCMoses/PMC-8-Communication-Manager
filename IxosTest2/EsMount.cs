using System;

namespace IxosTest2
{
 



    public class EsMount
    {
        public MountModelEnum MountModel { get; set; }
        public MountConnectionSettings ConnectionSettings { get; set; }
        public EsMount()
        {
            MountModel = MountModelEnum.NotSet;
            ConnectionSettings = new MountConnectionSettings();
        }

    }

    public class MountConnectionSettings
    {
        public string IpAddr { get; set; }
        public int IpPort { get; set; }
        public string SerPort { get; set; }
        public ConnectionEnum IsConnected { get; set; }

        public MountConnectionSettings()
        {
            IsConnected = ConnectionEnum.NONE;
        }

    }
    public enum ConnectionEnum
    {
        TCP,
        UDP,
        Serial,
        NONE
    }

    public enum MountModelEnum
    {
        iXos100,
        Xos2,
        g11,
        NotSet
    }

}
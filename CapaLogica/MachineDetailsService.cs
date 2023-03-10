using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net;

namespace CapaLogica
{
    public  class MachineDetailsService
    {
        string CurrentMachineMacAddres = "";
        string CurrentMachineIp = "";
        NetworkInterface NetInfo;
        PhysicalAddress ObjMacAddress;
        IPAddress ObjIpAddress;

        public MachineDetailsService()
        {
            NetInfo = NetworkInterface.GetAllNetworkInterfaces()
            .FirstOrDefault(n => n.OperationalStatus == OperationalStatus.Up 
            && n.NetworkInterfaceType != NetworkInterfaceType.Loopback);
        }



        public string GetMacAddressMachine()
        {
            ObjMacAddress = NetInfo.GetPhysicalAddress();
            CurrentMachineMacAddres = BitConverter.ToString(ObjMacAddress.GetAddressBytes());
            return CurrentMachineMacAddres;

        }

        public string GetIpAddressMachine()
        {
            ObjIpAddress = NetInfo.GetIPProperties()
                .UnicastAddresses
                .FirstOrDefault(Ip => Ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?.Address;

            CurrentMachineIp = ObjIpAddress?.ToString() ?? "null";
            return CurrentMachineIp;

        }



    }
}

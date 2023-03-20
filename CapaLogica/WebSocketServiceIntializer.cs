using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using CapaModelo.Request;
using CapaModelo.Response;
using CapaModelo.Common;
using Newtonsoft.Json;

namespace CapaLogica
{
    public class WebSocketServiceIntializer
    {
        MachineDetailsService MachineDetails;
        WebSocket LanCenterWebSocket;
        string WebSocketUrl = "";

        public WebSocketServiceIntializer()
        {
            Init();
            
        }

       void Init()
        {
            MachineDetails = new MachineDetailsService();

            WebSocketUrl = BuildUrlConnection();
            LanCenterWebSocket = new WebSocket(WebSocketUrl);
        }

       

        public void InitLanWebSocket()
        {
            LanCenterWebSocket.Connect();
            LanCenterWebSocket.Send(GetJsonStringFromObject(BuildRequest()));
            
        }
       public WebSocket GetWebSockInstance()
        {
            return LanCenterWebSocket;
        }

        public void SendMessageToServer(string Message)
        {
            LanCenterWebSocket.Send(Message);
        }

        public void SendMessageToServer(byte[] MessageBytes)
        {
            LanCenterWebSocket.Send(MessageBytes);
        }

        private string BuildUrlConnection()
        {
            return WebSocketConstants.WEB_SOCKET_URL +
                WebSocketConstants.CLIENTE_ID_PARAM +
                MachineDetails.GetMacAddressMachine();

        }
        WebSocketRequest BuildRequest()
        {
            return new WebSocketRequest()
            {
                IdMachine = 1,
                IpMachine = MachineDetails.GetIpAddressMachine(),
                MacAddress = MachineDetails.GetMacAddressMachine()
            };
        }

        string GetJsonStringFromObject(WebSocketRequest Req)
        {
            return JsonConvert.SerializeObject(Req);

        }

         string ConvertTiemEndObjToString(TimeEndRequest req)
        {
            return JsonConvert.SerializeObject(req);
        }

        public void SendTimeEndToServer()
        {
            SendMessageToServer(
                ConvertTiemEndObjToString(
                    new TimeEndRequest() 
                    {
                        macAddres = MachineDetails.GetMacAddressMachine(),

                        isTimeEnd = true
                    }
                    )
                );
        }
       

    }
}

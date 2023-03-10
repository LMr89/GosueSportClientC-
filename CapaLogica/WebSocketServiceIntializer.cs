using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using CapaModelo.Common;

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
            LanCenterWebSocket = new WebSocket(WebSocketUrl);
        }


        public void InitLanWebSocket()
        {
            LanCenterWebSocket.Connect();
            
        }

        public void SendMessageToServer(string Message)
        {
            LanCenterWebSocket.Send(Message);
        }

        public void SendMessageToServer(byte[] MessageBytes)
        {
            LanCenterWebSocket.Send(MessageBytes);
        }
    }
}

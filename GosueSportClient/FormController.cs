using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CapaLogica;
using WebSocketSharp;

namespace GosueSportClient
{
    public class FormController
    {
        //Obj Clases formularios 
        BlockScreen blockScreenLanForm;
        TimeCounterForm TimeCounterLanForm;
         WebSocketServiceIntializer WebSockInit;
        bool IsConnected;


        public FormController(BlockScreen blockScreen, TimeCounterForm timeCounterForm)
        {
            blockScreenLanForm = blockScreen;
            TimeCounterLanForm = timeCounterForm;
            WebSockInit = new WebSocketServiceIntializer();
            InitConnectionWithServer();
            IsConnected = false;
        }


        void InitConnectionWithServer()
        {
            WebSockInit.InitLanWebSocket();
            WebSockInit.GetWebSockInstance().OnMessage += FormControllOnMessageHandler;
            WebSockInit.GetWebSockInstance().OnClose += FormController_OnClose;
            WebSockInit.GetWebSockInstance().OnError += FormController_OnError;
            WebSockInit.GetWebSockInstance().OnOpen += FormController_OnOpen;
            

        }

        private void FormController_OnOpen(object sender, EventArgs e)
        {
            IsConnected = true;
        }

        private void FormController_OnError(object sender, ErrorEventArgs e)
        {
            IsConnected = false;
        }

        private void FormController_OnClose(object sender, CloseEventArgs e)
        {

            while (!IsConnected) // Conexion cerrada
            {
                Thread.Sleep(5000);
                WebSockInit.InitLanWebSocket();

            }
            
        }

        private void FormControllOnMessageHandler(object sender, MessageEventArgs e)
        {
            MessageBox.Show(e.Data);
           
            
        }

        private void OnMessageWebSocketHandler(object sender, MessageEventArgs message)
        {
            throw new NotImplementedException();
        }

        
    }
}

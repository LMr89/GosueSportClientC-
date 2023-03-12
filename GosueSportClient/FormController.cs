using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CapaLogica;
using CapaModelo.Response;
using Newtonsoft.Json;
using WebSocketSharp;

namespace GosueSportClient
{
    public class FormController : OnNotificateCounterEnd
    {
        //Obj Clases formularios 
        BlockScreen blockScreenLanForm;
        TimeCounterForm TimeCounterLanForm;
         WebSocketServiceIntializer WebSockInit;
        ActionResponse Response;
        bool IsConnected;
        bool IsBlockFormShown;
        bool IsCounterTimeShow;


        public FormController(BlockScreen blockScreen, TimeCounterForm timeCounterForm)
        {
            blockScreenLanForm = blockScreen;
            TimeCounterLanForm = timeCounterForm;
            WebSockInit = new WebSocketServiceIntializer();
            InitConnectionWithServer();
            IsConnected = false;

            
            IsBlockFormShown = true;
            IsCounterTimeShow = false;
            TimeCounterLanForm.Notificator = this;


            blockScreen.Show();
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
            Response = null;
            Response = JsonConvert.DeserializeObject<ActionResponse>(e.Data);
            Console.WriteLine(e.Data);
            StartFormFromAction(Response);
           
            
        }



        void StartFormFromAction(ActionResponse Resp)
        {
            if (Resp.tipeAction ==  ((int)TipeAction.LOCK_MACHINE) && IsCounterTimeShow)
            {
                ThreadSafe(() =>
                {
                    TimeCounterLanForm.Hide();
                    blockScreenLanForm.Show();
                    IsBlockFormShown = true;
                }, TimeCounterLanForm);

            }

            if(Resp.tipeAction == ((int) TipeAction.RUN_TIME ) && IsBlockFormShown)
            {
                Console.WriteLine("Se iniciara el bloqueo formulario");
                ThreadSafe(() =>
               {
                   blockScreenLanForm.Hide();

                   TimeCounterLanForm.AllMinutos = Resp.rentedTime;
                   TimeCounterLanForm.Show();
                   IsBlockFormShown = false;
               }, blockScreenLanForm);

                
            }
        }
        public void ThreadSafe(Action callback, Form form)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.RunWorkerCompleted += (obj, e) =>
            {
                if (form.InvokeRequired)
                    form.Invoke(callback);
                else
                    callback();
            };
            worker.RunWorkerAsync();
        }

        public void OnNotifiedCounterCompleted()
        {
            ThreadSafe(() =>
            {
                Thread.Sleep(2000);
                TimeCounterLanForm.Hide();
                blockScreenLanForm.Show();
                IsBlockFormShown = true;
            }, blockScreenLanForm);

        }
    }
}

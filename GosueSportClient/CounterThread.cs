using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GosueSportClient
{
     public class CounterThread 
    {
        private Thread HiloContador;
        private Label LblCounter;
        private StringBuilder StringBuilder;
        public int Hora { get; set; }
        public int Minutos { get; set; }


        public CounterThread(Label LblCoun)
        {
            LblCounter = LblCoun;
            StringBuilder = new StringBuilder();
        }

        public void ArmarContador()
        {
            HiloContador = null;
            HiloContador = new Thread(new ThreadStart(DisminuirTiempo));
        }


        public void ComenzarContador()
        {
            HiloContador.Start();
        }
        public void DetenerContadorAlFuerza()
        {
            HiloContador.Abort();
        }

        public void JuntarContadorConElHiloPrincipal()
        {
            HiloContador.Join();
        }


        void DisminuirTiempo()
        {
            LblCounter.Invoke((MethodInvoker)delegate
            {
                StringBuilder.Clear();

                while (Hora != 0 || Minutos != 0)
                {

                    if (Minutos != 0)
                    {
                        Minutos -= 1;
                        Thread.Sleep(60000); // equivale a un minuto
                                             //continue;
                    }
                    if (Hora == 1)
                    {
                        Hora -= 1;
                        Minutos = 59;
                        //continue;
                    }
                    StringBuilder.Append(Hora.ToString("D2"))
                        .Append(":")
                        .Append(Minutos.ToString("D2"));

                    LblCounter.Text = StringBuilder.ToString();
                }




            });


            

        }


    }
}

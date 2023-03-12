using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GosueSportClient
{
    public partial class TimeCounterForm : Form
    {


        int Hora;
        int Minutos;
        int Segundos;

        int TiempoTotalEnSegundos;

        public int AllMinutos { get; set; }
        private StringBuilder StringBuilder;

        public OnNotificateCounterEnd Notificator { set; get; }

       


        public TimeCounterForm()
        {
            InitializeComponent();
            StringBuilder = new StringBuilder();
            Segundos = 59;
            LocateForm();
        }

        

        private void TimeCounterForm_Load(object sender, EventArgs e)
        {
            EjecutarProcesoPrincipal();

        }


        void EjecutarProcesoPrincipal()
        {
            Console.WriteLine("Minutos llegados : " + AllMinutos);
            TiempoTotalEnSegundos = AllMinutos * 60;

            Hora = TiempoTotalEnSegundos / 3600;
            Minutos = (TiempoTotalEnSegundos % 3600) / 60;
            Segundos = TiempoTotalEnSegundos % 60;

            string HorasYMinutosForUser = Hora.ToString("D2") + ":" +
                    Minutos.ToString("D2");

            TxtTiempoAlquilado.Text = HorasYMinutosForUser;
            TimeContador.Enabled = true;
            TimeContador.Start();

        }

        void LocateForm()
        {
            this.StartPosition = FormStartPosition.Manual;

            var screenSize = Screen.PrimaryScreen.WorkingArea.Size;

            this.Location = new Point(screenSize.Width - this.Width, 0);
        }

        private void PcbMinimize_Click(object sender, EventArgs e)
        {
            NtfIcon.ShowBalloonTip(1);
            this.Hide();
        }

        private void mostrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        

        private void TimeCounterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void TimeContador_Tick(object sender, EventArgs e)
        {
            

            TiempoTotalEnSegundos--;
            Segundos--;


            if (Segundos < 0)
            {
                Segundos = 59;
                Minutos--;
            }

            // Si los minutos llegan a cero, restablecer a 59 y decrementar las horas
            if (Minutos < 0)
            {
                Minutos = 59;
                Hora--;
            }


            if (Minutos == 0 && Hora == 0 && Segundos == 0)
            {
                TimeContador.Enabled = false;
                TimeContador.Stop();
                TxtTiempoRestante.Text = " Tiempo terminado";
                Notificator.OnNotifiedCounterCompleted();
               

            }
            TxtTiempoRestante.Text = "";
            StringBuilder.Clear();
            StringBuilder.Append(Hora.ToString("D2"))
                       .Append(":")
                       .Append(Minutos.ToString("D2"))
                       .Append(":")
                       .Append(Segundos.ToString("D2"));

            TxtTiempoRestante.Text = StringBuilder.ToString();
            Console.WriteLine(StringBuilder.ToString());




        }

        private void TimeCounterForm_Activated(object sender, EventArgs e)
        {
            EjecutarProcesoPrincipal();
        }

        private void TimeCounterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}

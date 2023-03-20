using System;
using System.Drawing;
using System.Text;
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
        private TimeCounterManager TimeCounterManager;
        public OnNotificateCounterEnd Notificator { set; get; }

       


        public TimeCounterForm()
        {
            TimeCounterManager = new TimeCounterManager();
            TimeCounterManager.Tick += TimeCounterManager_Tick;
            TimeCounterManager.isTimeCounterRunning = false;
            InitializeComponent();
            StringBuilder = new StringBuilder();
            Segundos = 59;
            LocateForm();
        }

        private void TimeCounterManager_Tick(object sender, EventArgs e)
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
                TimeCounterManager.StopTimeCounter();
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

        private void TimeCounterForm_Load(object sender, EventArgs e)
        {
            EjecutarProcesoPrincipal();

        }

        public void StopTimer()
        {
            /*
             
             TimeContador.Enabled = false;
            TimeContador.Stop();*/
            TimeCounterManager.StopTimeCounter();
        }

        void EjecutarProcesoPrincipal()
        {
            if (!TimeCounterManager.isTimeCounterRunning)
            {
                Console.WriteLine("Minutos llegados : " + AllMinutos);
                TiempoTotalEnSegundos = AllMinutos * 60;

                Hora = TiempoTotalEnSegundos / 3600;
                Minutos = (TiempoTotalEnSegundos % 3600) / 60;
                Segundos = TiempoTotalEnSegundos % 60;

                string HorasYMinutosForUser = Hora.ToString("D2") + ":" +
                        Minutos.ToString("D2");

                TxtTiempoAlquilado.Text = HorasYMinutosForUser;
                TimeCounterManager.StartCounter();
                TimeCounterManager.isTimeCounterRunning = true;
            }

            

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
            TimeCounterManager.isTimeCounterRunning = true;
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

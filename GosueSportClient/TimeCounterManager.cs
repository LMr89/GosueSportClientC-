using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GosueSportClient
{
    public class TimeCounterManager
    {
        private Timer TimeCounter;
        private readonly int TIME_INTERVAL = 1000;
        public bool isTimeCounterRunning { get; set; }

        public TimeCounterManager()
        {
            TimeCounter = new Timer();
            TimeCounter.Interval = TIME_INTERVAL;
            TimeCounter.Enabled = true;
            TimeCounter.Tick += TimeCounter_TickHandler;
        }

        public event EventHandler Tick;

        private void TimeCounter_TickHandler(object sender, EventArgs e)
        {
            Tick?.Invoke(sender, e);
           
        }

        public void StopTimeCounter()
        {
            TimeCounter.Enabled = false;
            TimeCounter.Stop();
            isTimeCounterRunning = false;
        }

        public void StartCounter()
        {
            if (!isTimeCounterRunning)
            {
                TimeCounter.Enabled = true;
                TimeCounter.Start();
                isTimeCounterRunning = true;
            }
        }

    }
}

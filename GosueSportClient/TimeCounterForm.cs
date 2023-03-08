using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GosueSportClient
{
    public partial class TimeCounterForm : Form
    {
        public TimeCounterForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TimeCounterForm_Load(object sender, EventArgs e)
        {

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
    }
}

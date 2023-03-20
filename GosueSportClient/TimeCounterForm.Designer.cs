
namespace GosueSportClient
{
    partial class TimeCounterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeCounterForm));
            this.PcbMinimize = new System.Windows.Forms.PictureBox();
            this.PcbIcon = new System.Windows.Forms.PictureBox();
            this.GbTiempo = new System.Windows.Forms.GroupBox();
            this.TxtNegocio = new System.Windows.Forms.Label();
            this.TxtTiempoRestante = new System.Windows.Forms.Label();
            this.TxtTitRestante = new System.Windows.Forms.Label();
            this.TxtTiempoAlquilado = new System.Windows.Forms.Label();
            this.TxtTitAlquilado = new System.Windows.Forms.Label();
            this.NtfIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.CmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeContador = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PcbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbIcon)).BeginInit();
            this.GbTiempo.SuspendLayout();
            this.CmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // PcbMinimize
            // 
            this.PcbMinimize.Image = global::GosueSportClient.Properties.Resources.minimize;
            this.PcbMinimize.Location = new System.Drawing.Point(245, 10);
            this.PcbMinimize.Name = "PcbMinimize";
            this.PcbMinimize.Size = new System.Drawing.Size(24, 22);
            this.PcbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbMinimize.TabIndex = 1;
            this.PcbMinimize.TabStop = false;
            this.PcbMinimize.Click += new System.EventHandler(this.PcbMinimize_Click);
            // 
            // PcbIcon
            // 
            this.PcbIcon.Image = global::GosueSportClient.Properties.Resources.dragonIcon;
            this.PcbIcon.Location = new System.Drawing.Point(12, 6);
            this.PcbIcon.Name = "PcbIcon";
            this.PcbIcon.Size = new System.Drawing.Size(25, 26);
            this.PcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbIcon.TabIndex = 0;
            this.PcbIcon.TabStop = false;
            // 
            // GbTiempo
            // 
            this.GbTiempo.Controls.Add(this.TxtNegocio);
            this.GbTiempo.Controls.Add(this.TxtTiempoRestante);
            this.GbTiempo.Controls.Add(this.TxtTitRestante);
            this.GbTiempo.Controls.Add(this.TxtTiempoAlquilado);
            this.GbTiempo.Controls.Add(this.TxtTitAlquilado);
            this.GbTiempo.ForeColor = System.Drawing.Color.Red;
            this.GbTiempo.Location = new System.Drawing.Point(12, 38);
            this.GbTiempo.Name = "GbTiempo";
            this.GbTiempo.Size = new System.Drawing.Size(257, 112);
            this.GbTiempo.TabIndex = 2;
            this.GbTiempo.TabStop = false;
            this.GbTiempo.Text = "Tiempo";
            // 
            // TxtNegocio
            // 
            this.TxtNegocio.AutoSize = true;
            this.TxtNegocio.Location = new System.Drawing.Point(63, 86);
            this.TxtNegocio.Name = "TxtNegocio";
            this.TxtNegocio.Size = new System.Drawing.Size(129, 13);
            this.TxtNegocio.TabIndex = 4;
            this.TxtNegocio.Text = "GOSUESPORTS ARENA";
            // 
            // TxtTiempoRestante
            // 
            this.TxtTiempoRestante.Location = new System.Drawing.Point(114, 54);
            this.TxtTiempoRestante.Name = "TxtTiempoRestante";
            this.TxtTiempoRestante.Size = new System.Drawing.Size(137, 20);
            this.TxtTiempoRestante.TabIndex = 3;
            this.TxtTiempoRestante.Text = "-----------------";
            // 
            // TxtTitRestante
            // 
            this.TxtTitRestante.AutoSize = true;
            this.TxtTitRestante.Location = new System.Drawing.Point(18, 54);
            this.TxtTitRestante.Name = "TxtTitRestante";
            this.TxtTitRestante.Size = new System.Drawing.Size(91, 13);
            this.TxtTitRestante.TabIndex = 2;
            this.TxtTitRestante.Text = "Tiempo Restante:";
            // 
            // TxtTiempoAlquilado
            // 
            this.TxtTiempoAlquilado.Location = new System.Drawing.Point(116, 25);
            this.TxtTiempoAlquilado.Name = "TxtTiempoAlquilado";
            this.TxtTiempoAlquilado.Size = new System.Drawing.Size(108, 20);
            this.TxtTiempoAlquilado.TabIndex = 1;
            this.TxtTiempoAlquilado.Text = "-----------------";
            // 
            // TxtTitAlquilado
            // 
            this.TxtTitAlquilado.AutoSize = true;
            this.TxtTitAlquilado.Location = new System.Drawing.Point(18, 25);
            this.TxtTitAlquilado.Name = "TxtTitAlquilado";
            this.TxtTitAlquilado.Size = new System.Drawing.Size(91, 13);
            this.TxtTitAlquilado.TabIndex = 0;
            this.TxtTitAlquilado.Text = "Tiempo Alquilado:";
            // 
            // NtfIcon
            // 
            this.NtfIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NtfIcon.BalloonTipText = "Sigue disfrutando";
            this.NtfIcon.BalloonTipTitle = "GosuEsports Arena";
            this.NtfIcon.ContextMenuStrip = this.CmsOptions;
            this.NtfIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NtfIcon.Icon")));
            this.NtfIcon.Text = "NotProgram";
            this.NtfIcon.Visible = true;
            // 
            // CmsOptions
            // 
            this.CmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarProgramaToolStripMenuItem});
            this.CmsOptions.Name = "CmsOptions";
            this.CmsOptions.Size = new System.Drawing.Size(171, 26);
            // 
            // mostrarProgramaToolStripMenuItem
            // 
            this.mostrarProgramaToolStripMenuItem.Name = "mostrarProgramaToolStripMenuItem";
            this.mostrarProgramaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.mostrarProgramaToolStripMenuItem.Text = "Mostrar Programa";
            this.mostrarProgramaToolStripMenuItem.Click += new System.EventHandler(this.mostrarProgramaToolStripMenuItem_Click);
            // 
            // TimeContador
            // 
            this.TimeContador.Interval = 1000;
            this.TimeContador.Tick += new System.EventHandler(this.TimeContador_Tick);
            // 
            // TimeCounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(280, 162);
            this.Controls.Add(this.GbTiempo);
            this.Controls.Add(this.PcbMinimize);
            this.Controls.Add(this.PcbIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TimeCounterForm";
            this.ShowInTaskbar = false;
            this.Text = "TimeCounterForm";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.TimeCounterForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeCounterForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimeCounterForm_FormClosed);
            this.Load += new System.EventHandler(this.TimeCounterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbIcon)).EndInit();
            this.GbTiempo.ResumeLayout(false);
            this.GbTiempo.PerformLayout();
            this.CmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbIcon;
        private System.Windows.Forms.PictureBox PcbMinimize;
        private System.Windows.Forms.GroupBox GbTiempo;
        private System.Windows.Forms.Label TxtTiempoRestante;
        private System.Windows.Forms.Label TxtTitRestante;
        private System.Windows.Forms.Label TxtTiempoAlquilado;
        private System.Windows.Forms.Label TxtTitAlquilado;
        private System.Windows.Forms.Label TxtNegocio;
        private System.Windows.Forms.NotifyIcon NtfIcon;
        private System.Windows.Forms.ContextMenuStrip CmsOptions;
        private System.Windows.Forms.ToolStripMenuItem mostrarProgramaToolStripMenuItem;
        private System.Windows.Forms.Timer TimeContador;
    }
}
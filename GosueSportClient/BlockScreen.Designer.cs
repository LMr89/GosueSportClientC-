
namespace GosueSportClient
{
    partial class BlockScreen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlockScreen));
            this.BlockPictureBox = new System.Windows.Forms.PictureBox();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BlockPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BlockPictureBox
            // 
            this.BlockPictureBox.Image = global::GosueSportClient.Properties.Resources.GosueBlockScreen;
            this.BlockPictureBox.Location = new System.Drawing.Point(-3, 0);
            this.BlockPictureBox.Name = "BlockPictureBox";
            this.BlockPictureBox.Size = new System.Drawing.Size(863, 551);
            this.BlockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BlockPictureBox.TabIndex = 0;
            this.BlockPictureBox.TabStop = false;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "GosueBlockScreen.png");
            // 
            // BlockScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 491);
            this.Controls.Add(this.BlockPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "BlockScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.BlockPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BlockPictureBox;
        private System.Windows.Forms.ImageList ImageList;
    }
}


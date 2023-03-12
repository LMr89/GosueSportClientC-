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
    public partial class BlockScreen : Form
    {

        Rectangle ScreenDimension = Screen.PrimaryScreen.Bounds;
        public BlockScreen()
        {
            InitializeComponent();

            BackColor = Color.Black;
           
             
            Width = ScreenDimension.Width;
            Height = ScreenDimension.Height;
            BlockPictureBox.Width = ScreenDimension.Width;
            BlockPictureBox.Height = ScreenDimension.Height;
             


            Image ImgResized = resizeImage(Properties.Resources.GosueBlockScreen, ScreenDimension.Size);

            BlockPictureBox.Image = ImgResized;
           

            
        }

        private Image resizeImage(Image ImgToResize, Size Size)
        {
            return new Bitmap(ImgToResize, Size);
        }

        private void BlockScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void BlockScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}

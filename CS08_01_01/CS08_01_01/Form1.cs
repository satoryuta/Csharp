using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS08_01_01
{
    public partial class Form1 : Form
    {


        Image im;
        public Form1()
        {
            InitializeComponent();

            im = Image.FromFile(@"C:\Users\180598\Desktop\CS\CS画像\car.bmp");

            //this.Click += new EventHandler(fm_Click);
            // this.Paint += new PaintEventHandler(fm_Click);
        }

        private void fm_Click(object sender, EventArgs e)
        {
            
            im.RotateFlip(RotateFlipType.Rotate90FlipNone);
            this.Invalidate();
        }

        private void fm_Click(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            g.Clear(this.BackColor);
            g.DrawImage(im, 70, 50);
        }
    }
}

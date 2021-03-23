using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS08_02_03
{
    public partial class Form1 : Form
    {

        private Bitmap bm1, bm2;
        private int i;

        public Form1()
        {
            InitializeComponent();

            bm1 = new Bitmap(@"C:\Users\180598\Desktop\CS\CS画像\tea.jpg");
            bm2 = new Bitmap(@"C:\Users\180598\Desktop\CS\CS画像\tea.jpg");

            i = 0;
        }

        public void convert()
        {
            for (int x = 0; x < bm1.Width; x++)
            {
                for (int y = 0; y < bm1.Height; y++)
                {
                    Color c = bm1.GetPixel(x, y);
                    int rgb = c.ToArgb();
                    int a = (rgb >> 24) & 0xFF;
                    int r = (rgb >> 16) & 0xFF;
                    int g = (rgb >>  8) & 0xFF;
                    int b = (rgb >>  0) & 0xFF;

                    switch (i)
                    {
                        case 1:
                            r >>= 2; break;
                        case 2:
                            g >>= 2; break;
                        case 3:
                            b >>= 2; break;
                        case 4:
                            r >>= 1; break;
                        case 5:
                            g >>= 1; break;
                        case 6:
                            b >>= 1; break;

                    }
                    rgb = (a << 24) | (r << 16) | (g << 8) | (b << 0);

                    c = Color.FromArgb(rgb);

                    bm2.SetPixel(x,y,c);
                }
            }
        }




        private void Form1_Click(object sender, EventArgs e)
        {
            i++;
            if (i >= 7)
                i = 0;
            convert();
            this.Invalidate();
               
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(bm2,0,0,400,300);
        }
    }
}

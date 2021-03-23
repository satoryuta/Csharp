using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS08_02_04
{
    public partial class Form1 : Form
    {
        private List<Point> ls;
        public Form1()
        {

            InitializeComponent();
            ls = new List<Point>();

         }

        private void MouseEventHandler(object sender, MouseEventArgs e)
        {
            Point p = new Point();
            p.X = e.X;
            p.Y = e.Y;          
            ls.Add(p);
            this.Invalidate();


        }
        private void PaintEventHand(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen db = new Pen(Color.Black,1);
            foreach (Point p in ls)
            {
                g.DrawEllipse(db,p.X,p.Y,10,10);
            }
        }
    }
}

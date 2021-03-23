using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS09_01_04
{
    public partial class Form1 : Form
    {
        private List<Ball> ball;
        private Cart ct;
        private Image im;
        private int dx, dy;
        private bool isOver;
        private bool isIn;
        private Label lb;
        private int score;
        private Stopwatch stopwatch;
        private Random random;
        private int Dropcount = 0;
        private long oldAddTime = 0;
        Timer tm;

        public Form1()
        {
            InitializeComponent();

            this.Text = "サンプル";
            this.ClientSize = new Size(600, 300);
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            lb = new Label();
            lb.Font = new Font("SansSerif", 20, FontStyle.Bold);
            lb.AutoSize = true;
            lb.Anchor = AnchorStyles.None;
            lb.BackColor = Color.Transparent;
            lb.Text = "SCORE";
            lb.Parent = this;



            im = Image.FromFile(@"C:\Users\sator\OneDrive\デスクトップ\R02_前期_CS\CS画像\sky.bmp");

            isOver = false;
            isIn = false;

            stopwatch = new Stopwatch();
            stopwatch.Start();
            random = new Random();

            ball = new List<Ball>();

            Point blp = new Point(0, 0);
            Image bim = Image.FromFile(@"C:\Users\sator\OneDrive\デスクトップ\R02_前期_CS\CS画像\apple.png");

            ball.Point = blp;
            ball.Image = bim;

            dx = 4;
            dy = 4;

            ct = new Cart();

            Point ctp = new Point(this.ClientSize.Width / 2, this.ClientSize.Height - 80);
            Image cim = Image.FromFile(@"C:\Users\sator\OneDrive\デスクトップ\R02_前期_CS\CS画像\cart.png");

            ct.Point = ctp;
            ct.Image = cim;

            Timer tm = new Timer();
            tm.Interval = 100;
            tm.Start();

            this.Paint += new PaintEventHandler(fm_Paint);
            tm.Tick += new EventHandler(tm_Tick);

            this.KeyDown += new KeyEventHandler(fm_KeyDown);
        }
        public void fm_Paint(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawImage(im, 0, 0, im.Width, im.Height);

            Point blp = bl.Point;
            Image bim = bl.Image;

            g.DrawImage(bl.Image, blp.X, blp.Y, bim.Width, bim.Height);

            Point ctp = ct.Point;
            Image cim = ct.Image;
            g.DrawImage(ct.Image, ctp.X, ctp.Y, cim.Width, cim.Height);

            if (isOver == true)
            {
                Font f = new Font("SansSerif", 30);
                SizeF s = g.MeasureString("Game Over", f);

                float cx = (this.ClientSize.Width - s.Width) / 2;
                float cy = (this.ClientSize.Height - s.Height) / 2;

                g.DrawString("Game Over", f, new SolidBrush(Color.Blue), cx, cy);
            }
        }
        public void tm_Tick(Object sender, EventArgs e)
        {
            Point blp = bl.Point;
            Point ctp = ct.Point;

            Image bim = bl.Image;
            Image cim = ct.Image;

            if (blp.X < 0 || blp.X > this.ClientSize.Width - bim.Width) dx = -dx;
            if (blp.Y < 0) dy = -dy;
            if ((isIn == false) && (blp.X > ctp.X - bim.Width && blp.X < ctp.X + cim.Width)
                                    && (blp.Y > ctp.Y - bim.Height && blp.Y < ctp.Y - bim.Height / 2))
            {

                isIn = true;
                dy = -dy;
                score = score + 100;
                lb.Text = "SCORE" + score;
            }
            if (blp.Y < ctp.Y - bim.Height)
            {
                isIn = false;
            }
            if (blp.Y > this.ClientSize.Height)
            {
                isOver = true;
                Timer t = (Timer)sender;
                t.Stop();
            }

            blp.X = blp.X + dx;
            blp.Y = blp.Y + dy;

            bl.Point = blp;

            this.Invalidate();
        }



        public void fm_KeyDown(Object sender, KeyEventArgs e)
        {
            Point ctp = ct.Point;
            Image cim = ct.Image;

            if (e.KeyCode == Keys.Right)
            {
                ctp.X = ctp.X + 4;
                if (ctp.X > this.ClientSize.Width - cim.Width)
                    ctp.X = this.ClientSize.Width - cim.Width;
            }
            else if (e.KeyCode == Keys.Left)
            {
                ctp.X = ctp.X - 4;
                if (ctp.X < 0)
                    ctp.X = 0;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Application.Restart();
            }
            ct.Point = ctp;
            this.Invalidate();
        }
    }

    class Ball
    {
        public Image Image;
        public Point Point;
    }
    class Cart
    {
        public Image Image;
        public Point Point;
    }
}
    

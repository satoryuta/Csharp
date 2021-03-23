using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS09_01_01
{
    public partial class Form1 : Form
    {
        private TableLayoutPanel tlp;
        private CheckBox[] cb = new CheckBox[4];
        private Image cim;
        private Image[] mim = new Image[4];
        private PictureBox pb;
        private Label lb;
        private List<int> chkList;

        private int num;            //カードのマークをあらわす
        private bool isOpen;        //カードの表裏を表す

        public Form1()
        {
            InitializeComponent();

            

            var chkList = new List<int>();

            tlp = new TableLayoutPanel();
            tlp.Dock = DockStyle.Fill;
            tlp.ColumnCount = 4;
            tlp.RowCount = 2;

            for (int i = 0; i < cb.Length; i++)
            {
                mim[i] = Image.FromFile(@"C:\Users\180598\Desktop\CS\CS画像\mark" + i + ".bmp");
                cb[i] = new CheckBox();
                cb[i].Image = mim[i];
                cb[i].AutoSize = true;
                cb[i].Parent = tlp;
                cb[i].CheckedChanged += new EventHandler(CheckBox1_CheckedChanged);
            }

            cim = Image.FromFile(@"C:\Users\180598\Desktop\CS\CS画像\card.bmp");
            pb = new PictureBox();
            pb.Image = cim;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.Anchor = AnchorStyles.Right;
            pb.Parent = tlp;

            lb = new Label();
            lb.Font = new Font("SansSerif", 50, FontStyle.Bold);
            lb.AutoSize = true;
            lb.Anchor = AnchorStyles.None;
            lb.Parent = tlp;

            tlp.SetColumnSpan(pb, 2);
            tlp.SetColumnSpan(lb, 2);

            tlp.Parent = this;
            isOpen = false;
            Random rn = new Random();　      //カードのマークをランダムに決める
            num = rn.Next(4);

            pb.Click += new EventHandler(pb_Click);
        }
        public void pb_Click(Object sender, EventArgs e)　//カードをクリックした時
        {
            if (isOpen == false)//カードが裏であれば
            {
                isOpen = true;
                pb.Image = mim[num];
                if (cb[num].Checked == true)
                {
                    lb.ForeColor = Color.DeepPink;//あたりの処理
                    lb.Text = "HIT!";
                }
                else
                {
                    lb.ForeColor = Color.SlateBlue;//はずれの処理
                    lb.Text = "MISS!";
                }
            }
            else
            {
                isOpen = false;
                lb.Text = "";
                pb.Image = cim;
                Random rn = new Random();
                num = rn.Next(4);
            }
        }
        private void CheckBox1_CheckedChanged(Object sender, EventArgs e)
        {
            int checkedIndex = 0;
            for (int i = 0; i < cb.Length; i++)
            {
                if(cb[i] == (CheckBox)sender)
                {
                    if (((CheckBox)sender).Checked) chkList.Add(i);
                    checkedIndex = i;
                    break;
                }
            }
          
            if(chkList.Count >= 3 && cb[chkList[0]].Checked)
            {
                cb[chkList[0]].Checked = false;
                chkList.RemoveAt(0);
            }
            Console.WriteLine(((CheckBox)sender).Checked);
            //if (chkList.Count <= 2 && !(((CheckBox)sender).Checked))
            //{
            //    chkList.RemoveAt();
            //}

        }


    }
}


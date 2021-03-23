using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS07_07_16
{
    public partial class Form2 : Form
    {
        private string[] argumentValues; //Form1 から受け取った引数
        public string ReturnValue; //Form1 に返す戻り値

        public Form2(params string[] argumentValues)
        {
            //Form1 から受け取ったデータを Form2 インスタンスのメンバに格納
            this.argumentValues = argumentValues;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Form1 から送られてきたテキストを Form2 で表示
            textBox1.Text = argumentValues[0];
            string buton = argumentValues[1];

            if(textBox1.Text != null)
            {
                int len = textBox1.Text.Length;
                if(len >= 5)
                {
                    checkBox1.Checked = true;
                }

            }


            if (buton == "わんわん")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = @"C:\Users\画像\wan.jpg";
                checkBox2.Checked = true;
            }else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = @"C:\Users\画像\u-.jpg";
                checkBox3.Checked = true;
            }
            
            
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //戻り値をセット
            this.ReturnValue = textBox2.Text;
            this.Close();

        }
        static public string ShowMiniForm(params string[] s)
        {

            Form2 f = new Form2(s);
            
            f.ShowDialog();
            string receiveText = f.ReturnValue;
            f.Dispose();
            return receiveText;

        }
    }
}

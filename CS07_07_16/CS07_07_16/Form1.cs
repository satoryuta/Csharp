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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 に送るテキスト
            string sendText = textBox2.Text;
            string radiobutton = radioButton1.Text;
            if(!radioButton1.Checked)
            {
                 radiobutton = radioButton2.Text;
            }

          


            //Form2 から送られてきたテキストを受け取る。
            string receiveText = Form2.ShowMiniForm(sendText,radiobutton); //Form2 を開く
            
            
            //Form2 から受け取ったテキストを Form1 で表示させる。
            textBox1.Text = receiveText;


        }
    }
}

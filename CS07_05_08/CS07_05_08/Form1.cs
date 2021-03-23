using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS07_05_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tmp = (TextBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "" || textBox2.Text != "")
                {
                    
                    if(textBox1.Text != "" && textBox2.Text != "")
                    {
                        label1.Text = textBox1.Text + "と" + textBox2.Text + "を選びました";
                    }else
                    {
                        label1.Text = tmp.Text + "を選びました";
                    }
                }else
                {
                    label1.Text = "nullを選びました";
                }

            }



        }
    }
}

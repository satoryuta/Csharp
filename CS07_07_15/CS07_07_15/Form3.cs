using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS07_07_15
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tx1 = (TextBox)sender;

            if (e.KeyCode == Keys.Enter)
            {


                if (tx1.Text != "")
                {
                    double i = double.Parse(tx1.Text);



                    if (i == 1)
                    {
                        label1.Text = i + "ですね。";
                    }
                    else if(i == 2)
                    {
                        label1.Text = i + "ですね。";
                    }
                    else if(i == 3)
                    {
                        label1.Text = i + "ですね。";
                    }
                    else if(i == 4)
                    {
                        label1.Text = i + "ですね。";
                    }
                    else if(i == 5)
                    {
                        label1.Text = i + "ですね。";
                    }
                    else 
                    {
                        label1.Text = "成績が間違っています。１～５で入力してください";
                    }                  
                   
                }
                else
                {
                    label1.Text = "空欄です。成績を入力してください";
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button tx1 = (Button)sender;

            if (textBox1.Text != "")
            {
                this.Close();
            }else
            {
                label1.Text = "空欄です。成績を入力してください";
            }
            




                
        }
    }
}

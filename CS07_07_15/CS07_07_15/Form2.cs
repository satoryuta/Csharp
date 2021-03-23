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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tx1 = (TextBox)sender;

            

            if (e.KeyCode == Keys.Enter)//Enter押し
            {

                if (tx1.Text != "")//未入力時判定
                {
                    label1.Text = "正しい出席率を入力して下さい。";
                    label1.ForeColor = Color.Red;
                }


                var f1 = tx1.Text.All(char.IsDigit);     
                

                if (f1 == true)
                {
                    double i = double.Parse(tx1.Text);//数値に変換

                    if (i <= 100.0 && i >= 0)       //0%以上100.0%以下
                    {
                        i = Math.Truncate(i * 10);                     //切り捨て


                        label1.Text = i / 10 + "%ですね。";
                        label1.ForeColor = Color.Black;
                    }
                    else if (i < 0)
                    {

                        label1.Text = "値がマイナスです。正しい出席率を入力して下さい。";
                        label1.ForeColor = Color.Red;
                    }
                }
                else
                {
                    label1.Text = "数値のみを入力してください。";
                    label1.ForeColor = Color.Red;
                }
                                                                                                                         
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Button tx1 = (Button)sender;

           

            if (textBox1.Text != "")
            {
                float i = float.Parse(textBox1.Text);
                if (i <= 100.0 && i >= 0) 
                {
                    this.Close();
                }else{
                    label1.Text = "正しい出席率を入力して下さい。";
                    label1.ForeColor = Color.Red;
                }
                      
            }
            else{
                
                label1.Text = "正しい出席率を入力して下さい。";
                label1.ForeColor = Color.Red;
            }
                        
        }


    }
}

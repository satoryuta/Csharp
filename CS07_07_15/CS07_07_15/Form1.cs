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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            string[] str = { "天野敦", "五十嵐泉", "上田馬之助" };
            for (int i = 0; i < str.Length; i += 1)
            {
                listBox1.Items.Add(str[i]);
            }

            radioButton1.Checked = true;

        }



        private void button1_Click(object sender, EventArgs e)
        {

  
            if (radioButton2.Checked)
            {
                 new Form2().ShowDialog();
            }else 
            {
                new Form3().ShowDialog();
            }

            
             
          
              
        }


    }
}

              
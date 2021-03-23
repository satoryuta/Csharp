using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CS10_02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "テキストファイル|*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    /* StreamReader sr = new StreamReader(ofd.FileName, System.Text.Encoding.Default);
                     textBox1.Text = sr.ReadToEnd();
                     sr.Close();*/
                    ReadCsv(ofd);


                }
            }
            else if (sender == button2)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "テキストファイル|*.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);

                    System.IO.StringReader rs =
                        new System.IO.StringReader(textBox1.Text);

                    int NLcnt = 0;
                    while(rs.Peek() > -1)
                    {
                        var line = rs.ReadLine();

                        if (line.Length == 0)
                        {
                            if (NLcnt == 0)
                            {
                                sw.WriteLine();
                                NLcnt++;
                            }
                        }
                        else
                        {
                            sw.Write(line+",");
                            NLcnt = 0;
                        }
                    }


                    rs.Close();
                    sw.Close();
                }
            }
        }

        void ReadCsv(OpenFileDialog ofd)
        {
            try
            {
                using (StreamReader sr = new StreamReader(ofd.FileName, System.Text.Encoding.UTF8))
                {
                    textBox1.Text = "";
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] columns = line.Split(',');
                        foreach (string s in columns)
                        {
                            textBox1.Text += s + "\r\n";
                        }
                        textBox1.Text += "\r\n";
                    }
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
            }
        }



    }
}

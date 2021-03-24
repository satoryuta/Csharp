using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample4C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string HOST = "localhost";
        public static int PORT = 10000;

        private void button1_Click(object sender, EventArgs e)
        {
            TcpClient tc = new TcpClient(HOST, PORT);

            StreamReader sr = new StreamReader(tc.GetStream());
            String str = sr.ReadLine();
            textBox1.Text += str+"\r\n";
            //カレット位置を末尾に移動
            textBox1.SelectionStart = textBox1.Text.Length;
            //テキストボックスにフォーカスを移動
            textBox1.Focus();
            //カレット位置までスクロール
            textBox1.ScrollToCaret();


        }
    }
}

using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Sample4S { 

    class Sample4S
    {
        public static string HOST = "localhost";
        public static int PORT = 10000;
        public static void Main()
        {
            IPHostEntry ih = Dns.GetHostEntry(HOST);

            TcpListener tl = new TcpListener(ih.AddressList[0], PORT);
            tl.Start();

            Console.WriteLine("待機します。");
            while (true)
            {
                TcpClient tc = tl.AcceptTcpClient();
                StreamWriter sw = new StreamWriter(tc.GetStream());
                sw.WriteLine("こちらはサーバーです。" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);

                sw.Flush();
                sw.Close();
                tc.Close();
                
            }
        }
    }
}

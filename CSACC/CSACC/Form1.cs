using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Serialization;
namespace CSACC
{
    public partial class Form1 : Form
    {

        string strAccessConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CSDB.accdb"; 
        string strAccessSelect = "SELECT * FROM gakusei";

        public Form1()
        {
            InitializeComponent();


            

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            OleDbConnection myAccessConn = null;
            try
            {
                myAccessConn = new OleDbConnection(strAccessConn);
            }
            catch (Exception ex)
            {
                label1.Text = "Error: Failed connection. " + ex.Message;
                return;
            }
            try
            {
                OleDbCommand myAccessCommand = new OleDbCommand(strAccessSelect, myAccessConn);
                myAccessConn.Open();
                OleDbDataReader reader = myAccessCommand.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetDouble(5) <= double.Parse(textBox1.Text)) {
                        listBox1.Items.Add(reader.GetString(0) + "  " + reader.GetString(1) + reader.GetString(2) + reader.GetString(3) + " " + reader.GetString(4) + " " + reader.GetDouble(5));
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = "Error: Failed from the DataBase. " + ex.Message;
                return;
            }
            finally
            {
                myAccessConn.Close();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSACC2
{
    public partial class Form1 : Form
    {
        string strAccessConn= "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CSDB2.accdb";
        string strAccessSelect = "SELECT * FROM shohin";
        string strAccessWhere;
        string strAccessInsert;
        string strAccessUpdate;
        string strAccessDelete;


        OleDbConnection myAccessConn = null;

        public Form1()
        {
            InitializeComponent();
        }

         private void Render()
        {
            try
            {
                OleDbCommand myAccessCommand
                = new OleDbCommand(strAccessSelect, myAccessConn);
                myAccessConn.Open();
                OleDbDataReader reader = myAccessCommand.ExecuteReader();
                listBox1.Items.Clear();
                while (reader.Read())
                {
                    listBox1.Items.Add(
                    reader.GetValue(0) + " " + reader.GetString(1) + " " + reader.GetValue(2)
                   );

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



        private void button1_Click(object sender, EventArgs e)
        {
            label1.ResetText();
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
                /* 未使用 */
                if (textBox3.Text.Length != 0)
                {
                    strAccessWhere = " WHERE pro_price <= " + textBox3.Text;
                }
                else
                {
                    strAccessWhere = "";
                }
                /* 未使用 */
                OleDbCommand myAccessCommand
                = new OleDbCommand(strAccessSelect + strAccessWhere, myAccessConn);
                myAccessConn.Open();
                OleDbDataReader reader = myAccessCommand.ExecuteReader();
                listBox1.Items.Clear();
                while (reader.Read())
                {
                    listBox1.Items.Add(
                    reader.GetValue(0) + " " + reader.GetString(1)+ " "+ reader.GetValue(2)
                   );

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

        private void button2_Click(object sender, EventArgs e)
        {
            strAccessInsert = "INSERT INTO shohin(pro_code,pro_name,pro_price)"
                + " VALUES('" + textBox1.Text + "','"
                + textBox2.Text + "',"
                + textBox3.Text + ")";
            label2.Text = strAccessInsert;
            label1.ResetText();
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
                myAccessConn.Open();
                OleDbCommand cmd = new OleDbCommand(strAccessInsert, myAccessConn);
                cmd.ExecuteNonQuery();
                if (myAccessConn.State != ConnectionState.Closed)
                {
                    myAccessConn.Close();
                }
                Render();
            }
            catch (OleDbException ex)
            {
                if (ex.ErrorCode == -2147467259)
                {
                    label1.Text = "データの重複";
                }
                else
                {
                    label1.Text = ex.Message;
                }
            }
            catch (Exception ex)
            {
                this.Width = 400;
                label1.Text = ex.Message;
            }
            finally
            {
                if (myAccessConn.State != ConnectionState.Closed)
                {
                    myAccessConn.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != "" && textBox3.Text != "")
            {
                strAccessUpdate = "UPDATE shohin SET pro_name = '" + textBox2.Text + "' , pro_price =" + textBox3.Text + " ";
            }
            else if (textBox2.Text != "")
            {
                strAccessUpdate = "UPDATE shohin SET pro_name = '" + textBox2.Text + "'";
            }else if (textBox3.Text != "")
            {
                strAccessUpdate = "UPDATE shohin SET  pro_price =" + textBox3.Text + " ";
            }

            strAccessWhere = "WHERE pro_code = " + textBox1.Text;
            label2.Text = strAccessUpdate + strAccessWhere;
            label1.ResetText();
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
                if (textBox2.Text != "" && textBox3.Text != "")
            {
                strAccessUpdate = "UPDATE shohin SET pro_name = '" + textBox2.Text + "' , pro_price =" + textBox3.Text + " ";
            }
            else if (textBox2.Text != "")
            {
                strAccessUpdate = "UPDATE shohin SET pro_name = '" + textBox2.Text + "'";
            }else if (textBox3.Text != "")
            {
                strAccessUpdate = "UPDATE shohin SET  pro_price =" + textBox3.Text + " ";
            }
                myAccessConn.Open();
                OleDbCommand cmd = new OleDbCommand(strAccessUpdate + strAccessWhere, myAccessConn);
                cmd.ExecuteNonQuery();
                if (myAccessConn.State != ConnectionState.Closed)
                {
                    myAccessConn.Close();
                }
                Render();
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

        private void button4_Click(object sender, EventArgs e)
        {
            label1.ResetText();
            strAccessDelete = "DELETE FROM shohin WHERE pro_code = " + textBox1.Text;
            label2.Text = strAccessDelete;
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
                myAccessConn.Open();
                OleDbCommand cmd = new OleDbCommand(strAccessDelete,myAccessConn);
                cmd.ExecuteNonQuery();
                if (myAccessConn.State != ConnectionState.Closed)
                {
                    myAccessConn.Close();
                }
                Render();
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

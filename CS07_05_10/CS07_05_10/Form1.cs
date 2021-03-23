using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS07_05_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;
            label1.Text = mi.Text + "ですね";
            label1.Font = new Font("Arial", 8, FontStyle.Regular);
        }

        private void itarixtuku_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;
            label1.Text = mi.Text + "ですね";
            label1.Font = new Font("Arial", 8, FontStyle.Italic);
        }
    }
}

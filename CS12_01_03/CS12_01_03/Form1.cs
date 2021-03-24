using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS12_01_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class 担任 { public string クラス; public string 担任名; }

        class 学生 { public string クラス; public int 番号; public string 学生名; public int 出席率; }

        担任[] 担任表 = {
            new 担任() { クラス = "TE2A", 担任名 = "後藤みき" },
            new 担任() { クラス = "TE3A", 担任名 = "藤本まき" },
            new 担任() { クラス = "TE4A", 担任名 = "辻あさみ" },
            new 担任() { クラス = "TE5A", 担任名 = "雲丹ありさ" }
        };

        学生[] 学生表 = {
            new 学生() { クラス = "TE2A", 番号 = 1, 学生名 = "紺野こうた", 出席率 = 80 },
            new 学生() { クラス = "TE2A", 番号 = 2, 学生名 = "小川のぶ", 出席率 = 90 },
            new 学生() { クラス = "TE3A", 番号 = 1, 学生名 = "道重ゆう", 出席率 = 50 },
            new 学生() { クラス = "TE3A", 番号 = 2, 学生名 = "新垣たく", 出席率 = 70 },
            new 学生() { クラス = "TE4A", 番号 = 1, 学生名 = "田中さとみ", 出席率 = 80 },
            new 学生() { クラス = "TE4A", 番号 = 2, 学生名 = "髙橋あい", 出席率 = 100 }
        };

        private void button1_Click(object sender, EventArgs e)
        {
            IEnumerable qry = from sensei in 担任表
                              join seito in 学生表
                              on sensei.クラス equals seito.クラス into ss
                              from comb in ss.DefaultIfEmpty(new 学生()
                              {
                                  クラス = "なし",
                                  番号 = 0,
                                  学生名 = "在籍なし ",
                                  出席率 = 0
                              })
                              where comb.出席率 <= int.Parse(textBox1.Text)
                              orderby comb.クラス,comb.番号 ascending 
                              select new { comb.クラス, comb.番号, comb.学生名, comb.出席率, sensei.担任名 };

            foreach (var v in qry)
            {
                listBox1.Items.Add(v);

            }


        }
    }
}

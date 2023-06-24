using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerTester
{
    public partial class console : Form
    {
        public console()
        {
            //変数設定
            string Ver = "0.1.0";
            InitializeComponent();
            String r1 = "console Version is " + Ver;
            Loglist.Items.Add(r1);
        }

        private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Loglist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void コンソールについてToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String r1 = "=========[About this console]=========";
            String r2 = "This console was created by I.kaito";
            String r3 = "This software is a program that onl";
            String r4 = "y issues processed instructions.";
            Loglist.Items.Add(r1);
            Loglist.Items.Add(r2);
            Loglist.Items.Add(r3);
            Loglist.Items.Add(r4);
        }

        private void fwToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ログを10列追加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                for (int i = 0; i <= 10; i++)
            {
                String r = "debug:";

                String r1 = r + i.ToString();
                Loglist.Items.Add(r1);
            }
        }
    }
}

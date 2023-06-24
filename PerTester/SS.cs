using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PerTester.SplashScreen
{
    public partial class SpS : Form
    {
        public SpS()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1000;
            progressBar1.Value = 0;

            for (int i = 1; i <= 1000; i++)
            {
                System.Random rdom = new System.Random(1407);
                int r1 = rdom.Next(10);
                Thread.Sleep(r1);
                progressBar1.Value = i;

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}

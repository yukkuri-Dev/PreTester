using System.Runtime.CompilerServices;

namespace PerTester.SplashScreen
{
    public partial class SpS : Form
    {
        public SpS()
        {


            InitializeComponent();
            startLog.Items.Add("これはダミーです");
            startLog.Items.Add("だから開くボタンをおしてくださいな");



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

        private void startLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main Form1 = new Main();
            Form1.Show();
            
        }
    }
}

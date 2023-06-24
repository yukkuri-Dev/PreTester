using PerTester.SplashScreen;


namespace PerTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void aAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void callSplashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpS SS = new SpS();
            SS.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void タイトル変更ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Text = "AAA";

        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void 設定ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            developeroptionTool.Visible = true;

        }

        private void developeroptionTool_Click(object sender, EventArgs e)
        {

        }

        private void 開発者用オプションの非表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            developeroptionTool.Visible = false;

        }

        private void コンソールの表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            console console = new console();
            console.Show();
        }
    }
}

namespace PerTester
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (SeedCheckBox.Checked == true)
            {
                SeedVex.Enabled = false;
                SeedVex.Text = "3407";
            }
            else
            {
                SeedVex.Enabled = true;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.Text = FormRenamer.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Gen_Click(object sender, EventArgs e)
        {
            textBoxVex.Text = "";
            string q3;

            System.Random r = new System.Random(int.Parse(SeedVex.Text));
            int r2 = r.Next(0, 100);

            q3 = r2.ToString();
            textBoxVex.Text = q3;
        }
    }
}

namespace tpmodul12_2311104046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int nilai))
            {
                string hasil = CariTandaBilangan(nilai);
                label1.Text = hasil;
            }
            else
            {
                label1.Text = "Input tidak valid!";
            }
        }


    }
}
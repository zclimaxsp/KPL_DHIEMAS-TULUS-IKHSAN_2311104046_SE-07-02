using System;
using System.Windows.Forms;

namespace tjmodul12_2311104046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int CariNilaiPangkat(int a, int b)
        {
            if (b == 0) return 1;
            if (b < 0) return -1;

            try
            {
                checked
                {
                    int hasil = 1;
                    for (int i = 0; i < b; i++)
                    {
                        hasil *= a;
                    }

                    // Validasi setelah proses perkalian
                    if (b > 10 || a > 100)
                        return -2;

                    return hasil;
                }
            }
            catch (OverflowException)
            {
                return -3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int hasil = CariNilaiPangkat(a, b);
            label1.Text = hasil.ToString();
        }
    


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
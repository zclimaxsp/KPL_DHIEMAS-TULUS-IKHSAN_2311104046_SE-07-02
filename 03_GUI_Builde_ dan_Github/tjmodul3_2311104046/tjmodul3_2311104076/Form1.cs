using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tjmodul3_2311104046
{
    public partial class Form1: Form
    {
        private double angka1 = 0;
        private double angka2 = 0;
        private char operasi;
        private bool isOperationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                angka1 = Convert.ToDouble(textBox1.Text);
                operasi = '+';
                isOperationPressed = true;
                textBox1.Text = "";  // Kosongkan textBox1 untuk angka kedua
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && isOperationPressed)
            {
                angka2 = Convert.ToDouble(textBox1.Text);
                double hasil = 0;

                switch (operasi)
                {
                    case '+': hasil = angka1 + angka2; break;
                        // Tambahkan operator lain seperti -, *, / jika ingin
                }

                textBox1.Text = hasil.ToString();  // Tampilkan hasil
                isOperationPressed = false;
            }
        }
    }
}

using System;
using System.Text;

namespace MatematikaLibraries
{
    public class Matematika
    {
        public int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int KPK(int a, int b)
        {
            return (a * b) / FPB(a, b);
        }

        public string Turunan(int[] persamaan)
        {
            StringBuilder hasil = new StringBuilder();
            int pangkat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koefisien = persamaan[i] * pangkat;
                if (koefisien == 0)
                {
                    pangkat--;
                    continue;
                }

                if (hasil.Length > 0 && koefisien > 0)
                    hasil.Append(" + ");

                if (koefisien < 0)
                    hasil.Append(" - ");

                int absKoef = Math.Abs(koefisien);

                if (absKoef != 1 || pangkat - 1 == 0)
                    hasil.Append(absKoef);

                if (pangkat - 1 > 0)
                    hasil.Append("x");

                if (pangkat - 1 > 1)
                    hasil.Append(pangkat - 1);

                pangkat--;
            }

            return hasil.ToString();
        }

        public string Integral(int[] persamaan)
        {
            StringBuilder hasil = new StringBuilder();
            int pangkat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length; i++)
            {
                int koefisien = persamaan[i];
                int pangkatBaru = pangkat + 1;
                double hasilKoef = (double)koefisien / pangkatBaru;

                if (hasil.Length > 0 && hasilKoef > 0)
                    hasil.Append(" + ");

                if (hasilKoef < 0)
                    hasil.Append(" - ");

                double absKoef = Math.Abs(hasilKoef);

                if (absKoef != 1 || pangkatBaru == 0)
                    hasil.Append(absKoef);

                if (pangkatBaru > 0)
                    hasil.Append("x");

                if (pangkatBaru > 1)
                    hasil.Append(pangkatBaru);

                pangkat--;
            }

            hasil.Append(" + C");

            return hasil.ToString();
        }
    }
}

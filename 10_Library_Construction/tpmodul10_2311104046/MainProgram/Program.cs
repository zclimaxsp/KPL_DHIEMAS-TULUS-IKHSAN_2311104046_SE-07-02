using System;
using AljabarLibraries;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Memanggil fungsi HasilKuadrat
            double[] hasilKuadrat = Aljabar.HasilKuadrat(new double[] { 2, -3 });
            Console.WriteLine("Hasil Kuadrat dari 2x - 3:");
            Console.WriteLine($"{hasilKuadrat[0]}x^2 + {hasilKuadrat[1]}x + {hasilKuadrat[2]}");

            // Memanggil fungsi AkarPersamaanKuadrat
            double[] akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
            Console.WriteLine("\nAkar-akar dari persamaan x^2 - 3x - 10:");
            Console.WriteLine($"x1 = {akar[0]}, x2 = {akar[1]}");
        }
    }
}

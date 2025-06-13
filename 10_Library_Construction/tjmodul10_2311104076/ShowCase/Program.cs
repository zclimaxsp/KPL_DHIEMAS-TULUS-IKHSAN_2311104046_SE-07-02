using System;
using MatematikaLibraries;

namespace ShowCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematika math = new Matematika();

            Console.WriteLine("=== PROGRAM PERHITUNGAN MATEMATIKA ===\n");

            Console.WriteLine(">> FUNGSI FPB");
            Console.WriteLine("FPB dari 60 dan 45 = " + math.FPB(60, 45));
            Console.WriteLine(new string('-', 40));

            Console.WriteLine(">> FUNGSI KPK");
            Console.WriteLine("KPK dari 12 dan 8 = " + math.KPK(12, 8));
            Console.WriteLine(new string('-', 40));

            int[] persamaan1 = { 1, 4, -12, 9 };
            Console.WriteLine(">> TURUNAN POLINOMIAL");
            Console.WriteLine("Persamaan awal   : x^3 + 4x^2 - 12x + 9");
            Console.WriteLine("Hasil Turunan    : " + math.Turunan(persamaan1));
            Console.WriteLine(new string('-', 40));

            int[] persamaan2 = { 4, 6, -12, 9 };
            Console.WriteLine(">> INTEGRAL POLINOMIAL");
            Console.WriteLine("Persamaan awal   : 4x^3 + 6x^2 - 12x + 9");
            Console.WriteLine("Hasil Integral   : " + math.Integral(persamaan2));
            Console.WriteLine(new string('-', 40));

            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }

    }
}

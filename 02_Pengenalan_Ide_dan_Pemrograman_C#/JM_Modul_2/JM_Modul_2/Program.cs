using System;

namespace Modul2_2311104046
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Menerima input nama praktikan
            Console.Write("Masukkan nama Anda: ");
            string nama = Console.ReadLine();
            Console.WriteLine($"Selamat datang, {nama}!");

            // 2. Membuat array int berukuran 50 dan mencetak elemen dengan aturan tertentu
            int[] array = new int[50];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                if (i % 2 == 0 && i % 3 == 0)
                    Console.WriteLine($"{i} #$#$");
                else if (i % 2 == 0)
                    Console.WriteLine($"{i} ##");
                else if (i % 3 == 0)
                    Console.WriteLine($"{i} $$");
                else
                    Console.WriteLine($"{i}");
            }

            // 3. Meminta input angka dan memeriksa apakah bilangan prima
            Console.Write("Masukkan angka (1-10000): ");
            int nilaiInt = Convert.ToInt32(Console.ReadLine());
            if (IsPrima(nilaiInt))
                Console.WriteLine($"Angka {nilaiInt} merupakan bilangan prima");
            else
                Console.WriteLine($"Angka {nilaiInt} bukan merupakan bilangan prima");
        }

        // Method untuk memeriksa apakah bilangan prima
        static bool IsPrima(int angka)
        {
            if (angka < 2) return false;
            for (int i = 2; i <= Math.Sqrt(angka); i++)
            {
                if (angka % i == 0) return false;
            }
            return true;
        }
    }
}

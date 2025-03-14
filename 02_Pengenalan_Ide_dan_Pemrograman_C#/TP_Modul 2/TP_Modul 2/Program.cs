using System;

class Program
{
    static void Main()
    {
        // A. Menerima input satu karakter
        Console.Write("Masukkan satu huruf: ");
        char huruf = Char.ToUpper(Console.ReadKey().KeyChar); // Mengubah input menjadi huruf kapital
        Console.WriteLine(); // Untuk pindah ke baris baru setelah input

        // Mengecek apakah huruf tersebut vokal atau konsonan
        if (huruf == 'A' || huruf == 'I' || huruf == 'U' || huruf == 'E' || huruf == 'O')
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf vokal");
        }
        else
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan");
        }

        // B. Membuat array bertipe integer dengan 5 bilangan genap dari angka 2
        int[] bilanganGenap = { 2, 4, 6, 8, 10 };

        // Melakukan iterasi dan mencetak output dari tiap elemen
        for (int i = 0; i < bilanganGenap.Length; i++)
        {
            Console.WriteLine($"Angka genap {i + 1} : {bilanganGenap[i]}");
        }
    }
}
using modul4_2311104046;
using System;

namespace modul4_231110406
{
    class Program
    {
        static void Main(string[] args)
        {
            // BAGIAN 1: Interaksi dengan KodeBuah
            Console.WriteLine("=== Testing KodeBuah Class ===");
            while (true)
            {
                Console.Write("Masukkan nama buah (atau 'exit' untuk keluar): ");
                string namaBuah = Console.ReadLine();

                if (namaBuah.ToLower() == "exit")
                    break;

                Console.WriteLine($"Kode Buah {namaBuah} adalah: {KodeBuah.getKodeBuah(namaBuah)}\n");
            }

            // BAGIAN 2: Interaksi dengan PosisiKarakterGame
            Console.WriteLine("\n=== Testing PosisiKarakterGame Class ===");
            PosisiKarakterGame karakterGame = new PosisiKarakterGame();

            while (true)
            {
                Console.Write("Tekan tombol (W: Atas, S: Bawah, X: Special, Q: Keluar): ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        karakterGame.TombolW();
                        break;
                    case ConsoleKey.S:
                        karakterGame.TombolS();
                        break;
                    case ConsoleKey.X:
                        karakterGame.TombolX();
                        break;
                    case ConsoleKey.Q:
                        Console.WriteLine("Keluar dari program...");
                        return;
                    default:
                        Console.WriteLine("Tombol tidak dikenali. Gunakan W, S, X, atau Q.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}

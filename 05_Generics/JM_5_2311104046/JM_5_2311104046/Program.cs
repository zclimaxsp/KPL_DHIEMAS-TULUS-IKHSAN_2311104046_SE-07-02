using System;

class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T a, T b, T c) where T : struct
    {
        dynamic x = a, y = b, z = c;
        return x + y + z;
    }
}

class Program
{
    static void Main()
    {
        // NIM: 2311104046 → Menggunakan int
        int angka1 = 23, angka2 = 11, angka3 = 04;

        Console.WriteLine($"Hasil: {Penjumlahan.JumlahTigaAngka<int>(angka1, angka2, angka3)}");
    }
}

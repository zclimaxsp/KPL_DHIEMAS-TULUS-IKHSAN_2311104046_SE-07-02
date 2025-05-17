using System;

class Program
{
    static void Main(string[] args)
    {
        // A & B. Membuat dua variabel instance Singleton
        var data1 = PusatDataSingleton.GetDataSingleton();
        var data2 = PusatDataSingleton.GetDataSingleton();

        // C. Tambahkan nama anggota kelompok dan asisten praktikum
        data1.AddSebuahData("Dhiemas");
        data1.AddSebuahData("Eva");
        data1.AddSebuahData("Arka");
        data1.AddSebuahData("Asisten: Budi");

        // D. Print data dari data2
        Console.WriteLine("Isi data2:");
        data2.PrintSemuaData();

        // E. Hapus nama asisten (index ke-3)
        data2.HapusSebuahData(3);

        // F. Print data1 (nama asisten seharusnya sudah terhapus)
        Console.WriteLine("\nIsi data1 setelah hapus:");
        data1.PrintSemuaData();

        // G. Print jumlah data di data1 dan data2
        Console.WriteLine($"\nJumlah data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah data2: {data2.GetSemuaData().Count}");
    }
}

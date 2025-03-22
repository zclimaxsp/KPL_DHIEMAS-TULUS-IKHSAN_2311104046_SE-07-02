//using System;

//class Penjumlahan//

//class Program//

using System;
using System.Collections.Generic;

class SimpleDatabase<T>
{
    private List<T> data = new List<T>();
    private List<DateTime> timestamps = new List<DateTime>();

    public void AddNewData(T item)
    {
        data.Add(item);
        timestamps.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < data.Count; i++)
        {
            Console.WriteLine($"Data: {data[i]}, Waktu: {timestamps[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Ganti dengan NIM kamu
        uint nim = 2311104046;

        SimpleDatabase<int> database = new SimpleDatabase<int>();

        // Menambahkan 3 data contoh (bisa disesuaikan)
        database.AddNewData((int)(nim % 100));
        database.AddNewData((int)(nim / 100) % 100);
        database.AddNewData((int)(nim / 10000) % 100);

        // Cetak semua data yang tersimpan
        database.PrintAllData();
    }
}

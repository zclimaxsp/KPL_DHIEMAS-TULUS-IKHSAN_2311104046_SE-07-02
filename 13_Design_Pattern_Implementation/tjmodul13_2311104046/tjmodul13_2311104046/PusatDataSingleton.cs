using System;
using System.Collections.Generic;

public class PusatDataSingleton
{
private static PusatDataSingleton? _instance;
    public List<string> DataTersimpan { get; private set; }

    // Konstruktor private agar tidak bisa diakses dari luar
    private PusatDataSingleton()
    {
        DataTersimpan = new List<string>();
    }

    // Method untuk mengambil instance Singleton
    public static PusatDataSingleton GetDataSingleton()
    {
        if (_instance == null)
        {
            _instance = new PusatDataSingleton();
        }
        return _instance!;
    }

    // Mengembalikan semua data
    public List<string> GetSemuaData()
    {
        return DataTersimpan;
    }

    // Mencetak semua data
    public void PrintSemuaData()
    {
        foreach (string data in DataTersimpan)
        {
            Console.WriteLine(data);
        }
    }

    // Menambahkan data baru
    public void AddSebuahData(string input)
    {
        DataTersimpan.Add(input);
    }

    // Menghapus data berdasarkan index
    public void HapusSebuahData(int index)
    {
        if (index >= 0 && index < DataTersimpan.Count)
        {
            DataTersimpan.RemoveAt(index);
        }
    }
}

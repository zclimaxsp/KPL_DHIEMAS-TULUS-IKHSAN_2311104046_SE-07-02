//class Penjumlahan//

//class Program//

using System;
using System.Collections.Generic;

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T item)
    {
        storedData.Add(item);
        inputDates.Add(DateTime.UtcNow);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Ganti dengan NIM kamu
        long nim = 2311104046;

        int angka1 = 23, angka2 = 11, angka3 = 04;

        // Tipe data berdasarkan akhir NIM
        if (nim % 10 == 1 || nim % 10 == 2)
        {
            SimpleDataBase<float> db = new SimpleDataBase<float>();
            db.AddNewData(angka1);
            db.AddNewData(angka2);
            db.AddNewData(angka3);
            db.PrintAllData();
        }
        else if (nim % 10 == 3 || nim % 10 == 4 || nim % 10 == 5)
        {
            SimpleDataBase<double> db = new SimpleDataBase<double>();
            db.AddNewData(angka1);
            db.AddNewData(angka2);
            db.AddNewData(angka3);
            db.PrintAllData();
        }
        else if (nim % 10 == 6 || nim % 10 == 7 || nim % 10 == 8)
        {
            SimpleDataBase<int> db = new SimpleDataBase<int>();
            db.AddNewData(angka1);
            db.AddNewData(angka2);
            db.AddNewData(angka3);
            db.PrintAllData();
        }
        else
        {
            SimpleDataBase<long> db = new SimpleDataBase<long>();
            db.AddNewData(angka1);
            db.AddNewData(angka2);
            db.AddNewData(angka3);
            db.PrintAllData();
        }
    }
}

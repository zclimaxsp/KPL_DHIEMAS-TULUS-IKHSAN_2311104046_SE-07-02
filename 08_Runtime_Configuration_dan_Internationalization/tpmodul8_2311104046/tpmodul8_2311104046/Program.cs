using System;
using System.IO;
using System.Text.Json;

class CovidConfig
{
    public string satuan_suhu { get; set; }
    public int batas_hari_deman { get; set; }
    public string pesan_ditolak { get; set; }
    public string pesan_diterima { get; set; }

    public static CovidConfig LoadConfig(string path)
    {
        if (!File.Exists(path))
        {
            var defaultConfig = new CovidConfig
            {
                satuan_suhu = "celcius",
                batas_hari_deman = 14,
                pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini",
                pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini"
            };
            File.WriteAllText(path, JsonSerializer.Serialize(defaultConfig, new JsonSerializerOptions { WriteIndented = true }));
            return defaultConfig;
        }
        else
        {
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<CovidConfig>(json);
        }
    }

    public void UbahSatuan()
    {
        if (satuan_suhu.ToLower() == "celcius")
        {
            satuan_suhu = "fahrenheit";
        }
        else
        {
            satuan_suhu = "celcius";
        }
    }
}

class Program
{
    static void Main()
    {
        string configPath = "covid_config.json";
        var config = CovidConfig.LoadConfig(configPath);

        // Input suhu
        Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}:");
        double suhu = double.Parse(Console.ReadLine());

        // Input hari demam
        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
        int hariDemam = int.Parse(Console.ReadLine());

        // Cek kondisi
        bool isSuhuNormal = false;

        if (config.satuan_suhu.ToLower() == "celcius")
        {
            isSuhuNormal = suhu >= 36.5 && suhu <= 37.5;
        }
        else if (config.satuan_suhu.ToLower() == "fahrenheit")
        {
            isSuhuNormal = suhu >= 97.7 && suhu <= 99.5;
        }

        if (isSuhuNormal && hariDemam < config.batas_hari_deman)
        {
            Console.WriteLine(config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.pesan_ditolak);
        }


        // Ubah satuan setelah proses selesai
        config.UbahSatuan();
        Console.WriteLine($"\nSatuan suhu telah diubah menjadi: {config.satuan_suhu}");
    }
}

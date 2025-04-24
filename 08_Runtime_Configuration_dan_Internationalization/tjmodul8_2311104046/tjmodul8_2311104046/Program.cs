using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class BankTransferConfig
{
    public string lang { get; set; }
    public Transfer transfer { get; set; }
    public List<string> methods { get; set; }
    public Confirmation confirmation { get; set; }

    public class Transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
    }

    public class Confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
    }

    public static BankTransferConfig LoadFromFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            var defaultConfig = new BankTransferConfig
            {
                lang = "en",
                transfer = new Transfer { threshold = 25000000, low_fee = 6500, high_fee = 15000 },
                methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
                confirmation = new Confirmation { en = "yes", id = "ya" }
            };
            File.WriteAllText(filePath, JsonSerializer.Serialize(defaultConfig, new JsonSerializerOptions { WriteIndented = true }));
            return defaultConfig;
        }
        else
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<BankTransferConfig>(json);
        }
    }
}

class Program
{
    static void Main()
    {
        string configPath = "bank_transfer_config.json";
        var config = BankTransferConfig.LoadFromFile(configPath);

        Console.WriteLine(config.lang == "en"
            ? "Please insert the amount of money to transfer:"
            : "Masukkan jumlah uang yang akan di-transfer:");

        int amount = int.Parse(Console.ReadLine());

        int fee = amount <= config.transfer.threshold
            ? config.transfer.low_fee
            : config.transfer.high_fee;

        int total = amount + fee;

        Console.WriteLine(config.lang == "en"
            ? $"Transfer fee = {fee}\nTotal amount = {total}"
            : $"Biaya transfer = {fee}\nTotal biaya = {total}");

        Console.WriteLine(config.lang == "en"
            ? "Select transfer method:"
            : "Pilih metode transfer:");

        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        Console.ReadLine(); // Simulasi input metode transfer

        string confirmKey = config.lang == "en"
            ? config.confirmation.en
            : config.confirmation.id;

        Console.WriteLine(config.lang == "en"
            ? $"Please type \"{confirmKey}\" to confirm the transaction:"
            : $"Ketik \"{confirmKey}\" untuk mengkonfirmasi transaksi:");

        string inputConfirm = Console.ReadLine();

        if (inputConfirm.ToLower() == confirmKey.ToLower())
        {
            Console.WriteLine(config.lang == "en"
                ? "The transfer is completed"
                : "Proses transfer berhasil");
        }
        else
        {
            Console.WriteLine(config.lang == "en"
                ? "Transfer is cancelled"
                : "Transfer dibatalkan");
        }
    }
}

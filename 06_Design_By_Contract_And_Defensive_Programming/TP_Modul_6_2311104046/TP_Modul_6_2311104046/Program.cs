using System;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 100)
            throw new ArgumentException("Judul video tidak boleh null dan maksimal 100 karakter.");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999); // 5 digit random ID
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count > 10000000 || count < 0)
            throw new ArgumentException("Penambahan play count maksimal 10.000.000 dan tidak boleh negatif.");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas integer.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID: " + this.id);
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount);
    }
}


class Program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [DHIEMAS TULUS]");

        video.PrintVideoDetails();

        // Uji prekondisi dan exception
        try
        {
            video.IncreasePlayCount(5000000); // Valid
            video.IncreasePlayCount(15000000); // Invalid (harus ditangkap oleh exception)
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        // Simulasi overflow dengan loop
        for (int i = 0; i < 100; i++)
        {
            video.IncreasePlayCount(10000000);
        }

        video.PrintVideoDetails();
    }
}
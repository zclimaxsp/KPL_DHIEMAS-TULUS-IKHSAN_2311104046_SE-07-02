using System;

public class SayaTubeVideo
{
    private int videoId;
    private string videoTitle;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title))
            throw new ArgumentException("Judul video tidak boleh kosong atau null.");

        if (title.Length > 100)
            throw new ArgumentException("Judul video tidak boleh lebih dari 100 karakter.");

        Random random = new Random();
        this.videoId = random.Next(10000, 99999);
        this.videoTitle = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count > 10000000)
            throw new ArgumentException("Penambahan play count tidak boleh lebih dari 10.000.000.");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas maksimum integer!");
        }
    }

    public void PrintDetails()
    {
        Console.WriteLine($"ID Video    : {videoId}");
        Console.WriteLine($"Judul       : {videoTitle}");
        Console.WriteLine($"Jumlah Play : {playCount}");
    }
}

using System;
using System.Collections.Generic;

class SayaTubeVideo
{
    private int _id;
    private string _title;
    private int _playCount;

    public string Title => _title;
    public int PlayCount => _playCount;

    public SayaTubeVideo(string title)
    {
        // Validasi input judul
        if (string.IsNullOrEmpty(title))
            throw new ArgumentNullException(nameof(title), "Judul tidak boleh null atau kosong");

        if (title.Length > 200)
            throw new ArgumentException("Judul tidak boleh lebih dari 200 karakter", nameof(title));

        Random random = new Random();
        _id = random.Next(10000, 99999);
        _title = title;
        _playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        // Validasi nilai count
        if (count < 0)
            throw new ArgumentException("Play count tidak boleh negatif", nameof(count));

        if (count > 25000000)
            throw new ArgumentException("Maksimum play count adalah 25.000.000", nameof(count));

        checked
        {
            try
            {
                _playCount += count;
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR: Play count melebihi batas integer.");
            }
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {_id}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Play Count: {_playCount}\n");
    }
}

class SayaTubeUser
{
    private int _id;
    private List<SayaTubeVideo> _uploadedVideos;

    public string Username { get; private set; }

    public SayaTubeUser(string username)
    {
        // Validasi input username
        if (string.IsNullOrEmpty(username))
            throw new ArgumentNullException(nameof(username), "Username tidak boleh null atau kosong");

        if (username.Length > 100)
            throw new ArgumentException("Username tidak boleh lebih dari 100 karakter", nameof(username));

        Random random = new Random();
        _id = random.Next(10000, 99999);
        Username = username;
        _uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        // Validasi input video
        if (video == null)
            throw new ArgumentNullException(nameof(video), "Video tidak boleh null");

        if (video.PlayCount >= int.MaxValue)
            throw new ArgumentException("Play count tidak boleh lebih dari batas maksimum integer");

        _uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;

        foreach (var video in _uploadedVideos)
        {
            totalPlayCount += video.PlayCount;
        }

        return totalPlayCount;
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine($"User: {Username}");

        int maxPrint = Math.Min(8, _uploadedVideos.Count);

        for (int i = 0; i < maxPrint; i++)
        {
            Console.WriteLine($"Video {i + 1} Judul: {_uploadedVideos[i].Title}");
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            SayaTubeUser user = new SayaTubeUser("Dhiemas Tulus");

            // Daftar judul video
            List<string> filmTitles = new List<string>
            {
                "Review Film The Little Mermaid oleh Dhiemas Tulus",
                "Review Film Barbie and the Diamond Castle oleh Dhiemas Tulus",
                "Review Film How to Train Your Dragon oleh Dhiemas Tulus",
                "Review Film Frozen II oleh Dhiemas Tulus",
                "Review Film Moana oleh Dhiemas Tulus",
                "Review Film Tangled oleh Dhiemas Tulus",
                "Review Film Encanto oleh Dhiemas Tulus",
                "Review Film Coco oleh Dhiemas Tulus",
                "Review Film Wicked oleh Dhiemas Tulus",
                "Review Film Turning Red oleh Dhiemas Tulus"
            };


            // Tambahkan video ke user
            foreach (var title in filmTitles)
            {
                SayaTubeVideo video = new SayaTubeVideo(title);
                user.AddVideo(video);
            }

            user.PrintAllVideoPlayCount();

            // Pengujian batas validasi play count
            SayaTubeVideo testVideo = new SayaTubeVideo("Review Film Uji Maksimum");

            try
            {
                testVideo.IncreasePlayCount(25000001); // Harus gagal
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }

            try
            {
                testVideo.IncreasePlayCount(-5); // Harus gagal
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }

            user.AddVideo(testVideo);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
        }
    }
}
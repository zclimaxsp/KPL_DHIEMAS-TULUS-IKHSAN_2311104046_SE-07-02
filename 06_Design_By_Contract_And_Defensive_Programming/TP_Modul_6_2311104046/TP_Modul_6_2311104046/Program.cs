
class Program
{
    static void Main()
    {
        try
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract – Dhiemas Tulus Ikhsan");
            video1.IncreasePlayCount(5000000);
            video1.PrintVideoDetails();

            SayaTubeVideo video2 = new SayaTubeVideo("Test Overflow");
            for (int i = 0; i < 10; i++)
            {
                video2.IncreasePlayCount(int.MaxValue);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }
}
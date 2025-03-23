public class Program
{
    public static void Main()
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Anak Agung Aryadipa Aditya Nugraha");
            for (int i = 0; i < 10; i++)
            {
                video.IncreasePlayCount(1000000);
            }
            video.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
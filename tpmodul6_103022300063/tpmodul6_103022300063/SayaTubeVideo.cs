using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string videoTitle)
    {
        if (videoTitle == null) throw new ArgumentNullException("Title tidak boleh null.");
        if (videoTitle.Length > 100) throw new ArgumentException("Title maksimal 100 karakter.");

        playCount = 0;

        Random rand = new Random();
        id = rand.Next(10000, 100000);

        title = videoTitle;
    }

    public void IncreasePlayCount(int count)
    {
        if (count > 10000000) throw new ArgumentException("Maksimal penambahan play count adalah 10.000.000.");
        if (count < 0) throw new ArgumentException("Play count tidak boleh negatif.");

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Terjadi overflow pada play count.");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID Video: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
}



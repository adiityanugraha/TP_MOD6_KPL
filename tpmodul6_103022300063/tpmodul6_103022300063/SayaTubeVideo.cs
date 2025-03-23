using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    // Konstruktor
    public SayaTubeVideo(string videoTitle)
    {
        playCount = 0;

        Random rand = new Random();
        id = rand.Next(10000, 100000);

        title = videoTitle;
    }

    public void IncreasePlayCount(int count)
    {
        if (count > 0)
        {
            playCount += count;
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID Video: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
}

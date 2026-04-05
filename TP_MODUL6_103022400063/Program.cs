// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

public class SayaMusicTrack()
{
   private int id;
   private String playCount;
   private string title;

    public SayaMusicTrack(string title)
    {
        this.title = title;

        Random random = new Random();
        this.id = 10000 + random.Next(1, 10000);
        this.playCount = "0";
        this.title = title;


    }

    public void IncreasePlayCount(int count)
    {
        int currentPlayCount = int.Parse(playCount);
        currentPlayCount += count;
        this.playCount = currentPlayCount.ToString();
    }

    public void PrintTrackDetails()
    {
        Console.WriteLine("| " + this.id + " | " + this.playCount + " | " + this.title + " |");
    }
}
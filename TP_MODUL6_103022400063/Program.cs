// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Reflection;
namespace TP_MODUL6_103022400063
{
    public class SayaMusicTrack
    {
        private int id;
        private string playCount;
        private string title;

        public SayaMusicTrack(string title)
        {

            Debug.Assert(title != null, "Title tidak bisa tidak terisi");
            Debug.Assert(title.Length <= 100, "Title maks 100");

            this.title = title;
            Random random = new Random();
            this.id = 10000 + random.Next(1, 10000);
            this.playCount = "0";
        }

        public void IncreasePlayCount(int count)
        {

            Debug.Assert(count <= 10000000, "Tidak boleh lebih dari 10.000.000");

            int currentPlayCount = int.Parse(playCount);
            currentPlayCount += count;
            this.playCount = currentPlayCount.ToString();
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine("| " + this.id + " | " + this.playCount + " | " + this.title + " |");
        }
    }
}

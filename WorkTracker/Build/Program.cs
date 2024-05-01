using System.Threading;

namespace Build
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var timeRecords = new List<WorkTimeRecord>();

            timeRecords.Add(new WorkTimeRecord());
            Console.WriteLine($"start: {timeRecords[0]}");

            Thread.Sleep(2000);

            timeRecords[0].end = DateTime.Now;
            Console.WriteLine($"end:  {timeRecords[0]}");

            Console.WriteLine($"duration: {timeRecords[0].duration}");

            Console.WriteLine("\nSummary:");
            timeRecords.ForEach(x => Console.WriteLine($"- {x}"));
        }
    }
}

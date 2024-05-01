using System.Threading;

namespace Build
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var timeRecord = new WorkTimeRecord();
            Console.WriteLine($"start: {timeRecord}");

            Thread.Sleep(2000);

            timeRecord.end = DateTime.Now;
            Console.WriteLine($"end:  {timeRecord}");

            Console.WriteLine($"duration: {timeRecord.duration}");
            //new Program().Foo(4);
        }

        public bool Foo(int bar)
        {
            Console.WriteLine("Hello, World, I am the new WorkerTracker Project!");

            if (bar == 4)
            {
                return false;
            }

            throw new NotImplementedException("Not fully implemented.");
        }
    }
}

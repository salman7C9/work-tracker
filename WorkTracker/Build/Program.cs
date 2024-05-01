using System.Threading;

namespace Build
{
    public class Program
    {
        public static void Main(string[] args)
        {


            var start = DateTime.Now;
            Console.WriteLine($"start: {start}");

            Thread.Sleep(2000);

            var end = DateTime.Now;
            Console.WriteLine($"end:  {end}");

            Console.WriteLine($"duration: {end - start}");
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

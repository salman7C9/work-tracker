namespace Build
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new Program().Foo(4);
        }

        public bool Foo(int bar)
        {
            Console.WriteLine("Hello, World, I am the new TimeTracker Project!");

            if (bar == 4)
            {
                return false;
            }

            throw new NotImplementedException("Not fully implemented.");
        }
    }
}

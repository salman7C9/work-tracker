namespace Build
{
    public class Program
    {
        public static void Main(string[] args) {
                new Program().Foo(4);
        }

        public bool Foo(int bar)
        {
            Console.WriteLine("Hello, World, I am the new TimeTracker Project!");
            throw new NotImplementedException("Not implemented.");
        }
    }
}

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



namespace Konsole1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Hello World!");
            }
            else
            {
                foreach (var arg in args)
                {
                    Console.WriteLine(arg);
                }
            }
        }
    }
}
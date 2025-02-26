// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



using Konsele1;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Konsole1
{
    internal class Program
    {

        static async Task Main(string[] args)
        {
            Parallel.For(1, 6, i =>
            {
                Console.WriteLine($"Task {i} wird ausgeführt");
            });

            var names = new List<string> { "Alice", "Bob", "Frank"};
            Parallel.ForEach(names, name =>
            {
                Console.WriteLine(name);
            });

        }

        static void PrintNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {i}");
                Thread.Sleep(1000);
            }
        }

    }
}
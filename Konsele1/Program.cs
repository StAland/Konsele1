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
            Task t1 = Task.Run(() => PrintNumbers());
            Task t2 = Task.Run(() => PrintNumbers());

            await Task.WhenAll(t1, t2); // Wartet auf beide Tasks

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
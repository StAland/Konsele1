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
            Thread t = new Thread(PrintNumbers);
            t.Start(); // Startet den neuen Thread
            PrintNumbers(); // Wird im Hauptthread ausgeführt

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
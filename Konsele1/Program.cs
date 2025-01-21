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
            IProgress<int> progress = new Progress<int>(percent =>
            {
                Console.WriteLine($"Fortschritt: {percent}");
            });
            await SimulateProgress(progress);
            Console.WriteLine("Bearbeitung abgeschlossen");
        }

        static async Task SimulateProgress(IProgress<int> progress)
        {
            for (int i = 0; i <= 100; i+=5)
            {
                await Task.Delay(500);
                progress.Report(i);
            }
        }

    }
}
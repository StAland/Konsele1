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
            using CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken cancellationToken = cts.Token;

            Console.WriteLine("Drücken Sie eine Taste um abzubrechen");

            Task cancelTask = Task.Run(() =>
            {
                Console.ReadKey();
                cts.Cancel();
            });

            try
            {
                await RunWithCancellationAsync(cancellationToken);
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Abgebrochen");
            }
        }

        static async Task RunWithCancellationAsync(CancellationToken token)
        {
            for (int i = 0; i <= 100; i++)
            {
                token.ThrowIfCancellationRequested();

                Console.WriteLine($"Schritt {i}");
                await Task.Delay(100, token); // Simulierte Verzögerung
            }

            Console.WriteLine("Operation abgeschlossen!");
        }

    }
}
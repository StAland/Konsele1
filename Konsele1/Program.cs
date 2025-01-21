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
            Task<int> task1 = SimulateCalculationAsync(5); // Quadrieren einer Zahl
            Task<string> task2 = SimulateConversionAsync("Hallo Welt"); // String in Großbuchstaben
            Task task3 = SimulateMessageWritingAsync("Nachricht wird geschrieben..."); // Schreiben einer Nachricht

            await Task.WhenAll(task1, task2, task3);

            Console.WriteLine($"Berechnungsergebnis: {await task1}");
            Console.WriteLine($"Konvertierungsergebnis: {await task2}");
        }


        static async Task<int> SimulateCalculationAsync(int number)
        {
            await Task.Delay(1000); // Simulierte Verzögerung
            return number * number;
        }

        static async Task<string> SimulateConversionAsync(string input)
        {
            await Task.Delay(2000); // Simulierte Verzögerung
            return input.ToUpper();
        }

        static async Task SimulateMessageWritingAsync(string message)
        {
            await Task.Delay(3000); // Simulierte Verzögerung
            Console.WriteLine(message);
        }
    }
}
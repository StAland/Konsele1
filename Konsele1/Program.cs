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
            bool conditionMet = false;
            Task.Run(async () =>
            {
                await Task.Delay(5000);
                conditionMet = true;
                Console.WriteLine("Bedingung erfüllt");
            });

            Console.WriteLine("Warten auf Bedingung");
            await WartenAufBedingung(() => conditionMet);
            Console.WriteLine("Programm beendet");
        }

        static async Task WartenAufBedingung(Func<bool> condition)
        {
            while (!condition()) 
            {
                await Task.Delay(200);
            }
        }

    }
}
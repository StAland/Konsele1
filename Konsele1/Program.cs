// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



using Konsele1;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Konsole1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var path = "config.txt";

            string[] lines =
            {
                "Benutzer: Steffen",
                "weitere Zeilen",
                "meine neue Zeile"
            };

            File.WriteAllLines(path, lines);
        }     
    }
}
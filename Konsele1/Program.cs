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
                "meine neue Zeile",
                "jetzt mit Stream"
            };

            var dateiInfo = new FileInfo(path);
            using (var stream = dateiInfo.OpenWrite())
            {
                using (var writer  = new StreamWriter(stream))
                {
                    foreach (var line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
                
            }
        }     
    }
}
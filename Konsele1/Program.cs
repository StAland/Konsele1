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
            var dateiInfo = new FileInfo("config.txt");
            using(var reader  = dateiInfo.OpenText())
            {
                while(!reader.EndOfStream)
                {
                    var zeile = reader.ReadLine();
                    Console.WriteLine(zeile);
                }
            }
        }     
    }
}
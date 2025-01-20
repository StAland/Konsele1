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
            var text = File.ReadAllText("config.txt");
            text += "\r\nhier ist ne weitere Zeile";
            File.WriteAllText("config.txt", text);
        }     
    }
}
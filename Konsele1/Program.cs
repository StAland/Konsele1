// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



using Konsele1;
using System.ComponentModel.DataAnnotations;

namespace Konsole1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var text = File.ReadAllLines("config.txt");
            foreach (var line in text)
            {
                Console.WriteLine(line);
            }
        }     
    }
}
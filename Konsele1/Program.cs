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
            Bruch bruch1 = new Bruch(3, 4);
            Bruch bruch2 = new Bruch(2, 5);

            Bruch summe = bruch1 + bruch2;
            Bruch differenz = bruch1.Subtrahieren(bruch2);
            Bruch produkt = bruch1.Multiplizieren(bruch2);
            Bruch quotient = bruch1.Dividieren(bruch2);

            Console.WriteLine($"Summe: {summe}");
            Console.WriteLine($"Differenz: {differenz}");
            Console.WriteLine($"Produkt: {produkt}");
            Console.WriteLine($"Quotient: {quotient}");

        }
       

    }
}
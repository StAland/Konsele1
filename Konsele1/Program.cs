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
            var pizzabuilder = new Pizza.Builder() 
            { 
                HasMushrooms = true,
                Size = 100,
                Cheese = "Gouada",
                HasPinapple = false,
                Crust = "dick"
            };
            var pizza = pizzabuilder.Build();
            var size = pizza.Size;


        }


    }
}
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
            var pizza = new PizzaBuilder()
                .SetSize(10)
                .SetCrust("dick")
                .Build();
        }


    }
}
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
            var bruch = new Bruch(4, 5);
            var bruch2 = bruch.TauscheZahlerNenner();
            Console.WriteLine(bruch2);
        }
       

    }
}
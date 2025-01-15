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
            var kiste = new Kiste(50);
            var tree = new Tree<Kiste>(kiste);
            tree.Add(new Kiste(30));
            tree.Add(new Kiste(40));
            tree.Add(new Kiste(20));
            tree.Add(new Kiste(45));
            tree.Add(new Kiste(60));
            tree.Add(new Kiste(55));
        }
       

    }
}
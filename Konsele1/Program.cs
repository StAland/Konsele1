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
            var bruechedict = new Dictionary<int, int>();
            bruechedict.Add(5, 3);
            bruechedict.Add(7, 2);
            bruechedict.Add(2, 9);
            bruechedict.Add(4, 3);

            var brueche = bruechedict.Select(item => new Bruch(item.Key, item.Value));
            var bruchMitNenner3 = brueche.First(item => item.Nenner == 3);
            foreach (var item in brueche)
            {
                Console.WriteLine(item);
            }
        }     
    }
}
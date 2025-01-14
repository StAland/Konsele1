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
            var haus = new Haus(15, Gebauedefarbe.weiss, 3);
            var kiste = new Kiste();
            var kiste2 = new Kiste();
            var haus2 = new Haus(20, 3);

            var aufschliessenListe = new List<IAufschliessbar>
            {
                haus,
                kiste2,
                kiste,
                haus2
            };

            foreach ( var au in aufschliessenListe)
            {
                au.Aufschliessen();
            }
        }
       

    }
}
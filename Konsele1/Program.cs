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
            var meinHaus = new Haus("rot", 4);
            var hausFarbe = meinHaus.Farbe;
            Console.WriteLine(hausFarbe);
            meinHaus.Farbe = "gelb";
            Console.WriteLine(meinHaus.Farbe);
            meinHaus.Rooms = 3;
            
        }

        public static int Addieren(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }

        public static int Addieren(int zahlMax)
        {
            var ergebnis = 0;
            for (int i = 0; i<= zahlMax; i++)
            {
                ergebnis += i;
            }
            return ergebnis;
        }

        public static int Addieren(int zahl1, int zahl2, int zahl3)
        {
            return zahl1 + zahl2 + zahl3;
        }

        public static int Addieren(IEnumerable<int> zahlen)
        {
            var ergebnis = 0;
            foreach (var zahl in zahlen) 
            { 
                ergebnis += zahl;
            }
            return ergebnis;
        }

    }
}
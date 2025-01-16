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
            var kisten = new List<Kiste>();
            kisten.Add(new Kiste(15));
            kisten.Add(new Kiste(55));
            kisten.Add(new Kiste(40));
            kisten.Add(new Kiste(70));
            kisten.Add(new Kiste(115));
            kisten.Add(new Kiste(36));
            kisten.Add(new Kiste(80));
            kisten.Add(new Kiste(7));
            kisten.Add(new Kiste(23));
            kisten.Add(new Kiste(85));

            var kistenGreater50 = new List<Kiste>();
            foreach (var kiste in kisten)
            {
                if (kiste.Volumen >= 50)
                {
                    kistenGreater50.Add(kiste);
                }
            }
            var kisteGroesser1000 = kisten.Any(kiste => kiste.Volumen > 1000);
            var kistensmaller50 = from kiste in kisten where kiste.Volumen < 50 select kiste;
            foreach (var kiste in kistensmaller50)
            {
                Console.WriteLine(kiste.Volumen);
            }
            var kistengroeser50 = kisten.Where(kiste => kiste.Volumen >= 50);
            foreach (var kiste in kistengroeser50)
            {
                Console.WriteLine(kiste.Volumen);
            }
            

        }
       

    }
}
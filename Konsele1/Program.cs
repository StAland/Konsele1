// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



namespace Konsole1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var zahl1string = NutzereingabeAbfragen("Bitte eine Zahl eingeben");
            var zahl2string = NutzereingabeAbfragen("Bitte eine zweite Zahl eingeben");
            int zahl1;
            int zahl2;
            if(int.TryParse(zahl1string, out zahl1) && int.TryParse(zahl2string, out zahl2))
            {
                int zahl3 = zahl1 + zahl2;
                Console.WriteLine($"{zahl1} + {zahl2} = {zahl3}");
            }
            else
            {
                Console.WriteLine("Keine Zahlen eingegeben");
            }
        }

        public static string NutzereingabeAbfragen(string eingabe)
        {
            Console.WriteLine(eingabe);
            var zahl = Console.ReadLine();
            if (zahl != null)
            {
                return zahl;
            }
            return "";
        }
    }
}
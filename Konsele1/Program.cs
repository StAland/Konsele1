// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



namespace Konsole1
{
    internal class Program
    {
        enum Schwierigkeit
        {
            Normal = 1,
            Elite = 2,
            Boss = 4
        }
        static void Main(string[] args)
        {
            Schwierigkeit gegnerSchwierigkeit = (Schwierigkeit)3;

            switch (gegnerSchwierigkeit)
            {
                case Schwierigkeit.Normal:
                    Console.WriteLine("Das ist ein normaler Gegner");
                    break;
                case Schwierigkeit.Elite:
                    Console.WriteLine("Das ist ein Elite Gegner");
                    break;
                case Schwierigkeit.Boss:
                    Console.WriteLine("Das ist ein Boss Gegner");
                    break;
                default:
                    Console.WriteLine("Den Gegner kenne ich nicht");
                    break;
            }
        }

    }
}
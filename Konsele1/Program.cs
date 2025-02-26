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
        static int counter = 0;
        static object locker = new object();

        static async Task Main(string[] args)
        {
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine($"Finaler Counter-Wert: {counter}");
        }

        static void Increment()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (locker)
                {
                    counter++;
                }               
            }
        }


    }
}
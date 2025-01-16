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
            var ints = new int[] { 1, 2, 3 };
            
            try
            {
                var zahhl = ints[4];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
                //throw;
            }



            int zahl2;
            if (!int.TryParse("Hallo", out zahl2))
            {

            }
        }     
    }
}
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
            var linkedList = new LinkedListElement<int>(4);
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(7);
            linkedList.Add(4);
            Console.WriteLine(linkedList.ToString());
            linkedList.Insert(7);
            Console.WriteLine(linkedList.ToString());

            var linkedList2 = linkedList.Next.Next;
            Console.WriteLine(linkedList2.ToString());

            var linkedStringList = new LinkedListElement<string>("Hallo");
            linkedStringList.Add("a");
            linkedStringList.Add("b");
            linkedStringList.Insert("c");
            Console.WriteLine(linkedStringList.ToString());
        }
       

    }
}
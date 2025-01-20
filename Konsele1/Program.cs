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

        static void Main(string[] args)
        {
            var serialisierer = new XmlSerializer(typeof(List<Person>));
            using (var fileStream = new FileStream("Persons.xml", FileMode.Create))
            {
                serialisierer.Serialize(fileStream, Person.Personen);
            }
        }
            
    }
}
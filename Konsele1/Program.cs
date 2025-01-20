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
            List<Person> personen = null;
            var rootAttribut = new XmlRootAttribute("personen");
            var serialisierer = new XmlSerializer(typeof(List<Person>), rootAttribut);
            using (var filestream = new FileStream("Persons.xml", FileMode.Open))
            {
                personen = (List<Person>)serialisierer.Deserialize(filestream);

            }

            foreach (var person in personen)
            {
                Console.WriteLine($"{person.ID}: {person.Vorname} {person.Name}");
            }
        }
            
    }
}
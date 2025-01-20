// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



using Konsele1;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Linq;

namespace Konsole1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var wurzel = XElement.Load("Personen.xml");
            var xmlPersonen = wurzel.Descendants("Person");
            foreach (var person in xmlPersonen)
            {
                var id = person.Attribute("Id").Value;
                var vorname = person.Descendants("Vorname").First().Value;
                var nachname = person.Descendants("Nachname").First().Value;
                Console.WriteLine($"ID: {id}, {vorname} {nachname}");
            }

            var wurzelNeu = new XElement("Personen",
                new XElement("Person",
                    new XAttribute("Id", "1"),
                    new XElement("Vorname", "Robert"),
                    new XElement("Nachname", "Schiefele")
                ),
                new XElement("Person",
                    new XAttribute("Id", "2"),
                    new XElement("Vorname", "Max"),
                    new XElement("Nachname", "Mustermann")
                ),
                new XElement("Person",
                    new XAttribute("Id", "3"),
                    new XElement("Vorname", "Marta"),
                    new XElement("Nachname", "Musterfrau")
                )
                );
            wurzelNeu.Save("Personen2.xml");
        }     
    }
}
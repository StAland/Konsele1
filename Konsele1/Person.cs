using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Konsele1
{
    [XmlType("person")]
    public class Person
    {
        [XmlAttribute("id")]
        public string ID { get; set; }
        [XmlElement("nachname")]
        public string Name { get; set; }
        [XmlElement("vorname")]
        public string Vorname { get; set; }


        public static List<Person> Personen
        {
            get
            {

                return
                [
                    new Person("1", "Mustermann", "Max"),
                    new Person("2", "Musterfrau", "Marta")
                ];
            }
        }
        public Person()
        {

        }
        public Person(string id, string name, string vorname)
        {
            ID = id;
            Name = name;
            Vorname = vorname;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    public class Kiste : IAufschliessbar, IVergleichbar<Kiste>
    {
        public int Volumen {  get; set; }

        public Kiste(int volumen) 
        { 
            Volumen = volumen;
        }
        public void Aufschliessen()
        {
            Console.WriteLine("Die Kiste wurde aufgeschlossen");
        }

        public Vergleich Vergleichen(Kiste item2)
        {
            if (Volumen == item2.Volumen)
            {
                return Vergleich.equal;
            }
            else if(Volumen > item2.Volumen)
            {
                return Vergleich.greater;
            }
            return Vergleich.smaller;
        }
    }
}

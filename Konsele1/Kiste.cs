using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    public class Kiste : IAufschliessbar
    {
        public void Aufschliessen()
        {
            Console.WriteLine("Die Kiste wurde aufgeschlossen");
        }
    }
}

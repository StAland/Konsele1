using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    internal static class BruchErweiterungen
    {
        public static Bruch TauscheZahlerNenner(this Bruch bruch)
        {
            return new Bruch(bruch.Nenner, bruch.Zaehler);
        }
    }
}

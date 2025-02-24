using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    public class Singleton
    {
        public string Value { get; set; }

        public static Singleton Instance { get; } = new();
        private Singleton() { }


    }
}

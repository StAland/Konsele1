using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    public class Singleton
    {
        private static Singleton instance = new Singleton();
        public string Value { get; set; }

        public static Singleton Instance {  get { return instance; } }
        private Singleton() { }


    }
}

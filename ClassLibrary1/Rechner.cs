using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rechner
    {
        private ISubtrahierenService _subtrahierenService;
        public Rechner(ISubtrahierenService subtrahierenService)
        {
            _subtrahierenService = subtrahierenService;
        }

        public Rechner() { }

        public int Addieren(int a, int b)
        {
            return a + b;
        }

        public int Subtrahieren(int a, int b)
        {
            if (_subtrahierenService == null)
            {
                return a - b;
            }
            return _subtrahierenService.Subtrahieren(a,b);
        }

        public double Dividieren(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("b darf nicht 0 sein");
            }
            return (double)a / (double)b;
        }
    }
}

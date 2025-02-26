using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    internal class MockEngine : IEngine
    {
        public float beschleunigen(int sec)
        {
            return 1;
        }
    }
}

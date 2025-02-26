using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    internal class Car
    {
        private IEngine _engine;
        private float _speed;

        public Car()
        {
            _engine = new Engine();
        }

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void beschleunigen(int sec)
        {
            _speed += _engine.beschleunigen(sec);
        }
    }
}

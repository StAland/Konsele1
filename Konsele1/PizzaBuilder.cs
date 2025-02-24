using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    public class PizzaBuilder
    {
        private readonly Pizza _pizza = new Pizza();
        public PizzaBuilder() { }

        public PizzaBuilder SetSize(int size)
        {
            _pizza.Size = size;
            return this;
        }

        public PizzaBuilder SetCrust(string crust)
        {
            _pizza.Crust = crust;
            return this;
        }

        public Pizza Build()
        {
            return _pizza;
        }
    }
}

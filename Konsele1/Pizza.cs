using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    public class Pizza
    {
        public class Builder
        {
            public int Size { get; set; }
            public string Crust { get; set; }
            public string Cheese { get; set; }
            public bool HasMushrooms { get; set; }
            public bool HasPinapple { get; set; }

            public Builder() 
            { 
            }

            public Pizza Build()
            {
                return new Pizza(this);
            }
        }


        public int Size { get;  }
        public string Crust { get;  }
        public string Cheese { get; }
        public bool HasMushrooms { get; }
        public bool HasPinapple {  get; }

        private Pizza(Builder builder) 
        {
            Size = builder.Size;
            Crust = builder.Crust;
            Cheese = builder.Cheese;
            HasMushrooms = builder.HasMushrooms;
            HasPinapple = builder.HasPinapple;
        }
    }
}

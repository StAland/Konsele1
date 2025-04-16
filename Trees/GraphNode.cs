using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class GraphNode
    {
        public string Name { get; }

        public GraphNode(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;

        public override bool Equals(object obj)
        {
            return obj is GraphNode other && Name == other.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}

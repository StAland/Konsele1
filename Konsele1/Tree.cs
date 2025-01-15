using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    public class Tree<T> where T : IVergleichbar<T>
    {
        public TreeNode<T> Root { get; set; }

        public Tree(T value) 
        {
            Root = new TreeNode<T>(value);
        }

        public void Add(T value)
        {
            Root.Add(value);
        }
    }
}

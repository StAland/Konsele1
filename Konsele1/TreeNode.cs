using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    public class TreeNode<T> where T : IVergleichbar<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T value)
        {
            Value = value;
        }

        public void Add(T value)
        {
            if(value.Vergleichen(Value) == Vergleich.smaller)
            {
                if (Left != null)
                {
                    Left.Add(value);
                }
                else
                {
                    Left = new TreeNode<T>(value);
                }
            }
            if(value.Vergleichen(Value) == Vergleich.greater)
            {
                if (Right != null)
                {
                    Right.Add(value);
                }
                else
                {
                    Right = new TreeNode<T>(value);
                }
            }
        }
    }
}

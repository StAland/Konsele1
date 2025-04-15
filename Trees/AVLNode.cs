using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class AVLNode
    {
        public int Value;
        public AVLNode Left;
        public AVLNode Right;
        public int Height;

        public AVLNode(int value)
        {
            Value = value;
            Height = 1;
        }
    }
}

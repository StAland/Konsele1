using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    public class LinkedListElement<T>
    {
        public T Value {  get; set; }
        public LinkedListElement<T> Next { get; private set; }

        public LinkedListElement(T value) 
        { 
            Value = value;
        }

        public void Add(T value)
        {
            if (Next == null) 
            { 
                Next = new LinkedListElement<T>(value); 
            }
            else Next.Add(value);
        }

        public void Add(LinkedListElement<T> value)
        {
            if (Next == null)
            {
                Next = value;
            }
            else Next.Add(value);
        }

        public void Insert(T value)
        {
            if (Next == null) 
            { 
                Next = new LinkedListElement<T>(value);
            }
            else
            {
                var temp = Next;
                Next = new LinkedListElement<T>(value);
                Next.Add(temp);
            }
        }

        public override string ToString()
        {
            if (Next != null)
            {
                return Value.ToString() + ";" + Next.ToString();
            }
            return Value.ToString();
        }
    }
}

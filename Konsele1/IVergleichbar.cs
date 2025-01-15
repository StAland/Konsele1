using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    public enum Vergleich
    {
        smaller,
        greater,
        equal
    }

    public interface IVergleichbar<T>
    {
        Vergleich Vergleichen(T item2);
    }
}

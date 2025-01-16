using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    public class FalscheEingabeException : Exception
    {
        public FalscheEingabeException() : base("Es wurde eine falsche Eingabe gemacht")
        {

        }

        public FalscheEingabeException(string message) : base(message)
        {

        }

        public FalscheEingabeException(string message, Exception innerException) : base(message, innerException) 
        {
        }

        public FalscheEingabeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Logger
    {

        private string _file;

        public Logger(string file) 
        {  
            _file = file; 
        }

        public void Log(string text)
        {
            using(var streamWriter = new StreamWriter(_file, true))
            {
                streamWriter.WriteLine(text);
            }
        }
    }
}

using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Aufgabe
    {
        private int _duration;
        private Logger _logger = new Logger("aufgabenlog.txt");

        public event EventHandler<string>? AufgabeFertig;
        

        public Aufgabe(int duration)
        {
            _duration = duration;
        }

        public void AufgabeAbarbeiten()
        {
            Thread.Sleep(_duration * 1000);
            AufgabeFertig?.Invoke(this, $"Aufgabe wurde in {_duration} Sekunden abgearbeitet");
            _logger.Log($"Aufgabe wurde in {_duration} Sekunden abgearbeitet");
        }
    }
}

using ClassLibrary1;

namespace Konsele1
{
    public class Haus : Gebaeude
    {
        private int _rooms;
        private ILogging _logger;
        public int Rooms
        {
            get
            {
                return _rooms;
            }
            set
            {
                if (value >= 1)
                {
                    _rooms = value;
                }
            }
        }

        public Haus(int flaeche, Gebauedefarbe farbe, int rooms, ILogging logger) : base(flaeche, farbe) 
        {
            _rooms = rooms;
            _logger = logger;
        }

        public Haus(int flaeche, int rooms, ILogging logger) : base(flaeche)
        {
            _rooms = rooms;
            _logger = logger;
        }

        public override void ZeigeGebauede()
        {
            Console.WriteLine($"Raueme: {Rooms}");
            base.ZeigeGebauede();
        }

        public override void Aufschliessen()
        {
            Console.WriteLine("Das Haus wurde aufgeschlossen");
            _logger.Log("Das Haus wurde aufgeschlossen");
        }
    }
}

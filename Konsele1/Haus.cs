namespace Konsele1
{
    public class Haus : Gebaeude
    {
        private int _rooms;
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

        public Haus(int flaeche, Gebauedefarbe farbe, int rooms) : base(flaeche, farbe) 
        {
            _rooms = rooms;
        }

        public Haus(int flaeche, int rooms) : base(flaeche)
        {
            _rooms = rooms;
        }

        public override void ZeigeGebauede()
        {
            Console.WriteLine($"Raueme: {Rooms}");
            base.ZeigeGebauede();
        }

        public override void Aufschliessen()
        {
            Console.WriteLine("Das Haus wurde aufgeschlossen");
        }
    }
}

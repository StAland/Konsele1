namespace Konsele1
{
    public class Haus
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

        public string Farbe { get; set; }

        public Haus(string farbe, int rooms)
        {
            Farbe = farbe;
            Rooms = rooms;
        }

        public Haus(string farbe) 
        {
            Farbe = farbe;
            Rooms=4;
        }

    }
}

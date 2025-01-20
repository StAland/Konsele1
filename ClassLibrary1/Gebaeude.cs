namespace ClassLibrary1
{
    public enum Gebauedefarbe
    {
        weiss,
        gelb,
        rot,
        gruen
    }
    public abstract class Gebaeude : IAufschliessbar
    {
        public int Flaeche { set; get; }
        public Gebauedefarbe Farbe { set; get; }


        public Gebaeude(int flaeche, Gebauedefarbe farbe)
        {
            Flaeche = flaeche;
            Farbe = farbe;
        }

        public Gebaeude(int flaeche)
        {
            Flaeche = flaeche;
            Farbe = Gebauedefarbe.weiss;
        }

        public virtual void ZeigeGebauede()
        {
            Console.WriteLine($"Farbe: {Farbe}, Flaeche: {Flaeche}");
        }

        public abstract void Aufschliessen();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsele1
{
    class Bruch
    {
        public int Zaehler { get; private set; }
        public int Nenner { get; private set; }

        public Bruch(int zaehler, int nenner)
        {
            if (nenner == 0)
            {
                throw new ArgumentException("Nenner darf nicht null sein.");
            }

            this.Zaehler = zaehler;
            this.Nenner = nenner;
            Kürzen();
        }

        private void Kürzen()
        {
            int gcd = GCD(Zaehler, Nenner);
            Zaehler /= gcd;
            Nenner /= gcd;
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public Bruch Addieren(Bruch anderer)
        {
            int neuerZaehler = Zaehler * anderer.Nenner + anderer.Zaehler * this.Nenner;
            int neuerNenner = this.Nenner * anderer.Nenner;
            return new Bruch(neuerZaehler, neuerNenner);
        }

        public Bruch Subtrahieren(Bruch anderer)
        {
            int neuerZaehler = this.Zaehler * anderer.Nenner - anderer.Zaehler * this.Nenner;
            int neuerNenner = this.Nenner * anderer.Nenner;
            return new Bruch(neuerZaehler, neuerNenner);
        }

        public Bruch Multiplizieren(Bruch anderer)
        {
            int neuerZaehler = this.Zaehler * anderer.Zaehler;
            int neuerNenner = this.Nenner * anderer.Nenner;
            return new Bruch(neuerZaehler, neuerNenner);
        }

        public Bruch Dividieren(Bruch anderer)
        {
            if (anderer.Zaehler == 0)
            {
                throw new ArgumentException("Division durch null ist nicht erlaubt.");
            }

            int neuerZaehler = this.Zaehler * anderer.Nenner;
            int neuerNenner = this.Nenner * anderer.Zaehler;
            return new Bruch(neuerZaehler, neuerNenner);
        }

        public override string ToString()
        {
            return $"{Zaehler}/{Nenner}";
        }

        public static Bruch operator + (Bruch a, Bruch b)
        {
            int neuerZaehler = a.Zaehler * b.Nenner + b.Zaehler * a.Nenner;
            int neuerNenner = a.Nenner * b.Nenner;
            return new Bruch(neuerZaehler, neuerNenner);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DiakApp
{
    public class Diak
    {
        public string nev { get; set; }
        public double atlag { get; set; }

        public Diak()
        {
            nev = "Kiss Péter";
            atlag = 4.5;
        }
        public Diak(string Nev, double Atlag)
        {
            Nev = nev;
            Atlag = atlag;

        }
        public Diak(string Nev2)
        {
            nev = Nev2;
            atlag = 5;
        }
    }
}

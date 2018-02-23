using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3Zad1.Model
{
    class Izvodac
    {

        public int IDIzvodjac { get; set; }
        public string Ime { get; set; }

        public override string ToString()
        {
            return "(" + IDIzvodjac + ") " + Ime;
        }

        public Izvodac()
        {

        }
        public Izvodac(int id, string ime)
        {
            this.IDIzvodjac = id;
            this.Ime = ime;

        }
    }
}

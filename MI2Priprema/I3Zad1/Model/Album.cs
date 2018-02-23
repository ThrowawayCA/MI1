using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3Zad1.Model
{
    class Album
    {
        public int IDAlbum { get; set; }
        public int IzvodjacID { get; set; }
        public string NazivAlbuma { get; set; }

        public Album()
        {

        }

        public Album(int id , int idIzvodjac, string naslov)
        {
            IDAlbum = id;
            IzvodjacID = idIzvodjac;
            NazivAlbuma = naslov;
        }

        public override string ToString()
        {
            return NazivAlbuma;
        }
    }
}

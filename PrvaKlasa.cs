using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statickeVarijableBudicMarin
{
    class PrvaKlasa
    {
        private string ime;
        private string prezime;
        private static int counter=0;
        public PrvaKlasa()
        {
            counter++;
            
        }

        public PrvaKlasa(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }

        public int Counter
        {
            get { return counter; }
            
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        public override string ToString()
        {
            string ispis = "Redni broj: " + counter+", "+ime+" "+prezime;
            return ispis;
        }
    }
}


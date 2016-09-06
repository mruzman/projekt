using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarApp
{
    class zaposlenici
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa { get; set; }
        public string OIB { get; set; }
        public string brMob { get; set; }
        public int rola { get; set; }
        public string korIme { get; set; }
        public string lozinka { get; set; }
        public zaposlenici(string ime,string prezime,string adresa,string OIB, string brMob,int rola,string korIme,string lozinka)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.adresa = adresa;
            this.OIB = OIB;
            this.brMob = brMob;
            this.rola = rola;
            this.korIme = korIme;
            this.lozinka = lozinka;
        }
        public int DodajZaposlenika()
        {
            try {
                _16023_DBDataSetTableAdapters.zaposleniciTableAdapter zaposleni = new _16023_DBDataSetTableAdapters.zaposleniciTableAdapter();
                zaposleni.InsertQuery(ime, prezime, adresa, OIB, brMob, rola, korIme, lozinka);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}

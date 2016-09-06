using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;
using System.Configuration;

namespace RentACarApp
{
    class klijent
    {
        public string ime
        {
            get; set;
        }
        public string prezime
        {
            get; set;
        }
        public string adresa
        {
            get; set;
        }
        public string broj_mobitela
        {
            get; set;
        }
        public string oib
        {
            get; set;
        }
        public klijent(string ime,string prezime,string adresa, string broj_mobitela, string oib)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.adresa = adresa;
            this.broj_mobitela = broj_mobitela;
            this.oib = oib;
        }
        public int dodaj()
        {

            try {
                _16023_DBDataSetTableAdapters.klijentiTableAdapter insertaj = new _16023_DBDataSetTableAdapters.klijentiTableAdapter();
                insertaj.InsertQuery(this.ime, this.prezime, this.adresa, this.oib, this.broj_mobitela);
                return 1;
            }
            catch
            {
                return 0;
            }

        }
        public int promjeni(int id)
        {
            try
            {
              //  _16023_DBDataSetTableAdapters.klijentiTableAdapter updejtaj = new _16023_DBDataSetTableAdapters.klijentiTableAdapter();
              //  updejtaj.UpdateQuery(this.ime, this.prezime, this.adresa, this.oib, this.broj_mobitela, id,id);
                    return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}

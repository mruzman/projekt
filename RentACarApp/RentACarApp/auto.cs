using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarApp
{
    class auto
    {
        int marka { get; set; }
        string naziv { get; set; }
        string vrijednost { get; set; }
        public auto(string naziv,int marka,string vrijednost)
        {
            this.naziv = naziv;
            this.marka = marka;
            this.vrijednost = vrijednost;
        }
        public int dodaj()
        {
            try {
                _16023_DBDataSetTableAdapters.automobiliTableAdapter dodaj = new _16023_DBDataSetTableAdapters.automobiliTableAdapter();
                dodaj.InsertQuery(this.marka, this.naziv, this.vrijednost);
                return 1; }
            catch
            {
                return 0;
            }
        }
    }
}

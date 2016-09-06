using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarApp
{
    public partial class RentACar : Form
    {
        public int nesto;
        public int upisi=0;
        public string datum;
        public RentACar(int id)
        {
            InitializeComponent();
            upisi = id;
        }

        private void dodajNovogKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodaj_novog_klijenta dodaj = new Dodaj_novog_klijenta();
            dodaj.ShowDialog();
        }

        private void izlazakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite izaći iz aplikacije?", "Izađi iz aplikacije", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void oAplikacijiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            o_aplikaciji f2 = new o_aplikaciji();
            f2.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Uredi_postojeceg uredi = new Uredi_postojeceg();
            uredi.ShowDialog();
        }

        
        private void RentACar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16023_DBDataSet.privremena' table. You can move, or remove it, as needed.
            this.privremenaTableAdapter.Fill(this._16023_DBDataSet.privremena);
            // TODO: This line of code loads data into the '_16023_DBDataSet.klijenti1' table. You can move, or remove it, as needed.
            this.klijenti1TableAdapter.Fill(this._16023_DBDataSet.klijenti1);
            // TODO: This line of code loads data into the '_16023_DBDataSet.zaposlenici1' table. You can move, or remove it, as needed.
            this.zaposlenici1TableAdapter.Fill(this._16023_DBDataSet.zaposlenici1);
            // TODO: This line of code loads data into the '_16023_DBDataSet1.zaposlenici' table. You can move, or remove it, as needed.
            this.zaposleniciTableAdapter.Fill(this._16023_DBDataSet1.zaposlenici);
            // TODO: This line of code loads data into the '_16023_DBDataSet.servisirano1' table. You can move, or remove it, as needed.
            this.servisirano1TableAdapter.FillServisi(this._16023_DBDataSet.servisirano1);
            // TODO: This line of code loads data into the '_16023_DBDataSet.servisirano' table. You can move, or remove it, as needed.
            this.servisiranoTableAdapter.Fill(this._16023_DBDataSet.servisirano);

        }

        private void rezervirajAutomobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rezervirajForma nova = new rezervirajForma();
            nova.ShowDialog();
        }
        private void izradiRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onemoguci();
            btnIspisi.Visible = true;
            btnOdustani.Visible = true;
            dataGridView2.Visible = true;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            cmbKlijent.Visible = true;
            cmbZaposlenik.Visible = true;
            DatumIzdavanja.Visible = true;
            cmbZaposlenik.SelectedValue = upisi;
            btnDodajStavke.Visible = true;
            datum = DateTime.Now.ToString();


        }

        private void pregledServisaAutomobilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onemoguci();
            dataGridView1.Visible = true;
        }
        private void pregledajRezerviraneAutomobieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pregledRezerviranih pregled = new pregledRezerviranih();
            pregled.ShowDialog();
        }

        private void pregledajSlobodneAutomobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pregledSlobodnih pregled = new pregledSlobodnih();
            pregled.ShowDialog();
        }
        private void onemoguci()
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            cmbKlijent.Visible = false;
            cmbZaposlenik.Visible = false;
            DatumIzdavanja.Visible = false;
            btnIspisi.Visible = false;
            btnOdustani.Visible = false;
            btnDodajStavke.Visible = false;
            

        }

        private void btnOdustani_Click_1(object sender, EventArgs e)
        {
            onemoguci();
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            try
            {
                _16023_DBDataSetTableAdapters.racunTableAdapter nova = new _16023_DBDataSetTableAdapters.racunTableAdapter();
                nova.InsertQuery(int.Parse(cmbZaposlenik.SelectedValue.ToString()), int.Parse(cmbKlijent.SelectedValue.ToString()), DateTime.Parse(datum));

            }
            catch
            {
                MessageBox.Show("Dogodila se greška!");
            }
        }

        private void btnDodajStavke_Click(object sender, EventArgs e)
        {
            int auto;
            DateTime iznajmi_od;
            DateTime iznajmi_do;
            float cijena;
            int broj;
            int rez;
            broj=int.Parse(cmbKlijent.SelectedValue.ToString());
            using (var stavka = new OdaberiStavke(broj))
            {
                var rezultat = stavka.ShowDialog();
                if (rezultat == DialogResult.OK)
                {
                    rez = stavka.stavke;
                    _16023_DBDataSetTableAdapters.rezerviranoTableAdapter dohvati = new _16023_DBDataSetTableAdapters.rezerviranoTableAdapter();
                    DataTable podaci = new DataTable();
                    podaci.Rows.Add(dohvati.GetDataById(rez));
                    iznajmi_od = DateTime.Parse(podaci.Rows[1].ToString());
                    iznajmi_do = DateTime.Parse(dohvati.GetDataById(rez).Rows[2].ToString());
                    auto = int.Parse(dohvati.GetDataById(rez).Rows[1].ToString());
                    cijena = izracunajCijenu(iznajmi_od,iznajmi_do);
                    _16023_DBDataSetTableAdapters.privremenaTableAdapter ubaci = new _16023_DBDataSetTableAdapters.privremenaTableAdapter();
                    ubaci.InsertQuery(1, auto, iznajmi_od, iznajmi_do, cijena);
                    
                    
                }
            }
            

        }
        private float izracunajCijenu(DateTime datum1,DateTime datum2)
        {
            int poSatu=0;
            int godina,godina2,mjesec,mjesec2, dan,dan2, sat,sat2=0;
            float cijena=0;
            godina = int.Parse(datum1.Year.ToString());
            mjesec = int.Parse(datum1.Month.ToString());
            dan=int.Parse(datum1.Day.ToString());
            sat = int.Parse(datum1.Hour.ToString());
            godina2 = int.Parse(datum2.Year.ToString());
            mjesec2 = int.Parse(datum2.Month.ToString());
            dan2 = int.Parse(datum2.Day.ToString());
            sat2 = int.Parse(datum2.Hour.ToString());
            while (mjesec < mjesec2)
            {
                if (mjesec == 1 || mjesec == 3 || mjesec == 5 || mjesec == 7 || mjesec == 8 || mjesec == 10 || mjesec == 12)
                {
                    cijena = cijena + 31;
                }else if (mjesec == 2)
                {
                    if (godina % 4 == 0)
                    {
                        cijena = cijena + 29;
                    }
                    else
                    {
                        cijena = cijena + 28;
                    }
                }
                else
                {
                    cijena = cijena + 30;
                }
                mjesec++;
            }
            while(godina<godina2){
                cijena = cijena + 365;
                godina++;
            }
            while (sat < sat2)
            {
                poSatu = poSatu + 1;
                sat++;
            }
            poSatu = poSatu * 20;
            cijena = ((cijena * 24) * 20) + poSatu;
            return cijena;

            
        }

        private void cmbKlijent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnDodajStavke.Enabled = true;
        }

        private void dataGridView2_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            btnIspisi.Enabled = true;
        }
    }
}

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
    public partial class rezervirajForma : Form
    {
        bool greska = true;
        public string iznajmljen_od;
        public string iznajmljen_do;
        public int autic;
        public int klijent;

        public rezervirajForma()
        {
            InitializeComponent();
        }

        private void rezervirajForma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16023_DBDataSet.klijenti1' table. You can move, or remove it, as needed.
            this.klijenti1TableAdapter.Fill(this._16023_DBDataSet.klijenti1);
            this.markeTableAdapter.Fill(this._16023_DBDataSet.marke);
            cmbMarka.Text = "Izaberite marku:";
            cmbTip.Text = "";
        }
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            selektajauto();
        }
        
     
        private void selektajauto()
        {
            this.automobiliTableAdapter.Fill(this._16023_DBDataSet.automobili);
            if (this.automobiliTableAdapter.FillByMarka(this._16023_DBDataSet.automobili, (int.Parse(cmbMarka.SelectedValue.ToString()))) ==0)
            { 
            cmbTip.Text = "Nemamo auta s tom markom u izlogu!";
            cmbTip.Enabled = false;
            }
            else
            {
                cmbTip.Enabled = true;
                cmbTip.Text = "Izaberite tip";
            }
           
        }
        private void provjeri_za_gumb()
        {
            string prvi_vure,drugi_vure;
            lblGreska.Visible = false;
            string vure_od, vure_do;
            vure_od = txtVureOd.Text.ToString();
            vure_do = txtVureDo.Text.ToString();
            prvi_vure = vure_od.Split(':')[0];
            drugi_vure = vure_do.Split(':')[0];
            greska = true;
            if (vure_od == "  :" || vure_do == "  :")
            {
                lblGreska.Text = "Prazna su vremena!";
                greska = false;
            }
            else if (vure_od.Split(':')[1].Length!=2 || vure_do.Split(':')[1].Length != 2)
            {
                lblGreska.Text = "Prazna su vremena!";
                greska = false;
            }
            else {
                if (int.Parse(prvi_vure.ToString()) >= 24 || int.Parse(drugi_vure.ToString()) >= 24)
                {
                    lblGreska.Text = "Nemože biti više od 24 sata";
                    greska = false;
                }
                else {
                    string dan, mjesec, godina;
                    dan = dtOd.Value.Day.ToString();
                    mjesec = dtOd.Value.Month.ToString();
                    godina = dtOd.Value.Year.ToString();
                    iznajmljen_od = dan + "." + mjesec + "." + godina + "." + " " + txtVureOd.Text.ToString();
                    dan = dtDo.Value.Day.ToString();
                    mjesec = dtDo.Value.Month.ToString();
                    godina = dtDo.Value.Year.ToString();
                    iznajmljen_do = dan + "." + mjesec + "." + godina + "." + " " + txtVureDo.Text.ToString();
                    lblGreska.Text = "";
                    if (iznajmljen_do == iznajmljen_od)
                    {
                        lblGreska.Text = "Greška u unosu!";
                        greska = false;

                    }
                    if (DateTime.Parse(iznajmljen_od.ToString()) > DateTime.Parse(iznajmljen_do.ToString()))
                    {
                        lblGreska.Text = "Završena rezervacija?";
                        greska = false;
                    }
                    if (dtOd.Value < DateTime.Today)
                    {
                        lblGreska.Text = "Želite rezervirati za jučer??";
                        greska = false;
                    }
                    if (int.Parse(cmbTip.SelectedIndex.ToString()) == -1)
                    {
                        lblGreska.Text = "Izaberite tip vozila";
                        greska = false;
                    }
                    if (int.Parse(cmbKlijent.SelectedIndex.ToString()) == -1)
                    {
                        greska = false;
                        lblGreska.Text = "Niste izabrali klijenta";
                    }
                }
            }

            if (greska == true)
            {
                btnZavrsi.Enabled = true;
            }
            else
            {
                lblGreska.Visible = true;
                btnZavrsi.Enabled = false;
            }
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            lblGreska.Visible = false;
            string dan, mjesec, godina;
            dan = dtOd.Value.Day.ToString();
            mjesec = dtOd.Value.Month.ToString();
            godina = dtOd.Value.Year.ToString();
            iznajmljen_od = dan + "." + mjesec + "." + godina + "." + " " + txtVureOd.Text.ToString();
            dan = dtDo.Value.Day.ToString();
            mjesec = dtDo.Value.Month.ToString();
            godina = dtDo.Value.Year.ToString();
            iznajmljen_do = dan + "." + mjesec + "." + godina + "." + " " + txtVureDo.Text.ToString();
            klijent = int.Parse(cmbKlijent.SelectedValue.ToString());
            autic = int.Parse(cmbTip.SelectedValue.ToString());
            if (provjeri()== true)
            {
                try {
                    _16023_DBDataSetTableAdapters.rezerviranoTableAdapter rezerviraj = new _16023_DBDataSetTableAdapters.rezerviranoTableAdapter();
                    rezerviraj.InsertQuery(autic, DateTime.Parse(iznajmljen_od.ToString()), DateTime.Parse(iznajmljen_do.ToString()), klijent);
                    MessageBox.Show("Unesena je rezervacija!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Dogodila se greška!");
                }
            }
            else
            {
                lblGreska.Visible = true;
            }
        }
        private bool provjeri()
        {
            bool zauzeto=true;
            try {
                _16023_DBDataSetTableAdapters.rezerviranoTableAdapter provjeriti_rezervirano = new _16023_DBDataSetTableAdapters.rezerviranoTableAdapter();
                if (provjeriti_rezervirano.GetDataByAutomobil(autic).Rows.Count == 0)
                {
                    greska = false;
                }
                else {
                    foreach(DataRow red in provjeriti_rezervirano.GetDataByAutomobil(autic).Rows)
                    {
                        if (DateTime.Parse(red[2].ToString()) < DateTime.Parse(iznajmljen_od.ToString())&&(DateTime.Parse(iznajmljen_od.ToString())<DateTime.Parse(red[3].ToString())))
                        {
                            zauzeto = false;
                        }
                        else if((DateTime.Parse(red[2].ToString())<DateTime.Parse(iznajmljen_do.ToString()))&&(DateTime.Parse(red[3].ToString())>DateTime.Parse(iznajmljen_do.ToString())))
                        {
                            zauzeto = false;
                        }
                        else
                        {
                            zauzeto = true;
                        }
                    }
                    if (zauzeto == false)
                    {
                        MessageBox.Show("Rezerviran auto u tom periodu! Molimo pogledajte slobodne termine za ovaj automobil!");
                        greska = true;
                    }
                    else
                    {
                        greska = false;
                    }
                    
                }
                if (!greska)
                {
                    lblGreska.Visible = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Dogodila se greška pri uspostavi konekcije");
                return false;
            }
        }

        private void rezervirajForma_Click(object sender, EventArgs e)
        {
            provjeri_za_gumb();
        }
        private void inicijalizacija()
        {
            dtDo.Value = DateTime.Now;
            dtOd.Value = DateTime.Now;
            cmbTip.SelectedIndex = -1;
            txtVureOd.Text = StartPosition.ToString();
            txtVureDo.Text = StartPosition.ToString();

        }

        private void btnInicijaliziraj_Click(object sender, EventArgs e)
        {
            inicijalizacija();
        }

        private void txtVureOd_TextChanged(object sender, EventArgs e)
        {
            provjeri_za_gumb();
        }

        private void txtVureDo_TextChanged(object sender, EventArgs e)
        {
            provjeri_za_gumb();
        }

        private void dtDo_ValueChanged(object sender, EventArgs e)
        {
            provjeri_za_gumb();
        }

        private void dtOd_ValueChanged(object sender, EventArgs e)
        {
            provjeri_za_gumb();
        }
    }
}

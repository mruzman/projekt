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
    public partial class pregledSlobodnih : Form
    {
        public pregledSlobodnih()
        {
            InitializeComponent();
        }

        private void pregledSlobodnih_Load(object sender, EventArgs e)
        {
            this.markeTableAdapter.Fill(this._16023_DBDataSet.marke);
        }        
        private void cmbMarka_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                cmbVozilo.Enabled = true;
                this.automobiliTableAdapter.Fill(this._16023_DBDataSet.automobili);
                this.automobiliTableAdapter.FillByMarka(this._16023_DBDataSet.automobili, int.Parse(cmbMarka.SelectedValue.ToString()));
            }
            catch { }
        }

        

        private void cmbVozilo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _16023_DBDataSetTableAdapters.rezerviranoTableAdapter rezervirani = new _16023_DBDataSetTableAdapters.rezerviranoTableAdapter();
            if (rezervirani.GetDataByAutomobil(int.Parse(cmbVozilo.SelectedValue.ToString())).Rows.Count == 0)
            {
                lblZauzetost.Visible = true;
                lblZauzetost.Text = "Automobil je slobodan!";
                lblTekst.Visible = false;
                lblDostupan.Visible = false;
            }
            else
            {
                foreach (DataRow red in rezervirani.GetDataByAutomobil(int.Parse(cmbVozilo.SelectedValue.ToString())))
                {
                    if ((DateTime.Parse(red[3].ToString()) > DateTime.Today) && (DateTime.Parse(red[2].ToString()) < DateTime.Today))
                    {
                        lblDostupan.Visible = true;
                        lblTekst.Visible = true;
                        lblZauzetost.Text = "Auto je zauzet";
                        lblZauzetost.Visible = true;
                        lblDostupan.Text = red[3].ToString();
                    }
                }
            }
        }

        
        
    }
}

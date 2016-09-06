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
    public partial class pregledRezerviranih : Form
    {
        public pregledRezerviranih()
        {
            InitializeComponent();
        }

        private void pregledRezerviranih_Load(object sender, EventArgs e)
        {
            this.markeTableAdapter.Fill(this._16023_DBDataSet.marke);
            cmbMarka.Text = "Izaberite marku";

        }

        

        private void cmbTip_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.rezerviranoTableAdapter.Fill(this._16023_DBDataSet.rezervirano);
            this.rezerviranoTableAdapter.FillByAutomobil(this._16023_DBDataSet.rezervirano, int.Parse(cmbTip.SelectedValue.ToString()));   
        }

        private void cmbMarka_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.automobiliTableAdapter.Fill(this._16023_DBDataSet.automobili);
            if (this.automobiliTableAdapter.FillByMarka(this._16023_DBDataSet.automobili, (int.Parse(cmbMarka.SelectedValue.ToString()))) == 0)
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
    }
}

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
    public partial class servis : Form
    {
        public servis()
        {
            InitializeComponent();
        }

        private void servis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16023_DBDataSet.zaposlenici' table. You can move, or remove it, as needed.
            this.zaposleniciTableAdapter.Fill(this._16023_DBDataSet.zaposlenici);
            // TODO: This line of code loads data into the '_16023_DBDataSet.automobili' table. You can move, or remove it, as needed.
            this.automobiliTableAdapter.Fill(this._16023_DBDataSet.automobili);

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            int auto;
            int zaposlenik;
            string datum;
            auto = int.Parse(comboBox1.SelectedValue.ToString());
            zaposlenik = int.Parse(comboBox2.SelectedValue.ToString());
            datum = dateTimePicker1.Text.ToString();
            try {
                _16023_DBDataSetTableAdapters.servisiranoTableAdapter servis = new _16023_DBDataSetTableAdapters.servisiranoTableAdapter();
                servis.InsertQuery(auto, zaposlenik, datum);
                MessageBox.Show("Uspješno uneseno!");
            }
            catch
            {
                MessageBox.Show("Greška unosa");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite izaći iz aplikacije? Nećete sačuvati promjene!", "Izađi iz aplikacije", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}

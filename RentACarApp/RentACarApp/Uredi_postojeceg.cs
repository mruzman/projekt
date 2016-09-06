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
    public partial class Uredi_postojeceg : Form
    {
        public int broj = 0;
        public Uredi_postojeceg()
        {
            InitializeComponent();
        }

        private void Uredi_postojeceg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16023_DBDataSet.klijenti' table. You can move, or remove it, as needed.
            this.klijentiTableAdapter.Fill(this._16023_DBDataSet.klijenti);
            
        }
        private void dataGridView1_MultiSelectChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Nemožete urediti više od jednom!");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (broj > 0)
            {
                int vri;
                vri = int.Parse(dataGridView1.SelectedRows[0].ToString());
                Dodaj_novog_klijenta nova = new Dodaj_novog_klijenta(vri);
                nova.ShowDialog();
            }broj++;
        }
    }
}

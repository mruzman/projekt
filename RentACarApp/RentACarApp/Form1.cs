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
    public partial class Form1 : Form
    {
        public string korIme;
        public string lozinka;
        public Form1()
        {
            InitializeComponent();
            
            if (string.IsNullOrWhiteSpace(txtKorIme.Text) || string.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                btnPrijavi.Enabled = false;
            }
            
        }

        private void btnPrijavi_Click(object sender, EventArgs e){
            korIme = txtKorIme.Text;
            lozinka = txtLozinka.Text;
            try {
                _16023_DBDataSetTableAdapters.zaposleniciTableAdapter provjera = new _16023_DBDataSetTableAdapters.zaposleniciTableAdapter();
                _16023_DBDataSet.zaposleniciDataTable nova = new _16023_DBDataSet.zaposleniciDataTable();
                provjera.zaLogiranjeFill(nova, korIme, lozinka);
                int rez = nova.Rows.Count;
                if (rez == 1)
                {
                    int rola = 0;
                    DataRow[] rezultat = nova.Select();
                    foreach (DataRow row in rezultat)
                    {
                        rola = int.Parse(row[6].ToString());
                        korIme = row[0].ToString();
                    }
                    if (rola == 1)
                    {
                        if (MessageBox.Show("Želite li ući u direktorski način rada?", "Direktorski način rada", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            this.Hide();
                            DirektorskiMod rent = new DirektorskiMod();
                            rent.Closed += (s, args) => this.Close();
                            rent.Show();
                        }
                        else
                        {
                            MessageBox.Show("Logirani ste!");
                            this.Hide();
                            RentACar rent = new RentACar(int.Parse(korIme));
                            rent.Closed += (s, args) => this.Close();
                            rent.Show();
                        }

                    }
                    else {
                        MessageBox.Show("Logirani ste!");
                        this.Hide();
                        RentACar rent = new RentACar(int.Parse(korIme));
                        rent.Closed += (s, args) => this.Close();
                        rent.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Pogrešno korisničko ime i/ili lozinka");
                }
            }
            catch
            {
                MessageBox.Show("Provjerite internet vezu!");
            }
             
        }

        private void txtKorIme_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorIme.Text) || string.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                btnPrijavi.Enabled = false;
            }
            else
            {
                btnPrijavi.Enabled = true;
            }
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorIme.Text) || string.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                btnPrijavi.Enabled = false;
            }
            else
            {
                btnPrijavi.Enabled = true;
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            
            txtKorIme.Text = null;
            txtLozinka.Text = null;
            
        }

        private void txtKorIme_Click(object sender, EventArgs e)
        {
            tssStrip1.Text = "Unos vašeg korisničkog imena";
            
        }

        private void txtLozinka_Click(object sender, EventArgs e)
        {
            tssStrip1.Text = "Unos vaše lozinke";
            if (string.IsNullOrWhiteSpace(txtKorIme.Text))
            {
                MessageBox.Show("Unesite korisničko ime!");
            }
        }
        private void oAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_aplikaciji f2 = new o_aplikaciji();
            f2.ShowDialog();
        }

        private void oAplikacijiToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            tssStrip1.Text = "Pogledajte sve o aplikaciji";
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

            tssStrip1.Text = "Dobro došli u prijavu";
        }

        private void btnInit_MouseHover(object sender, EventArgs e)
        {
            tssStrip1.Text = "Postavi sve na početak!";
        }

        private void izlazakToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite izaći iz aplikacije?", "Izađi iz aplikacije", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

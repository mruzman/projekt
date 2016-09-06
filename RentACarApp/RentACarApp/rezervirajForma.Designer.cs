namespace RentACarApp
{
    partial class rezervirajForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtOd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.markeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16023_DBDataSet = new RentACarApp._16023_DBDataSet();
            this.txtVureOd = new System.Windows.Forms.MaskedTextBox();
            this.dtDo = new System.Windows.Forms.DateTimePicker();
            this.txtVureDo = new System.Windows.Forms.MaskedTextBox();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.btnInicijaliziraj = new System.Windows.Forms.Button();
            this.lblGreska = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.automobiliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markeTableAdapter = new RentACarApp._16023_DBDataSetTableAdapters.markeTableAdapter();
            this.automobiliTableAdapter = new RentACarApp._16023_DBDataSetTableAdapters.automobiliTableAdapter();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.klijenti1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.klijenti1TableAdapter = new RentACarApp._16023_DBDataSetTableAdapters.klijenti1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.markeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobiliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijenti1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtOd
            // 
            this.dtOd.Location = new System.Drawing.Point(121, 174);
            this.dtOd.Name = "dtOd";
            this.dtOd.Size = new System.Drawing.Size(187, 20);
            this.dtOd.TabIndex = 3;
            this.dtOd.Value = new System.DateTime(2016, 9, 8, 0, 0, 0, 0);
            this.dtOd.ValueChanged += new System.EventHandler(this.dtOd_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rezervacija auta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razdoblje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Do:";
            // 
            // cmbMarka
            // 
            this.cmbMarka.DataSource = this.markeBindingSource;
            this.cmbMarka.DisplayMember = "naziv";
            this.cmbMarka.Location = new System.Drawing.Point(120, 46);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(234, 21);
            this.cmbMarka.TabIndex = 1;
            this.cmbMarka.ValueMember = "Id";
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // markeBindingSource
            // 
            this.markeBindingSource.DataMember = "marke";
            this.markeBindingSource.DataSource = this._16023_DBDataSet;
            // 
            // _16023_DBDataSet
            // 
            this._16023_DBDataSet.DataSetName = "_16023_DBDataSet";
            this._16023_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtVureOd
            // 
            this.txtVureOd.Location = new System.Drawing.Point(314, 174);
            this.txtVureOd.Mask = "00:00";
            this.txtVureOd.Name = "txtVureOd";
            this.txtVureOd.Size = new System.Drawing.Size(41, 20);
            this.txtVureOd.TabIndex = 4;
            this.txtVureOd.ValidatingType = typeof(System.DateTime);
            this.txtVureOd.TextChanged += new System.EventHandler(this.txtVureOd_TextChanged);
            // 
            // dtDo
            // 
            this.dtDo.Location = new System.Drawing.Point(121, 210);
            this.dtDo.Name = "dtDo";
            this.dtDo.Size = new System.Drawing.Size(187, 20);
            this.dtDo.TabIndex = 5;
            this.dtDo.Value = new System.DateTime(2016, 9, 8, 0, 0, 0, 0);
            this.dtDo.ValueChanged += new System.EventHandler(this.dtDo_ValueChanged);
            // 
            // txtVureDo
            // 
            this.txtVureDo.Location = new System.Drawing.Point(314, 210);
            this.txtVureDo.Mask = "00:00";
            this.txtVureDo.Name = "txtVureDo";
            this.txtVureDo.Size = new System.Drawing.Size(41, 20);
            this.txtVureDo.TabIndex = 6;
            this.txtVureDo.ValidatingType = typeof(System.DateTime);
            this.txtVureDo.TextChanged += new System.EventHandler(this.txtVureDo_TextChanged);
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.Enabled = false;
            this.btnZavrsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZavrsi.Location = new System.Drawing.Point(12, 299);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(221, 58);
            this.btnZavrsi.TabIndex = 7;
            this.btnZavrsi.Text = "Zaključi rezervaciju";
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // btnInicijaliziraj
            // 
            this.btnInicijaliziraj.Location = new System.Drawing.Point(244, 299);
            this.btnInicijaliziraj.Name = "btnInicijaliziraj";
            this.btnInicijaliziraj.Size = new System.Drawing.Size(111, 58);
            this.btnInicijaliziraj.TabIndex = 8;
            this.btnInicijaliziraj.Text = "Inicijaliziraj";
            this.btnInicijaliziraj.UseVisualStyleBackColor = true;
            this.btnInicijaliziraj.Click += new System.EventHandler(this.btnInicijaliziraj_Click);
            // 
            // lblGreska
            // 
            this.lblGreska.AutoSize = true;
            this.lblGreska.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGreska.Location = new System.Drawing.Point(13, 276);
            this.lblGreska.Name = "lblGreska";
            this.lblGreska.Size = new System.Drawing.Size(51, 20);
            this.lblGreska.TabIndex = 10;
            this.lblGreska.Text = "label4";
            this.lblGreska.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Od:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Marka automobila:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tip automobila:";
            // 
            // cmbTip
            // 
            this.cmbTip.DataSource = this.automobiliBindingSource;
            this.cmbTip.DisplayMember = "naziv";
            this.cmbTip.Enabled = false;
            this.cmbTip.Location = new System.Drawing.Point(120, 89);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(234, 21);
            this.cmbTip.TabIndex = 2;
            this.cmbTip.ValueMember = "Id";
            // 
            // automobiliBindingSource
            // 
            this.automobiliBindingSource.DataMember = "automobili";
            this.automobiliBindingSource.DataSource = this._16023_DBDataSet;
            // 
            // markeTableAdapter
            // 
            this.markeTableAdapter.ClearBeforeFill = true;
            // 
            // automobiliTableAdapter
            // 
            this.automobiliTableAdapter.ClearBeforeFill = true;
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.DataSource = this.klijenti1BindingSource;
            this.cmbKlijent.DisplayMember = "klijent";
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(121, 236);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(233, 21);
            this.cmbKlijent.TabIndex = 14;
            this.cmbKlijent.ValueMember = "Id";
            // 
            // klijenti1BindingSource
            // 
            this.klijenti1BindingSource.DataMember = "klijenti1";
            this.klijenti1BindingSource.DataSource = this._16023_DBDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Klijent:";
            // 
            // klijenti1TableAdapter
            // 
            this.klijenti1TableAdapter.ClearBeforeFill = true;
            // 
            // rezervirajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 369);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbKlijent);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGreska);
            this.Controls.Add(this.btnInicijaliziraj);
            this.Controls.Add(this.btnZavrsi);
            this.Controls.Add(this.txtVureDo);
            this.Controls.Add(this.dtDo);
            this.Controls.Add(this.txtVureOd);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtOd);
            this.Name = "rezervirajForma";
            this.Text = "rezervirajForma";
            this.Load += new System.EventHandler(this.rezervirajForma_Load);
            this.Click += new System.EventHandler(this.rezervirajForma_Click);
            ((System.ComponentModel.ISupportInitialize)(this.markeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobiliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijenti1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtOd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMarka;
        private _16023_DBDataSet _16023_DBDataSet;
        private System.Windows.Forms.MaskedTextBox txtVureOd;
        private System.Windows.Forms.DateTimePicker dtDo;
        private System.Windows.Forms.MaskedTextBox txtVureDo;
        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.Button btnInicijaliziraj;
        private System.Windows.Forms.Label lblGreska;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.BindingSource markeBindingSource;
        private _16023_DBDataSetTableAdapters.markeTableAdapter markeTableAdapter;
        private System.Windows.Forms.BindingSource automobiliBindingSource;
        private _16023_DBDataSetTableAdapters.automobiliTableAdapter automobiliTableAdapter;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource klijenti1BindingSource;
        private _16023_DBDataSetTableAdapters.klijenti1TableAdapter klijenti1TableAdapter;
    }
}
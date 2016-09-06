namespace RentACarApp
{
    partial class pregledSlobodnih
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblZauzetost = new System.Windows.Forms.Label();
            this.lblTekst = new System.Windows.Forms.Label();
            this.lblDostupan = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.markeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16023_DBDataSet = new RentACarApp._16023_DBDataSet();
            this.cmbVozilo = new System.Windows.Forms.ComboBox();
            this.automobiliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markeTableAdapter = new RentACarApp._16023_DBDataSetTableAdapters.markeTableAdapter();
            this.automobiliTableAdapter = new RentACarApp._16023_DBDataSetTableAdapters.automobiliTableAdapter();
            this.markaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.markaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.markeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobiliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberite marku atuomobila:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odaberite tip automobila:";
            // 
            // lblZauzetost
            // 
            this.lblZauzetost.AutoSize = true;
            this.lblZauzetost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZauzetost.Location = new System.Drawing.Point(138, 94);
            this.lblZauzetost.Name = "lblZauzetost";
            this.lblZauzetost.Size = new System.Drawing.Size(242, 22);
            this.lblZauzetost.TabIndex = 2;
            this.lblZauzetost.Text = "Automobil je zauzet/slobodan";
            this.lblZauzetost.Visible = false;
            // 
            // lblTekst
            // 
            this.lblTekst.AutoSize = true;
            this.lblTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTekst.Location = new System.Drawing.Point(12, 130);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(262, 20);
            this.lblTekst.TabIndex = 3;
            this.lblTekst.Text = "Automobil će biti sljedeće dostupan:";
            this.lblTekst.Visible = false;
            // 
            // lblDostupan
            // 
            this.lblDostupan.AutoSize = true;
            this.lblDostupan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDostupan.Location = new System.Drawing.Point(280, 130);
            this.lblDostupan.Name = "lblDostupan";
            this.lblDostupan.Size = new System.Drawing.Size(51, 20);
            this.lblDostupan.TabIndex = 4;
            this.lblDostupan.Text = "label5";
            this.lblDostupan.Visible = false;
            // 
            // cmbMarka
            // 
            this.cmbMarka.DataSource = this.markeBindingSource;
            this.cmbMarka.DisplayMember = "naziv";
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(192, 9);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(288, 21);
            this.cmbMarka.TabIndex = 5;
            this.cmbMarka.ValueMember = "Id";
            this.cmbMarka.SelectionChangeCommitted += new System.EventHandler(this.cmbMarka_SelectionChangeCommitted);
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
            // cmbVozilo
            // 
            this.cmbVozilo.DataSource = this.automobiliBindingSource;
            this.cmbVozilo.DisplayMember = "naziv";
            this.cmbVozilo.Enabled = false;
            this.cmbVozilo.FormattingEnabled = true;
            this.cmbVozilo.Location = new System.Drawing.Point(192, 44);
            this.cmbVozilo.Name = "cmbVozilo";
            this.cmbVozilo.Size = new System.Drawing.Size(288, 21);
            this.cmbVozilo.TabIndex = 6;
            this.cmbVozilo.ValueMember = "Id";
            this.cmbVozilo.SelectionChangeCommitted += new System.EventHandler(this.cmbVozilo_SelectionChangeCommitted);
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
            // markaToolStripLabel
            // 
            this.markaToolStripLabel.Name = "markaToolStripLabel";
            this.markaToolStripLabel.Size = new System.Drawing.Size(23, 23);
            // 
            // markaToolStripTextBox
            // 
            this.markaToolStripTextBox.Name = "markaToolStripTextBox";
            this.markaToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // pregledSlobodnih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 173);
            this.Controls.Add(this.cmbVozilo);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.lblDostupan);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.lblZauzetost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "pregledSlobodnih";
            this.Text = "Slobodni automobili";
            this.Load += new System.EventHandler(this.pregledSlobodnih_Load);
            ((System.ComponentModel.ISupportInitialize)(this.markeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobiliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblZauzetost;
        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.Label lblDostupan;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbVozilo;
        private _16023_DBDataSet _16023_DBDataSet;
        private System.Windows.Forms.BindingSource markeBindingSource;
        private _16023_DBDataSetTableAdapters.markeTableAdapter markeTableAdapter;
        private System.Windows.Forms.BindingSource automobiliBindingSource;
        private _16023_DBDataSetTableAdapters.automobiliTableAdapter automobiliTableAdapter;
        private System.Windows.Forms.ToolStripLabel markaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox markaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
    }
}
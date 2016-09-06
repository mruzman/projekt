namespace RentACarApp
{
    partial class pregledRezerviranih
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznajmljenodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznajmljendoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezerviranoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16023_DBDataSet = new RentACarApp._16023_DBDataSet();
            this.stavkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.markeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markeTableAdapter = new RentACarApp._16023_DBDataSetTableAdapters.markeTableAdapter();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.automobiliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobiliTableAdapter = new RentACarApp._16023_DBDataSetTableAdapters.automobiliTableAdapter();
            this.autoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.autoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stavkeTableAdapter = new RentACarApp._16023_DBDataSetTableAdapters.stavkeTableAdapter();
            this.autoToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.autoToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.rezerviranoTableAdapter = new RentACarApp._16023_DBDataSetTableAdapters.rezerviranoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezerviranoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobiliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iznajmljenodDataGridViewTextBoxColumn,
            this.iznajmljendoDataGridViewTextBoxColumn,
            this.klijent});
            this.dataGridView1.DataSource = this.rezerviranoBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(530, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // iznajmljenodDataGridViewTextBoxColumn
            // 
            this.iznajmljenodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iznajmljenodDataGridViewTextBoxColumn.DataPropertyName = "iznajmljen_od";
            this.iznajmljenodDataGridViewTextBoxColumn.HeaderText = "iznajmljen_od";
            this.iznajmljenodDataGridViewTextBoxColumn.Name = "iznajmljenodDataGridViewTextBoxColumn";
            this.iznajmljenodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iznajmljendoDataGridViewTextBoxColumn
            // 
            this.iznajmljendoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iznajmljendoDataGridViewTextBoxColumn.DataPropertyName = "iznajmljen_do";
            this.iznajmljendoDataGridViewTextBoxColumn.HeaderText = "iznajmljen_do";
            this.iznajmljendoDataGridViewTextBoxColumn.Name = "iznajmljendoDataGridViewTextBoxColumn";
            this.iznajmljendoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // klijent
            // 
            this.klijent.DataPropertyName = "klijent";
            this.klijent.HeaderText = "Šifra klijenta:";
            this.klijent.Name = "klijent";
            this.klijent.ReadOnly = true;
            // 
            // rezerviranoBindingSource
            // 
            this.rezerviranoBindingSource.DataMember = "rezervirano";
            this.rezerviranoBindingSource.DataSource = this._16023_DBDataSet;
            // 
            // _16023_DBDataSet
            // 
            this._16023_DBDataSet.DataSetName = "_16023_DBDataSet";
            this._16023_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stavkeBindingSource
            // 
            this.stavkeBindingSource.DataMember = "stavke";
            this.stavkeBindingSource.DataSource = this._16023_DBDataSet;
            // 
            // cmbMarka
            // 
            this.cmbMarka.DataSource = this.markeBindingSource;
            this.cmbMarka.DisplayMember = "naziv";
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(177, 13);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(365, 21);
            this.cmbMarka.TabIndex = 1;
            this.cmbMarka.ValueMember = "Id";
            this.cmbMarka.SelectionChangeCommitted += new System.EventHandler(this.cmbMarka_SelectionChangeCommitted);
            // 
            // markeBindingSource
            // 
            this.markeBindingSource.DataMember = "marke";
            this.markeBindingSource.DataSource = this._16023_DBDataSet;
            // 
            // markeTableAdapter
            // 
            this.markeTableAdapter.ClearBeforeFill = true;
            // 
            // cmbTip
            // 
            this.cmbTip.DataSource = this.automobiliBindingSource;
            this.cmbTip.DisplayMember = "naziv";
            this.cmbTip.Enabled = false;
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(177, 53);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(365, 21);
            this.cmbTip.TabIndex = 2;
            this.cmbTip.ValueMember = "Id";
            this.cmbTip.SelectionChangeCommitted += new System.EventHandler(this.cmbTip_SelectionChangeCommitted);
            // 
            // automobiliBindingSource
            // 
            this.automobiliBindingSource.DataMember = "automobili";
            this.automobiliBindingSource.DataSource = this._16023_DBDataSet;
            // 
            // automobiliTableAdapter
            // 
            this.automobiliTableAdapter.ClearBeforeFill = true;
            // 
            // autoToolStripLabel
            // 
            this.autoToolStripLabel.Name = "autoToolStripLabel";
            this.autoToolStripLabel.Size = new System.Drawing.Size(34, 22);
            this.autoToolStripLabel.Text = "auto:";
            // 
            // autoToolStripTextBox
            // 
            this.autoToolStripTextBox.Name = "autoToolStripTextBox";
            this.autoToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odaberite marku:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odaberite model:";
            // 
            // stavkeTableAdapter
            // 
            this.stavkeTableAdapter.ClearBeforeFill = true;
            // 
            // autoToolStripLabel1
            // 
            this.autoToolStripLabel1.Name = "autoToolStripLabel1";
            this.autoToolStripLabel1.Size = new System.Drawing.Size(34, 22);
            this.autoToolStripLabel1.Text = "auto:";
            // 
            // autoToolStripTextBox1
            // 
            this.autoToolStripTextBox1.Name = "autoToolStripTextBox1";
            this.autoToolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // rezerviranoTableAdapter
            // 
            this.rezerviranoTableAdapter.ClearBeforeFill = true;
            // 
            // pregledRezerviranih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.dataGridView1);
            this.Name = "pregledRezerviranih";
            this.Text = "Rezervirani automobili";
            this.Load += new System.EventHandler(this.pregledRezerviranih_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezerviranoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16023_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobiliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbMarka;
        private _16023_DBDataSet _16023_DBDataSet;
        private System.Windows.Forms.BindingSource markeBindingSource;
        private _16023_DBDataSetTableAdapters.markeTableAdapter markeTableAdapter;
        private System.Windows.Forms.ComboBox cmbTip;
        private _16023_DBDataSetTableAdapters.automobiliTableAdapter automobiliTableAdapter;
        private System.Windows.Forms.BindingSource automobiliBindingSource;
        private System.Windows.Forms.ToolStripLabel autoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox autoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource stavkeBindingSource;
        private _16023_DBDataSetTableAdapters.stavkeTableAdapter stavkeTableAdapter;
        private System.Windows.Forms.ToolStripLabel autoToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox autoToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
        private System.Windows.Forms.BindingSource rezerviranoBindingSource;
        private _16023_DBDataSetTableAdapters.rezerviranoTableAdapter rezerviranoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznajmljenodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznajmljendoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijent;
    }
}
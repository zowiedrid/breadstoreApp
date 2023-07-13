namespace breadstoreApp
{
    partial class FormRoti
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
            this.tbStok = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.dataGridViewRoti = new System.Windows.Forms.DataGridView();
            this.rotiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaRotiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.breadstoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.breadstoreDataSet = new breadstoreApp.breadstoreDataSet();
            this.btSave = new System.Windows.Forms.Button();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.txNama = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.txJenis = new System.Windows.Forms.Label();
            this.btOpen = new System.Windows.Forms.Button();
            this.txStok = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.txID = new System.Windows.Forms.Label();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.txHarga = new System.Windows.Forms.Label();
            this.tbJenis = new System.Windows.Forms.TextBox();
            this.rotiTableAdapter = new breadstoreApp.breadstoreDataSetTableAdapters.RotiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbStok
            // 
            this.tbStok.Location = new System.Drawing.Point(590, 240);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(170, 20);
            this.tbStok.TabIndex = 59;

            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(590, 370);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 49;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dataGridViewRoti
            // 
            this.dataGridViewRoti.AutoGenerateColumns = false;
            this.dataGridViewRoti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rotiIDDataGridViewTextBoxColumn,
            this.namaRotiDataGridViewTextBoxColumn,
            this.jenisDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn});
            this.dataGridViewRoti.DataSource = this.rotiBindingSource;
            this.dataGridViewRoti.Location = new System.Drawing.Point(40, 12);
            this.dataGridViewRoti.Name = "dataGridViewRoti";
            this.dataGridViewRoti.Size = new System.Drawing.Size(401, 426);
            this.dataGridViewRoti.TabIndex = 45;

            // 
            // rotiIDDataGridViewTextBoxColumn
            // 
            this.rotiIDDataGridViewTextBoxColumn.DataPropertyName = "RotiID";
            this.rotiIDDataGridViewTextBoxColumn.HeaderText = "RotiID";
            this.rotiIDDataGridViewTextBoxColumn.Name = "rotiIDDataGridViewTextBoxColumn";
            // 
            // namaRotiDataGridViewTextBoxColumn
            // 
            this.namaRotiDataGridViewTextBoxColumn.DataPropertyName = "NamaRoti";
            this.namaRotiDataGridViewTextBoxColumn.HeaderText = "NamaRoti";
            this.namaRotiDataGridViewTextBoxColumn.Name = "namaRotiDataGridViewTextBoxColumn";
            // 
            // jenisDataGridViewTextBoxColumn
            // 
            this.jenisDataGridViewTextBoxColumn.DataPropertyName = "Jenis";
            this.jenisDataGridViewTextBoxColumn.HeaderText = "Jenis";
            this.jenisDataGridViewTextBoxColumn.Name = "jenisDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // rotiBindingSource
            // 
            this.rotiBindingSource.DataMember = "Roti";
            this.rotiBindingSource.DataSource = this.breadstoreDataSetBindingSource;
            // 
            // breadstoreDataSetBindingSource
            // 
            this.breadstoreDataSetBindingSource.DataSource = this.breadstoreDataSet;
            this.breadstoreDataSetBindingSource.Position = 0;
            // 
            // breadstoreDataSet
            // 
            this.breadstoreDataSet.DataSetName = "breadstoreDataSet";
            this.breadstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(590, 317);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 47;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(590, 123);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(170, 20);
            this.tbNama.TabIndex = 51;

            // 
            // txNama
            // 
            this.txNama.AutoSize = true;
            this.txNama.Location = new System.Drawing.Point(475, 126);
            this.txNama.Name = "txNama";
            this.txNama.Size = new System.Drawing.Size(35, 13);
            this.txNama.TabIndex = 50;
            this.txNama.Text = "Nama";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(476, 370);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 48;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // txJenis
            // 
            this.txJenis.AutoSize = true;
            this.txJenis.Location = new System.Drawing.Point(475, 164);
            this.txJenis.Name = "txJenis";
            this.txJenis.Size = new System.Drawing.Size(31, 13);
            this.txJenis.TabIndex = 52;
            this.txJenis.Text = "Jenis";
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(476, 317);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 46;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;

            // 
            // txStok
            // 
            this.txStok.AutoSize = true;
            this.txStok.Location = new System.Drawing.Point(475, 240);
            this.txStok.Name = "txStok";
            this.txStok.Size = new System.Drawing.Size(29, 13);
            this.txStok.TabIndex = 58;
            this.txStok.Text = "Stok";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(590, 81);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(170, 20);
            this.tbID.TabIndex = 57;

            // 
            // txID
            // 
            this.txID.AutoSize = true;
            this.txID.Location = new System.Drawing.Point(475, 84);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(18, 13);
            this.txID.TabIndex = 56;
            this.txID.Text = "ID";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(590, 202);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(170, 20);
            this.tbHarga.TabIndex = 55;

            // 
            // txHarga
            // 
            this.txHarga.AutoSize = true;
            this.txHarga.Location = new System.Drawing.Point(475, 205);
            this.txHarga.Name = "txHarga";
            this.txHarga.Size = new System.Drawing.Size(36, 13);
            this.txHarga.TabIndex = 54;
            this.txHarga.Text = "Harga";
            // 
            // tbJenis
            // 
            this.tbJenis.Location = new System.Drawing.Point(590, 161);
            this.tbJenis.Name = "tbJenis";
            this.tbJenis.Size = new System.Drawing.Size(170, 20);
            this.tbJenis.TabIndex = 53;

            // 
            // rotiTableAdapter
            // 
            this.rotiTableAdapter.ClearBeforeFill = true;
            // 
            // FormRoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dataGridViewRoti);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.txNama);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.txJenis);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.txStok);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.txHarga);
            this.Controls.Add(this.tbJenis);
            this.Name = "FormRoti";
            this.Text = "FormRoti";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dataGridViewRoti;
        private System.Windows.Forms.BindingSource breadstoreDataSetBindingSource;
        private breadstoreDataSet breadstoreDataSet;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label txNama;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label txJenis;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Label txStok;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label txID;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label txHarga;
        private System.Windows.Forms.TextBox tbJenis;
        private System.Windows.Forms.BindingSource rotiBindingSource;
        private breadstoreDataSetTableAdapters.RotiTableAdapter rotiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaRotiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
    }
}
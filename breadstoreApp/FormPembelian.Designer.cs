namespace breadstoreApp
{
    partial class FormPembelian
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.breadstoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.breadstoreDataSet = new breadstoreApp.breadstoreDataSet();
            this.txEmail = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.txTelepon = new System.Windows.Forms.Label();
            this.btOpen = new System.Windows.Forms.Button();
            this.txPelanggan = new System.Windows.Forms.Label();
            this.dataGridViewPembelian = new System.Windows.Forms.DataGridView();
            this.pembelianIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pelangganIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pembelianRotiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pembelianRotiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btCreate = new System.Windows.Forms.Button();
            this.pembelianRotiTableAdapter = new breadstoreApp.breadstoreDataSetTableAdapters.PembelianRotiTableAdapter();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPelanggan = new System.Windows.Forms.ComboBox();
            this.comboBoxRoti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPembelian = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembelian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembelianRotiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembelianRotiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Tanggal";
            // 
            // tbJumlah
            // 
            this.tbJumlah.Location = new System.Drawing.Point(589, 200);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(170, 20);
            this.tbJumlah.TabIndex = 42;
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
            // txEmail
            // 
            this.txEmail.AutoSize = true;
            this.txEmail.Location = new System.Drawing.Point(474, 203);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(40, 13);
            this.txEmail.TabIndex = 41;
            this.txEmail.Text = "Jumlah";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(591, 370);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 36;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(477, 370);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 35;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // txTelepon
            // 
            this.txTelepon.AutoSize = true;
            this.txTelepon.Location = new System.Drawing.Point(477, 164);
            this.txTelepon.Name = "txTelepon";
            this.txTelepon.Size = new System.Drawing.Size(40, 13);
            this.txTelepon.TabIndex = 39;
            this.txTelepon.Text = "ID Roti";
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(477, 317);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 33;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // txPelanggan
            // 
            this.txPelanggan.AutoSize = true;
            this.txPelanggan.Location = new System.Drawing.Point(477, 126);
            this.txPelanggan.Name = "txPelanggan";
            this.txPelanggan.Size = new System.Drawing.Size(72, 13);
            this.txPelanggan.TabIndex = 37;
            this.txPelanggan.Text = "ID Pelanggan";
            // 
            // dataGridViewPembelian
            // 
            this.dataGridViewPembelian.AllowUserToOrderColumns = true;
            this.dataGridViewPembelian.AutoGenerateColumns = false;
            this.dataGridViewPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPembelian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pembelianIDDataGridViewTextBoxColumn,
            this.pelangganIDDataGridViewTextBoxColumn,
            this.rotiIDDataGridViewTextBoxColumn,
            this.jumlahDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.totalHargaDataGridViewTextBoxColumn});
            this.dataGridViewPembelian.DataSource = this.pembelianRotiBindingSource1;
            this.dataGridViewPembelian.Location = new System.Drawing.Point(41, 12);
            this.dataGridViewPembelian.Name = "dataGridViewPembelian";
            this.dataGridViewPembelian.Size = new System.Drawing.Size(401, 426);
            this.dataGridViewPembelian.TabIndex = 32;
            this.dataGridViewPembelian.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPembelian_CellContentClick);
            // 
            // pembelianIDDataGridViewTextBoxColumn
            // 
            this.pembelianIDDataGridViewTextBoxColumn.DataPropertyName = "PembelianID";
            this.pembelianIDDataGridViewTextBoxColumn.HeaderText = "PembelianID";
            this.pembelianIDDataGridViewTextBoxColumn.Name = "pembelianIDDataGridViewTextBoxColumn";
            // 
            // pelangganIDDataGridViewTextBoxColumn
            // 
            this.pelangganIDDataGridViewTextBoxColumn.DataPropertyName = "PelangganID";
            this.pelangganIDDataGridViewTextBoxColumn.HeaderText = "PelangganID";
            this.pelangganIDDataGridViewTextBoxColumn.Name = "pelangganIDDataGridViewTextBoxColumn";
            // 
            // rotiIDDataGridViewTextBoxColumn
            // 
            this.rotiIDDataGridViewTextBoxColumn.DataPropertyName = "RotiID";
            this.rotiIDDataGridViewTextBoxColumn.HeaderText = "RotiID";
            this.rotiIDDataGridViewTextBoxColumn.Name = "rotiIDDataGridViewTextBoxColumn";
            // 
            // jumlahDataGridViewTextBoxColumn
            // 
            this.jumlahDataGridViewTextBoxColumn.DataPropertyName = "Jumlah";
            this.jumlahDataGridViewTextBoxColumn.HeaderText = "Jumlah";
            this.jumlahDataGridViewTextBoxColumn.Name = "jumlahDataGridViewTextBoxColumn";
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            // 
            // totalHargaDataGridViewTextBoxColumn
            // 
            this.totalHargaDataGridViewTextBoxColumn.DataPropertyName = "TotalHarga";
            this.totalHargaDataGridViewTextBoxColumn.HeaderText = "TotalHarga";
            this.totalHargaDataGridViewTextBoxColumn.Name = "totalHargaDataGridViewTextBoxColumn";
            // 
            // pembelianRotiBindingSource1
            // 
            this.pembelianRotiBindingSource1.DataMember = "PembelianRoti";
            this.pembelianRotiBindingSource1.DataSource = this.breadstoreDataSetBindingSource;
            // 
            // pembelianRotiBindingSource
            // 
            this.pembelianRotiBindingSource.DataMember = "PembelianRoti";
            this.pembelianRotiBindingSource.DataSource = this.breadstoreDataSetBindingSource;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(591, 317);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 23);
            this.btCreate.TabIndex = 34;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // pembelianRotiTableAdapter
            // 
            this.pembelianRotiTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(588, 248);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTanggal.TabIndex = 49;
            // 
            // comboBoxPelanggan
            // 
            this.comboBoxPelanggan.FormattingEnabled = true;
            this.comboBoxPelanggan.Location = new System.Drawing.Point(591, 122);
            this.comboBoxPelanggan.Name = "comboBoxPelanggan";
            this.comboBoxPelanggan.Size = new System.Drawing.Size(171, 21);
            this.comboBoxPelanggan.TabIndex = 50;
            // 
            // comboBoxRoti
            // 
            this.comboBoxRoti.FormattingEnabled = true;
            this.comboBoxRoti.Location = new System.Drawing.Point(591, 161);
            this.comboBoxRoti.Name = "comboBoxRoti";
            this.comboBoxRoti.Size = new System.Drawing.Size(171, 21);
            this.comboBoxRoti.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "ID Pembelian";
            // 
            // comboBoxPembelian
            // 
            this.comboBoxPembelian.FormattingEnabled = true;
            this.comboBoxPembelian.Location = new System.Drawing.Point(591, 77);
            this.comboBoxPembelian.Name = "comboBoxPembelian";
            this.comboBoxPembelian.Size = new System.Drawing.Size(171, 21);
            this.comboBoxPembelian.TabIndex = 53;
            // 
            // FormPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxPembelian);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRoti);
            this.Controls.Add(this.comboBoxPelanggan);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbJumlah);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.txTelepon);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.txPelanggan);
            this.Controls.Add(this.dataGridViewPembelian);
            this.Controls.Add(this.btCreate);
            this.Name = "FormPembelian";
            this.Text = "FormPembelian";
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPembelian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembelianRotiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembelianRotiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbJumlah;
        private System.Windows.Forms.BindingSource breadstoreDataSetBindingSource;
        private breadstoreDataSet breadstoreDataSet;
        private System.Windows.Forms.Label txEmail;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label txTelepon;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Label txPelanggan;
        private System.Windows.Forms.DataGridView dataGridViewPembelian;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.BindingSource pembelianRotiBindingSource;
        private breadstoreDataSetTableAdapters.PembelianRotiTableAdapter pembelianRotiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pembelianIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pelangganIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pembelianRotiBindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.ComboBox comboBoxPelanggan;
        private System.Windows.Forms.ComboBox comboBoxRoti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPembelian;
    }
}
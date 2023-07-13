namespace breadstoreApp
{
    partial class FormBahan
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.txID = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.txEmail = new System.Windows.Forms.Label();
            this.tbTelepon = new System.Windows.Forms.TextBox();
            this.txTelepon = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.txNama = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.breadstoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.breadstoreDataSet = new breadstoreApp.breadstoreDataSet();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.bahanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bahanTableAdapter = new breadstoreApp.breadstoreDataSetTableAdapters.BahanTableAdapter();
            this.bahanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBahanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(590, 81);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(170, 20);
            this.tbID.TabIndex = 42;
            // 
            // txID
            // 
            this.txID.AutoSize = true;
            this.txID.Location = new System.Drawing.Point(475, 84);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(18, 13);
            this.txID.TabIndex = 41;
            this.txID.Text = "ID";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(590, 202);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(170, 20);
            this.tbEmail.TabIndex = 40;
            // 
            // txEmail
            // 
            this.txEmail.AutoSize = true;
            this.txEmail.Location = new System.Drawing.Point(475, 205);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(36, 13);
            this.txEmail.TabIndex = 39;
            this.txEmail.Text = "Harga";
            // 
            // tbTelepon
            // 
            this.tbTelepon.Location = new System.Drawing.Point(590, 161);
            this.tbTelepon.Name = "tbTelepon";
            this.tbTelepon.Size = new System.Drawing.Size(170, 20);
            this.tbTelepon.TabIndex = 38;
            // 
            // txTelepon
            // 
            this.txTelepon.AutoSize = true;
            this.txTelepon.Location = new System.Drawing.Point(475, 164);
            this.txTelepon.Name = "txTelepon";
            this.txTelepon.Size = new System.Drawing.Size(29, 13);
            this.txTelepon.TabIndex = 37;
            this.txTelepon.Text = "Stok";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(590, 123);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(170, 20);
            this.tbNama.TabIndex = 36;
            // 
            // txNama
            // 
            this.txNama.AutoSize = true;
            this.txNama.Location = new System.Drawing.Point(475, 126);
            this.txNama.Name = "txNama";
            this.txNama.Size = new System.Drawing.Size(35, 13);
            this.txNama.TabIndex = 35;
            this.txNama.Text = "Nama";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(590, 370);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 34;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(476, 370);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 33;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
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
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(476, 317);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 31;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(590, 317);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 32;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AutoGenerateColumns = false;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bahanIDDataGridViewTextBoxColumn,
            this.namaBahanDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridViewAdmin.DataSource = this.bahanBindingSource;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(40, 12);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(401, 426);
            this.dataGridViewAdmin.TabIndex = 30;
            // 
            // bahanBindingSource
            // 
            this.bahanBindingSource.DataMember = "Bahan";
            this.bahanBindingSource.DataSource = this.breadstoreDataSetBindingSource;
            // 
            // bahanTableAdapter
            // 
            this.bahanTableAdapter.ClearBeforeFill = true;
            // 
            // bahanIDDataGridViewTextBoxColumn
            // 
            this.bahanIDDataGridViewTextBoxColumn.DataPropertyName = "BahanID";
            this.bahanIDDataGridViewTextBoxColumn.HeaderText = "BahanID";
            this.bahanIDDataGridViewTextBoxColumn.Name = "bahanIDDataGridViewTextBoxColumn";
            // 
            // namaBahanDataGridViewTextBoxColumn
            // 
            this.namaBahanDataGridViewTextBoxColumn.DataPropertyName = "NamaBahan";
            this.namaBahanDataGridViewTextBoxColumn.HeaderText = "NamaBahan";
            this.namaBahanDataGridViewTextBoxColumn.Name = "namaBahanDataGridViewTextBoxColumn";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // FormBahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.tbTelepon);
            this.Controls.Add(this.txTelepon);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.txNama);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Name = "FormBahan";
            this.Text = "FormBahan";
            this.Load += new System.EventHandler(this.FormBahan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bahanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label txID;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label txEmail;
        private System.Windows.Forms.TextBox tbTelepon;
        private System.Windows.Forms.Label txTelepon;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label txNama;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.BindingSource breadstoreDataSetBindingSource;
        private breadstoreDataSet breadstoreDataSet;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.BindingSource bahanBindingSource;
        private breadstoreDataSetTableAdapters.BahanTableAdapter bahanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bahanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
    }
}
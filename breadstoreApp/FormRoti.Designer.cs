﻿namespace breadstoreApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.breadstoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.breadstoreDataSet = new breadstoreApp.breadstoreDataSet();
            this.btSave = new System.Windows.Forms.Button();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.txNama = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.txTelepon = new System.Windows.Forms.Label();
            this.btOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.txID = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.txEmail = new System.Windows.Forms.Label();
            this.tbTelepon = new System.Windows.Forms.TextBox();
            this.rotiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rotiTableAdapter = new breadstoreApp.breadstoreDataSetTableAdapters.RotiTableAdapter();
            this.rotiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaRotiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(590, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 59;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(590, 370);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 49;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AutoGenerateColumns = false;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rotiIDDataGridViewTextBoxColumn,
            this.namaRotiDataGridViewTextBoxColumn,
            this.jenisDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn});
            this.dataGridViewAdmin.DataSource = this.rotiBindingSource;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(40, 12);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(401, 426);
            this.dataGridViewAdmin.TabIndex = 45;
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
            // 
            // txTelepon
            // 
            this.txTelepon.AutoSize = true;
            this.txTelepon.Location = new System.Drawing.Point(475, 164);
            this.txTelepon.Name = "txTelepon";
            this.txTelepon.Size = new System.Drawing.Size(31, 13);
            this.txTelepon.TabIndex = 52;
            this.txTelepon.Text = "Jenis";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Stok";
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
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(590, 202);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(170, 20);
            this.tbEmail.TabIndex = 55;
            // 
            // txEmail
            // 
            this.txEmail.AutoSize = true;
            this.txEmail.Location = new System.Drawing.Point(475, 205);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(36, 13);
            this.txEmail.TabIndex = 54;
            this.txEmail.Text = "Harga";
            // 
            // tbTelepon
            // 
            this.tbTelepon.Location = new System.Drawing.Point(590, 161);
            this.tbTelepon.Name = "tbTelepon";
            this.tbTelepon.Size = new System.Drawing.Size(170, 20);
            this.tbTelepon.TabIndex = 53;
            // 
            // rotiBindingSource
            // 
            this.rotiBindingSource.DataMember = "Roti";
            this.rotiBindingSource.DataSource = this.breadstoreDataSetBindingSource;
            // 
            // rotiTableAdapter
            // 
            this.rotiTableAdapter.ClearBeforeFill = true;
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
            // FormRoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.txNama);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.txTelepon);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.tbTelepon);
            this.Name = "FormRoti";
            this.Text = "FormRoti";
            this.Load += new System.EventHandler(this.FormRoti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.BindingSource breadstoreDataSetBindingSource;
        private breadstoreDataSet breadstoreDataSet;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label txNama;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label txTelepon;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label txID;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label txEmail;
        private System.Windows.Forms.TextBox tbTelepon;
        private System.Windows.Forms.BindingSource rotiBindingSource;
        private breadstoreDataSetTableAdapters.RotiTableAdapter rotiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaRotiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
    }
}
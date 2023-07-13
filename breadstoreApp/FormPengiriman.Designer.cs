namespace breadstoreApp
{
    partial class FormPengiriman
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.txEmail = new System.Windows.Forms.Label();
            this.tbTelepon = new System.Windows.Forms.TextBox();
            this.breadstoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.breadstoreDataSet = new breadstoreApp.breadstoreDataSet();
            this.txTelepon = new System.Windows.Forms.Label();
            this.btOpen = new System.Windows.Forms.Button();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.txNama = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.pengirimanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bahanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengirimanBahanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btSave = new System.Windows.Forms.Button();
            this.pengirimanBahanTableAdapter = new breadstoreApp.breadstoreDataSetTableAdapters.PengirimanBahanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengirimanBahanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(590, 81);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(170, 20);
            this.tbID.TabIndex = 44;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // txID
            // 
            this.txID.AutoSize = true;
            this.txID.Location = new System.Drawing.Point(475, 84);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(18, 13);
            this.txID.TabIndex = 43;
            this.txID.Text = "ID";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(590, 247);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(170, 20);
            this.tbPassword.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Password";
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
            this.txEmail.Size = new System.Drawing.Size(32, 13);
            this.txEmail.TabIndex = 39;
            this.txEmail.Text = "Email";
            // 
            // tbTelepon
            // 
            this.tbTelepon.Location = new System.Drawing.Point(590, 161);
            this.tbTelepon.Name = "tbTelepon";
            this.tbTelepon.Size = new System.Drawing.Size(170, 20);
            this.tbTelepon.TabIndex = 38;
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
            // txTelepon
            // 
            this.txTelepon.AutoSize = true;
            this.txTelepon.Location = new System.Drawing.Point(475, 164);
            this.txTelepon.Name = "txTelepon";
            this.txTelepon.Size = new System.Drawing.Size(46, 13);
            this.txTelepon.TabIndex = 37;
            this.txTelepon.Text = "Telepon";
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
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AutoGenerateColumns = false;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pengirimanIDDataGridViewTextBoxColumn,
            this.suplierIDDataGridViewTextBoxColumn,
            this.bahanIDDataGridViewTextBoxColumn,
            this.jumlahDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn});
            this.dataGridViewAdmin.DataSource = this.pengirimanBahanBindingSource;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(40, 12);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(401, 426);
            this.dataGridViewAdmin.TabIndex = 30;
            this.dataGridViewAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellContentClick);
            // 
            // pengirimanIDDataGridViewTextBoxColumn
            // 
            this.pengirimanIDDataGridViewTextBoxColumn.DataPropertyName = "PengirimanID";
            this.pengirimanIDDataGridViewTextBoxColumn.HeaderText = "PengirimanID";
            this.pengirimanIDDataGridViewTextBoxColumn.Name = "pengirimanIDDataGridViewTextBoxColumn";
            // 
            // suplierIDDataGridViewTextBoxColumn
            // 
            this.suplierIDDataGridViewTextBoxColumn.DataPropertyName = "SuplierID";
            this.suplierIDDataGridViewTextBoxColumn.HeaderText = "SuplierID";
            this.suplierIDDataGridViewTextBoxColumn.Name = "suplierIDDataGridViewTextBoxColumn";
            // 
            // bahanIDDataGridViewTextBoxColumn
            // 
            this.bahanIDDataGridViewTextBoxColumn.DataPropertyName = "BahanID";
            this.bahanIDDataGridViewTextBoxColumn.HeaderText = "BahanID";
            this.bahanIDDataGridViewTextBoxColumn.Name = "bahanIDDataGridViewTextBoxColumn";
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
            // pengirimanBahanBindingSource
            // 
            this.pengirimanBahanBindingSource.DataMember = "PengirimanBahan";
            this.pengirimanBahanBindingSource.DataSource = this.breadstoreDataSetBindingSource;
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
            // pengirimanBahanTableAdapter
            // 
            this.pengirimanBahanTableAdapter.ClearBeforeFill = true;
            // 
            // FormPengiriman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.tbTelepon);
            this.Controls.Add(this.txTelepon);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.txNama);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Controls.Add(this.btSave);
            this.Name = "FormPengiriman";
            this.Text = "FormPengiriman";
            this.Load += new System.EventHandler(this.FormPengiriman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengirimanBahanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label txID;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label txEmail;
        private System.Windows.Forms.TextBox tbTelepon;
        private System.Windows.Forms.BindingSource breadstoreDataSetBindingSource;
        private breadstoreDataSet breadstoreDataSet;
        private System.Windows.Forms.Label txTelepon;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label txNama;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.BindingSource pengirimanBahanBindingSource;
        private breadstoreDataSetTableAdapters.PengirimanBahanTableAdapter pengirimanBahanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pengirimanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bahanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
    }
}
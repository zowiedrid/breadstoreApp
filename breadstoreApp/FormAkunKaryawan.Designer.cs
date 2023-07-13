namespace breadstoreApp
{
    partial class FormAkunKaryawan
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
            this.tbTelepon = new System.Windows.Forms.TextBox();
            this.txTelepon = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.txNama = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.breadstoreDataSet = new breadstoreApp.breadstoreDataSet();
            this.akunKaryawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.akunKaryawanTableAdapter = new breadstoreApp.breadstoreDataSetTableAdapters.AkunKaryawanTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akunKaryawanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(590, 81);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(170, 20);
            this.tbID.TabIndex = 40;
            // 
            // txID
            // 
            this.txID.AutoSize = true;
            this.txID.Location = new System.Drawing.Point(475, 84);
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(32, 13);
            this.txID.TabIndex = 39;
            this.txID.Text = "Akun";
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
            this.txTelepon.Size = new System.Drawing.Size(68, 13);
            this.txTelepon.TabIndex = 37;
            this.txTelepon.Text = "ID Karyawan";
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
            this.txNama.Size = new System.Drawing.Size(50, 13);
            this.txNama.TabIndex = 35;
            this.txNama.Text = "ID Admin";
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewAdmin.DataSource = this.akunKaryawanBindingSource;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(40, 12);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(401, 426);
            this.dataGridViewAdmin.TabIndex = 30;
            this.dataGridViewAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellContentClick);
            // 
            // breadstoreDataSet
            // 
            this.breadstoreDataSet.DataSetName = "breadstoreDataSet";
            this.breadstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // akunKaryawanBindingSource
            // 
            this.akunKaryawanBindingSource.DataMember = "AkunKaryawan";
            this.akunKaryawanBindingSource.DataSource = this.breadstoreDataSet;
            // 
            // akunKaryawanTableAdapter
            // 
            this.akunKaryawanTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AkunID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AkunID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AdminID";
            this.dataGridViewTextBoxColumn2.HeaderText = "AdminID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "KaryawanID";
            this.dataGridViewTextBoxColumn3.HeaderText = "KaryawanID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormAkunKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.txID);
            this.Controls.Add(this.tbTelepon);
            this.Controls.Add(this.txTelepon);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.txNama);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Name = "FormAkunKaryawan";
            this.Text = "FormAkunKaryawan";
            this.Load += new System.EventHandler(this.FormAkunKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akunKaryawanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label txID;
        private System.Windows.Forms.TextBox tbTelepon;
        private System.Windows.Forms.Label txTelepon;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label txNama;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private breadstoreDataSet breadstoreDataSet;
        private System.Windows.Forms.BindingSource akunKaryawanBindingSource;
        private breadstoreDataSetTableAdapters.AkunKaryawanTableAdapter akunKaryawanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
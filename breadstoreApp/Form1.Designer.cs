namespace breadstoreApp
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsMasterData = new System.Windows.Forms.ToolStripDropDownButton();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karyawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bahanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTambahData = new System.Windows.Forms.ToolStripDropDownButton();
            this.pembelianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengirimanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akunkaryawanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bahanRotiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMasterData,
            this.tsTambahData});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsMasterData
            // 
            this.tsMasterData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMasterData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.karyawanToolStripMenuItem,
            this.rotiToolStripMenuItem,
            this.bahanToolStripMenuItem,
            this.pelangganToolStripMenuItem,
            this.supplierToolStripMenuItem});
            this.tsMasterData.Image = ((System.Drawing.Image)(resources.GetObject("tsMasterData.Image")));
            this.tsMasterData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMasterData.Name = "tsMasterData";
            this.tsMasterData.Size = new System.Drawing.Size(83, 22);
            this.tsMasterData.Text = "Master Data";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // karyawanToolStripMenuItem
            // 
            this.karyawanToolStripMenuItem.Name = "karyawanToolStripMenuItem";
            this.karyawanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.karyawanToolStripMenuItem.Text = "Karyawan";
            this.karyawanToolStripMenuItem.Click += new System.EventHandler(this.karyawanToolStripMenuItem_Click);
            // 
            // rotiToolStripMenuItem
            // 
            this.rotiToolStripMenuItem.Name = "rotiToolStripMenuItem";
            this.rotiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rotiToolStripMenuItem.Text = "Roti";
            this.rotiToolStripMenuItem.Click += new System.EventHandler(this.rotiToolStripMenuItem_Click);
            // 
            // bahanToolStripMenuItem
            // 
            this.bahanToolStripMenuItem.Name = "bahanToolStripMenuItem";
            this.bahanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bahanToolStripMenuItem.Text = "Bahan";
            this.bahanToolStripMenuItem.Click += new System.EventHandler(this.bahanToolStripMenuItem_Click);
            // 
            // pelangganToolStripMenuItem
            // 
            this.pelangganToolStripMenuItem.Name = "pelangganToolStripMenuItem";
            this.pelangganToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pelangganToolStripMenuItem.Text = "Pelanggan";
            this.pelangganToolStripMenuItem.Click += new System.EventHandler(this.pelangganToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // tsTambahData
            // 
            this.tsTambahData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsTambahData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pembelianToolStripMenuItem,
            this.pengirimanToolStripMenuItem,
            this.akunkaryawanToolStripMenuItem1,
            this.bahanRotiToolStripMenuItem});
            this.tsTambahData.Image = ((System.Drawing.Image)(resources.GetObject("tsTambahData.Image")));
            this.tsTambahData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTambahData.Name = "tsTambahData";
            this.tsTambahData.Size = new System.Drawing.Size(89, 22);
            this.tsTambahData.Text = "Tambah Data";
            this.tsTambahData.Click += new System.EventHandler(this.tsTambahData_Click);
            // 
            // pembelianToolStripMenuItem
            // 
            this.pembelianToolStripMenuItem.Name = "pembelianToolStripMenuItem";
            this.pembelianToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pembelianToolStripMenuItem.Text = "Pembelian";
            this.pembelianToolStripMenuItem.Click += new System.EventHandler(this.pembelianToolStripMenuItem_Click);
            // 
            // pengirimanToolStripMenuItem
            // 
            this.pengirimanToolStripMenuItem.Name = "pengirimanToolStripMenuItem";
            this.pengirimanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pengirimanToolStripMenuItem.Text = "Pengiriman";
            this.pengirimanToolStripMenuItem.Click += new System.EventHandler(this.pengirimanToolStripMenuItem_Click);
            // 
            // akunkaryawanToolStripMenuItem1
            // 
            this.akunkaryawanToolStripMenuItem1.Name = "akunkaryawanToolStripMenuItem1";
            this.akunkaryawanToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.akunkaryawanToolStripMenuItem1.Text = "Akun Karyawan";
            this.akunkaryawanToolStripMenuItem1.Click += new System.EventHandler(this.akunkaryawanToolStripMenuItem1_Click);
            // 
            // bahanRotiToolStripMenuItem
            // 
            this.bahanRotiToolStripMenuItem.Name = "bahanRotiToolStripMenuItem";
            this.bahanRotiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bahanRotiToolStripMenuItem.Text = "Bahan Roti";
            this.bahanRotiToolStripMenuItem.Click += new System.EventHandler(this.bahanRotiToolStripMenuItem_Click_1);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormHome";
            this.Text = "Form Home";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsMasterData;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karyawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bahanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pelangganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsTambahData;
        private System.Windows.Forms.ToolStripMenuItem pembelianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengirimanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem akunkaryawanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bahanRotiToolStripMenuItem;
    }
}


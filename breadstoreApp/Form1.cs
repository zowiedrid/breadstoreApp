using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace breadstoreApp
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
        }

        private void karyawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKaryawan formKaryawan = new FormKaryawan();
            formKaryawan.Show();
        }

        private void rotiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoti formRoti = new FormRoti();
            formRoti.Show();
        }

        private void bahanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBahan formBahan = new FormBahan();
            formBahan.Show();
        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPelanggan formPelanggan = new FormPelanggan();
            formPelanggan.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplier formSupplier = new FormSupplier();
            formSupplier.Show();
        }

        private void tsTambahData_Click(object sender, EventArgs e)
        {

        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPembelian formPembelian = new FormPembelian();
            formPembelian.Show();
        }

        private void pengirimanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPengiriman formPengiriman = new FormPengiriman();
            formPengiriman.Show();
        }


        private void akunkaryawanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAkunKaryawan formAkunKaryawan = new FormAkunKaryawan();
            formAkunKaryawan.Show();
        }

        private void bahanRotiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormBahanRoti formBahanRoti = new FormBahanRoti();
            formBahanRoti.Show();
        }


    }
}
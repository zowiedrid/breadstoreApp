using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace breadstoreApp
{
    public partial class FormPembelian : Form
    {
        private string connectionString = "data source=ZOWIE;database=breadstore;User ID=sa;Password=1234;";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable pembelianTable;
        private DataTable pelangganTable;
        private DataTable rotiTable;

        public FormPembelian()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadDataPembelian();
            LoadDataPelanggan();
            LoadDataRoti();
            ClearForm();
            EnableForm();
        }

        private void LoadDataPembelian()
        {
            adapter = new SqlDataAdapter("SELECT * FROM PembelianRoti", connection);
            pembelianTable = new DataTable();
            adapter.Fill(pembelianTable);
            dataGridViewPembelian.DataSource = pembelianTable;

            // Populate the comboBoxPembelian with PembelianRotiID values from the database
            comboBoxPembelian.DataSource = pembelianTable;
            comboBoxPembelian.DisplayMember = "PembelianRotiID"; // Assuming the column name is "PembelianRotiID"
            comboBoxPembelian.ValueMember = "PembelianRotiID"; // Assuming the column name is "PembelianRotiID"
        }



        private void LoadDataPelanggan()
        {
            adapter = new SqlDataAdapter("SELECT PelangganID, Nama FROM Pelanggan", connection);
            pelangganTable = new DataTable();
            adapter.Fill(pelangganTable);
            comboBoxPelanggan.DataSource = pelangganTable;
            comboBoxPelanggan.DisplayMember = "Nama";
            comboBoxPelanggan.ValueMember = "PelangganID";
        }

        private void LoadDataRoti()
        {
            adapter = new SqlDataAdapter("SELECT RotiID, NamaRoti FROM Roti", connection);
            rotiTable = new DataTable();
            adapter.Fill(rotiTable);
            comboBoxRoti.DataSource = rotiTable;
            comboBoxRoti.DisplayMember = "NamaRoti";
            comboBoxRoti.ValueMember = "RotiID";
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            EnableForm();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            int pelangganID = Convert.ToInt32(comboBoxPelanggan.SelectedValue);
            string namaPelanggan = comboBoxPelanggan.Text;
            int rotiID = Convert.ToInt32(comboBoxRoti.SelectedValue);
            string namaRoti = comboBoxRoti.Text;
            int jumlahBeli = Convert.ToInt32(tbJumlah.Text);
            DateTime tanggal = dateTimePickerTanggal.Value;

            // Get harga value from the selected Roti
            decimal hargaRoti = GetHargaRoti(rotiID);

            // Hitung total harga
            decimal totalHarga = hargaRoti * jumlahBeli;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO PembelianRoti (PelangganID, NamaPelanggan, RotiID, NamaRoti, Jumlah, Tanggal, TotalHarga) " +
                               "VALUES (@PelangganID, @NamaPelanggan, @RotiID, @NamaRoti, @Jumlah, @Tanggal, @TotalHarga)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PelangganID", pelangganID);
                command.Parameters.AddWithValue("@NamaPelanggan", namaPelanggan);
                command.Parameters.AddWithValue("@RotiID", rotiID);
                command.Parameters.AddWithValue("@NamaRoti", namaRoti);
                command.Parameters.AddWithValue("@Jumlah", jumlahBeli);
                command.Parameters.AddWithValue("@Tanggal", tanggal);
                command.Parameters.AddWithValue("@TotalHarga", totalHarga);

                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataPembelian();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan data.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private decimal GetHargaRoti(int rotiID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Harga FROM Roti WHERE RotiID = @RotiID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RotiID", rotiID);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }

                return 0; // Default value if Harga not found
            }
        }



        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewPembelian.SelectedRows.Count > 0)
            {
                int pembelianRotiID = Convert.ToInt32(dataGridViewPembelian.SelectedRows[0].Cells["PembelianRotiID"].Value);
                int pelangganID = Convert.ToInt32(comboBoxPelanggan.SelectedValue);
                string namaPelanggan = comboBoxPelanggan.Text;
                int rotiID = Convert.ToInt32(comboBoxRoti.SelectedValue);
                string namaRoti = comboBoxRoti.Text;
                int jumlah = Convert.ToInt32(tbJumlah.Text);
                DateTime tanggal = dateTimePickerTanggal.Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE PembelianRoti SET PelangganID = @PelangganID, NamaPelanggan = @NamaPelanggan, " +
                                   "RotiID = @RotiID, NamaRoti = @NamaRoti, Jumlah = @Jumlah, Tanggal = @Tanggal " +
                                   "WHERE PembelianRotiID = @PembelianRotiID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PembelianRotiID", pembelianRotiID);
                    command.Parameters.AddWithValue("@PelangganID", pelangganID);
                    command.Parameters.AddWithValue("@NamaPelanggan", namaPelanggan);
                    command.Parameters.AddWithValue("@RotiID", rotiID);
                    command.Parameters.AddWithValue("@NamaRoti", namaRoti);
                    command.Parameters.AddWithValue("@Jumlah", jumlah);
                    command.Parameters.AddWithValue("@Tanggal", tanggal);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil di-update.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataPembelian();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Gagal meng-update data.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPembelian.SelectedRows.Count > 0)
            {
                int pembelianRotiID = Convert.ToInt32(dataGridViewPembelian.SelectedRows[0].Cells["PembelianRotiID"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM PembelianRoti WHERE PembelianRotiID = @PembelianRotiID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PembelianRotiID", pembelianRotiID);

                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataPembelian();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void EnableForm()
        {
            comboBoxPelanggan.Enabled = true;
            comboBoxRoti.Enabled = true;
            tbJumlah.Enabled = true;
            dateTimePickerTanggal.Enabled = true;

            btCreate.Enabled = true;
            btUpdate.Enabled = true;
            btDelete.Enabled = true;

            dataGridViewPembelian.Enabled = false;

            btOpen.Enabled = false;
        }

        private void ClearForm()
        {
            comboBoxPelanggan.SelectedIndex = -1;
            comboBoxRoti.SelectedIndex = -1;
            tbJumlah.Text = string.Empty;
            dateTimePickerTanggal.Value = DateTime.Today;
            dataGridViewPembelian.ClearSelection();
        }

        private void dataGridViewPembelian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

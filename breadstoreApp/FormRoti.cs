using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace breadstoreApp
{
    public partial class FormRoti : Form
    {
        private string connectionString = "data source=ZOWIE;database=breadstore;User ID=sa;Password=1234;";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable rotiTable;

        public FormRoti()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadDataRoti();
            ClearForm();
            EnableForm();
        }

        private void LoadDataRoti()
        {
            adapter = new SqlDataAdapter("SELECT * FROM Roti", connection);
            rotiTable = new DataTable();
            adapter.Fill(rotiTable);
            dataGridViewRoti.DataSource = rotiTable;
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            string id = tbID.Text;
            string nama = tbNama.Text;
            string jenis = tbJenis.Text;
            string harga = tbHarga.Text;
            int stok = Convert.ToInt32(tbStok.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Roti (RotiID, NamaRoti, Jenis, Harga, Stok) VALUES (@RotiID, @NamaRoti, @Jenis, @Harga, @Stok)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RotiID", id);
                command.Parameters.AddWithValue("@NamaRoti", nama);
                command.Parameters.AddWithValue("@Jenis", jenis);
                command.Parameters.AddWithValue("@Harga", harga);
                command.Parameters.AddWithValue("@Stok", stok);

                connection.Open();

                command.ExecuteNonQuery();
            }

            LoadDataRoti();
            ClearForm();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoti.SelectedRows.Count > 0)
            {
                string id = tbID.Text;
                string nama = tbNama.Text;
                string jenis = tbJenis.Text;
                string harga = tbHarga.Text;
                int stok = Convert.ToInt32(tbStok.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Roti SET NamaRoti = @NamaRoti, Jenis = @Jenis, Harga = @Harga, Stok = @Stok WHERE RotiID = @RotiID";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@NamaRoti", nama);
                    updateCommand.Parameters.AddWithValue("@Jenis", jenis);
                    updateCommand.Parameters.AddWithValue("@Harga", harga);
                    updateCommand.Parameters.AddWithValue("@Stok", stok);
                    updateCommand.Parameters.AddWithValue("@RotiID", id);

                    try
                    {
                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil di-update.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataRoti();
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Gagal meng-update data. Periksa kembali ID Roti yang dimasukkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan saat meng-update data: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoti.SelectedRows.Count > 0)
            {
                string id = tbID.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Roti WHERE RotiID = @RotiID";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@RotiID", id);

                    try
                    {
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataRoti();
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus data. Periksa kembali ID Roti yang dimasukkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan saat menghapus data: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            EnableForm();
        }

        private void EnableForm()
        {
            tbID.Enabled = true;
            tbNama.Enabled = true;
            tbJenis.Enabled = true;
            tbHarga.Enabled = true;
            tbStok.Enabled = true;

            btCreate.Enabled = true;
            btUpdate.Enabled = true;
            btDelete.Enabled = true;
        }

        private void SaveChanges()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(rotiTable);
        }

        private void ClearForm()
        {
            tbID.Text = string.Empty;
            tbNama.Text = string.Empty;
            tbJenis.Text = string.Empty;
                }

        private void dataGridViewRoti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace breadstoreApp
{
    public partial class FormAdmin : Form
    {
        private string stringConnection = "data source=ZOWIE;database=breadstore;User ID=sa;Password=1234;";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable adminTable;

        public FormAdmin()
        {
            InitializeComponent();
            connection = new SqlConnection(stringConnection);
            LoadDataAdmin();
        }

        private void LoadDataAdmin()
        {
            adapter = new SqlDataAdapter("SELECT * FROM Admin", connection);
            adminTable = new DataTable();
            adapter.Fill(adminTable);
            dataGridViewAdmin.DataSource = adminTable;

            // Populate the comboBoxAdminID with AdminID values from the database
            comboBoxAdminID.DataSource = adminTable;
            comboBoxAdminID.DisplayMember = "AdminID";
            comboBoxAdminID.ValueMember = "AdminID";
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            EnableForm();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            string id = comboBoxAdminID.Text; // Use selected value from comboBoxAdminID
            string nama = tbNama.Text;
            string telepon = tbTelepon.Text;
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string query = "INSERT INTO Admin (AdminID, Nama, Telepon, Email, Password) VALUES (@AdminID, @Nama, @Telepon, @Email, @Password)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AdminID", id);
                command.Parameters.AddWithValue("@Nama", nama);
                command.Parameters.AddWithValue("@Telepon", telepon);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();

                command.ExecuteNonQuery();
            }

            LoadDataAdmin();
            ClearForm();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdmin.SelectedRows.Count > 0)
            {
                string id = comboBoxAdminID.Text; // Use selected value from comboBoxAdminID
                string nama = tbNama.Text;
                string telepon = tbTelepon.Text;
                string email = tbEmail.Text;
                string password = tbPassword.Text;

                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();

                    // Cek apakah ID admin yang akan di-update digunakan dalam tabel lain
                    string checkReferenceQuery = "SELECT COUNT(*) FROM AkunKaryawan WHERE AdminID = @AdminID";
                    SqlCommand checkReferenceCommand = new SqlCommand(checkReferenceQuery, connection);
                    checkReferenceCommand.Parameters.AddWithValue("@AdminID", id);
                    int referenceCount = (int)checkReferenceCommand.ExecuteScalar();

                    if (referenceCount > 0)
                    {
                        MessageBox.Show("Tidak dapat mengubah data. ID admin digunakan dalam tabel lain.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string updateQuery = "UPDATE Admin SET Nama = @Nama, Telepon = @Telepon, Email = @Email, Password = @Password WHERE AdminID = @AdminID";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@Nama", nama);
                    updateCommand.Parameters.AddWithValue("@Telepon", telepon);
                    updateCommand.Parameters.AddWithValue("@Email", email);
                    updateCommand.Parameters.AddWithValue("@Password", password);
                    updateCommand.Parameters.AddWithValue("@AdminID", id);

                    try
                    {
                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil di-update.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataAdmin();
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Gagal meng-update data. Periksa kembali ID admin yang dimasukkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dataGridViewAdmin.SelectedRows.Count > 0)
            {
                // Get the selected AdminID from the comboBoxAdminID
                string id = comboBoxAdminID.SelectedValue.ToString();

                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();

                    // Cek apakah ID admin yang akan dihapus digunakan dalam tabel lain
                    string checkReferenceQuery = "SELECT COUNT(*) FROM AkunKaryawan WHERE AdminID = @AdminID";
                    SqlCommand checkReferenceCommand = new SqlCommand(checkReferenceQuery, connection);
                    checkReferenceCommand.Parameters.AddWithValue("@AdminID", id);
                    int referenceCount = (int)checkReferenceCommand.ExecuteScalar();

                    if (referenceCount > 0)
                    {
                        MessageBox.Show("Tidak dapat menghapus data. ID admin digunakan dalam tabel lain.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string deleteQuery = "DELETE FROM Admin WHERE AdminID = @AdminID";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@AdminID", id);

                    try
                    {
                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataAdmin();
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus data. Periksa kembali ID admin yang dipilih.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan saat menghapus data: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void EnableForm()
        {
            comboBoxAdminID.Enabled = true;
            tbNama.Enabled = true;
            tbTelepon.Enabled = true;
            tbEmail.Enabled = true;
            tbPassword.Enabled = true;

            btCreate.Enabled = true;
            btUpdate.Enabled = true;
            btDelete.Enabled = true;

            dataGridViewAdmin.Enabled = false; // optional: disable DataGridView to prevent interaction while in edit mode

            btOpen.Enabled = false;
        }

        private void ClearForm()
        {
            comboBoxAdminID.SelectedIndex = -1;
            tbNama.Text = string.Empty;
            tbTelepon.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbPassword.Text = string.Empty;
            dataGridViewAdmin.ClearSelection();
        }
    }
}

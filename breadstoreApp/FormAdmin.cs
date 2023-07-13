using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            EnableForm();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            string id = tbID.Text;
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
                string id = dataGridViewAdmin.SelectedRows[0].Cells["AdminID"].Value.ToString();
                string nama = tbNama.Text;
                string telepon = tbTelepon.Text;
                string email = tbEmail.Text;
                string password = tbPassword.Text;

                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "UPDATE Admin SET Nama = @Nama, Telepon = @Telepon, Email = @Email, Password = @Password WHERE AdminID = @AdminID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nama", nama);
                    command.Parameters.AddWithValue("@Telepon", telepon);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@AdminID", id);

                    connection.Open();

                    command.ExecuteNonQuery();
                }

                LoadDataAdmin();
                ClearForm();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdmin.SelectedRows.Count > 0)
            {
                string id = dataGridViewAdmin.SelectedRows[0].Cells["AdminID"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string query = "DELETE FROM Admin WHERE AdminID = @AdminID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AdminID", id);

                    connection.Open();

                    command.ExecuteNonQuery();
                }

                LoadDataAdmin();
                ClearForm();
            }
        }

        private void EnableForm()
        {
            tbID.Enabled = true;
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
            tbID.Text = string.Empty;
            tbNama.Text = string.Empty;
            tbTelepon.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbPassword.Text = string.Empty;
            dataGridViewAdmin.ClearSelection();
        }

    }
}

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
            DisableForm();
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
            DataRow newRow = rotiTable.NewRow();
            newRow["NamaRoti"] = tbNama.Text;
            newRow["Jenis"] = tbJenis.Text;
            newRow["Harga"] = tbHarga.Text;
            newRow["Stok"] = tbStok.Text;
            rotiTable.Rows.Add(newRow);

            SaveChanges();
            ClearForm();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoti.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewRoti.SelectedRows[0].Index;
                DataRow row = rotiTable.Rows[selectedIndex];
                row["NamaRoti"] = tbNama.Text;
                row["Jenis"] = tbJenis.Text;
                row["Harga"] = tbHarga.Text;
                row["Stok"] = tbStok.Text;

                SaveChanges();
                ClearForm();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoti.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewRoti.SelectedRows[0].Index;
                DataRow row = rotiTable.Rows[selectedIndex];
                row.Delete();

                SaveChanges();
                ClearForm();
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            EnableForm();
        }

        private void SaveChanges()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(rotiTable);
        }

        private void ClearForm()
        {
            tbNama.Text = string.Empty;
            tbJenis.Text = string.Empty;
            tbHarga.Text = string.Empty;
            tbStok.Text = string.Empty;
            dataGridViewRoti.ClearSelection();
        }

        private void EnableForm()
        {
            tbNama.Enabled = true;
            tbJenis.Enabled = true;
            tbHarga.Enabled = true;
            tbStok.Enabled = true;

            btCreate.Enabled = true;
            btUpdate.Enabled = true;
            btDelete.Enabled = true;

            dataGridViewRoti.Enabled = true;
        }

        private void DisableForm()
        {
            tbNama.Enabled = false;
            tbJenis.Enabled = false;
            tbHarga.Enabled = false;
            tbStok.Enabled = false;

            btCreate.Enabled = false;
            btUpdate.Enabled = false;
            btDelete.Enabled = false;

            dataGridViewRoti.Enabled = false;
        }
    }
}

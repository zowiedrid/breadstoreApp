using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace breadstoreApp
{
    public partial class FormAkunKaryawan : Form
    {
        public FormAkunKaryawan()
        {
            InitializeComponent();
        }

        private void dataGridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAkunKaryawan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'breadstoreDataSet.AkunKaryawan' table. You can move, or remove it, as needed.
            this.akunKaryawanTableAdapter.Fill(this.breadstoreDataSet.AkunKaryawan);

        }
    }
}

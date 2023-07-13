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
    public partial class FormPengiriman : Form
    {
        public FormPengiriman()
        {
            InitializeComponent();
        }

        private void FormPengiriman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'breadstoreDataSet.PengirimanBahan' table. You can move, or remove it, as needed.
            this.pengirimanBahanTableAdapter.Fill(this.breadstoreDataSet.PengirimanBahan);

        }

        private void dataGridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

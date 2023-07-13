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
    public partial class FormPelanggan : Form
    {
        public FormPelanggan()
        {
            InitializeComponent();
        }

        private void FormPelanggan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'breadstoreDataSet.Pelanggan' table. You can move, or remove it, as needed.
            this.pelangganTableAdapter.Fill(this.breadstoreDataSet.Pelanggan);

        }
    }
}

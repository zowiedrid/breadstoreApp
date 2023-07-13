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
    public partial class FormBahanRoti : Form
    {
        public FormBahanRoti()
        {
            InitializeComponent();
        }

        private void FormBahanRoti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'breadstoreDataSet.RotiBahan' table. You can move, or remove it, as needed.
            this.rotiBahanTableAdapter.Fill(this.breadstoreDataSet.RotiBahan);

        }
    }
}

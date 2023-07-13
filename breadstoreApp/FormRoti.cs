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
    public partial class FormRoti : Form
    {
        public FormRoti()
        {
            InitializeComponent();
        }

        private void FormRoti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'breadstoreDataSet.Roti' table. You can move, or remove it, as needed.
            this.rotiTableAdapter.Fill(this.breadstoreDataSet.Roti);

        }
    }
}

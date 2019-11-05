using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootManager
{
    public partial class frmUtilisateur : Form
    {
        public frmUtilisateur()
        {
            InitializeComponent();
        }


        private void FrmUtilisateur_Load(object sender, EventArgs e)
        {

        }


        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void dtgUtilisateur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
               // frmMatch.ShowDialog();
            }

        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {

            this.Hide();
            var frmLog = new frmLogin();
            frmLog.ShowDialog();

            this.Close();
        }
    }
}

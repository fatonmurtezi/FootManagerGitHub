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
    public partial class FrmUtilisateur : Form
    {
        private FrmLogin frmLogin;
        public FrmUtilisateur(FrmLogin frmLogin)
        {
            this.frmLogin = frmLogin;
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tpProfil_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmMatch frmMatch = new FrmMatch();
            frmMatch.ShowDialog();

        }

        private void FrmUtilisateur_Load(object sender, EventArgs e)
        {

        }

        private void FrmUtilisateur_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin.Dispose();
        }
    }
}

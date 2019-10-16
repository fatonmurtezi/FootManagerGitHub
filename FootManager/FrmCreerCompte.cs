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
    public partial class FrmCreerCompte : Form
    {
        public FrmCreerCompte()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            
            frmLogin.Show();
            this.Hide();
        }

        private void FrmCreerCompte_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {

        }

        private void lblCreerCompte_Click(object sender, EventArgs e)
        {
            FrmCreerCompte frmCreerCompte = new FrmCreerCompte();
            frmCreerCompte.Show();
        }
    }
}

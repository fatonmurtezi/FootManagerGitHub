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
        private FrmLogin frmLogin;
        public FrmCreerCompte(FrmLogin frmLogin)
        {
            this.frmLogin = frmLogin;
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            
            frmLogin.Show();
            this.Hide();
        }

        private void FrmCreerCompte_Load(object sender, EventArgs e)
        {

        }

        private void FrmCreerCompte_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if(e.CloseReason == CloseReason.UserClosing)
            {
                frmLogin.Dispose();
            }
                
        }

        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            if (tbIdentifiant.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("My message here");

            }
        }
    }
}

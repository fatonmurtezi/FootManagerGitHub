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
            if (tbIdentifiant.Text == "admin")
            {
                FrmAdministrateur frmAdministrateur = new FrmAdministrateur();
                frmAdministrateur.Show();
                this.Hide();
            }
            if(tbIdentifiant.Text == "user")
            {
                FrmUtilisateur frmUtilisateur = new FrmUtilisateur();
                frmUtilisateur.Show();
                this.Hide();
            }
        }

        private void lblCreerCompte_Click(object sender, EventArgs e)
        {
            FrmCreerCompte frmCreerCompte = new FrmCreerCompte();
            frmCreerCompte.Show();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }


        private void llblCreerCompte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCreerCompte frmCreerCompte = new FrmCreerCompte();
            frmCreerCompte.Show();
            this.Close();
        }

        
    }
}

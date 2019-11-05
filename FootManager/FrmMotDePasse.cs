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
    public partial class frmMotDePasse : Form
    {
        private frmLogin frmLogin;
        public frmMotDePasse(frmLogin frmLogin)
        {
            this.frmLogin = frmLogin;
            InitializeComponent();
        }

        private void frmMotDePasse_Load(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            frmLogin.Show();
            this.Hide();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (txtConfirmerMDP.Text == txtNouveauMDP.Text & txtNouveauMDP.Text != "")
            {
                System.Windows.Forms.MessageBox.Show("Mot de passe modifié");
                frmLogin.Show();
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Le mot de passe n'est pas conforme");

            }
        }

        private void txtConfirmerMDP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

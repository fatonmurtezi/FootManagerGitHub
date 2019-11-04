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
    public partial class frmCreerCompte : Form
    {
        private frmLogin frmLogin;
        private bool pass;
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public frmCreerCompte(frmLogin frmLogin)
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
            pass = true;
            if (txtIdentifiant.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Identifiant vide");
                pass = false;
            }

            if (!txtMotDePasse.Text.Equals(txtConfirmerMotDePasse)) {
                System.Windows.Forms.MessageBox.Show("Mots de passe différents");

                pass = false;
            }



            if (!IsValidEmail(txtEmail.Text)){
                System.Windows.Forms.MessageBox.Show("email invalide");
                pass = false;
            }

            if (pass == true)
            {
                System.Windows.Forms.MessageBox.Show("Créer le compte");
                this.Hide();
                frmLogin.Show();
            }
        }
        

    }
}

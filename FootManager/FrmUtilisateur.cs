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

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (txtModifierEmail.Text != "")//si vide ça veut dire qu'on veut pas le changer
            {
                if(txtModifierEmail.Text == lblEmailBDD.Text)
                {
                    System.Windows.Forms.MessageBox.Show("L'email n'est pas différent");

                }
                else
                {
                    if (IsValidEmail(txtModifierEmail.Text))
                    {
                        System.Windows.Forms.MessageBox.Show("L'email a été changé");
                        lblEmailBDD.Text = txtModifierEmail.Text;
                        txtModifierEmail.Text = "";
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("L'email est invalide");

                    }


                }
            }
            

            if (txtModifierMdp.Text !="" )//si le mdp est vide ça veut dire qu'on veut pas le changer
            {
                if (txtModifierMdp.Text != txtConfirmerMdp.Text)
                {
                    System.Windows.Forms.MessageBox.Show("La confirmation du mot de passe est différente");

                    //mdp invalide
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Mot de passe modifié");
                    txtConfirmerMdp.Text = "";
                    txtModifierMdp.Text = "";
                }
            }

            
        }

        private void dtgUtilisateur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var frmMatch = new frmMatch();
                frmMatch.ShowDialog();
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

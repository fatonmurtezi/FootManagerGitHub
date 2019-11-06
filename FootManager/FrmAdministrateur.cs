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
    public partial class frmAdministrateur : Form
    {
        public frmAdministrateur()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAdresse.Text != "")
            {
                int nb = dgvMatches.Rows.Count;

                this.dgvMatches.Rows.Add();

                this.dgvMatches.Rows[nb].Cells[0].Value = txtAdresse.Text;
                this.dgvMatches.Rows[nb].Cells[1].Value = dtpDate.Text;
                this.dgvMatches.Rows[nb].Cells[2].Value = dtpHeure.Text;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Erreur d'adresse");

            }

        }

   

    



      

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool pass = true;
            if(txtSaison.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Erreur de saison");
                pass = false;
            }

            if(txtIban.Text == "") 
            {
                System.Windows.Forms.MessageBox.Show("Erreur d'iban");

                pass = false;
            }

            if(txtNom.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Erreur de nom");

                pass = false;
            }

            if(txtAdresseCotisation.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Erreur d'adresse");

                pass = false;
            }
            


            if(pass)
            {
                System.Windows.Forms.MessageBox.Show("Données modifiées avec succès");
                //envoyer a la bdd et afficher les champs contenu dans la bdd pour la prochaine fois

            }


        }




        private void FrmAdministrateur_Load(object sender, EventArgs e)
        {

            this.dgvMembres.Rows.Add();

            this.dgvMembres.Rows[0].Cells[0].Value = "Nono";
            this.dgvMembres.Rows[0].Cells[1].Value = "nono@hotmail.com";
            this.dgvMembres.Rows[0].Cells[2].Value = true;
            this.dgvMembres.Rows.Add();
            this.dgvMembres.Rows[1].Cells[0].Value = "Toto";
            this.dgvMembres.Rows[1].Cells[1].Value = "Toto@hotmail.com";
            this.dgvMembres.Rows[1].Cells[2].Value = false;

            this.dgvMatches.Rows.Add();

            this.dgvMatches.Rows[0].Cells[0].Value = "Av.Henri-Bordier 1 1203 Genève";
            this.dgvMatches.Rows[0].Cells[1].Value = "30.10.2019";
            this.dgvMatches.Rows[0].Cells[2].Value = "10:30:00";
            


        }

      
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmLog = new frmLogin();
            frmLog.ShowDialog();
            this.Close();
        }

        private void btnDeconnexion_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var frmLog = new frmLogin();
            frmLog.ShowDialog();
            this.Close();
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



        private void btnAjouterMembre_Click(object sender, EventArgs e)
        {
            bool pass = true;

            if (txtIdentifiant.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Erreur d'identifiant");
                pass = false;
            }


            if (txtEmail.Text == "" || !IsValidEmail(txtEmail.Text))
            {
                System.Windows.Forms.MessageBox.Show("Erreur d'email");

                pass = false;
            }
            if(txtMDPMembre.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Erreur de mot de passe");
                pass = false;
            }

            if (pass)
            {
                System.Windows.Forms.MessageBox.Show("Membre ajouté avec succès");
                txtIdentifiant.Text = "";
                txtEmail.Text = "";
                txtMDPMembre.Text = "";
            }
        }
    }
}
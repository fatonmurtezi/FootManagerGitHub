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
            if(txtAdresse.Text == "" && txtAdresseCotisation.Text == "" &&
                txtDernierDelai.Text == "" && txtIban.Text == "" && txtMontant.Text == ""
                && txtNom.Text == "" && txtSaison.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Erreur saisie incomplète");

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Données modifiées avec succès");

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

  
    }
}
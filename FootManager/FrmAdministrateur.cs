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
        private frmLogin frmLogin;
        public frmAdministrateur(frmLogin frmLogin)
        {
            this.frmLogin = frmLogin;
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nb = dgvMatches.Rows.Count;

            this.dgvMatches.Rows.Add();
            
           
            this.dgvMatches.Rows[nb].Cells[0].Value = txtAdresse.Text;
            this.dgvMatches.Rows[nb].Cells[1].Value = dtpDate.Text;
            this.dgvMatches.Rows[nb].Cells[2].Value = dtpHeure.Text;
        }

        private void tpMatches_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void tpCotisations_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAdministrateur_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin.Dispose();
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
            this.dgvMatches.Rows[0].Cells[2].Value = "10:30";


        }
    }
}
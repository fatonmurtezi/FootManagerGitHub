﻿using System;
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
    public partial class FrmAdministrateur : Form
    {
        private FrmLogin frmLogin;
        public FrmAdministrateur(FrmLogin frmLogin)
        {
            this.frmLogin = frmLogin;
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
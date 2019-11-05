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
    public partial class frmMatch : Form
    {
        public frmMatch()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuitterMatch_Click(object sender, EventArgs e)
        {
            if (btnQuitterMatch.Text == "&Quitter")
            {
                btnQuitterMatch.Text = "&Rejoindre";
            }
            else
            {
                btnQuitterMatch.Text = "&Quitter";
            }
        }
    }
}

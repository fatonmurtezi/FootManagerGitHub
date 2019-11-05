namespace FootManager
{
    partial class frmAdministrateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpMatches = new System.Windows.Forms.TabPage();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.clmAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbpAjouterMatch = new System.Windows.Forms.GroupBox();
            this.dtpHeure = new System.Windows.Forms.DateTimePicker();
            this.lblHeure = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAdresseMatch = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.tpMembres = new System.Windows.Forms.TabPage();
            this.dgvMembres = new System.Windows.Forms.DataGridView();
            this.cIdentifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tpCotisations = new System.Windows.Forms.TabPage();
            this.btnModifier = new System.Windows.Forms.Button();
            this.gbpInformationsBancaires = new System.Windows.Forms.GroupBox();
            this.txtAdresseCotisation = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.lblIban = new System.Windows.Forms.Label();
            this.lblAdresseCotisations = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.gbpInformationsSaison = new System.Windows.Forms.GroupBox();
            this.txtDernierDelai = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtSaison = new System.Windows.Forms.TextBox();
            this.lblSaison = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblDernierDelai = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.tcAdmin.SuspendLayout();
            this.tpMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.gbpAjouterMatch.SuspendLayout();
            this.tpMembres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembres)).BeginInit();
            this.tpCotisations.SuspendLayout();
            this.gbpInformationsBancaires.SuspendLayout();
            this.gbpInformationsSaison.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpMatches);
            this.tcAdmin.Controls.Add(this.tpMembres);
            this.tcAdmin.Controls.Add(this.tpCotisations);
            this.tcAdmin.Location = new System.Drawing.Point(3, 2);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(981, 400);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpMatches
            // 
            this.tpMatches.BackColor = System.Drawing.Color.White;
            this.tpMatches.Controls.Add(this.dgvMatches);
            this.tpMatches.Controls.Add(this.gbpAjouterMatch);
            this.tpMatches.Location = new System.Drawing.Point(4, 29);
            this.tpMatches.Name = "tpMatches";
            this.tpMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tpMatches.Size = new System.Drawing.Size(973, 367);
            this.tpMatches.TabIndex = 0;
            this.tpMatches.Text = "Matches";
            // 
            // dgvMatches
            // 
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAdresse,
            this.cDate,
            this.Column1,
            this.cBtn});
            this.dgvMatches.Location = new System.Drawing.Point(0, 89);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.RowHeadersWidth = 62;
            this.dgvMatches.RowTemplate.Height = 28;
            this.dgvMatches.Size = new System.Drawing.Size(966, 265);
            this.dgvMatches.TabIndex = 1;
            // 
            // clmAdresse
            // 
            this.clmAdresse.Frozen = true;
            this.clmAdresse.HeaderText = "Adresse";
            this.clmAdresse.MinimumWidth = 8;
            this.clmAdresse.Name = "clmAdresse";
            this.clmAdresse.ReadOnly = true;
            this.clmAdresse.Width = 240;
            // 
            // cDate
            // 
            this.cDate.Frozen = true;
            this.cDate.HeaderText = "Date";
            this.cDate.MinimumWidth = 8;
            this.cDate.Name = "cDate";
            this.cDate.ReadOnly = true;
            this.cDate.Width = 130;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Heure";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // cBtn
            // 
            this.cBtn.Frozen = true;
            this.cBtn.HeaderText = "Supprimer";
            this.cBtn.MinimumWidth = 8;
            this.cBtn.Name = "cBtn";
            this.cBtn.ReadOnly = true;
            this.cBtn.Width = 70;
            // 
            // gbpAjouterMatch
            // 
            this.gbpAjouterMatch.Controls.Add(this.dtpHeure);
            this.gbpAjouterMatch.Controls.Add(this.lblHeure);
            this.gbpAjouterMatch.Controls.Add(this.txtAdresse);
            this.gbpAjouterMatch.Controls.Add(this.dtpDate);
            this.gbpAjouterMatch.Controls.Add(this.lblDate);
            this.gbpAjouterMatch.Controls.Add(this.lblAdresseMatch);
            this.gbpAjouterMatch.Controls.Add(this.btnAjouter);
            this.gbpAjouterMatch.Location = new System.Drawing.Point(0, 0);
            this.gbpAjouterMatch.Name = "gbpAjouterMatch";
            this.gbpAjouterMatch.Size = new System.Drawing.Size(969, 83);
            this.gbpAjouterMatch.TabIndex = 0;
            this.gbpAjouterMatch.TabStop = false;
            this.gbpAjouterMatch.Text = "Ajouter un match";
            // 
            // dtpHeure
            // 
            this.dtpHeure.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHeure.Location = new System.Drawing.Point(646, 45);
            this.dtpHeure.Name = "dtpHeure";
            this.dtpHeure.ShowUpDown = true;
            this.dtpHeure.Size = new System.Drawing.Size(150, 26);
            this.dtpHeure.TabIndex = 2;
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(642, 22);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(53, 20);
            this.lblHeure.TabIndex = 7;
            this.lblHeure.Text = "Heure";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(8, 45);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(403, 26);
            this.txtAdresse.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(444, 45);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(172, 26);
            this.dtpDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(440, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblAdresseMatch
            // 
            this.lblAdresseMatch.AutoSize = true;
            this.lblAdresseMatch.Location = new System.Drawing.Point(3, 22);
            this.lblAdresseMatch.Name = "lblAdresseMatch";
            this.lblAdresseMatch.Size = new System.Drawing.Size(68, 20);
            this.lblAdresseMatch.TabIndex = 1;
            this.lblAdresseMatch.Text = "Adresse";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(860, 45);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(106, 32);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpMembres
            // 
            this.tpMembres.Controls.Add(this.dgvMembres);
            this.tpMembres.Location = new System.Drawing.Point(4, 29);
            this.tpMembres.Name = "tpMembres";
            this.tpMembres.Padding = new System.Windows.Forms.Padding(3);
            this.tpMembres.Size = new System.Drawing.Size(973, 367);
            this.tpMembres.TabIndex = 1;
            this.tpMembres.Text = "Membres";
            this.tpMembres.UseVisualStyleBackColor = true;
            // 
            // dgvMembres
            // 
            this.dgvMembres.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMembres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdentifiant,
            this.cEmail,
            this.Column2,
            this.Column3});
            this.dgvMembres.Location = new System.Drawing.Point(0, 0);
            this.dgvMembres.Name = "dgvMembres";
            this.dgvMembres.RowHeadersWidth = 62;
            this.dgvMembres.RowTemplate.Height = 28;
            this.dgvMembres.Size = new System.Drawing.Size(969, 365);
            this.dgvMembres.TabIndex = 0;
            // 
            // cIdentifiant
            // 
            this.cIdentifiant.Frozen = true;
            this.cIdentifiant.HeaderText = "Identifiant";
            this.cIdentifiant.MinimumWidth = 8;
            this.cIdentifiant.Name = "cIdentifiant";
            this.cIdentifiant.ReadOnly = true;
            this.cIdentifiant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cIdentifiant.Width = 140;
            // 
            // cEmail
            // 
            this.cEmail.Frozen = true;
            this.cEmail.HeaderText = "Email";
            this.cEmail.MinimumWidth = 8;
            this.cEmail.Name = "cEmail";
            this.cEmail.ReadOnly = true;
            this.cEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cEmail.Width = 150;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Paiement de la cotisation";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Rappel de paiement cotisation";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 150;
            // 
            // tpCotisations
            // 
            this.tpCotisations.Controls.Add(this.btnModifier);
            this.tpCotisations.Controls.Add(this.gbpInformationsBancaires);
            this.tpCotisations.Controls.Add(this.gbpInformationsSaison);
            this.tpCotisations.Location = new System.Drawing.Point(4, 29);
            this.tpCotisations.Name = "tpCotisations";
            this.tpCotisations.Padding = new System.Windows.Forms.Padding(3);
            this.tpCotisations.Size = new System.Drawing.Size(973, 367);
            this.tpCotisations.TabIndex = 2;
            this.tpCotisations.Text = "Cotisations";
            this.tpCotisations.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(397, 312);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(146, 31);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gbpInformationsBancaires
            // 
            this.gbpInformationsBancaires.Controls.Add(this.txtAdresseCotisation);
            this.gbpInformationsBancaires.Controls.Add(this.txtNom);
            this.gbpInformationsBancaires.Controls.Add(this.txtIban);
            this.gbpInformationsBancaires.Controls.Add(this.lblIban);
            this.gbpInformationsBancaires.Controls.Add(this.lblAdresseCotisations);
            this.gbpInformationsBancaires.Controls.Add(this.lblNom);
            this.gbpInformationsBancaires.Location = new System.Drawing.Point(9, 149);
            this.gbpInformationsBancaires.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbpInformationsBancaires.Name = "gbpInformationsBancaires";
            this.gbpInformationsBancaires.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbpInformationsBancaires.Size = new System.Drawing.Size(960, 121);
            this.gbpInformationsBancaires.TabIndex = 1;
            this.gbpInformationsBancaires.TabStop = false;
            this.gbpInformationsBancaires.Text = "Informations bancaires";
            // 
            // txtAdresseCotisation
            // 
            this.txtAdresseCotisation.Location = new System.Drawing.Point(299, 79);
            this.txtAdresseCotisation.Name = "txtAdresseCotisation";
            this.txtAdresseCotisation.Size = new System.Drawing.Size(575, 26);
            this.txtAdresseCotisation.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(299, 50);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(575, 26);
            this.txtNom.TabIndex = 1;
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(299, 19);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(575, 26);
            this.txtIban.TabIndex = 0;
            // 
            // lblIban
            // 
            this.lblIban.AutoSize = true;
            this.lblIban.Location = new System.Drawing.Point(9, 25);
            this.lblIban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(47, 20);
            this.lblIban.TabIndex = 3;
            this.lblIban.Text = "IBAN";
            // 
            // lblAdresseCotisations
            // 
            this.lblAdresseCotisations.AutoSize = true;
            this.lblAdresseCotisations.Location = new System.Drawing.Point(9, 85);
            this.lblAdresseCotisations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresseCotisations.Name = "lblAdresseCotisations";
            this.lblAdresseCotisations.Size = new System.Drawing.Size(68, 20);
            this.lblAdresseCotisations.TabIndex = 4;
            this.lblAdresseCotisations.Text = "Adresse";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(9, 56);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom";
            // 
            // gbpInformationsSaison
            // 
            this.gbpInformationsSaison.Controls.Add(this.txtDernierDelai);
            this.gbpInformationsSaison.Controls.Add(this.txtMontant);
            this.gbpInformationsSaison.Controls.Add(this.txtSaison);
            this.gbpInformationsSaison.Controls.Add(this.lblSaison);
            this.gbpInformationsSaison.Controls.Add(this.lblMontant);
            this.gbpInformationsSaison.Controls.Add(this.lblDernierDelai);
            this.gbpInformationsSaison.Location = new System.Drawing.Point(9, 8);
            this.gbpInformationsSaison.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbpInformationsSaison.Name = "gbpInformationsSaison";
            this.gbpInformationsSaison.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbpInformationsSaison.Size = new System.Drawing.Size(960, 131);
            this.gbpInformationsSaison.TabIndex = 0;
            this.gbpInformationsSaison.TabStop = false;
            this.gbpInformationsSaison.Text = "Informations de la saison";
            // 
            // txtDernierDelai
            // 
            this.txtDernierDelai.Location = new System.Drawing.Point(299, 94);
            this.txtDernierDelai.Name = "txtDernierDelai";
            this.txtDernierDelai.Size = new System.Drawing.Size(575, 26);
            this.txtDernierDelai.TabIndex = 2;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(299, 62);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(575, 26);
            this.txtMontant.TabIndex = 1;
            // 
            // txtSaison
            // 
            this.txtSaison.Location = new System.Drawing.Point(299, 30);
            this.txtSaison.Name = "txtSaison";
            this.txtSaison.Size = new System.Drawing.Size(575, 26);
            this.txtSaison.TabIndex = 0;
            // 
            // lblSaison
            // 
            this.lblSaison.AutoSize = true;
            this.lblSaison.Location = new System.Drawing.Point(9, 36);
            this.lblSaison.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaison.Name = "lblSaison";
            this.lblSaison.Size = new System.Drawing.Size(58, 20);
            this.lblSaison.TabIndex = 0;
            this.lblSaison.Text = "&Saison";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(9, 68);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(276, 20);
            this.lblMontant.TabIndex = 1;
            this.lblMontant.Text = "Montant de la cotisation par personne";
            // 
            // lblDernierDelai
            // 
            this.lblDernierDelai.AutoSize = true;
            this.lblDernierDelai.Location = new System.Drawing.Point(9, 100);
            this.lblDernierDelai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDernierDelai.Name = "lblDernierDelai";
            this.lblDernierDelai.Size = new System.Drawing.Size(265, 20);
            this.lblDernierDelai.TabIndex = 2;
            this.lblDernierDelai.Text = "Dernier délai pour payer la cotisation";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(404, 415);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(146, 31);
            this.btnDeconnexion.TabIndex = 1;
            this.btnDeconnexion.Text = "&Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // frmAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 449);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.tcAdmin);
            this.Name = "frmAdministrateur";
            this.Text = "FootManager - Administrateur";
            this.Load += new System.EventHandler(this.FrmAdministrateur_Load);
            this.tcAdmin.ResumeLayout(false);
            this.tpMatches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.gbpAjouterMatch.ResumeLayout(false);
            this.gbpAjouterMatch.PerformLayout();
            this.tpMembres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembres)).EndInit();
            this.tpCotisations.ResumeLayout(false);
            this.gbpInformationsBancaires.ResumeLayout(false);
            this.gbpInformationsBancaires.PerformLayout();
            this.gbpInformationsSaison.ResumeLayout(false);
            this.gbpInformationsSaison.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpMatches;
        private System.Windows.Forms.TabPage tpMembres;
        private System.Windows.Forms.GroupBox gbpAjouterMatch;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAdresseMatch;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.DateTimePicker dtpHeure;
        private System.Windows.Forms.DataGridView dgvMembres;
        private System.Windows.Forms.TabPage tpCotisations;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn cBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdentifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.Label lblDernierDelai;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblSaison;
        private System.Windows.Forms.GroupBox gbpInformationsBancaires;
        private System.Windows.Forms.Label lblIban;
        private System.Windows.Forms.Label lblAdresseCotisations;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox gbpInformationsSaison;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtSaison;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.TextBox txtDernierDelai;
        private System.Windows.Forms.TextBox txtAdresseCotisation;
        private System.Windows.Forms.TextBox txtNom;
    }
}
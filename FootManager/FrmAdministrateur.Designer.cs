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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrateur));
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpMatches = new System.Windows.Forms.TabPage();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.clmAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.gbpAjouterMembre = new System.Windows.Forms.GroupBox();
            this.txtMDPMembre = new System.Windows.Forms.TextBox();
            this.lblMDP = new System.Windows.Forms.Label();
            this.btnAjouterMembre = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.dgvMembres = new System.Windows.Forms.DataGridView();
            this.cIdentifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPaiementCotisation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPaiementRappel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSupprimerMembre = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.txtSaison = new System.Windows.Forms.TextBox();
            this.lblSaison = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblDernierDelai = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.npdMontant = new System.Windows.Forms.NumericUpDown();
            this.tcAdmin.SuspendLayout();
            this.tpMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.gbpAjouterMatch.SuspendLayout();
            this.tpMembres.SuspendLayout();
            this.gbpAjouterMembre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembres)).BeginInit();
            this.tpCotisations.SuspendLayout();
            this.gbpInformationsBancaires.SuspendLayout();
            this.gbpInformationsSaison.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdMontant)).BeginInit();
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
            this.dgvMatches.AllowUserToResizeColumns = false;
            this.dgvMatches.AllowUserToResizeRows = false;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAdresse,
            this.cDate,
            this.colHeure,
            this.cBtn});
            this.dgvMatches.Location = new System.Drawing.Point(0, 89);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.RowHeadersWidth = 62;
            this.dgvMatches.RowTemplate.Height = 28;
            this.dgvMatches.Size = new System.Drawing.Size(966, 278);
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
            // colHeure
            // 
            this.colHeure.Frozen = true;
            this.colHeure.HeaderText = "Heure";
            this.colHeure.MinimumWidth = 8;
            this.colHeure.Name = "colHeure";
            this.colHeure.Width = 140;
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
            this.btnAjouter.Location = new System.Drawing.Point(848, 39);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(115, 32);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpMembres
            // 
            this.tpMembres.Controls.Add(this.gbpAjouterMembre);
            this.tpMembres.Controls.Add(this.dgvMembres);
            this.tpMembres.Location = new System.Drawing.Point(4, 29);
            this.tpMembres.Name = "tpMembres";
            this.tpMembres.Padding = new System.Windows.Forms.Padding(3);
            this.tpMembres.Size = new System.Drawing.Size(973, 367);
            this.tpMembres.TabIndex = 1;
            this.tpMembres.Text = "Membres";
            this.tpMembres.UseVisualStyleBackColor = true;
            // 
            // gbpAjouterMembre
            // 
            this.gbpAjouterMembre.Controls.Add(this.txtMDPMembre);
            this.gbpAjouterMembre.Controls.Add(this.lblMDP);
            this.gbpAjouterMembre.Controls.Add(this.btnAjouterMembre);
            this.gbpAjouterMembre.Controls.Add(this.lblEmail);
            this.gbpAjouterMembre.Controls.Add(this.lblIdentifiant);
            this.gbpAjouterMembre.Controls.Add(this.txtEmail);
            this.gbpAjouterMembre.Controls.Add(this.txtIdentifiant);
            this.gbpAjouterMembre.Location = new System.Drawing.Point(3, 0);
            this.gbpAjouterMembre.Name = "gbpAjouterMembre";
            this.gbpAjouterMembre.Size = new System.Drawing.Size(962, 64);
            this.gbpAjouterMembre.TabIndex = 0;
            this.gbpAjouterMembre.TabStop = false;
            this.gbpAjouterMembre.Text = "Ajouter un membre";
            // 
            // txtMDPMembre
            // 
            this.txtMDPMembre.Location = new System.Drawing.Point(662, 25);
            this.txtMDPMembre.Name = "txtMDPMembre";
            this.txtMDPMembre.PasswordChar = '*';
            this.txtMDPMembre.Size = new System.Drawing.Size(174, 26);
            this.txtMDPMembre.TabIndex = 2;
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Location = new System.Drawing.Point(551, 28);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(105, 20);
            this.lblMDP.TabIndex = 5;
            this.lblMDP.Text = "&Mot de passe";
            // 
            // btnAjouterMembre
            // 
            this.btnAjouterMembre.Location = new System.Drawing.Point(842, 18);
            this.btnAjouterMembre.Name = "btnAjouterMembre";
            this.btnAjouterMembre.Size = new System.Drawing.Size(114, 33);
            this.btnAjouterMembre.TabIndex = 3;
            this.btnAjouterMembre.Text = "&Ajouter";
            this.btnAjouterMembre.UseVisualStyleBackColor = true;
            this.btnAjouterMembre.Click += new System.EventHandler(this.btnAjouterMembre_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(264, 26);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "&Email";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(2, 28);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(80, 20);
            this.lblIdentifiant.TabIndex = 0;
            this.lblIdentifiant.Text = "&Identifiant";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(318, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 26);
            this.txtEmail.TabIndex = 1;
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(88, 25);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(170, 26);
            this.txtIdentifiant.TabIndex = 0;
            // 
            // dgvMembres
            // 
            this.dgvMembres.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvMembres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdentifiant,
            this.cEmail,
            this.ColPaiementCotisation,
            this.colPaiementRappel,
            this.colSupprimerMembre});
            this.dgvMembres.Location = new System.Drawing.Point(0, 70);
            this.dgvMembres.Name = "dgvMembres";
            this.dgvMembres.RowHeadersWidth = 62;
            this.dgvMembres.RowTemplate.Height = 28;
            this.dgvMembres.Size = new System.Drawing.Size(969, 295);
            this.dgvMembres.TabIndex = 1;
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
            this.cEmail.Width = 155;
            // 
            // ColPaiementCotisation
            // 
            this.ColPaiementCotisation.FillWeight = 90F;
            this.ColPaiementCotisation.Frozen = true;
            this.ColPaiementCotisation.HeaderText = "Statut du paiement";
            this.ColPaiementCotisation.MinimumWidth = 8;
            this.ColPaiementCotisation.Name = "ColPaiementCotisation";
            this.ColPaiementCotisation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColPaiementCotisation.Width = 95;
            // 
            // colPaiementRappel
            // 
            this.colPaiementRappel.Frozen = true;
            this.colPaiementRappel.HeaderText = "Rappel de paiement";
            this.colPaiementRappel.MinimumWidth = 8;
            this.colPaiementRappel.Name = "colPaiementRappel";
            this.colPaiementRappel.ReadOnly = true;
            this.colPaiementRappel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPaiementRappel.Width = 105;
            // 
            // colSupprimerMembre
            // 
            this.colSupprimerMembre.HeaderText = "Supprimer";
            this.colSupprimerMembre.MinimumWidth = 8;
            this.colSupprimerMembre.Name = "colSupprimerMembre";
            this.colSupprimerMembre.Width = 85;
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
            this.lblIban.Text = "I&BAN";
            // 
            // lblAdresseCotisations
            // 
            this.lblAdresseCotisations.AutoSize = true;
            this.lblAdresseCotisations.Location = new System.Drawing.Point(9, 85);
            this.lblAdresseCotisations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresseCotisations.Name = "lblAdresseCotisations";
            this.lblAdresseCotisations.Size = new System.Drawing.Size(68, 20);
            this.lblAdresseCotisations.TabIndex = 4;
            this.lblAdresseCotisations.Text = "&Adresse";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(9, 56);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "&Nom";
            // 
            // gbpInformationsSaison
            // 
            this.gbpInformationsSaison.Controls.Add(this.npdMontant);
            this.gbpInformationsSaison.Controls.Add(this.dateTimePicker1);
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
            this.lblMontant.Text = "M&ontant de la cotisation par personne";
            // 
            // lblDernierDelai
            // 
            this.lblDernierDelai.AutoSize = true;
            this.lblDernierDelai.Location = new System.Drawing.Point(9, 100);
            this.lblDernierDelai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDernierDelai.Name = "lblDernierDelai";
            this.lblDernierDelai.Size = new System.Drawing.Size(265, 20);
            this.lblDernierDelai.TabIndex = 2;
            this.lblDernierDelai.Text = "D&ernier délai pour payer la cotisation";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(404, 419);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(146, 32);
            this.btnDeconnexion.TabIndex = 1;
            this.btnDeconnexion.Text = "&Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(299, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(575, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // npdMontant
            // 
            this.npdMontant.Location = new System.Drawing.Point(299, 66);
            this.npdMontant.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.npdMontant.Name = "npdMontant";
            this.npdMontant.Size = new System.Drawing.Size(575, 26);
            this.npdMontant.TabIndex = 3;
            // 
            // frmAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 463);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.tcAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdministrateur";
            this.Text = "FootManager - Administrateur";
            this.Load += new System.EventHandler(this.FrmAdministrateur_Load);
            this.tcAdmin.ResumeLayout(false);
            this.tpMatches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.gbpAjouterMatch.ResumeLayout(false);
            this.gbpAjouterMatch.PerformLayout();
            this.tpMembres.ResumeLayout(false);
            this.gbpAjouterMembre.ResumeLayout(false);
            this.gbpAjouterMembre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembres)).EndInit();
            this.tpCotisations.ResumeLayout(false);
            this.gbpInformationsBancaires.ResumeLayout(false);
            this.gbpInformationsBancaires.PerformLayout();
            this.gbpInformationsSaison.ResumeLayout(false);
            this.gbpInformationsSaison.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npdMontant)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeure;
        private System.Windows.Forms.DataGridViewButtonColumn cBtn;
        private System.Windows.Forms.Label lblDernierDelai;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblSaison;
        private System.Windows.Forms.GroupBox gbpInformationsBancaires;
        private System.Windows.Forms.Label lblIban;
        private System.Windows.Forms.Label lblAdresseCotisations;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox gbpInformationsSaison;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtSaison;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.TextBox txtAdresseCotisation;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdentifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColPaiementCotisation;
        private System.Windows.Forms.DataGridViewButtonColumn colPaiementRappel;
        private System.Windows.Forms.DataGridViewButtonColumn colSupprimerMembre;
        private System.Windows.Forms.GroupBox gbpAjouterMembre;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Button btnAjouterMembre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.TextBox txtMDPMembre;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.NumericUpDown npdMontant;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
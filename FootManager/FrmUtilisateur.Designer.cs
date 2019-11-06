namespace FootManager
{
    partial class frmUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUtilisateur));
            this.tcUtilisateur = new System.Windows.Forms.TabControl();
            this.tpMatches = new System.Windows.Forms.TabPage();
            this.dtgUtilisateur = new System.Windows.Forms.DataGridView();
            this.clmAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmParticipants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInfos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tpProfil = new System.Windows.Forms.TabPage();
            this.gbModifications = new System.Windows.Forms.GroupBox();
            this.lblModifierMdp = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtModifierMdp = new System.Windows.Forms.TextBox();
            this.gbInformations = new System.Windows.Forms.GroupBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblStatutBDD = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIbanBDD = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblPaiementBDD = new System.Windows.Forms.Label();
            this.lblIban = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblEmailBDD = new System.Windows.Forms.Label();
            this.lblIdentifiantBDD = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.lblConfirmerMdp = new System.Windows.Forms.Label();
            this.lblModifierEmail = new System.Windows.Forms.Label();
            this.txtConfirmerMdp = new System.Windows.Forms.TextBox();
            this.txtModifierEmail = new System.Windows.Forms.TextBox();
            this.lblDernierDelai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcUtilisateur.SuspendLayout();
            this.tpMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUtilisateur)).BeginInit();
            this.tpProfil.SuspendLayout();
            this.gbModifications.SuspendLayout();
            this.gbInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcUtilisateur
            // 
            this.tcUtilisateur.Controls.Add(this.tpMatches);
            this.tcUtilisateur.Controls.Add(this.tpProfil);
            this.tcUtilisateur.Location = new System.Drawing.Point(3, 6);
            this.tcUtilisateur.Name = "tcUtilisateur";
            this.tcUtilisateur.SelectedIndex = 0;
            this.tcUtilisateur.Size = new System.Drawing.Size(1010, 455);
            this.tcUtilisateur.TabIndex = 0;
            // 
            // tpMatches
            // 
            this.tpMatches.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tpMatches.Controls.Add(this.dtgUtilisateur);
            this.tpMatches.Location = new System.Drawing.Point(4, 29);
            this.tpMatches.Name = "tpMatches";
            this.tpMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tpMatches.Size = new System.Drawing.Size(1002, 422);
            this.tpMatches.TabIndex = 0;
            this.tpMatches.Text = "Matches";
            // 
            // dtgUtilisateur
            // 
            this.dtgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUtilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAdresse,
            this.clmDate,
            this.clmHeure,
            this.clmParticipants,
            this.clmInfos});
            this.dtgUtilisateur.Location = new System.Drawing.Point(0, 0);
            this.dtgUtilisateur.Name = "dtgUtilisateur";
            this.dtgUtilisateur.RowHeadersWidth = 62;
            this.dtgUtilisateur.RowTemplate.Height = 28;
            this.dtgUtilisateur.Size = new System.Drawing.Size(990, 418);
            this.dtgUtilisateur.TabIndex = 0;
            this.dtgUtilisateur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUtilisateur_CellContentClick);
            // 
            // clmAdresse
            // 
            this.clmAdresse.HeaderText = "Adresse";
            this.clmAdresse.MinimumWidth = 8;
            this.clmAdresse.Name = "clmAdresse";
            this.clmAdresse.Width = 205;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Date";
            this.clmDate.MinimumWidth = 8;
            this.clmDate.Name = "clmDate";
            this.clmDate.Width = 140;
            // 
            // clmHeure
            // 
            this.clmHeure.HeaderText = "Heure";
            this.clmHeure.MinimumWidth = 8;
            this.clmHeure.Name = "clmHeure";
            this.clmHeure.Width = 120;
            // 
            // clmParticipants
            // 
            this.clmParticipants.HeaderText = "Participants";
            this.clmParticipants.MinimumWidth = 8;
            this.clmParticipants.Name = "clmParticipants";
            this.clmParticipants.Width = 80;
            // 
            // clmInfos
            // 
            this.clmInfos.HeaderText = "Infos";
            this.clmInfos.MinimumWidth = 8;
            this.clmInfos.Name = "clmInfos";
            this.clmInfos.Width = 50;
            // 
            // tpProfil
            // 
            this.tpProfil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tpProfil.Controls.Add(this.gbModifications);
            this.tpProfil.Controls.Add(this.gbInformations);
            this.tpProfil.Location = new System.Drawing.Point(4, 29);
            this.tpProfil.Name = "tpProfil";
            this.tpProfil.Padding = new System.Windows.Forms.Padding(3);
            this.tpProfil.Size = new System.Drawing.Size(1002, 422);
            this.tpProfil.TabIndex = 1;
            this.tpProfil.Text = "Profil";
            // 
            // gbModifications
            // 
            this.gbModifications.Controls.Add(this.txtModifierEmail);
            this.gbModifications.Controls.Add(this.txtConfirmerMdp);
            this.gbModifications.Controls.Add(this.lblModifierEmail);
            this.gbModifications.Controls.Add(this.lblConfirmerMdp);
            this.gbModifications.Controls.Add(this.lblModifierMdp);
            this.gbModifications.Controls.Add(this.btnModifier);
            this.gbModifications.Controls.Add(this.txtModifierMdp);
            this.gbModifications.Location = new System.Drawing.Point(6, 237);
            this.gbModifications.Name = "gbModifications";
            this.gbModifications.Size = new System.Drawing.Size(986, 179);
            this.gbModifications.TabIndex = 15;
            this.gbModifications.TabStop = false;
            this.gbModifications.Text = "Modifications";
            // 
            // lblModifierMdp
            // 
            this.lblModifierMdp.AutoSize = true;
            this.lblModifierMdp.Location = new System.Drawing.Point(6, 28);
            this.lblModifierMdp.Name = "lblModifierMdp";
            this.lblModifierMdp.Size = new System.Drawing.Size(272, 30);
            this.lblModifierMdp.TabIndex = 6;
            this.lblModifierMdp.Text = "M&odifier le mot de passe";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(379, 134);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(194, 31);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtModifierMdp
            // 
            this.txtModifierMdp.Location = new System.Drawing.Point(214, 25);
            this.txtModifierMdp.Name = "txtModifierMdp";
            this.txtModifierMdp.PasswordChar = '*';
            this.txtModifierMdp.Size = new System.Drawing.Size(359, 26);
            this.txtModifierMdp.TabIndex = 0;
            // 
            // gbInformations
            // 
            this.gbInformations.Controls.Add(this.label1);
            this.gbInformations.Controls.Add(this.lblDernierDelai);
            this.gbInformations.Controls.Add(this.lblIdentifiant);
            this.gbInformations.Controls.Add(this.lblStatutBDD);
            this.gbInformations.Controls.Add(this.lblEmail);
            this.gbInformations.Controls.Add(this.lblIbanBDD);
            this.gbInformations.Controls.Add(this.lblMontant);
            this.gbInformations.Controls.Add(this.lblPaiementBDD);
            this.gbInformations.Controls.Add(this.lblIban);
            this.gbInformations.Controls.Add(this.lblStatut);
            this.gbInformations.Controls.Add(this.lblEmailBDD);
            this.gbInformations.Controls.Add(this.lblIdentifiantBDD);
            this.gbInformations.Location = new System.Drawing.Point(6, 6);
            this.gbInformations.Name = "gbInformations";
            this.gbInformations.Size = new System.Drawing.Size(986, 225);
            this.gbInformations.TabIndex = 14;
            this.gbInformations.TabStop = false;
            this.gbInformations.Text = "Informations";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(6, 22);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(80, 20);
            this.lblIdentifiant.TabIndex = 0;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // lblStatutBDD
            // 
            this.lblStatutBDD.AutoSize = true;
            this.lblStatutBDD.Location = new System.Drawing.Point(190, 155);
            this.lblStatutBDD.Name = "lblStatutBDD";
            this.lblStatutBDD.Size = new System.Drawing.Size(126, 30);
            this.lblStatutBDD.TabIndex = 13;
            this.lblStatutBDD.Text = "En attente";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 55);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblIbanBDD
            // 
            this.lblIbanBDD.AutoSize = true;
            this.lblIbanBDD.Location = new System.Drawing.Point(190, 121);
            this.lblIbanBDD.Name = "lblIbanBDD";
            this.lblIbanBDD.Size = new System.Drawing.Size(315, 30);
            this.lblIbanBDD.TabIndex = 12;
            this.lblIbanBDD.Text = "CH34 0800 2322 1232 1232";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(6, 88);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(178, 20);
            this.lblMontant.TabIndex = 2;
            this.lblMontant.Text = "Montant de la cotisation";
            // 
            // lblPaiementBDD
            // 
            this.lblPaiementBDD.AutoSize = true;
            this.lblPaiementBDD.Location = new System.Drawing.Point(190, 88);
            this.lblPaiementBDD.Name = "lblPaiementBDD";
            this.lblPaiementBDD.Size = new System.Drawing.Size(69, 30);
            this.lblPaiementBDD.TabIndex = 11;
            this.lblPaiementBDD.Text = "60 Fr";
            // 
            // lblIban
            // 
            this.lblIban.AutoSize = true;
            this.lblIban.Location = new System.Drawing.Point(6, 121);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(139, 20);
            this.lblIban.TabIndex = 3;
            this.lblIban.Text = "Paiement via l\'iban";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(6, 155);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(145, 20);
            this.lblStatut.TabIndex = 5;
            this.lblStatut.Text = "Statut du paiement";
            // 
            // lblEmailBDD
            // 
            this.lblEmailBDD.AutoSize = true;
            this.lblEmailBDD.Location = new System.Drawing.Point(190, 55);
            this.lblEmailBDD.Name = "lblEmailBDD";
            this.lblEmailBDD.Size = new System.Drawing.Size(198, 30);
            this.lblEmailBDD.TabIndex = 9;
            this.lblEmailBDD.Text = "nono@gmail.com";
            // 
            // lblIdentifiantBDD
            // 
            this.lblIdentifiantBDD.AutoSize = true;
            this.lblIdentifiantBDD.Location = new System.Drawing.Point(190, 22);
            this.lblIdentifiantBDD.Name = "lblIdentifiantBDD";
            this.lblIdentifiantBDD.Size = new System.Drawing.Size(71, 30);
            this.lblIdentifiantBDD.TabIndex = 0;
            this.lblIdentifiantBDD.Text = "Nono";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(392, 465);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(194, 32);
            this.btnDeconnexion.TabIndex = 1;
            this.btnDeconnexion.Text = "&Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // lblConfirmerMdp
            // 
            this.lblConfirmerMdp.AutoSize = true;
            this.lblConfirmerMdp.Location = new System.Drawing.Point(6, 57);
            this.lblConfirmerMdp.Name = "lblConfirmerMdp";
            this.lblConfirmerMdp.Size = new System.Drawing.Size(291, 30);
            this.lblConfirmerMdp.TabIndex = 7;
            this.lblConfirmerMdp.Text = "&Confirmer le mot de passe";
            // 
            // lblModifierEmail
            // 
            this.lblModifierEmail.AutoSize = true;
            this.lblModifierEmail.Location = new System.Drawing.Point(6, 89);
            this.lblModifierEmail.Name = "lblModifierEmail";
            this.lblModifierEmail.Size = new System.Drawing.Size(168, 30);
            this.lblModifierEmail.TabIndex = 8;
            this.lblModifierEmail.Text = "Mod&ifier l\'email";
            // 
            // txtConfirmerMdp
            // 
            this.txtConfirmerMdp.Location = new System.Drawing.Point(214, 57);
            this.txtConfirmerMdp.Name = "txtConfirmerMdp";
            this.txtConfirmerMdp.PasswordChar = '*';
            this.txtConfirmerMdp.Size = new System.Drawing.Size(359, 26);
            this.txtConfirmerMdp.TabIndex = 1;
            // 
            // txtModifierEmail
            // 
            this.txtModifierEmail.Location = new System.Drawing.Point(214, 89);
            this.txtModifierEmail.Name = "txtModifierEmail";
            this.txtModifierEmail.Size = new System.Drawing.Size(359, 26);
            this.txtModifierEmail.TabIndex = 2;
            // 
            // lblDernierDelai
            // 
            this.lblDernierDelai.AutoSize = true;
            this.lblDernierDelai.Location = new System.Drawing.Point(6, 188);
            this.lblDernierDelai.Name = "lblDernierDelai";
            this.lblDernierDelai.Size = new System.Drawing.Size(147, 30);
            this.lblDernierDelai.TabIndex = 14;
            this.lblDernierDelai.Text = "Dernier délai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "01/11/2019";
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 498);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.tcUtilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUtilisateur";
            this.Text = "FootManager - Utilisateur";
            this.Load += new System.EventHandler(this.FrmUtilisateur_Load);
            this.tcUtilisateur.ResumeLayout(false);
            this.tpMatches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUtilisateur)).EndInit();
            this.tpProfil.ResumeLayout(false);
            this.gbModifications.ResumeLayout(false);
            this.gbModifications.PerformLayout();
            this.gbInformations.ResumeLayout(false);
            this.gbInformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcUtilisateur;
        private System.Windows.Forms.TabPage tpMatches;
        private System.Windows.Forms.TabPage tpProfil;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Label lblIban;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox txtModifierMdp;
        private System.Windows.Forms.Label lblModifierMdp;
        private System.Windows.Forms.Label lblEmailBDD;
        private System.Windows.Forms.Label lblIdentifiantBDD;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblPaiementBDD;
        private System.Windows.Forms.Label lblStatutBDD;
        private System.Windows.Forms.Label lblIbanBDD;
        private System.Windows.Forms.DataGridView dtgUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmParticipants;
        private System.Windows.Forms.DataGridViewButtonColumn clmInfos;
        private System.Windows.Forms.GroupBox gbModifications;
        private System.Windows.Forms.GroupBox gbInformations;
        private System.Windows.Forms.TextBox txtModifierEmail;
        private System.Windows.Forms.TextBox txtConfirmerMdp;
        private System.Windows.Forms.Label lblModifierEmail;
        private System.Windows.Forms.Label lblConfirmerMdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDernierDelai;
    }
}
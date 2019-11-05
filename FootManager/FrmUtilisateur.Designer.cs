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
            this.tcUtilisateur = new System.Windows.Forms.TabControl();
            this.tpMatches = new System.Windows.Forms.TabPage();
            this.dtgUtilisateur = new System.Windows.Forms.DataGridView();
            this.clmAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmParticipants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInfos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tpProfil = new System.Windows.Forms.TabPage();
            this.lblStatutBDD = new System.Windows.Forms.Label();
            this.lblIbanBDD = new System.Windows.Forms.Label();
            this.lblPaiementBDD = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblEmailBDD = new System.Windows.Forms.Label();
            this.lblIdentifiantBDD = new System.Windows.Forms.Label();
            this.txtModifierMdp = new System.Windows.Forms.TextBox();
            this.lblModifierMdp = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblIban = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.tcUtilisateur.SuspendLayout();
            this.tpMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUtilisateur)).BeginInit();
            this.tpProfil.SuspendLayout();
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
            this.tpProfil.Controls.Add(this.lblStatutBDD);
            this.tpProfil.Controls.Add(this.lblIbanBDD);
            this.tpProfil.Controls.Add(this.lblPaiementBDD);
            this.tpProfil.Controls.Add(this.btnModifier);
            this.tpProfil.Controls.Add(this.lblEmailBDD);
            this.tpProfil.Controls.Add(this.lblIdentifiantBDD);
            this.tpProfil.Controls.Add(this.txtModifierMdp);
            this.tpProfil.Controls.Add(this.lblModifierMdp);
            this.tpProfil.Controls.Add(this.lblStatut);
            this.tpProfil.Controls.Add(this.lblIban);
            this.tpProfil.Controls.Add(this.lblMontant);
            this.tpProfil.Controls.Add(this.lblEmail);
            this.tpProfil.Controls.Add(this.lblIdentifiant);
            this.tpProfil.Location = new System.Drawing.Point(4, 29);
            this.tpProfil.Name = "tpProfil";
            this.tpProfil.Padding = new System.Windows.Forms.Padding(3);
            this.tpProfil.Size = new System.Drawing.Size(1002, 422);
            this.tpProfil.TabIndex = 1;
            this.tpProfil.Text = "Profil";
            // 
            // lblStatutBDD
            // 
            this.lblStatutBDD.AutoSize = true;
            this.lblStatutBDD.Location = new System.Drawing.Point(254, 178);
            this.lblStatutBDD.Name = "lblStatutBDD";
            this.lblStatutBDD.Size = new System.Drawing.Size(51, 20);
            this.lblStatutBDD.TabIndex = 13;
            this.lblStatutBDD.Text = "label8";
            // 
            // lblIbanBDD
            // 
            this.lblIbanBDD.AutoSize = true;
            this.lblIbanBDD.Location = new System.Drawing.Point(254, 134);
            this.lblIbanBDD.Name = "lblIbanBDD";
            this.lblIbanBDD.Size = new System.Drawing.Size(51, 20);
            this.lblIbanBDD.TabIndex = 12;
            this.lblIbanBDD.Text = "label7";
            // 
            // lblPaiementBDD
            // 
            this.lblPaiementBDD.AutoSize = true;
            this.lblPaiementBDD.Location = new System.Drawing.Point(254, 100);
            this.lblPaiementBDD.Name = "lblPaiementBDD";
            this.lblPaiementBDD.Size = new System.Drawing.Size(51, 20);
            this.lblPaiementBDD.TabIndex = 11;
            this.lblPaiementBDD.Text = "label4";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(632, 223);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(128, 31);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblEmailBDD
            // 
            this.lblEmailBDD.AutoSize = true;
            this.lblEmailBDD.Location = new System.Drawing.Point(254, 66);
            this.lblEmailBDD.Name = "lblEmailBDD";
            this.lblEmailBDD.Size = new System.Drawing.Size(51, 20);
            this.lblEmailBDD.TabIndex = 9;
            this.lblEmailBDD.Text = "label2";
            // 
            // lblIdentifiantBDD
            // 
            this.lblIdentifiantBDD.AutoSize = true;
            this.lblIdentifiantBDD.Location = new System.Drawing.Point(254, 34);
            this.lblIdentifiantBDD.Name = "lblIdentifiantBDD";
            this.lblIdentifiantBDD.Size = new System.Drawing.Size(51, 20);
            this.lblIdentifiantBDD.TabIndex = 0;
            this.lblIdentifiantBDD.Text = "label1";
            // 
            // txtModifierMdp
            // 
            this.txtModifierMdp.Location = new System.Drawing.Point(258, 223);
            this.txtModifierMdp.Name = "txtModifierMdp";
            this.txtModifierMdp.PasswordChar = '*';
            this.txtModifierMdp.Size = new System.Drawing.Size(336, 26);
            this.txtModifierMdp.TabIndex = 0;
            // 
            // lblModifierMdp
            // 
            this.lblModifierMdp.AutoSize = true;
            this.lblModifierMdp.Location = new System.Drawing.Point(21, 226);
            this.lblModifierMdp.Name = "lblModifierMdp";
            this.lblModifierMdp.Size = new System.Drawing.Size(195, 20);
            this.lblModifierMdp.TabIndex = 6;
            this.lblModifierMdp.Text = "Modifier son mot de passe";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(21, 178);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(145, 20);
            this.lblStatut.TabIndex = 5;
            this.lblStatut.Text = "Statut du paiement";
            // 
            // lblIban
            // 
            this.lblIban.AutoSize = true;
            this.lblIban.Location = new System.Drawing.Point(21, 134);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(139, 20);
            this.lblIban.TabIndex = 3;
            this.lblIban.Text = "Paiement via l\'iban";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(21, 100);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(178, 20);
            this.lblMontant.TabIndex = 2;
            this.lblMontant.Text = "Montant de la cotisation";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(21, 66);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(21, 34);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(80, 20);
            this.lblIdentifiant.TabIndex = 0;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(392, 465);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(194, 32);
            this.btnDeconnexion.TabIndex = 1;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 498);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.tcUtilisateur);
            this.MaximizeBox = false;
            this.Name = "frmUtilisateur";
            this.Text = "FootManager - Utilisateur";
            this.Load += new System.EventHandler(this.FrmUtilisateur_Load);
            this.tcUtilisateur.ResumeLayout(false);
            this.tpMatches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUtilisateur)).EndInit();
            this.tpProfil.ResumeLayout(false);
            this.tpProfil.PerformLayout();
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
    }
}
namespace FootManager
{
    partial class FrmUtilisateur
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpMatches = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cParticipants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tpProfil = new System.Windows.Forms.TabPage();
            this.lblEmailBDD = new System.Windows.Forms.Label();
            this.lblIdentifiantBDD = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblModifierMdp = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIban = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblPaiementBDD = new System.Windows.Forms.Label();
            this.lblIbanBDD = new System.Windows.Forms.Label();
            this.lblStatutBDD = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpProfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMatches);
            this.tabControl1.Controls.Add(this.tpProfil);
            this.tabControl1.Location = new System.Drawing.Point(3, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(858, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tpMatches
            // 
            this.tpMatches.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tpMatches.Controls.Add(this.dataGridView1);
            this.tpMatches.Location = new System.Drawing.Point(4, 29);
            this.tpMatches.Name = "tpMatches";
            this.tpMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tpMatches.Size = new System.Drawing.Size(850, 422);
            this.tpMatches.TabIndex = 0;
            this.tpMatches.Text = "matches";
            this.tpMatches.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAdresse,
            this.cDate,
            this.cHeure,
            this.cParticipants,
            this.cBtn});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(815, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // cAdresse
            // 
            this.cAdresse.Frozen = true;
            this.cAdresse.HeaderText = "adresse";
            this.cAdresse.MinimumWidth = 8;
            this.cAdresse.Name = "cAdresse";
            this.cAdresse.ReadOnly = true;
            this.cAdresse.Width = 150;
            // 
            // cDate
            // 
            this.cDate.Frozen = true;
            this.cDate.HeaderText = "date";
            this.cDate.MinimumWidth = 8;
            this.cDate.Name = "cDate";
            this.cDate.ReadOnly = true;
            this.cDate.Width = 150;
            // 
            // cHeure
            // 
            this.cHeure.Frozen = true;
            this.cHeure.HeaderText = "heure";
            this.cHeure.MinimumWidth = 8;
            this.cHeure.Name = "cHeure";
            this.cHeure.ReadOnly = true;
            this.cHeure.Width = 150;
            // 
            // cParticipants
            // 
            this.cParticipants.Frozen = true;
            this.cParticipants.HeaderText = "participants";
            this.cParticipants.MinimumWidth = 8;
            this.cParticipants.Name = "cParticipants";
            this.cParticipants.ReadOnly = true;
            this.cParticipants.Width = 150;
            // 
            // cBtn
            // 
            this.cBtn.Frozen = true;
            this.cBtn.HeaderText = "infos";
            this.cBtn.MinimumWidth = 8;
            this.cBtn.Name = "cBtn";
            this.cBtn.ReadOnly = true;
            this.cBtn.Width = 150;
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
            this.tpProfil.Controls.Add(this.textBox1);
            this.tpProfil.Controls.Add(this.lblModifierMdp);
            this.tpProfil.Controls.Add(this.lblStatut);
            this.tpProfil.Controls.Add(this.label5);
            this.tpProfil.Controls.Add(this.lblIban);
            this.tpProfil.Controls.Add(this.lblMontant);
            this.tpProfil.Controls.Add(this.lblEmail);
            this.tpProfil.Controls.Add(this.lblIdentifiant);
            this.tpProfil.Location = new System.Drawing.Point(4, 29);
            this.tpProfil.Name = "tpProfil";
            this.tpProfil.Padding = new System.Windows.Forms.Padding(3);
            this.tpProfil.Size = new System.Drawing.Size(850, 422);
            this.tpProfil.TabIndex = 1;
            this.tpProfil.Text = "profil";
            this.tpProfil.Click += new System.EventHandler(this.tpProfil_Click);
            // 
            // lblEmailBDD
            // 
            this.lblEmailBDD.AutoSize = true;
            this.lblEmailBDD.Location = new System.Drawing.Point(254, 66);
            this.lblEmailBDD.Name = "lblEmailBDD";
            this.lblEmailBDD.Size = new System.Drawing.Size(51, 20);
            this.lblEmailBDD.TabIndex = 9;
            this.lblEmailBDD.Text = "label2";
            this.lblEmailBDD.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblIdentifiantBDD
            // 
            this.lblIdentifiantBDD.AutoSize = true;
            this.lblIdentifiantBDD.Location = new System.Drawing.Point(254, 34);
            this.lblIdentifiantBDD.Name = "lblIdentifiantBDD";
            this.lblIdentifiantBDD.Size = new System.Drawing.Size(51, 20);
            this.lblIdentifiantBDD.TabIndex = 8;
            this.lblIdentifiantBDD.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 26);
            this.textBox1.TabIndex = 7;
            // 
            // lblModifierMdp
            // 
            this.lblModifierMdp.AutoSize = true;
            this.lblModifierMdp.Location = new System.Drawing.Point(21, 226);
            this.lblModifierMdp.Name = "lblModifierMdp";
            this.lblModifierMdp.Size = new System.Drawing.Size(195, 20);
            this.lblModifierMdp.TabIndex = 6;
            this.lblModifierMdp.Text = "modifier son mot de passe";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(21, 178);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(142, 20);
            this.lblStatut.TabIndex = 5;
            this.lblStatut.Text = "statut du paiement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // lblIban
            // 
            this.lblIban.AutoSize = true;
            this.lblIban.Location = new System.Drawing.Point(21, 134);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(138, 20);
            this.lblIban.TabIndex = 3;
            this.lblIban.Text = "paiement via l\'iban";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(21, 100);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(178, 20);
            this.lblMontant.TabIndex = 2;
            this.lblMontant.Text = "montant de la cotisation";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(21, 66);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "email";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(21, 34);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(78, 20);
            this.lblIdentifiant.TabIndex = 0;
            this.lblIdentifiant.Text = "identifiant";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(304, 463);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(194, 33);
            this.btnDeconnexion.TabIndex = 2;
            this.btnDeconnexion.Text = "déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(631, 223);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(128, 26);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.Text = "modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
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
            // lblIbanBDD
            // 
            this.lblIbanBDD.AutoSize = true;
            this.lblIbanBDD.Location = new System.Drawing.Point(254, 134);
            this.lblIbanBDD.Name = "lblIbanBDD";
            this.lblIbanBDD.Size = new System.Drawing.Size(51, 20);
            this.lblIbanBDD.TabIndex = 12;
            this.lblIbanBDD.Text = "label7";
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
            // FrmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 498);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmUtilisateur";
            this.Text = "FrmUtilisateur";
            this.tabControl1.ResumeLayout(false);
            this.tpMatches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpProfil.ResumeLayout(false);
            this.tpProfil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpMatches;
        private System.Windows.Forms.TabPage tpProfil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn cParticipants;
        private System.Windows.Forms.DataGridViewButtonColumn cBtn;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIban;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblModifierMdp;
        private System.Windows.Forms.Label lblEmailBDD;
        private System.Windows.Forms.Label lblIdentifiantBDD;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblPaiementBDD;
        private System.Windows.Forms.Label lblStatutBDD;
        private System.Windows.Forms.Label lblIbanBDD;
    }
}
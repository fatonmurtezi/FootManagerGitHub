namespace FootManager
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbIdentifiant = new System.Windows.Forms.TextBox();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.tbMotDePasse = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.llblCreerCompte = new System.Windows.Forms.LinkLabel();
            this.llblMotDePasseOublie = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbIdentifiant
            // 
            this.tbIdentifiant.Location = new System.Drawing.Point(182, 22);
            this.tbIdentifiant.Name = "tbIdentifiant";
            this.tbIdentifiant.Size = new System.Drawing.Size(294, 26);
            this.tbIdentifiant.TabIndex = 0;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(12, 25);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(80, 20);
            this.lblIdentifiant.TabIndex = 1;
            this.lblIdentifiant.Text = "&Identifiant";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(12, 58);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(105, 20);
            this.lblMotDePasse.TabIndex = 2;
            this.lblMotDePasse.Text = "&Mot de passe";
            // 
            // tbMotDePasse
            // 
            this.tbMotDePasse.Location = new System.Drawing.Point(182, 55);
            this.tbMotDePasse.Name = "tbMotDePasse";
            this.tbMotDePasse.Size = new System.Drawing.Size(294, 26);
            this.tbMotDePasse.TabIndex = 1;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(182, 103);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(294, 35);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.Text = "&Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // llblCreerCompte
            // 
            this.llblCreerCompte.AutoSize = true;
            this.llblCreerCompte.Location = new System.Drawing.Point(178, 197);
            this.llblCreerCompte.Name = "llblCreerCompte";
            this.llblCreerCompte.Size = new System.Drawing.Size(127, 20);
            this.llblCreerCompte.TabIndex = 3;
            this.llblCreerCompte.TabStop = true;
            this.llblCreerCompte.Text = "C&réer un compte";
            this.llblCreerCompte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCreerCompte_LinkClicked);
            // 
            // llblMotDePasseOublie
            // 
            this.llblMotDePasseOublie.AutoSize = true;
            this.llblMotDePasseOublie.Location = new System.Drawing.Point(178, 228);
            this.llblMotDePasseOublie.Name = "llblMotDePasseOublie";
            this.llblMotDePasseOublie.Size = new System.Drawing.Size(151, 20);
            this.llblMotDePasseOublie.TabIndex = 4;
            this.llblMotDePasseOublie.TabStop = true;
            this.llblMotDePasseOublie.Text = "M&ot de passe oublié";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 288);
            this.Controls.Add(this.llblMotDePasseOublie);
            this.Controls.Add(this.llblCreerCompte);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.tbMotDePasse);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.tbIdentifiant);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Text = "FootManager - Identification";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdentifiant;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox tbMotDePasse;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.LinkLabel llblCreerCompte;
        private System.Windows.Forms.LinkLabel llblMotDePasseOublie;
    }
}


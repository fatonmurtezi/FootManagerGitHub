namespace FootManager
{
    partial class FrmLogin
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
            this.tbIdentifiant.Location = new System.Drawing.Point(121, 14);
            this.tbIdentifiant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbIdentifiant.Name = "tbIdentifiant";
            this.tbIdentifiant.Size = new System.Drawing.Size(197, 20);
            this.tbIdentifiant.TabIndex = 0;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(8, 16);
            this.lblIdentifiant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.lblIdentifiant.TabIndex = 1;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(8, 38);
            this.lblMotDePasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(71, 13);
            this.lblMotDePasse.TabIndex = 2;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // tbMotDePasse
            // 
            this.tbMotDePasse.Location = new System.Drawing.Point(121, 36);
            this.tbMotDePasse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMotDePasse.Name = "tbMotDePasse";
            this.tbMotDePasse.Size = new System.Drawing.Size(197, 20);
            this.tbMotDePasse.TabIndex = 3;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(121, 67);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(196, 23);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // llblCreerCompte
            // 
            this.llblCreerCompte.AutoSize = true;
            this.llblCreerCompte.Location = new System.Drawing.Point(119, 128);
            this.llblCreerCompte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblCreerCompte.Name = "llblCreerCompte";
            this.llblCreerCompte.Size = new System.Drawing.Size(85, 13);
            this.llblCreerCompte.TabIndex = 7;
            this.llblCreerCompte.TabStop = true;
            this.llblCreerCompte.Text = "Créer un compte";
            // 
            // llblMotDePasseOublie
            // 
            this.llblMotDePasseOublie.AutoSize = true;
            this.llblMotDePasseOublie.Location = new System.Drawing.Point(119, 148);
            this.llblMotDePasseOublie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblMotDePasseOublie.Name = "llblMotDePasseOublie";
            this.llblMotDePasseOublie.Size = new System.Drawing.Size(102, 13);
            this.llblMotDePasseOublie.TabIndex = 8;
            this.llblMotDePasseOublie.TabStop = true;
            this.llblMotDePasseOublie.Text = "Mot de passe oublié";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 187);
            this.Controls.Add(this.llblMotDePasseOublie);
            this.Controls.Add(this.llblCreerCompte);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.tbMotDePasse);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.tbIdentifiant);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
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


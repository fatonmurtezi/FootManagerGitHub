﻿namespace FootManager
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
            this.lblCreerCompte = new System.Windows.Forms.Label();
            this.lblMotDePasseOublie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbIdentifiant
            // 
            this.tbIdentifiant.Location = new System.Drawing.Point(135, 22);
            this.tbIdentifiant.Name = "tbIdentifiant";
            this.tbIdentifiant.Size = new System.Drawing.Size(187, 26);
            this.tbIdentifiant.TabIndex = 0;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(12, 25);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(78, 20);
            this.lblIdentifiant.TabIndex = 1;
            this.lblIdentifiant.Text = "identifiant";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(12, 58);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(105, 20);
            this.lblMotDePasse.TabIndex = 2;
            this.lblMotDePasse.Text = "mot de passe";
            // 
            // tbMotDePasse
            // 
            this.tbMotDePasse.Location = new System.Drawing.Point(135, 58);
            this.tbMotDePasse.Name = "tbMotDePasse";
            this.tbMotDePasse.Size = new System.Drawing.Size(187, 26);
            this.tbMotDePasse.TabIndex = 3;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(135, 90);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(187, 26);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            // 
            // lblCreerCompte
            // 
            this.lblCreerCompte.AutoSize = true;
            this.lblCreerCompte.Location = new System.Drawing.Point(165, 147);
            this.lblCreerCompte.Name = "lblCreerCompte";
            this.lblCreerCompte.Size = new System.Drawing.Size(124, 20);
            this.lblCreerCompte.TabIndex = 5;
            this.lblCreerCompte.Text = "créer un compte";
            // 
            // lblMotDePasseOublie
            // 
            this.lblMotDePasseOublie.AutoSize = true;
            this.lblMotDePasseOublie.Location = new System.Drawing.Point(148, 171);
            this.lblMotDePasseOublie.Name = "lblMotDePasseOublie";
            this.lblMotDePasseOublie.Size = new System.Drawing.Size(151, 20);
            this.lblMotDePasseOublie.TabIndex = 6;
            this.lblMotDePasseOublie.Text = "mot de passe oublié";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 220);
            this.Controls.Add(this.lblMotDePasseOublie);
            this.Controls.Add(this.lblCreerCompte);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.tbMotDePasse);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.tbIdentifiant);
            this.Name = "FrmLogin";
            this.Text = "FootManager - Idenfitication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdentifiant;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox tbMotDePasse;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblCreerCompte;
        private System.Windows.Forms.Label lblMotDePasseOublie;
    }
}

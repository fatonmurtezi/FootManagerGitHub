namespace FootManager
{
    partial class FrmCreerCompte
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
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.lblConfirmerMotDePasse = new System.Windows.Forms.Label();
            this.tbIdentifiant = new System.Windows.Forms.TextBox();
            this.tbConfirmerMotDePasse = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnCreerCompte = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.tbMotDePasse = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(8, 14);
            this.lblIdentifiant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.lblIdentifiant.TabIndex = 0;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(8, 38);
            this.lblMotDePasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(71, 13);
            this.lblMotDePasse.TabIndex = 1;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // lblConfirmerMotDePasse
            // 
            this.lblConfirmerMotDePasse.AutoSize = true;
            this.lblConfirmerMotDePasse.Location = new System.Drawing.Point(8, 60);
            this.lblConfirmerMotDePasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmerMotDePasse.Name = "lblConfirmerMotDePasse";
            this.lblConfirmerMotDePasse.Size = new System.Drawing.Size(128, 13);
            this.lblConfirmerMotDePasse.TabIndex = 2;
            this.lblConfirmerMotDePasse.Text = "Confirmer le mot de passe";
            // 
            // tbIdentifiant
            // 
            this.tbIdentifiant.Location = new System.Drawing.Point(145, 12);
            this.tbIdentifiant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbIdentifiant.Name = "tbIdentifiant";
            this.tbIdentifiant.Size = new System.Drawing.Size(196, 20);
            this.tbIdentifiant.TabIndex = 4;
            // 
            // tbConfirmerMotDePasse
            // 
            this.tbConfirmerMotDePasse.Location = new System.Drawing.Point(145, 58);
            this.tbConfirmerMotDePasse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbConfirmerMotDePasse.Name = "tbConfirmerMotDePasse";
            this.tbConfirmerMotDePasse.Size = new System.Drawing.Size(196, 20);
            this.tbConfirmerMotDePasse.TabIndex = 6;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(145, 79);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(196, 20);
            this.tbEmail.TabIndex = 7;
            // 
            // btnCreerCompte
            // 
            this.btnCreerCompte.Location = new System.Drawing.Point(145, 106);
            this.btnCreerCompte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreerCompte.Name = "btnCreerCompte";
            this.btnCreerCompte.Size = new System.Drawing.Size(195, 20);
            this.btnCreerCompte.TabIndex = 8;
            this.btnCreerCompte.Text = "Créer un compte";
            this.btnCreerCompte.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(191, 138);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(101, 20);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // tbMotDePasse
            // 
            this.tbMotDePasse.Location = new System.Drawing.Point(145, 36);
            this.tbMotDePasse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMotDePasse.Name = "tbMotDePasse";
            this.tbMotDePasse.Size = new System.Drawing.Size(196, 20);
            this.tbMotDePasse.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(8, 81);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // FrmCreerCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 166);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbMotDePasse);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnCreerCompte);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbConfirmerMotDePasse);
            this.Controls.Add(this.tbIdentifiant);
            this.Controls.Add(this.lblConfirmerMotDePasse);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblIdentifiant);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCreerCompte";
            this.Text = "FootManager - Créer un compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.Label lblConfirmerMotDePasse;
        private System.Windows.Forms.TextBox tbIdentifiant;
        private System.Windows.Forms.TextBox tbConfirmerMotDePasse;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnCreerCompte;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox tbMotDePasse;
        private System.Windows.Forms.Label lblEmail;
    }
}
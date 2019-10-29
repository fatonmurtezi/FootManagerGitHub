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
            this.lblIdentifiant.Location = new System.Drawing.Point(12, 22);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(80, 20);
            this.lblIdentifiant.TabIndex = 0;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(12, 58);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(105, 20);
            this.lblMotDePasse.TabIndex = 1;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // lblConfirmerMotDePasse
            // 
            this.lblConfirmerMotDePasse.AutoSize = true;
            this.lblConfirmerMotDePasse.Location = new System.Drawing.Point(12, 92);
            this.lblConfirmerMotDePasse.Name = "lblConfirmerMotDePasse";
            this.lblConfirmerMotDePasse.Size = new System.Drawing.Size(194, 20);
            this.lblConfirmerMotDePasse.TabIndex = 2;
            this.lblConfirmerMotDePasse.Text = "Confirmer le mot de passe";
            // 
            // tbIdentifiant
            // 
            this.tbIdentifiant.Location = new System.Drawing.Point(218, 18);
            this.tbIdentifiant.Name = "tbIdentifiant";
            this.tbIdentifiant.Size = new System.Drawing.Size(292, 26);
            this.tbIdentifiant.TabIndex = 4;
            // 
            // tbConfirmerMotDePasse
            // 
            this.tbConfirmerMotDePasse.Location = new System.Drawing.Point(218, 89);
            this.tbConfirmerMotDePasse.Name = "tbConfirmerMotDePasse";
            this.tbConfirmerMotDePasse.Size = new System.Drawing.Size(292, 26);
            this.tbConfirmerMotDePasse.TabIndex = 6;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(218, 122);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(292, 26);
            this.tbEmail.TabIndex = 7;
            // 
            // btnCreerCompte
            // 
            this.btnCreerCompte.Location = new System.Drawing.Point(218, 163);
            this.btnCreerCompte.Name = "btnCreerCompte";
            this.btnCreerCompte.Size = new System.Drawing.Size(292, 31);
            this.btnCreerCompte.TabIndex = 8;
            this.btnCreerCompte.Text = "Créer un compte";
            this.btnCreerCompte.UseVisualStyleBackColor = true;
            this.btnCreerCompte.Click += new System.EventHandler(this.btnCreerCompte_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(286, 212);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(152, 31);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // tbMotDePasse
            // 
            this.tbMotDePasse.Location = new System.Drawing.Point(218, 55);
            this.tbMotDePasse.Name = "tbMotDePasse";
            this.tbMotDePasse.Size = new System.Drawing.Size(292, 26);
            this.tbMotDePasse.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // FrmCreerCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 255);
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
            this.Name = "FrmCreerCompte";
            this.Text = "FootManager - Créer un compte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCreerCompte_FormClosing);
            this.Load += new System.EventHandler(this.FrmCreerCompte_Load);
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
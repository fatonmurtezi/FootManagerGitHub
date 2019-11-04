namespace FootManager
{
    partial class frmCreerCompte
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
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtConfirmerMotDePasse = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCreerCompte = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
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
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(218, 18);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(292, 26);
            this.txtIdentifiant.TabIndex = 0;
            // 
            // txtConfirmerMotDePasse
            // 
            this.txtConfirmerMotDePasse.Location = new System.Drawing.Point(218, 89);
            this.txtConfirmerMotDePasse.Name = "txtConfirmerMotDePasse";
            this.txtConfirmerMotDePasse.Size = new System.Drawing.Size(292, 26);
            this.txtConfirmerMotDePasse.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(218, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // btnCreerCompte
            // 
            this.btnCreerCompte.Location = new System.Drawing.Point(218, 163);
            this.btnCreerCompte.Name = "btnCreerCompte";
            this.btnCreerCompte.Size = new System.Drawing.Size(292, 31);
            this.btnCreerCompte.TabIndex = 4;
            this.btnCreerCompte.Text = "Créer un compte";
            this.btnCreerCompte.UseVisualStyleBackColor = true;
            this.btnCreerCompte.Click += new System.EventHandler(this.btnCreerCompte_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(286, 212);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(152, 31);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(218, 55);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(292, 26);
            this.txtMotDePasse.TabIndex = 1;
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
            // frmCreerCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 255);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnCreerCompte);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtConfirmerMotDePasse);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.lblConfirmerMotDePasse);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblIdentifiant);
            this.Name = "frmCreerCompte";
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
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtConfirmerMotDePasse;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCreerCompte;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Label lblEmail;
    }
}
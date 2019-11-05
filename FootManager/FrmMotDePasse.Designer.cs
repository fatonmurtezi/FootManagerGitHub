namespace FootManager
{
    partial class frmMotDePasse
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
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblNouveauMDP = new System.Windows.Forms.Label();
            this.lblConfirmerMDP = new System.Windows.Forms.Label();
            this.txtNouveauMDP = new System.Windows.Forms.TextBox();
            this.txtConfirmerMDP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(160, 127);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(93, 31);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(274, 127);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(93, 31);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblNouveauMDP
            // 
            this.lblNouveauMDP.AutoSize = true;
            this.lblNouveauMDP.Location = new System.Drawing.Point(12, 28);
            this.lblNouveauMDP.Name = "lblNouveauMDP";
            this.lblNouveauMDP.Size = new System.Drawing.Size(172, 20);
            this.lblNouveauMDP.TabIndex = 2;
            this.lblNouveauMDP.Text = "Nouveau mot de passe";
            // 
            // lblConfirmerMDP
            // 
            this.lblConfirmerMDP.AutoSize = true;
            this.lblConfirmerMDP.Location = new System.Drawing.Point(12, 75);
            this.lblConfirmerMDP.Name = "lblConfirmerMDP";
            this.lblConfirmerMDP.Size = new System.Drawing.Size(194, 20);
            this.lblConfirmerMDP.TabIndex = 3;
            this.lblConfirmerMDP.Text = "Confirmer le mot de passe";
            // 
            // txtNouveauMDP
            // 
            this.txtNouveauMDP.Location = new System.Drawing.Point(219, 28);
            this.txtNouveauMDP.Name = "txtNouveauMDP";
            this.txtNouveauMDP.PasswordChar = '*';
            this.txtNouveauMDP.Size = new System.Drawing.Size(322, 26);
            this.txtNouveauMDP.TabIndex = 4;
            // 
            // txtConfirmerMDP
            // 
            this.txtConfirmerMDP.Location = new System.Drawing.Point(219, 75);
            this.txtConfirmerMDP.Name = "txtConfirmerMDP";
            this.txtConfirmerMDP.PasswordChar = '*';
            this.txtConfirmerMDP.Size = new System.Drawing.Size(322, 26);
            this.txtConfirmerMDP.TabIndex = 5;
            this.txtConfirmerMDP.TextChanged += new System.EventHandler(this.txtConfirmerMDP_TextChanged);
            // 
            // frmMotDePasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 184);
            this.Controls.Add(this.txtConfirmerMDP);
            this.Controls.Add(this.txtNouveauMDP);
            this.Controls.Add(this.lblConfirmerMDP);
            this.Controls.Add(this.lblNouveauMDP);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Name = "frmMotDePasse";
            this.Text = "FootManager - Mot de passe";
            this.Load += new System.EventHandler(this.frmMotDePasse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblNouveauMDP;
        private System.Windows.Forms.Label lblConfirmerMDP;
        private System.Windows.Forms.TextBox txtNouveauMDP;
        private System.Windows.Forms.TextBox txtConfirmerMDP;
    }
}
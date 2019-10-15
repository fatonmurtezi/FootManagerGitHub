namespace FootManager
{
    partial class FrmMatch
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
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblNbParticipant = new System.Windows.Forms.Label();
            this.btnQuitterMatch = new System.Windows.Forms.Button();
            this.lblAdresseBDD = new System.Windows.Forms.Label();
            this.lblDateBDD = new System.Windows.Forms.Label();
            this.lblHeureBDD = new System.Windows.Forms.Label();
            this.lblNbParticipantBDD = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(21, 32);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(44, 13);
            this.lblAdresse.TabIndex = 0;
            this.lblAdresse.Text = "adresse";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(21, 53);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(28, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "date";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(21, 73);
            this.lblHeure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(34, 13);
            this.lblHeure.TabIndex = 2;
            this.lblHeure.Text = "heure";
            // 
            // lblNbParticipant
            // 
            this.lblNbParticipant.AutoSize = true;
            this.lblNbParticipant.Location = new System.Drawing.Point(21, 97);
            this.lblNbParticipant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbParticipant.Name = "lblNbParticipant";
            this.lblNbParticipant.Size = new System.Drawing.Size(61, 13);
            this.lblNbParticipant.TabIndex = 3;
            this.lblNbParticipant.Text = "participants";
            // 
            // btnQuitterMatch
            // 
            this.btnQuitterMatch.Location = new System.Drawing.Point(23, 133);
            this.btnQuitterMatch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitterMatch.Name = "btnQuitterMatch";
            this.btnQuitterMatch.Size = new System.Drawing.Size(91, 27);
            this.btnQuitterMatch.TabIndex = 4;
            this.btnQuitterMatch.Text = "Quitter le match";
            this.btnQuitterMatch.UseVisualStyleBackColor = true;
            // 
            // lblAdresseBDD
            // 
            this.lblAdresseBDD.AutoSize = true;
            this.lblAdresseBDD.Location = new System.Drawing.Point(119, 32);
            this.lblAdresseBDD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresseBDD.Name = "lblAdresseBDD";
            this.lblAdresseBDD.Size = new System.Drawing.Size(44, 13);
            this.lblAdresseBDD.TabIndex = 5;
            this.lblAdresseBDD.Text = "adresse";
            // 
            // lblDateBDD
            // 
            this.lblDateBDD.AutoSize = true;
            this.lblDateBDD.Location = new System.Drawing.Point(119, 53);
            this.lblDateBDD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateBDD.Name = "lblDateBDD";
            this.lblDateBDD.Size = new System.Drawing.Size(28, 13);
            this.lblDateBDD.TabIndex = 6;
            this.lblDateBDD.Text = "date";
            // 
            // lblHeureBDD
            // 
            this.lblHeureBDD.AutoSize = true;
            this.lblHeureBDD.Location = new System.Drawing.Point(119, 73);
            this.lblHeureBDD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeureBDD.Name = "lblHeureBDD";
            this.lblHeureBDD.Size = new System.Drawing.Size(34, 13);
            this.lblHeureBDD.TabIndex = 7;
            this.lblHeureBDD.Text = "heure";
            // 
            // lblNbParticipantBDD
            // 
            this.lblNbParticipantBDD.AutoSize = true;
            this.lblNbParticipantBDD.Location = new System.Drawing.Point(119, 97);
            this.lblNbParticipantBDD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNbParticipantBDD.Name = "lblNbParticipantBDD";
            this.lblNbParticipantBDD.Size = new System.Drawing.Size(61, 13);
            this.lblNbParticipantBDD.TabIndex = 8;
            this.lblNbParticipantBDD.Text = "participants";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(122, 133);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(59, 27);
            this.btnFermer.TabIndex = 9;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FrmMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 205);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblNbParticipantBDD);
            this.Controls.Add(this.lblHeureBDD);
            this.Controls.Add(this.lblDateBDD);
            this.Controls.Add(this.lblAdresseBDD);
            this.Controls.Add(this.btnQuitterMatch);
            this.Controls.Add(this.lblNbParticipant);
            this.Controls.Add(this.lblHeure);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAdresse);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMatch";
            this.Text = "FootManager - Match";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblNbParticipant;
        private System.Windows.Forms.Button btnQuitterMatch;
        private System.Windows.Forms.Label lblAdresseBDD;
        private System.Windows.Forms.Label lblDateBDD;
        private System.Windows.Forms.Label lblHeureBDD;
        private System.Windows.Forms.Label lblNbParticipantBDD;
        private System.Windows.Forms.Button btnFermer;
    }
}
﻿namespace FootManager
{
    partial class frmMatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatch));
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
            this.lblAdresse.Location = new System.Drawing.Point(32, 49);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(68, 20);
            this.lblAdresse.TabIndex = 3;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(32, 82);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(32, 112);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(53, 20);
            this.lblHeure.TabIndex = 2;
            this.lblHeure.Text = "Heure";
            // 
            // lblNbParticipant
            // 
            this.lblNbParticipant.AutoSize = true;
            this.lblNbParticipant.Location = new System.Drawing.Point(32, 149);
            this.lblNbParticipant.Name = "lblNbParticipant";
            this.lblNbParticipant.Size = new System.Drawing.Size(92, 20);
            this.lblNbParticipant.TabIndex = 3;
            this.lblNbParticipant.Text = "Participants";
            // 
            // btnQuitterMatch
            // 
            this.btnQuitterMatch.Location = new System.Drawing.Point(34, 205);
            this.btnQuitterMatch.Name = "btnQuitterMatch";
            this.btnQuitterMatch.Size = new System.Drawing.Size(136, 42);
            this.btnQuitterMatch.TabIndex = 0;
            this.btnQuitterMatch.Text = "&Rejoindre";
            this.btnQuitterMatch.UseVisualStyleBackColor = true;
            this.btnQuitterMatch.Click += new System.EventHandler(this.btnQuitterMatch_Click);
            // 
            // lblAdresseBDD
            // 
            this.lblAdresseBDD.AutoSize = true;
            this.lblAdresseBDD.Location = new System.Drawing.Point(178, 49);
            this.lblAdresseBDD.Name = "lblAdresseBDD";
            this.lblAdresseBDD.Size = new System.Drawing.Size(229, 20);
            this.lblAdresseBDD.TabIndex = 5;
            this.lblAdresseBDD.Text = "Rue de la Heg 1 1227 Carouge";
            // 
            // lblDateBDD
            // 
            this.lblDateBDD.AutoSize = true;
            this.lblDateBDD.Location = new System.Drawing.Point(178, 82);
            this.lblDateBDD.Name = "lblDateBDD";
            this.lblDateBDD.Size = new System.Drawing.Size(89, 20);
            this.lblDateBDD.TabIndex = 6;
            this.lblDateBDD.Text = "06.12.2019";
            // 
            // lblHeureBDD
            // 
            this.lblHeureBDD.AutoSize = true;
            this.lblHeureBDD.Location = new System.Drawing.Point(178, 112);
            this.lblHeureBDD.Name = "lblHeureBDD";
            this.lblHeureBDD.Size = new System.Drawing.Size(71, 20);
            this.lblHeureBDD.TabIndex = 7;
            this.lblHeureBDD.Text = "10:30:00";
            // 
            // lblNbParticipantBDD
            // 
            this.lblNbParticipantBDD.AutoSize = true;
            this.lblNbParticipantBDD.Location = new System.Drawing.Point(178, 149);
            this.lblNbParticipantBDD.Name = "lblNbParticipantBDD";
            this.lblNbParticipantBDD.Size = new System.Drawing.Size(40, 20);
            this.lblNbParticipantBDD.TabIndex = 8;
            this.lblNbParticipantBDD.Text = "5/10";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(183, 205);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(88, 42);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // frmMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 334);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMatch";
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
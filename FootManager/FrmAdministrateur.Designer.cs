namespace FootManager
{
    partial class FrmAdministrateur
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpMatches = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpHeure = new System.Windows.Forms.DateTimePicker();
            this.lblHeure = new System.Windows.Forms.Label();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.tpMembres = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tpCotisations = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.lblSaison = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cIdentifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tcAdmin.SuspendLayout();
            this.tpMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpMembres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tpCotisations.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpMatches);
            this.tcAdmin.Controls.Add(this.tpMembres);
            this.tcAdmin.Controls.Add(this.tpCotisations);
            this.tcAdmin.Location = new System.Drawing.Point(2, 1);
            this.tcAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(654, 260);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpMatches
            // 
            this.tpMatches.BackColor = System.Drawing.Color.White;
            this.tpMatches.Controls.Add(this.dataGridView1);
            this.tpMatches.Controls.Add(this.groupBox1);
            this.tpMatches.Location = new System.Drawing.Point(4, 22);
            this.tpMatches.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpMatches.Name = "tpMatches";
            this.tpMatches.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpMatches.Size = new System.Drawing.Size(646, 234);
            this.tpMatches.TabIndex = 0;
            this.tpMatches.Text = "Matches";
            this.tpMatches.Click += new System.EventHandler(this.tpMatches_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAdresse,
            this.cDate,
            this.Column1,
            this.cBtn});
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(644, 172);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpHeure);
            this.groupBox1.Controls.Add(this.lblHeure);
            this.groupBox1.Controls.Add(this.tbAdresse);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblAdresse);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(646, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un match";
            // 
            // dtpHeure
            // 
            this.dtpHeure.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHeure.Location = new System.Drawing.Point(431, 29);
            this.dtpHeure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHeure.Name = "dtpHeure";
            this.dtpHeure.Size = new System.Drawing.Size(101, 20);
            this.dtpHeure.TabIndex = 8;
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(428, 14);
            this.lblHeure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(36, 13);
            this.lblHeure.TabIndex = 7;
            this.lblHeure.Text = "Heure";
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(5, 29);
            this.tbAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(270, 20);
            this.tbAdresse.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(296, 29);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(116, 20);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(293, 14);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(2, 14);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 1;
            this.lblAdresse.Text = "Adresse";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(573, 18);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(71, 32);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpMembres
            // 
            this.tpMembres.Controls.Add(this.dataGridView2);
            this.tpMembres.Location = new System.Drawing.Point(4, 22);
            this.tpMembres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpMembres.Name = "tpMembres";
            this.tpMembres.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpMembres.Size = new System.Drawing.Size(646, 234);
            this.tpMembres.TabIndex = 1;
            this.tpMembres.Text = "Membres";
            this.tpMembres.UseVisualStyleBackColor = true;
            this.tpMembres.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdentifiant,
            this.cEmail,
            this.Column2,
            this.Column3});
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(646, 237);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tpCotisations
            // 
            this.tpCotisations.Controls.Add(this.groupBox3);
            this.tpCotisations.Controls.Add(this.groupBox2);
            this.tpCotisations.Location = new System.Drawing.Point(4, 22);
            this.tpCotisations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpCotisations.Name = "tpCotisations";
            this.tpCotisations.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpCotisations.Size = new System.Drawing.Size(646, 234);
            this.tpCotisations.TabIndex = 2;
            this.tpCotisations.Text = "Cotisations";
            this.tpCotisations.UseVisualStyleBackColor = true;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(269, 270);
            this.btnDeconnexion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(97, 20);
            this.btnDeconnexion.TabIndex = 1;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            // 
            // lblSaison
            // 
            this.lblSaison.AutoSize = true;
            this.lblSaison.Location = new System.Drawing.Point(6, 16);
            this.lblSaison.Name = "lblSaison";
            this.lblSaison.Size = new System.Drawing.Size(39, 13);
            this.lblSaison.TabIndex = 0;
            this.lblSaison.Text = "Saison";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(6, 43);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(185, 13);
            this.lblMontant.TabIndex = 1;
            this.lblMontant.Text = "Montant de la cotisation par personne";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dernier délai pour payer la cotisation";
            // 
            // cIdentifiant
            // 
            this.cIdentifiant.Frozen = true;
            this.cIdentifiant.HeaderText = "Identifiant";
            this.cIdentifiant.MinimumWidth = 8;
            this.cIdentifiant.Name = "cIdentifiant";
            this.cIdentifiant.ReadOnly = true;
            this.cIdentifiant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cIdentifiant.Width = 140;
            // 
            // cEmail
            // 
            this.cEmail.Frozen = true;
            this.cEmail.HeaderText = "Email";
            this.cEmail.MinimumWidth = 8;
            this.cEmail.Name = "cEmail";
            this.cEmail.ReadOnly = true;
            this.cEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cEmail.Width = 150;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Paiement de la cotisation";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Rappel de paiement cotisation";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 150;
            // 
            // cAdresse
            // 
            this.cAdresse.Frozen = true;
            this.cAdresse.HeaderText = "Adresse";
            this.cAdresse.MinimumWidth = 8;
            this.cAdresse.Name = "cAdresse";
            this.cAdresse.ReadOnly = true;
            this.cAdresse.Width = 240;
            // 
            // cDate
            // 
            this.cDate.Frozen = true;
            this.cDate.HeaderText = "Date";
            this.cDate.MinimumWidth = 8;
            this.cDate.Name = "cDate";
            this.cDate.ReadOnly = true;
            this.cDate.Width = 130;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Heure";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // cBtn
            // 
            this.cBtn.Frozen = true;
            this.cBtn.HeaderText = "Supprimer";
            this.cBtn.MinimumWidth = 8;
            this.cBtn.Name = "cBtn";
            this.cBtn.ReadOnly = true;
            this.cBtn.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coordonnées bancaires - IBAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coordonnées bancaires - Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Coordonnées bancaires - Nom";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSaison);
            this.groupBox2.Controls.Add(this.lblMontant);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(236, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // FrmAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 292);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.tcAdmin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAdministrateur";
            this.Text = "FootManager - Administrateur";
            this.tcAdmin.ResumeLayout(false);
            this.tpMatches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpMembres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tpCotisations.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpMatches;
        private System.Windows.Forms.TabPage tpMembres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.DateTimePicker dtpHeure;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tpCotisations;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn cBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdentifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblSaison;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
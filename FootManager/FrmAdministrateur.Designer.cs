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
            this.cIdentifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tpCotisations = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.cAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tcAdmin.SuspendLayout();
            this.tpMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpMembres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tpCotisations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.tpMatches.Text = "matches";
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
            this.groupBox1.Text = "ajouter un match";
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
            this.lblHeure.Size = new System.Drawing.Size(34, 13);
            this.lblHeure.TabIndex = 7;
            this.lblHeure.Text = "heure";
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
            this.lblDate.Size = new System.Drawing.Size(28, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "date";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(2, 14);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(44, 13);
            this.lblAdresse.TabIndex = 1;
            this.lblAdresse.Text = "adresse";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(573, 18);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(71, 32);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "ajouter";
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
            this.tpMembres.Size = new System.Drawing.Size(543, 234);
            this.tpMembres.TabIndex = 1;
            this.tpMembres.Text = "membres";
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
            this.dataGridView2.Size = new System.Drawing.Size(545, 237);
            this.dataGridView2.TabIndex = 0;
            // 
            // cIdentifiant
            // 
            this.cIdentifiant.HeaderText = "identifiant";
            this.cIdentifiant.MinimumWidth = 8;
            this.cIdentifiant.Name = "cIdentifiant";
            this.cIdentifiant.Width = 150;
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "email";
            this.cEmail.MinimumWidth = 8;
            this.cEmail.Name = "cEmail";
            this.cEmail.Width = 170;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "paiement de la cotisation";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "rappel de paiement cotisation";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 230;
            // 
            // tpCotisations
            // 
            this.tpCotisations.Controls.Add(this.dataGridView3);
            this.tpCotisations.Location = new System.Drawing.Point(4, 22);
            this.tpCotisations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpCotisations.Name = "tpCotisations";
            this.tpCotisations.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpCotisations.Size = new System.Drawing.Size(543, 234);
            this.tpCotisations.TabIndex = 2;
            this.tpCotisations.Text = "cotisations";
            this.tpCotisations.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView3.Location = new System.Drawing.Point(4, 2);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(537, 189);
            this.dataGridView3.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "saison";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "montant";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "date d\'échéance";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(269, 270);
            this.btnDeconnexion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(97, 20);
            this.btnDeconnexion.TabIndex = 1;
            this.btnDeconnexion.Text = "déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            // 
            // cAdresse
            // 
            this.cAdresse.Frozen = true;
            this.cAdresse.HeaderText = "adresse";
            this.cAdresse.MinimumWidth = 8;
            this.cAdresse.Name = "cAdresse";
            this.cAdresse.ReadOnly = true;
            this.cAdresse.Width = 240;
            // 
            // cDate
            // 
            this.cDate.Frozen = true;
            this.cDate.HeaderText = "date";
            this.cDate.MinimumWidth = 8;
            this.cDate.Name = "cDate";
            this.cDate.ReadOnly = true;
            this.cDate.Width = 130;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "heure";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdentifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn cBtn;
    }
}
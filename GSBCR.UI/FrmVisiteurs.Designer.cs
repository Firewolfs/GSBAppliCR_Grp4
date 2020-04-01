namespace GSBCR.UI
{
    partial class FrmVisiteurs
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
            this.pnl_Separateur = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.dgv_Visiteurs = new System.Windows.Forms.DataGridView();
            this.txtc_Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtc_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtc_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtc_DateAffectation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtc_NbRapports = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Entete = new System.Windows.Forms.Panel();
            this.pnl_Donnees = new System.Windows.Forms.Panel();
            this.btn_Details = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Visiteurs)).BeginInit();
            this.pnl_Entete.SuspendLayout();
            this.pnl_Donnees.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Separateur
            // 
            this.pnl_Separateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Separateur.Location = new System.Drawing.Point(52, 45);
            this.pnl_Separateur.Name = "pnl_Separateur";
            this.pnl_Separateur.Size = new System.Drawing.Size(780, 2);
            this.pnl_Separateur.TabIndex = 28;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.CausesValidation = false;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(388, 22);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(109, 20);
            this.lblTitre.TabIndex = 27;
            this.lblTitre.Text = "Les visiteurs";
            // 
            // dgv_Visiteurs
            // 
            this.dgv_Visiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Visiteurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtc_Matricule,
            this.txtc_Nom,
            this.txtc_Prenom,
            this.txtc_DateAffectation,
            this.txtc_NbRapports});
            this.dgv_Visiteurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Visiteurs.Location = new System.Drawing.Point(0, 0);
            this.dgv_Visiteurs.Name = "dgv_Visiteurs";
            this.dgv_Visiteurs.Size = new System.Drawing.Size(884, 350);
            this.dgv_Visiteurs.TabIndex = 29;
            // 
            // txtc_Matricule
            // 
            this.txtc_Matricule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.txtc_Matricule.HeaderText = "Matricule";
            this.txtc_Matricule.Name = "txtc_Matricule";
            this.txtc_Matricule.ReadOnly = true;
            this.txtc_Matricule.Width = 75;
            // 
            // txtc_Nom
            // 
            this.txtc_Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtc_Nom.HeaderText = "Nom";
            this.txtc_Nom.Name = "txtc_Nom";
            this.txtc_Nom.ReadOnly = true;
            // 
            // txtc_Prenom
            // 
            this.txtc_Prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtc_Prenom.HeaderText = "Prénom";
            this.txtc_Prenom.Name = "txtc_Prenom";
            this.txtc_Prenom.ReadOnly = true;
            // 
            // txtc_DateAffectation
            // 
            this.txtc_DateAffectation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.txtc_DateAffectation.HeaderText = "Date d\'affectation";
            this.txtc_DateAffectation.Name = "txtc_DateAffectation";
            this.txtc_DateAffectation.ReadOnly = true;
            this.txtc_DateAffectation.Width = 130;
            // 
            // txtc_NbRapports
            // 
            this.txtc_NbRapports.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.txtc_NbRapports.HeaderText = "Rapports consultés";
            this.txtc_NbRapports.Name = "txtc_NbRapports";
            this.txtc_NbRapports.ReadOnly = true;
            this.txtc_NbRapports.Width = 130;
            // 
            // pnl_Entete
            // 
            this.pnl_Entete.Controls.Add(this.btn_Details);
            this.pnl_Entete.Controls.Add(this.lblTitre);
            this.pnl_Entete.Controls.Add(this.pnl_Separateur);
            this.pnl_Entete.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Entete.Location = new System.Drawing.Point(0, 0);
            this.pnl_Entete.Name = "pnl_Entete";
            this.pnl_Entete.Size = new System.Drawing.Size(884, 100);
            this.pnl_Entete.TabIndex = 30;
            // 
            // pnl_Donnees
            // 
            this.pnl_Donnees.Controls.Add(this.dgv_Visiteurs);
            this.pnl_Donnees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Donnees.Location = new System.Drawing.Point(0, 100);
            this.pnl_Donnees.Name = "pnl_Donnees";
            this.pnl_Donnees.Size = new System.Drawing.Size(884, 350);
            this.pnl_Donnees.TabIndex = 31;
            // 
            // btn_Details
            // 
            this.btn_Details.Location = new System.Drawing.Point(797, 71);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(75, 23);
            this.btn_Details.TabIndex = 29;
            this.btn_Details.Text = "Détails";
            this.btn_Details.UseVisualStyleBackColor = true;
            // 
            // FrmVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.pnl_Donnees);
            this.Controls.Add(this.pnl_Entete);
            this.Name = "FrmVisiteurs";
            this.Text = "FrmVisiteurs";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Visiteurs)).EndInit();
            this.pnl_Entete.ResumeLayout(false);
            this.pnl_Entete.PerformLayout();
            this.pnl_Donnees.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Separateur;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dgv_Visiteurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtc_Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtc_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtc_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtc_DateAffectation;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtc_NbRapports;
        private System.Windows.Forms.Panel pnl_Entete;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.Panel pnl_Donnees;
    }
}
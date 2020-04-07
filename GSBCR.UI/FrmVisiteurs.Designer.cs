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
            this.components = new System.ComponentModel.Container();
            this.pnl_Separateur = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.dgv_Visiteurs = new System.Windows.Forms.DataGridView();
            this.txtc_Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtc_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtc_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISADRESSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISCPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISVILLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lABCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vismdpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesRapportsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leSecteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesAffectationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsVisiteursRegion = new System.Windows.Forms.BindingSource(this.components);
            this.pnl_Entete = new System.Windows.Forms.Panel();
            this.btn_Details = new System.Windows.Forms.Button();
            this.pnl_Donnees = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Visiteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteursRegion)).BeginInit();
            this.pnl_Entete.SuspendLayout();
            this.pnl_Donnees.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Separateur
            // 
            this.pnl_Separateur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Separateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Separateur.Location = new System.Drawing.Point(52, 45);
            this.pnl_Separateur.Name = "pnl_Separateur";
            this.pnl_Separateur.Size = new System.Drawing.Size(780, 2);
            this.pnl_Separateur.TabIndex = 28;
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgv_Visiteurs.AllowUserToAddRows = false;
            this.dgv_Visiteurs.AllowUserToDeleteRows = false;
            this.dgv_Visiteurs.AutoGenerateColumns = false;
            this.dgv_Visiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Visiteurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtc_Matricule,
            this.txtc_Nom,
            this.txtc_Prenom,
            this.vISADRESSEDataGridViewTextBoxColumn,
            this.vISCPDataGridViewTextBoxColumn,
            this.vISVILLEDataGridViewTextBoxColumn,
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn,
            this.sECCODEDataGridViewTextBoxColumn,
            this.lABCODEDataGridViewTextBoxColumn,
            this.vismdpDataGridViewTextBoxColumn,
            this.lesRapportsDataGridViewTextBoxColumn,
            this.leSecteurDataGridViewTextBoxColumn,
            this.lesAffectationsDataGridViewTextBoxColumn});
            this.dgv_Visiteurs.DataSource = this.bsVisiteursRegion;
            this.dgv_Visiteurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Visiteurs.Location = new System.Drawing.Point(0, 0);
            this.dgv_Visiteurs.MultiSelect = false;
            this.dgv_Visiteurs.Name = "dgv_Visiteurs";
            this.dgv_Visiteurs.ReadOnly = true;
            this.dgv_Visiteurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Visiteurs.Size = new System.Drawing.Size(884, 350);
            this.dgv_Visiteurs.TabIndex = 29;
            this.dgv_Visiteurs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Visiteurs_CellDoubleClick);
            // 
            // txtc_Matricule
            // 
            this.txtc_Matricule.DataPropertyName = "VIS_MATRICULE";
            this.txtc_Matricule.HeaderText = "Matricule";
            this.txtc_Matricule.Name = "txtc_Matricule";
            this.txtc_Matricule.ReadOnly = true;
            // 
            // txtc_Nom
            // 
            this.txtc_Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtc_Nom.DataPropertyName = "VIS_NOM";
            this.txtc_Nom.HeaderText = "Nom";
            this.txtc_Nom.Name = "txtc_Nom";
            this.txtc_Nom.ReadOnly = true;
            // 
            // txtc_Prenom
            // 
            this.txtc_Prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtc_Prenom.DataPropertyName = "Vis_PRENOM";
            this.txtc_Prenom.HeaderText = "Prénom";
            this.txtc_Prenom.Name = "txtc_Prenom";
            this.txtc_Prenom.ReadOnly = true;
            // 
            // vISADRESSEDataGridViewTextBoxColumn
            // 
            this.vISADRESSEDataGridViewTextBoxColumn.DataPropertyName = "VIS_ADRESSE";
            this.vISADRESSEDataGridViewTextBoxColumn.HeaderText = "VIS_ADRESSE";
            this.vISADRESSEDataGridViewTextBoxColumn.Name = "vISADRESSEDataGridViewTextBoxColumn";
            this.vISADRESSEDataGridViewTextBoxColumn.ReadOnly = true;
            this.vISADRESSEDataGridViewTextBoxColumn.Visible = false;
            // 
            // vISCPDataGridViewTextBoxColumn
            // 
            this.vISCPDataGridViewTextBoxColumn.DataPropertyName = "VIS_CP";
            this.vISCPDataGridViewTextBoxColumn.HeaderText = "VIS_CP";
            this.vISCPDataGridViewTextBoxColumn.Name = "vISCPDataGridViewTextBoxColumn";
            this.vISCPDataGridViewTextBoxColumn.ReadOnly = true;
            this.vISCPDataGridViewTextBoxColumn.Visible = false;
            // 
            // vISVILLEDataGridViewTextBoxColumn
            // 
            this.vISVILLEDataGridViewTextBoxColumn.DataPropertyName = "VIS_VILLE";
            this.vISVILLEDataGridViewTextBoxColumn.HeaderText = "VIS_VILLE";
            this.vISVILLEDataGridViewTextBoxColumn.Name = "vISVILLEDataGridViewTextBoxColumn";
            this.vISVILLEDataGridViewTextBoxColumn.ReadOnly = true;
            this.vISVILLEDataGridViewTextBoxColumn.Visible = false;
            // 
            // vISDATEEMBAUCHEDataGridViewTextBoxColumn
            // 
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn.DataPropertyName = "VIS_DATEEMBAUCHE";
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn.HeaderText = "VIS_DATEEMBAUCHE";
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn.Name = "vISDATEEMBAUCHEDataGridViewTextBoxColumn";
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn.ReadOnly = true;
            this.vISDATEEMBAUCHEDataGridViewTextBoxColumn.Visible = false;
            // 
            // sECCODEDataGridViewTextBoxColumn
            // 
            this.sECCODEDataGridViewTextBoxColumn.DataPropertyName = "SEC_CODE";
            this.sECCODEDataGridViewTextBoxColumn.HeaderText = "SEC_CODE";
            this.sECCODEDataGridViewTextBoxColumn.Name = "sECCODEDataGridViewTextBoxColumn";
            this.sECCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sECCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // lABCODEDataGridViewTextBoxColumn
            // 
            this.lABCODEDataGridViewTextBoxColumn.DataPropertyName = "LAB_CODE";
            this.lABCODEDataGridViewTextBoxColumn.HeaderText = "LAB_CODE";
            this.lABCODEDataGridViewTextBoxColumn.Name = "lABCODEDataGridViewTextBoxColumn";
            this.lABCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lABCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // vismdpDataGridViewTextBoxColumn
            // 
            this.vismdpDataGridViewTextBoxColumn.DataPropertyName = "vis_mdp";
            this.vismdpDataGridViewTextBoxColumn.HeaderText = "vis_mdp";
            this.vismdpDataGridViewTextBoxColumn.Name = "vismdpDataGridViewTextBoxColumn";
            this.vismdpDataGridViewTextBoxColumn.ReadOnly = true;
            this.vismdpDataGridViewTextBoxColumn.Visible = false;
            // 
            // lesRapportsDataGridViewTextBoxColumn
            // 
            this.lesRapportsDataGridViewTextBoxColumn.DataPropertyName = "LesRapports";
            this.lesRapportsDataGridViewTextBoxColumn.HeaderText = "LesRapports";
            this.lesRapportsDataGridViewTextBoxColumn.Name = "lesRapportsDataGridViewTextBoxColumn";
            this.lesRapportsDataGridViewTextBoxColumn.ReadOnly = true;
            this.lesRapportsDataGridViewTextBoxColumn.Visible = false;
            // 
            // leSecteurDataGridViewTextBoxColumn
            // 
            this.leSecteurDataGridViewTextBoxColumn.DataPropertyName = "LeSecteur";
            this.leSecteurDataGridViewTextBoxColumn.HeaderText = "LeSecteur";
            this.leSecteurDataGridViewTextBoxColumn.Name = "leSecteurDataGridViewTextBoxColumn";
            this.leSecteurDataGridViewTextBoxColumn.ReadOnly = true;
            this.leSecteurDataGridViewTextBoxColumn.Visible = false;
            // 
            // lesAffectationsDataGridViewTextBoxColumn
            // 
            this.lesAffectationsDataGridViewTextBoxColumn.DataPropertyName = "LesAffectations";
            this.lesAffectationsDataGridViewTextBoxColumn.HeaderText = "LesAffectations";
            this.lesAffectationsDataGridViewTextBoxColumn.Name = "lesAffectationsDataGridViewTextBoxColumn";
            this.lesAffectationsDataGridViewTextBoxColumn.ReadOnly = true;
            this.lesAffectationsDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsVisiteursRegion
            // 
            this.bsVisiteursRegion.DataSource = typeof(GSBCR.modele.VISITEUR);
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
            // btn_Details
            // 
            this.btn_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Details.Location = new System.Drawing.Point(797, 71);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(75, 23);
            this.btn_Details.TabIndex = 29;
            this.btn_Details.Text = "Détails";
            this.btn_Details.UseVisualStyleBackColor = true;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
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
            // FrmVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.pnl_Donnees);
            this.Controls.Add(this.pnl_Entete);
            this.Name = "FrmVisiteurs";
            this.Text = "FrmVisiteurs";
            this.Load += new System.EventHandler(this.FrmVisiteurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Visiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteursRegion)).EndInit();
            this.pnl_Entete.ResumeLayout(false);
            this.pnl_Entete.PerformLayout();
            this.pnl_Donnees.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Separateur;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dgv_Visiteurs;
        private System.Windows.Forms.Panel pnl_Entete;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.Panel pnl_Donnees;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtc_Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtc_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtc_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISADRESSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISCPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISVILLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISDATEEMBAUCHEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lABCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vismdpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesRapportsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leSecteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesAffectationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsVisiteursRegion;
    }
}
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
            this.pnl_Entete = new System.Windows.Forms.Panel();
            this.btn_Details = new System.Windows.Forms.Button();
            this.pnl_Donnees = new System.Windows.Forms.Panel();
            this.bsVisiteursRegion = new System.Windows.Forms.BindingSource(this.components);
            this.vISMATRICULEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visPRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vISNOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAROLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jJMMAADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Visiteurs)).BeginInit();
            this.pnl_Entete.SuspendLayout();
            this.pnl_Donnees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteursRegion)).BeginInit();
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
            this.vISMATRICULEDataGridViewTextBoxColumn,
            this.visPRENOMDataGridViewTextBoxColumn,
            this.vISNOMDataGridViewTextBoxColumn,
            this.tRAROLEDataGridViewTextBoxColumn,
            this.jJMMAADataGridViewTextBoxColumn,
            this.rEGCODEDataGridViewTextBoxColumn});
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
            // bsVisiteursRegion
            // 
            this.bsVisiteursRegion.DataSource = typeof(GSBCR.modele.VAFFECTATION);
            // 
            // vISMATRICULEDataGridViewTextBoxColumn
            // 
            this.vISMATRICULEDataGridViewTextBoxColumn.DataPropertyName = "VIS_MATRICULE";
            this.vISMATRICULEDataGridViewTextBoxColumn.HeaderText = "Matricule";
            this.vISMATRICULEDataGridViewTextBoxColumn.Name = "vISMATRICULEDataGridViewTextBoxColumn";
            this.vISMATRICULEDataGridViewTextBoxColumn.ReadOnly = true;
            this.vISMATRICULEDataGridViewTextBoxColumn.Width = 140;
            // 
            // visPRENOMDataGridViewTextBoxColumn
            // 
            this.visPRENOMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.visPRENOMDataGridViewTextBoxColumn.DataPropertyName = "Vis_PRENOM";
            this.visPRENOMDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.visPRENOMDataGridViewTextBoxColumn.Name = "visPRENOMDataGridViewTextBoxColumn";
            this.visPRENOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vISNOMDataGridViewTextBoxColumn
            // 
            this.vISNOMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vISNOMDataGridViewTextBoxColumn.DataPropertyName = "VIS_NOM";
            this.vISNOMDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.vISNOMDataGridViewTextBoxColumn.Name = "vISNOMDataGridViewTextBoxColumn";
            this.vISNOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tRAROLEDataGridViewTextBoxColumn
            // 
            this.tRAROLEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tRAROLEDataGridViewTextBoxColumn.DataPropertyName = "TRA_ROLE";
            this.tRAROLEDataGridViewTextBoxColumn.HeaderText = "Rôle";
            this.tRAROLEDataGridViewTextBoxColumn.Name = "tRAROLEDataGridViewTextBoxColumn";
            this.tRAROLEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jJMMAADataGridViewTextBoxColumn
            // 
            this.jJMMAADataGridViewTextBoxColumn.DataPropertyName = "JJMMAA";
            this.jJMMAADataGridViewTextBoxColumn.HeaderText = "JJMMAA";
            this.jJMMAADataGridViewTextBoxColumn.Name = "jJMMAADataGridViewTextBoxColumn";
            this.jJMMAADataGridViewTextBoxColumn.ReadOnly = true;
            this.jJMMAADataGridViewTextBoxColumn.Visible = false;
            // 
            // rEGCODEDataGridViewTextBoxColumn
            // 
            this.rEGCODEDataGridViewTextBoxColumn.DataPropertyName = "REG_CODE";
            this.rEGCODEDataGridViewTextBoxColumn.HeaderText = "REG_CODE";
            this.rEGCODEDataGridViewTextBoxColumn.Name = "rEGCODEDataGridViewTextBoxColumn";
            this.rEGCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEGCODEDataGridViewTextBoxColumn.Visible = false;
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
            this.pnl_Entete.ResumeLayout(false);
            this.pnl_Entete.PerformLayout();
            this.pnl_Donnees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteursRegion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Separateur;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dgv_Visiteurs;
        private System.Windows.Forms.Panel pnl_Entete;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.Panel pnl_Donnees;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISMATRICULEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visPRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vISNOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAROLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jJMMAADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsVisiteursRegion;
    }
}
namespace GSBCR.UI
{
    partial class FrmRapports
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.dgvRapportEnCours = new System.Windows.Forms.DataGridView();
            this.rAPMATRICULEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPPRANUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPDATVISITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPETATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPCONFIANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPBILANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMOTIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPNOMREMPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPPNOMREMPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMED1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMED2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leMedicament1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leMedicament2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leMotifVisiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lePraticienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRapports = new System.Windows.Forms.BindingSource(this.components);
            this.bsRapportsMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.bsRapportsPraticien = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapportEnCours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapportsMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapportsPraticien)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnQuitter);
            this.splitContainer1.Panel1.Controls.Add(this.btnNouveau);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvRapportEnCours);
            this.splitContainer1.Size = new System.Drawing.Size(853, 411);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vos rapports en cours";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(706, 62);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(605, 62);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(75, 23);
            this.btnNouveau.TabIndex = 0;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // dgvRapportEnCours
            // 
            this.dgvRapportEnCours.AllowUserToAddRows = false;
            this.dgvRapportEnCours.AllowUserToDeleteRows = false;
            this.dgvRapportEnCours.AutoGenerateColumns = false;
            this.dgvRapportEnCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapportEnCours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rAPMATRICULEDataGridViewTextBoxColumn,
            this.rAPNUMDataGridViewTextBoxColumn,
            this.rAPPRANUMDataGridViewTextBoxColumn,
            this.rAPDATEDataGridViewTextBoxColumn,
            this.rAPDATVISITDataGridViewTextBoxColumn,
            this.rAPETATDataGridViewTextBoxColumn,
            this.rAPCONFIANCEDataGridViewTextBoxColumn,
            this.rAPBILANDataGridViewTextBoxColumn,
            this.rAPMOTIFDataGridViewTextBoxColumn,
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn,
            this.rAPNOMREMPLDataGridViewTextBoxColumn,
            this.rAPPNOMREMPLDataGridViewTextBoxColumn,
            this.rAPMED1DataGridViewTextBoxColumn,
            this.rAPMED2DataGridViewTextBoxColumn,
            this.leMedicament1DataGridViewTextBoxColumn,
            this.leMedicament2DataGridViewTextBoxColumn,
            this.leMotifVisiteDataGridViewTextBoxColumn,
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn,
            this.lePraticienDataGridViewTextBoxColumn,
            this.leVisiteurDataGridViewTextBoxColumn});
            this.dgvRapportEnCours.DataSource = this.bsRapports;
            this.dgvRapportEnCours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRapportEnCours.Location = new System.Drawing.Point(0, 0);
            this.dgvRapportEnCours.Name = "dgvRapportEnCours";
            this.dgvRapportEnCours.RowHeadersWidth = 62;
            this.dgvRapportEnCours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRapportEnCours.Size = new System.Drawing.Size(853, 310);
            this.dgvRapportEnCours.TabIndex = 0;
            this.dgvRapportEnCours.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRapportEnCours_CellDoubleClick);
            // 
            // rAPMATRICULEDataGridViewTextBoxColumn
            // 
            this.rAPMATRICULEDataGridViewTextBoxColumn.DataPropertyName = "RAP_MATRICULE";
            this.rAPMATRICULEDataGridViewTextBoxColumn.HeaderText = "RAP_MATRICULE";
            this.rAPMATRICULEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPMATRICULEDataGridViewTextBoxColumn.Name = "rAPMATRICULEDataGridViewTextBoxColumn";
            this.rAPMATRICULEDataGridViewTextBoxColumn.Visible = false;
            this.rAPMATRICULEDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPNUMDataGridViewTextBoxColumn
            // 
            this.rAPNUMDataGridViewTextBoxColumn.DataPropertyName = "RAP_NUM";
            this.rAPNUMDataGridViewTextBoxColumn.HeaderText = "Numéro rapport";
            this.rAPNUMDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPNUMDataGridViewTextBoxColumn.Name = "rAPNUMDataGridViewTextBoxColumn";
            this.rAPNUMDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPPRANUMDataGridViewTextBoxColumn
            // 
            this.rAPPRANUMDataGridViewTextBoxColumn.DataPropertyName = "RAP_PRANUM";
            this.rAPPRANUMDataGridViewTextBoxColumn.HeaderText = "Numéro praticien";
            this.rAPPRANUMDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPPRANUMDataGridViewTextBoxColumn.Name = "rAPPRANUMDataGridViewTextBoxColumn";
            this.rAPPRANUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPPRANUMDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPDATEDataGridViewTextBoxColumn
            // 
            this.rAPDATEDataGridViewTextBoxColumn.DataPropertyName = "RAP_DATE";
            this.rAPDATEDataGridViewTextBoxColumn.HeaderText = "Date rapport";
            this.rAPDATEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPDATEDataGridViewTextBoxColumn.Name = "rAPDATEDataGridViewTextBoxColumn";
            this.rAPDATEDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPDATVISITDataGridViewTextBoxColumn
            // 
            this.rAPDATVISITDataGridViewTextBoxColumn.DataPropertyName = "RAP_DATVISIT";
            this.rAPDATVISITDataGridViewTextBoxColumn.HeaderText = "Date visite";
            this.rAPDATVISITDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPDATVISITDataGridViewTextBoxColumn.Name = "rAPDATVISITDataGridViewTextBoxColumn";
            this.rAPDATVISITDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPETATDataGridViewTextBoxColumn
            // 
            this.rAPETATDataGridViewTextBoxColumn.DataPropertyName = "RAP_ETAT";
            this.rAPETATDataGridViewTextBoxColumn.HeaderText = "RAP_ETAT";
            this.rAPETATDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPETATDataGridViewTextBoxColumn.Name = "rAPETATDataGridViewTextBoxColumn";
            this.rAPETATDataGridViewTextBoxColumn.Visible = false;
            this.rAPETATDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPCONFIANCEDataGridViewTextBoxColumn
            // 
            this.rAPCONFIANCEDataGridViewTextBoxColumn.DataPropertyName = "RAP_CONFIANCE";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.HeaderText = "RAP_CONFIANCE";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPCONFIANCEDataGridViewTextBoxColumn.Name = "rAPCONFIANCEDataGridViewTextBoxColumn";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.Visible = false;
            this.rAPCONFIANCEDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPBILANDataGridViewTextBoxColumn
            // 
            this.rAPBILANDataGridViewTextBoxColumn.DataPropertyName = "RAP_BILAN";
            this.rAPBILANDataGridViewTextBoxColumn.HeaderText = "RAP_BILAN";
            this.rAPBILANDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPBILANDataGridViewTextBoxColumn.Name = "rAPBILANDataGridViewTextBoxColumn";
            this.rAPBILANDataGridViewTextBoxColumn.Visible = false;
            this.rAPBILANDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPMOTIFDataGridViewTextBoxColumn
            // 
            this.rAPMOTIFDataGridViewTextBoxColumn.DataPropertyName = "RAP_MOTIF";
            this.rAPMOTIFDataGridViewTextBoxColumn.HeaderText = "Motif rapport";
            this.rAPMOTIFDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPMOTIFDataGridViewTextBoxColumn.Name = "rAPMOTIFDataGridViewTextBoxColumn";
            this.rAPMOTIFDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPMOTIFAUTREDataGridViewTextBoxColumn
            // 
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.DataPropertyName = "RAP_MOTIFAUTRE";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.HeaderText = "Motif autre";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.Name = "rAPMOTIFAUTREDataGridViewTextBoxColumn";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPNOMREMPLDataGridViewTextBoxColumn
            // 
            this.rAPNOMREMPLDataGridViewTextBoxColumn.DataPropertyName = "RAP_NOMREMPL";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.HeaderText = "RAP_NOMREMPL";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPNOMREMPLDataGridViewTextBoxColumn.Name = "rAPNOMREMPLDataGridViewTextBoxColumn";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.Visible = false;
            this.rAPNOMREMPLDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPPNOMREMPLDataGridViewTextBoxColumn
            // 
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.DataPropertyName = "RAP_PNOMREMPL";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.HeaderText = "RAP_PNOMREMPL";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.Name = "rAPPNOMREMPLDataGridViewTextBoxColumn";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.Visible = false;
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPMED1DataGridViewTextBoxColumn
            // 
            this.rAPMED1DataGridViewTextBoxColumn.DataPropertyName = "RAP_MED1";
            this.rAPMED1DataGridViewTextBoxColumn.HeaderText = "Médicament 1";
            this.rAPMED1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPMED1DataGridViewTextBoxColumn.Name = "rAPMED1DataGridViewTextBoxColumn";
            this.rAPMED1DataGridViewTextBoxColumn.Width = 150;
            // 
            // rAPMED2DataGridViewTextBoxColumn
            // 
            this.rAPMED2DataGridViewTextBoxColumn.DataPropertyName = "RAP_MED2";
            this.rAPMED2DataGridViewTextBoxColumn.HeaderText = "Médicament 2";
            this.rAPMED2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rAPMED2DataGridViewTextBoxColumn.Name = "rAPMED2DataGridViewTextBoxColumn";
            this.rAPMED2DataGridViewTextBoxColumn.Width = 150;
            // 
            // leMedicament1DataGridViewTextBoxColumn
            // 
            this.leMedicament1DataGridViewTextBoxColumn.DataPropertyName = "leMedicament1";
            this.leMedicament1DataGridViewTextBoxColumn.HeaderText = "leMedicament1";
            this.leMedicament1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.leMedicament1DataGridViewTextBoxColumn.Name = "leMedicament1DataGridViewTextBoxColumn";
            this.leMedicament1DataGridViewTextBoxColumn.Visible = false;
            this.leMedicament1DataGridViewTextBoxColumn.Width = 150;
            // 
            // leMedicament2DataGridViewTextBoxColumn
            // 
            this.leMedicament2DataGridViewTextBoxColumn.DataPropertyName = "LeMedicament2";
            this.leMedicament2DataGridViewTextBoxColumn.HeaderText = "LeMedicament2";
            this.leMedicament2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.leMedicament2DataGridViewTextBoxColumn.Name = "leMedicament2DataGridViewTextBoxColumn";
            this.leMedicament2DataGridViewTextBoxColumn.Visible = false;
            this.leMedicament2DataGridViewTextBoxColumn.Width = 150;
            // 
            // leMotifVisiteDataGridViewTextBoxColumn
            // 
            this.leMotifVisiteDataGridViewTextBoxColumn.DataPropertyName = "LeMotifVisite";
            this.leMotifVisiteDataGridViewTextBoxColumn.HeaderText = "LeMotifVisite";
            this.leMotifVisiteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.leMotifVisiteDataGridViewTextBoxColumn.Name = "leMotifVisiteDataGridViewTextBoxColumn";
            this.leMotifVisiteDataGridViewTextBoxColumn.Visible = false;
            this.leMotifVisiteDataGridViewTextBoxColumn.Width = 150;
            // 
            // lesEchantillonsOffertsDataGridViewTextBoxColumn
            // 
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.DataPropertyName = "LesEchantillonsOfferts";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.HeaderText = "LesEchantillonsOfferts";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.Name = "lesEchantillonsOffertsDataGridViewTextBoxColumn";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.Visible = false;
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.Width = 150;
            // 
            // lePraticienDataGridViewTextBoxColumn
            // 
            this.lePraticienDataGridViewTextBoxColumn.DataPropertyName = "LePraticien";
            this.lePraticienDataGridViewTextBoxColumn.HeaderText = "LePraticien";
            this.lePraticienDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lePraticienDataGridViewTextBoxColumn.Name = "lePraticienDataGridViewTextBoxColumn";
            this.lePraticienDataGridViewTextBoxColumn.Visible = false;
            this.lePraticienDataGridViewTextBoxColumn.Width = 150;
            // 
            // leVisiteurDataGridViewTextBoxColumn
            // 
            this.leVisiteurDataGridViewTextBoxColumn.DataPropertyName = "LeVisiteur";
            this.leVisiteurDataGridViewTextBoxColumn.HeaderText = "LeVisiteur";
            this.leVisiteurDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.leVisiteurDataGridViewTextBoxColumn.Name = "leVisiteurDataGridViewTextBoxColumn";
            this.leVisiteurDataGridViewTextBoxColumn.Visible = false;
            this.leVisiteurDataGridViewTextBoxColumn.Width = 150;
            // 
            // bsRapports
            // 
            this.bsRapports.DataSource = typeof(GSBCR.modele.RAPPORT_VISITE);
            // 
            // FrmRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 411);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmRapports";
            this.Text = "FrmRapportEnCours";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapportEnCours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapportsMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapportsPraticien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.DataGridView dgvRapportEnCours;
        private System.Windows.Forms.BindingSource bsRapports;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMATRICULEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPPRANUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPDATVISITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPETATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPCONFIANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPBILANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMOTIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMOTIFAUTREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPNOMREMPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPPNOMREMPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMED1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMED2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leMedicament1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leMedicament2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leMotifVisiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesEchantillonsOffertsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lePraticienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsRapportsMedicament;
        private System.Windows.Forms.BindingSource bsRapportsPraticien;
    }
}
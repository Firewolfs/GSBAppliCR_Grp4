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
            this.cbx_Visiteur = new System.Windows.Forms.ComboBox();
            this.lbl_Visiteur = new System.Windows.Forms.Label();
            this.pnl_Separateur = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.ucVisiteur1 = new GSBCR.UC.UcVisiteur();
            this.SuspendLayout();
            // 
            // cbx_Visiteur
            // 
            this.cbx_Visiteur.FormattingEnabled = true;
            this.cbx_Visiteur.Location = new System.Drawing.Point(161, 76);
            this.cbx_Visiteur.Name = "cbx_Visiteur";
            this.cbx_Visiteur.Size = new System.Drawing.Size(230, 21);
            this.cbx_Visiteur.TabIndex = 36;
            // 
            // lbl_Visiteur
            // 
            this.lbl_Visiteur.AutoSize = true;
            this.lbl_Visiteur.Location = new System.Drawing.Point(42, 80);
            this.lbl_Visiteur.Name = "lbl_Visiteur";
            this.lbl_Visiteur.Size = new System.Drawing.Size(41, 13);
            this.lbl_Visiteur.TabIndex = 35;
            this.lbl_Visiteur.Text = "Visiteur";
            // 
            // pnl_Separateur
            // 
            this.pnl_Separateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Separateur.Location = new System.Drawing.Point(23, 45);
            this.pnl_Separateur.Name = "pnl_Separateur";
            this.pnl_Separateur.Size = new System.Drawing.Size(398, 2);
            this.pnl_Separateur.TabIndex = 34;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.CausesValidation = false;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(168, 22);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(109, 20);
            this.lblTitre.TabIndex = 33;
            this.lblTitre.Text = "Les visiteurs";
            // 
            // ucVisiteur1
            // 
            this.ucVisiteur1.Location = new System.Drawing.Point(12, 103);
            this.ucVisiteur1.Name = "ucVisiteur1";
            this.ucVisiteur1.Size = new System.Drawing.Size(420, 629);
            this.ucVisiteur1.TabIndex = 37;
            // 
            // FrmVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 712);
            this.Controls.Add(this.ucVisiteur1);
            this.Controls.Add(this.cbx_Visiteur);
            this.Controls.Add(this.lbl_Visiteur);
            this.Controls.Add(this.pnl_Separateur);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmVisiteurs";
            this.Text = "Visiteurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Visiteur;
        private System.Windows.Forms.Label lbl_Visiteur;
        private System.Windows.Forms.Panel pnl_Separateur;
        private System.Windows.Forms.Label lblTitre;
        private UC.UcVisiteur ucVisiteur1;
    }
}
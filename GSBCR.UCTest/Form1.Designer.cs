namespace GSBCR.UCTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMedi = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.bsMedoc = new System.Windows.Forms.BindingSource(this.components);
            this.ucMedicament1 = new GSBCR.UC.UcMedicament();
            this.btnPrati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir un Médicament";
            // 
            // cbxMedi
            // 
            this.cbxMedi.FormattingEnabled = true;
            this.cbxMedi.Location = new System.Drawing.Point(65, 48);
            this.cbxMedi.Name = "cbxMedi";
            this.cbxMedi.Size = new System.Drawing.Size(145, 21);
            this.cbxMedi.TabIndex = 1;
            this.cbxMedi.SelectedIndexChanged += new System.EventHandler(this.cbxMedi_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(650, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ucMedicament1
            // 
            this.ucMedicament1.Location = new System.Drawing.Point(232, 61);
            this.ucMedicament1.Medic = null;
            this.ucMedicament1.Name = "ucMedicament1";
            this.ucMedicament1.Size = new System.Drawing.Size(501, 683);
            this.ucMedicament1.TabIndex = 3;
            // 
            // btnPrati
            // 
            this.btnPrati.Location = new System.Drawing.Point(12, 156);
            this.btnPrati.Name = "btnPrati";
            this.btnPrati.Size = new System.Drawing.Size(145, 49);
            this.btnPrati.TabIndex = 5;
            this.btnPrati.Text = "Les Praticiens";
            this.btnPrati.UseVisualStyleBackColor = true;
            this.btnPrati.Click += new System.EventHandler(this.btnPrati_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 756);
            this.Controls.Add(this.btnPrati);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ucMedicament1);
            this.Controls.Add(this.cbxMedi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMedoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMedi;
        private UC.UcMedicament ucMedicament1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource bsMedoc;
        private System.Windows.Forms.Button btnPrati;
    }
}


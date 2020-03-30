namespace GSBCR.UI
{
    partial class FrmSaisirRapportRegion
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
            this.lblRapport = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVoirMed2 = new System.Windows.Forms.Button();
            this.btnVoirMed1 = new System.Windows.Forms.Button();
            this.txtMed2 = new System.Windows.Forms.TextBox();
            this.txtMed1 = new System.Windows.Forms.TextBox();
            this.cbxMed2 = new System.Windows.Forms.ComboBox();
            this.cbxMed1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVoirPatricien = new System.Windows.Forms.Button();
            this.txtMatricule = new System.Windows.Forms.TextBox();
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            this.bsMotif = new System.Windows.Forms.BindingSource(this.components);
            this.bsMed1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsMed2 = new System.Windows.Forms.BindingSource(this.components);
            this.cbxRapport = new System.Windows.Forms.ComboBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            this.txtCodeMotif = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtAutre = new System.Windows.Forms.TextBox();
            this.nupCoef = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBilan = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMotif = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNomPraticien = new System.Windows.Forms.ComboBox();
            this.txtNumPraticien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDateVisite = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCoef)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRapport
            // 
            this.lblRapport.AutoSize = true;
            this.lblRapport.Location = new System.Drawing.Point(327, 108);
            this.lblRapport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRapport.Name = "lblRapport";
            this.lblRapport.Size = new System.Drawing.Size(140, 20);
            this.lblRapport.TabIndex = 51;
            this.lblRapport.Text = "numéro de rapport";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVoirMed2);
            this.groupBox1.Controls.Add(this.btnVoirMed1);
            this.groupBox1.Controls.Add(this.txtMed2);
            this.groupBox1.Controls.Add(this.txtMed1);
            this.groupBox1.Controls.Add(this.cbxMed2);
            this.groupBox1.Controls.Add(this.cbxMed1);
            this.groupBox1.Location = new System.Drawing.Point(109, 577);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(591, 154);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Médicaments présentés";
            // 
            // btnVoirMed2
            // 
            this.btnVoirMed2.Location = new System.Drawing.Point(400, 75);
            this.btnVoirMed2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoirMed2.Name = "btnVoirMed2";
            this.btnVoirMed2.Size = new System.Drawing.Size(182, 35);
            this.btnVoirMed2.TabIndex = 5;
            this.btnVoirMed2.Text = "voir le médicament";
            this.btnVoirMed2.UseVisualStyleBackColor = true;
            // 
            // btnVoirMed1
            // 
            this.btnVoirMed1.Location = new System.Drawing.Point(400, 26);
            this.btnVoirMed1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoirMed1.Name = "btnVoirMed1";
            this.btnVoirMed1.Size = new System.Drawing.Size(182, 35);
            this.btnVoirMed1.TabIndex = 4;
            this.btnVoirMed1.Text = "voir le médicament";
            this.btnVoirMed1.UseVisualStyleBackColor = true;
            // 
            // txtMed2
            // 
            this.txtMed2.Location = new System.Drawing.Point(230, 80);
            this.txtMed2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMed2.Name = "txtMed2";
            this.txtMed2.Size = new System.Drawing.Size(148, 26);
            this.txtMed2.TabIndex = 3;
            this.txtMed2.TabStop = false;
            // 
            // txtMed1
            // 
            this.txtMed1.Location = new System.Drawing.Point(230, 31);
            this.txtMed1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMed1.Name = "txtMed1";
            this.txtMed1.Size = new System.Drawing.Size(148, 26);
            this.txtMed1.TabIndex = 2;
            this.txtMed1.TabStop = false;
            // 
            // cbxMed2
            // 
            this.cbxMed2.FormattingEnabled = true;
            this.cbxMed2.Location = new System.Drawing.Point(9, 80);
            this.cbxMed2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMed2.Name = "cbxMed2";
            this.cbxMed2.Size = new System.Drawing.Size(180, 28);
            this.cbxMed2.TabIndex = 1;
            // 
            // cbxMed1
            // 
            this.cbxMed1.FormattingEnabled = true;
            this.cbxMed1.Location = new System.Drawing.Point(9, 29);
            this.cbxMed1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMed1.Name = "cbxMed1";
            this.cbxMed1.Size = new System.Drawing.Size(180, 28);
            this.cbxMed1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(680, 307);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Autre Motif";
            // 
            // btnVoirPatricien
            // 
            this.btnVoirPatricien.Location = new System.Drawing.Point(685, 254);
            this.btnVoirPatricien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoirPatricien.Name = "btnVoirPatricien";
            this.btnVoirPatricien.Size = new System.Drawing.Size(148, 35);
            this.btnVoirPatricien.TabIndex = 49;
            this.btnVoirPatricien.Text = "voir le praticien";
            this.btnVoirPatricien.UseVisualStyleBackColor = true;
            // 
            // txtMatricule
            // 
            this.txtMatricule.Enabled = false;
            this.txtMatricule.Location = new System.Drawing.Point(287, 173);
            this.txtMatricule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatricule.Name = "txtMatricule";
            this.txtMatricule.Size = new System.Drawing.Size(148, 26);
            this.txtMatricule.TabIndex = 48;
            this.txtMatricule.TabStop = false;
            // 
            // cbxRapport
            // 
            this.cbxRapport.FormattingEnabled = true;
            this.cbxRapport.Location = new System.Drawing.Point(489, 105);
            this.cbxRapport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxRapport.Name = "cbxRapport";
            this.cbxRapport.Size = new System.Drawing.Size(180, 28);
            this.cbxRapport.TabIndex = 50;
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(791, 831);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(112, 35);
            this.btnQuitter.TabIndex = 45;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // txtCodeMotif
            // 
            this.txtCodeMotif.Location = new System.Drawing.Point(509, 299);
            this.txtCodeMotif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodeMotif.Name = "txtCodeMotif";
            this.txtCodeMotif.Size = new System.Drawing.Size(148, 26);
            this.txtCodeMotif.TabIndex = 44;
            this.txtCodeMotif.TabStop = false;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(637, 831);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(112, 35);
            this.btnValider.TabIndex = 43;
            this.btnValider.Text = "Enregistrer";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // txtAutre
            // 
            this.txtAutre.Location = new System.Drawing.Point(791, 302);
            this.txtAutre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutre.Name = "txtAutre";
            this.txtAutre.Size = new System.Drawing.Size(148, 26);
            this.txtAutre.TabIndex = 41;
            // 
            // nupCoef
            // 
            this.nupCoef.Location = new System.Drawing.Point(287, 336);
            this.nupCoef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nupCoef.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupCoef.Name = "nupCoef";
            this.nupCoef.Size = new System.Drawing.Size(114, 26);
            this.nupCoef.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 343);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "coef. confiance";
            // 
            // txtBilan
            // 
            this.txtBilan.Location = new System.Drawing.Point(287, 382);
            this.txtBilan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBilan.Name = "txtBilan";
            this.txtBilan.Size = new System.Drawing.Size(460, 153);
            this.txtBilan.TabIndex = 38;
            this.txtBilan.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 382);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Bilan";
            // 
            // cbxMotif
            // 
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new System.Drawing.Point(287, 294);
            this.cbxMotif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(180, 28);
            this.cbxMotif.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Motif";
            // 
            // cbxNomPraticien
            // 
            this.cbxNomPraticien.FormattingEnabled = true;
            this.cbxNomPraticien.Location = new System.Drawing.Point(287, 253);
            this.cbxNomPraticien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxNomPraticien.Name = "cbxNomPraticien";
            this.cbxNomPraticien.Size = new System.Drawing.Size(180, 28);
            this.cbxNomPraticien.TabIndex = 34;
            // 
            // txtNumPraticien
            // 
            this.txtNumPraticien.Location = new System.Drawing.Point(509, 254);
            this.txtNumPraticien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumPraticien.Name = "txtNumPraticien";
            this.txtNumPraticien.Size = new System.Drawing.Size(148, 26);
            this.txtNumPraticien.TabIndex = 33;
            this.txtNumPraticien.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Praticien visité";
            // 
            // dtDateVisite
            // 
            this.dtDateVisite.Location = new System.Drawing.Point(287, 218);
            this.dtDateVisite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtDateVisite.Name = "dtDateVisite";
            this.dtDateVisite.Size = new System.Drawing.Size(298, 26);
            this.dtDateVisite.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "date Visite";
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Location = new System.Drawing.Point(465, 173);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(148, 26);
            this.txtNum.TabIndex = 28;
            this.txtNum.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "numéro de rapport";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(133, 823);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(267, 24);
            this.checkBox1.TabIndex = 52;
            this.checkBox1.Text = "Mettre le rapport à l\'état consulté";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(666, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "_________________________________________________________________________";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.CausesValidation = false;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(398, 25);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(232, 29);
            this.lblTitre.TabIndex = 55;
            this.lblTitre.Text = "Saisie d\'un rapport";
            // 
            // FrmSaisirRapportRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 845);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblRapport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnVoirPatricien);
            this.Controls.Add(this.txtMatricule);
            this.Controls.Add(this.cbxRapport);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.txtCodeMotif);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtAutre);
            this.Controls.Add(this.nupCoef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBilan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxMotif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxNomPraticien);
            this.Controls.Add(this.txtNumPraticien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtDateVisite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Name = "FrmSaisirRapportRegion";
            this.Text = "FrmSaisirRapportRegion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCoef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRapport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVoirMed2;
        private System.Windows.Forms.Button btnVoirMed1;
        private System.Windows.Forms.TextBox txtMed2;
        private System.Windows.Forms.TextBox txtMed1;
        private System.Windows.Forms.ComboBox cbxMed2;
        private System.Windows.Forms.ComboBox cbxMed1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVoirPatricien;
        private System.Windows.Forms.TextBox txtMatricule;
        private System.Windows.Forms.BindingSource bsPraticien;
        private System.Windows.Forms.BindingSource bsMotif;
        private System.Windows.Forms.BindingSource bsMed1;
        private System.Windows.Forms.BindingSource bsMed2;
        private System.Windows.Forms.ComboBox cbxRapport;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.BindingSource bsRapport;
        private System.Windows.Forms.TextBox txtCodeMotif;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtAutre;
        private System.Windows.Forms.NumericUpDown nupCoef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtBilan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxNomPraticien;
        private System.Windows.Forms.TextBox txtNumPraticien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDateVisite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitre;
    }
}
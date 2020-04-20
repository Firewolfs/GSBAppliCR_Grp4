namespace GSBCR.UI
{
    partial class FrmMenuVisiteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuVisiteur));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mesRapportsEnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesRapportsValidésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesMedicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesPraticiensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesDonnéesPersonnellesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierConsulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerMonMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maRégionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportsNonConsultésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesVisiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauVisiteurDéléguéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion rapports de visite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(668, 540);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(282, 51);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesRapportsEnCoursToolStripMenuItem,
            this.consultationToolStripMenuItem,
            this.mesDonnéesPersonnellesToolStripMenuItem,
            this.maRégionToolStripMenuItem,
            this.monSecteurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(982, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mesRapportsEnCoursToolStripMenuItem
            // 
            this.mesRapportsEnCoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.mesRapportsEnCoursToolStripMenuItem.Name = "mesRapportsEnCoursToolStripMenuItem";
            this.mesRapportsEnCoursToolStripMenuItem.Size = new System.Drawing.Size(206, 29);
            this.mesRapportsEnCoursToolStripMenuItem.Text = "Mes rapports en cours";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.modifierToolStripMenuItem.Text = "Modifier / Consulter";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesRapportsValidésToolStripMenuItem,
            this.lesMedicamentsToolStripMenuItem,
            this.lesPraticiensToolStripMenuItem});
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.consultationToolStripMenuItem.Text = "Consultation";
            // 
            // mesRapportsValidésToolStripMenuItem
            // 
            this.mesRapportsValidésToolStripMenuItem.Name = "mesRapportsValidésToolStripMenuItem";
            this.mesRapportsValidésToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.mesRapportsValidésToolStripMenuItem.Text = "Mes rapports validés";
            this.mesRapportsValidésToolStripMenuItem.Click += new System.EventHandler(this.mesRapportsValidésToolStripMenuItem_Click);
            // 
            // lesMedicamentsToolStripMenuItem
            // 
            this.lesMedicamentsToolStripMenuItem.Name = "lesMedicamentsToolStripMenuItem";
            this.lesMedicamentsToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.lesMedicamentsToolStripMenuItem.Text = "Les medicaments";
            this.lesMedicamentsToolStripMenuItem.Click += new System.EventHandler(this.lesMedicamentsToolStripMenuItem_Click);
            // 
            // lesPraticiensToolStripMenuItem
            // 
            this.lesPraticiensToolStripMenuItem.Name = "lesPraticiensToolStripMenuItem";
            this.lesPraticiensToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.lesPraticiensToolStripMenuItem.Text = "Les praticiens";
            this.lesPraticiensToolStripMenuItem.Click += new System.EventHandler(this.lesPraticiensToolStripMenuItem_Click);
            // 
            // mesDonnéesPersonnellesToolStripMenuItem
            // 
            this.mesDonnéesPersonnellesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierConsulterToolStripMenuItem,
            this.changerMonMotDePasseToolStripMenuItem});
            this.mesDonnéesPersonnellesToolStripMenuItem.Name = "mesDonnéesPersonnellesToolStripMenuItem";
            this.mesDonnéesPersonnellesToolStripMenuItem.Size = new System.Drawing.Size(238, 29);
            this.mesDonnéesPersonnellesToolStripMenuItem.Text = "Mes données personnelles";
            // 
            // modifierConsulterToolStripMenuItem
            // 
            this.modifierConsulterToolStripMenuItem.Name = "modifierConsulterToolStripMenuItem";
            this.modifierConsulterToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.modifierConsulterToolStripMenuItem.Text = "Modifier / Consulter";
            this.modifierConsulterToolStripMenuItem.Click += new System.EventHandler(this.modifierConsulterToolStripMenuItem_Click);
            // 
            // changerMonMotDePasseToolStripMenuItem
            // 
            this.changerMonMotDePasseToolStripMenuItem.Name = "changerMonMotDePasseToolStripMenuItem";
            this.changerMonMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.changerMonMotDePasseToolStripMenuItem.Text = "Changer mon mot de passe";
            this.changerMonMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.changerMonMotDePasseToolStripMenuItem_Click);
            // 
            // maRégionToolStripMenuItem
            // 
            this.maRégionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportsNonConsultésToolStripMenuItem,
            this.listeDesVisiteursToolStripMenuItem});
            this.maRégionToolStripMenuItem.Enabled = false;
            this.maRégionToolStripMenuItem.Name = "maRégionToolStripMenuItem";
            this.maRégionToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.maRégionToolStripMenuItem.Text = "Ma région";
            // 
            // rapportsNonConsultésToolStripMenuItem
            // 
            this.rapportsNonConsultésToolStripMenuItem.Name = "rapportsNonConsultésToolStripMenuItem";
            this.rapportsNonConsultésToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.rapportsNonConsultésToolStripMenuItem.Text = "Rapports non consultés";
            this.rapportsNonConsultésToolStripMenuItem.Click += new System.EventHandler(this.rapportsNonConsultésToolStripMenuItem_Click);
            // 
            // listeDesVisiteursToolStripMenuItem
            // 
            this.listeDesVisiteursToolStripMenuItem.Name = "listeDesVisiteursToolStripMenuItem";
            this.listeDesVisiteursToolStripMenuItem.Size = new System.Drawing.Size(302, 34);
            this.listeDesVisiteursToolStripMenuItem.Text = "Liste des visiteurs";
            this.listeDesVisiteursToolStripMenuItem.Click += new System.EventHandler(this.listeDesVisiteursToolStripMenuItem_Click);
            // 
            // monSecteurToolStripMenuItem
            // 
            this.monSecteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionÉquipeToolStripMenuItem,
            this.statistiquesSecteurToolStripMenuItem,
            this.nouveauVisiteurDéléguéToolStripMenuItem});
            this.monSecteurToolStripMenuItem.Enabled = false;
            this.monSecteurToolStripMenuItem.Name = "monSecteurToolStripMenuItem";
            this.monSecteurToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.monSecteurToolStripMenuItem.Text = "Mon secteur";
            // 
            // gestionÉquipeToolStripMenuItem
            // 
            this.gestionÉquipeToolStripMenuItem.Name = "gestionÉquipeToolStripMenuItem";
            this.gestionÉquipeToolStripMenuItem.Size = new System.Drawing.Size(326, 34);
            this.gestionÉquipeToolStripMenuItem.Text = "Gestion équipe";
            // 
            // statistiquesSecteurToolStripMenuItem
            // 
            this.statistiquesSecteurToolStripMenuItem.Name = "statistiquesSecteurToolStripMenuItem";
            this.statistiquesSecteurToolStripMenuItem.Size = new System.Drawing.Size(326, 34);
            this.statistiquesSecteurToolStripMenuItem.Text = "Statistiques secteur";
            // 
            // nouveauVisiteurDéléguéToolStripMenuItem
            // 
            this.nouveauVisiteurDéléguéToolStripMenuItem.Name = "nouveauVisiteurDéléguéToolStripMenuItem";
            this.nouveauVisiteurDéléguéToolStripMenuItem.Size = new System.Drawing.Size(326, 34);
            this.nouveauVisiteurDéléguéToolStripMenuItem.Text = "Nouveau visiteur / délégué";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 182);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 349);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(418, 163);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 12);
            this.panel1.TabIndex = 9;
            // 
            // FrmMenuVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 632);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMenuVisiteur";
            this.Text = "FrmMenuVisiteur";
            this.Load += new System.EventHandler(this.FrmMenuVisiteur_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mesRapportsEnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesRapportsValidésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesMedicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesPraticiensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesDonnéesPersonnellesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierConsulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerMonMotDePasseToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem maRégionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportsNonConsultésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesVisiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionÉquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauVisiteurDéléguéToolStripMenuItem;
    }
}
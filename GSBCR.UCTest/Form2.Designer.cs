namespace GSBCR.UCTest
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPraticien = new System.Windows.Forms.ComboBox();
            this.bsPrati = new System.Windows.Forms.BindingSource(this.components);
            this.ucPraticien1 = new GSBCR.UC.UcPraticien();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir un Praticien";
            // 
            // cbxPraticien
            // 
            this.cbxPraticien.FormattingEnabled = true;
            this.cbxPraticien.Location = new System.Drawing.Point(85, 61);
            this.cbxPraticien.Name = "cbxPraticien";
            this.cbxPraticien.Size = new System.Drawing.Size(121, 21);
            this.cbxPraticien.TabIndex = 1;
            this.cbxPraticien.SelectedIndexChanged += new System.EventHandler(this.cbxPraticien_SelectedIndexChanged);
            // 
            // ucPraticien1
            // 
            this.ucPraticien1.Location = new System.Drawing.Point(230, 101);
            this.ucPraticien1.Name = "ucPraticien1";
            this.ucPraticien1.Prati = null;
            this.ucPraticien1.Size = new System.Drawing.Size(550, 520);
            this.ucPraticien1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 668);
            this.Controls.Add(this.ucPraticien1);
            this.Controls.Add(this.cbxPraticien);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPrati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPraticien;
        private UC.UcPraticien ucPraticien1;
        private System.Windows.Forms.BindingSource bsPrati;
    }
}
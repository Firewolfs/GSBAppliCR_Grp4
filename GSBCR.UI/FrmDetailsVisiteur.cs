using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.BLL;
using GSBCR.modele;

namespace GSBCR.UI
{
    public partial class FrmDetailsVisiteur : Form
    {

        private VAFFECTATION laAffectation;
        private VISITEUR leUtilisateur;
        private VAFFECTATION laAffectationUtilisateur;
        private bool modification = false;
        private VISITEUR leVisiteur;
        private FrmVisiteurs formParent;

        public FrmDetailsVisiteur(bool modification, VAFFECTATION laAffectation, VISITEUR leUtilisateur, VAFFECTATION laAffectationUtilisateur, FrmVisiteurs formParent)
        {
            InitializeComponent();
            this.laAffectation = laAffectation;
            this.leUtilisateur = leUtilisateur;
            this.laAffectationUtilisateur = laAffectationUtilisateur;
            this.modification = modification;
            this.formParent = formParent;
        }

        private void FrmDetailsVisiteur_Load(object sender, EventArgs e)
        {

            this.leVisiteur = VisiteurManager.loadVisiteur(laAffectation.VIS_MATRICULE);
            REGION laRegion = VisiteurManager.ChargerUneRegion(laAffectation.REG_CODE);
            List<RAPPORT_VISITE> lesRapportsConsultes = VisiteurManager.ChargerRapportVisiteurFinisEtLus(leVisiteur.VIS_MATRICULE);

            txt_Matricule.Text = leVisiteur.VIS_MATRICULE;
            txt_Nom.Text = leVisiteur.VIS_NOM;
            txt_Prenom.Text = leVisiteur.Vis_PRENOM;
            txt_Email.Text = leVisiteur.mail;
            txt_Telephone.Text = leVisiteur.tel;
            txt_Adresse.Text = leVisiteur.VIS_ADRESSE;
            txt_CodePostal.Text = leVisiteur.VIS_CP;
            txt_Ville.Text = leVisiteur.VIS_VILLE;
            dtp_DateEmbauche.Value = leVisiteur.VIS_DATEEMBAUCHE;
            dtp_DateEmbauche.MinDate = leVisiteur.VIS_DATEEMBAUCHE;
            dtp_DateEmbauche.MaxDate = leVisiteur.VIS_DATEEMBAUCHE;
            txt_SecteurCode.Text = laRegion.LeSecteur.SEC_CODE;
            txt_SecteurLibelle.Text = laRegion.LeSecteur.SEC_LIBELLE;
            txt_RegionCode.Text = laRegion.REG_CODE;
            txt_Role.Text = laAffectation.TRA_ROLE;
            dtp_DateAffectation.Value = laAffectation.JJMMAA;
            dtp_DateAffectation.MinDate = laAffectation.JJMMAA;
            dtp_DateAffectation.MaxDate = laAffectation.JJMMAA;
            txt_NbRapportsConsultes.Text = lesRapportsConsultes.Count.ToString();
            if (lesRapportsConsultes.Count > 0)
            {
                this.btn_ConsulterRapports.Enabled = true;
                this.btn_ConsulterRapports.Visible = true;
            }
            else
            {
                this.btn_ConsulterRapports.Enabled = false;
                this.btn_ConsulterRapports.Visible = false;
            }


            if (!modification)
            {
                this.txt_RegionLibelle = new System.Windows.Forms.TextBox();
                this.txt_RegionLibelle.BackColor = System.Drawing.Color.White;
                this.pnl_Region.Controls.Add(this.txt_RegionLibelle);
                this.txt_RegionLibelle.Location = new System.Drawing.Point(76, 2);
                this.txt_RegionLibelle.Name = "txt_RegionLibelle";
                this.txt_RegionLibelle.ReadOnly = true;
                this.txt_RegionLibelle.Size = new System.Drawing.Size(154, 20);
                this.txt_RegionLibelle.TabIndex = 13;
                this.txt_RegionLibelle.Text = laRegion.REG_NOM;

                if (laAffectationUtilisateur.TRA_ROLE == "Responsable")
                {
                    btnModifier.Visible = true;
                    btnModifier.Enabled = true;
                }
                else
                {
                    btnModifier.Visible = false;
                    btnModifier.Enabled = false;
                }
            }
            else
            {
                ActiverModification();
            }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            ActiverModification();
        }

        private void ActiverModification()
        {

            this.modification = true;
            this.btnAnnuler.Visible = true;
            this.btnAnnuler.Enabled = true;
            this.btnValider.Visible = true;
            this.btnValider.Enabled = true;
            this.btnModifier.Visible = false;

            if (this.txt_RegionLibelle != null)
            {
                this.txt_RegionLibelle.Dispose();
            }
            this.cbx_Region = new System.Windows.Forms.ComboBox();
            this.cbx_Region.BackColor = System.Drawing.Color.White;
            this.cbx_Region.Location = new System.Drawing.Point(76, 2);
            this.cbx_Region.Name = "txt_RegionLibelle";
            this.cbx_Region.Size = new System.Drawing.Size(154, 20);
            this.cbx_Region.TabIndex = 13;
            this.pnl_Region.Controls.Add(this.cbx_Region);
            this.cbx_Region.SelectedIndexChanged += new System.EventHandler(this.cbx_Region_SelectedIndexChanged);
            this.cbx_Region.ValueMember = "REG_CODE";
            this.cbx_Region.DisplayMember = "REG_NOM";
            this.bsRegions.DataSource = ResponsableManager.ChargerRegionsSecteur(leUtilisateur.SEC_CODE);
            this.cbx_Region.DataSource = bsRegions;
            this.cbx_Region.SelectedValue = this.laAffectation.REG_CODE;

            this.txt_Email.ReadOnly = false;
            this.txt_Telephone.ReadOnly = false;
            this.txt_Adresse.ReadOnly = false;
            this.txt_CodePostal.ReadOnly = false;
            this.txt_Ville.ReadOnly = false;

            if (laAffectation.TRA_ROLE == "Visiteur")
            {
                btn_Promouvoir.Visible = true;
                btn_Promouvoir.Enabled = true;
            }
            else
            {
                btn_Promouvoir.Visible = false;
                btn_Promouvoir.Enabled = false;
            }
        }


        private void cbx_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txt_RegionCode.Text = (string)cbx_Region.SelectedValue;

            if ((string)cbx_Region.SelectedValue != this.laAffectation.REG_CODE)
            {
                DateTime dateJour = System.DateTime.Now;
                this.dtp_DateAffectation.MaxDate = dateJour;
                this.dtp_DateAffectation.Value = dateJour;
                this.dtp_DateAffectation.MinDate = dateJour;
            }
            else if ((string)cbx_Region.SelectedValue == this.laAffectation.REG_CODE && this.laAffectation.TRA_ROLE == this.txt_Role.Text)
            {
                this.dtp_DateAffectation.MinDate = this.laAffectation.JJMMAA;
                this.dtp_DateAffectation.Value = this.laAffectation.JJMMAA;
                this.dtp_DateAffectation.MaxDate = this.laAffectation.JJMMAA;
            }

        }

        private void btn_Promouvoir_Click(object sender, EventArgs e)
        {
            DateTime dateJour = System.DateTime.Now;
            this.dtp_DateAffectation.MaxDate = dateJour;
            this.dtp_DateAffectation.Value = dateJour;
            this.dtp_DateAffectation.MinDate = dateJour;
            this.txt_Role.Text = "Délégué";

            this.btn_Promouvoir.Enabled = false;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_Telephone.Text != leVisiteur.tel || txt_Email.Text != leVisiteur.mail || txt_Adresse.Text != leVisiteur.VIS_ADRESSE
                    || txt_CodePostal.Text != leVisiteur.VIS_CP || txt_Ville.Text != leVisiteur.VIS_VILLE)
                {
                    VisiteurManager.updateVisiteur(leVisiteur.VIS_MATRICULE, txt_Adresse.Text, txt_CodePostal.Text, txt_Ville.Text, txt_Telephone.Text, txt_Email.Text);
                }

                if (txt_RegionCode.Text != laAffectation.REG_CODE || txt_Role.Text != laAffectation.TRA_ROLE)
                {
                    ResponsableManager.MettreAjourAffectationVisiteur(leVisiteur.VIS_MATRICULE, txt_RegionCode.Text, dtp_DateAffectation.Value, txt_Role.Text);
                }

                MessageBox.Show("Visiteur mis à jour avec succès", "Mise à jour terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Echec de la mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            formParent.AfficherAffectationsVisiteurs();
            this.Close();
        }
    }
}

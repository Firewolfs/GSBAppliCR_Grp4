using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UC
{
    public partial class UcVisiteur : UserControl
    {
        public UcVisiteur()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Affiche un visiteur dans le usercontrol
        /// </summary>
        /// <param name="laAffectation">Visiteur à afficher</param>
        public void AfficherVisiteur(VAFFECTATION laAffectation)
        {
            VISITEUR leVisiteur = VisiteurManager.ChargerInfosVisiteur(laAffectation.VIS_MATRICULE);
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
            txt_RegionLibelle.Text = laRegion.REG_NOM;
            txt_Role.Text = laAffectation.TRA_ROLE;
            dtp_DateAffectation.Value = laAffectation.JJMMAA;
            dtp_DateAffectation.MinDate = laAffectation.JJMMAA;
            dtp_DateAffectation.MaxDate = laAffectation.JJMMAA;
            txt_NbRapportsConsultes.Text = lesRapportsConsultes.Count.ToString();
        }
    }
}

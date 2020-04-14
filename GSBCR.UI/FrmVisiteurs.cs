using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmVisiteurs : Form
    {

        private VISITEUR leUtilisateur;
        private VAFFECTATION laAffectationUtilisateur;

        public FrmVisiteurs(VISITEUR leUtilisateur)
        {
            InitializeComponent();
            this.leUtilisateur = leUtilisateur;
        }

        private void FrmVisiteurs_Load(object sender, EventArgs e)
        {
            List<VAFFECTATION> lesAffectationsRegion;
            laAffectationUtilisateur = VisiteurManager.ChargerAffectationVisiteur(leUtilisateur.VIS_MATRICULE);

            lesAffectationsRegion = DelegueManager.ChargerAffectationsVisiteursByRegion(laAffectationUtilisateur.REG_CODE, laAffectationUtilisateur.TRA_ROLE);

            bsVisiteursRegion.DataSource = lesAffectationsRegion;
        }

        private void dgv_Visiteurs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VAFFECTATION affectationSelect;
            FrmDetailsVisiteur fenetreDetails;

            affectationSelect = (VAFFECTATION)bsVisiteursRegion[e.RowIndex];

            fenetreDetails = new FrmDetailsVisiteur(affectationSelect);

            fenetreDetails.ShowDialog();
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            VAFFECTATION affectationSelect;
            FrmDetailsVisiteur fenetreDetails;

            if (dgv_Visiteurs.SelectedRows.Count != 0)
            {

                affectationSelect = (VAFFECTATION)bsVisiteursRegion[dgv_Visiteurs.SelectedRows[0].Index];

                fenetreDetails = new FrmDetailsVisiteur(affectationSelect);

                fenetreDetails.ShowDialog();
            }

        }
    }
}

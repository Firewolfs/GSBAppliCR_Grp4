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
    public partial class FrmRapports : Form
    {
        private VISITEUR leVisiteur;
        public FrmRapports(VISITEUR v, List<RAPPORT_VISITE> lr)
        {
            InitializeComponent();
            leVisiteur = v;
            label2.Text = leVisiteur.VIS_NOM;
            label3.Text = leVisiteur.Vis_PRENOM;
            bsRapports.DataSource = lr;
            dgvRapportEnCours.DataSource = bsRapports;
        }

        public FrmRapports(VISITEUR v, MEDICAMENT leMedicament)
        {
            InitializeComponent();
            leVisiteur = v;
            label2.Text = leVisiteur.VIS_NOM;
            label3.Text = leVisiteur.Vis_PRENOM;
            bsRapportsMedicament.DataSource = VisiteurManager.ChargerRapportVisiteMedicament(v, leMedicament);
            dgvRapportEnCours.DataSource = bsRapportsMedicament;
        }

        public FrmRapports(VISITEUR leVisiteur, PRATICIEN lePraticien)
        {
            InitializeComponent();
            this.leVisiteur = leVisiteur;
            label2.Text = leVisiteur.VIS_NOM;
            label3.Text = leVisiteur.Vis_PRENOM;
            bsRapportsPraticien.DataSource = VisiteurManager.ChargerRapportsVisitesPraticien(leVisiteur, lePraticien);
            dgvRapportEnCours.DataSource = bsRapportsPraticien;

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRapportEnCours_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RAPPORT_VISITE r = null;

            if (bsRapports.Count != 0)
            {
                r = (RAPPORT_VISITE)bsRapports.Current;
            }
            else if (bsRapportsMedicament.Count != 0)
            {
                r = (RAPPORT_VISITE)bsRapportsMedicament.Current;
            }
            else if (bsRapportsPraticien.Count != 0)
            {
                r = (RAPPORT_VISITE)bsRapportsPraticien.Current;
            }

            FrmSaisir f = new FrmSaisir(r, true);
            f.ShowDialog();

            if (bsRapports.Count != 0)
            {
                //On relance la liaison de données pour actualiser l'état des rapports
                if (r.RAP_ETAT == "2")
                {
                    //les rapports à l'état 2 ('saisie terminée') ne doivent pas apparaitre dans la liste
                    bsRapports.RemoveCurrent();
                }
                else
                {
                    bsRapports.ResetCurrentItem();
                }
            }

        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmSaisir f = new FrmSaisir(r, true);
            if (f.ShowDialog() == DialogResult.OK)
            {
                bsRapports.Add(r);
            }
        }
    }
}

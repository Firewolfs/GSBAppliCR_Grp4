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

        public const int RapportsEnCoursVisiteurs = 1;
        public const int RapportsValidesVisiteurs = 2;
        public const int RapportsMedicaments = 3;
        public const int RapportPraticiens = 4;
        public const int NouveauxRapportsRegion = 5;

        private VISITEUR leVisiteur;
        private int fonction;
        public FrmRapports(VISITEUR v, List<RAPPORT_VISITE> lr, int fonction)
        {
            InitializeComponent();
            this.fonction = fonction;
            leVisiteur = v;
            label2.Text = leVisiteur.VIS_NOM;
            label3.Text = leVisiteur.Vis_PRENOM;
            bsRapports.DataSource = lr;
            dgvRapports.DataSource = bsRapports;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRapportEnCours_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RAPPORT_VISITE r = null;


            r = (RAPPORT_VISITE)bsRapports.Current;


            FrmSaisir f = new FrmSaisir(r, true);
            f.ShowDialog();

            if (this.fonction == 1)
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

        private void FrmRapports_Load(object sender, EventArgs e)
        {
            if(this.fonction == 5)
            {
                this.label2.Visible = false;
                this.label3.Visible = false;
            }
            else
            {
                this.label2.Visible = true;
                this.label3.Visible = true;
            }
        }
    }
}

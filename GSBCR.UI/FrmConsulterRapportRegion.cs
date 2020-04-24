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
    public partial class FrmConsulterRapportRegion : Form
    {
        private VISITEUR leUtilisateur;
        public FrmConsulterRapportRegion(VISITEUR leUtilisateur, List<RAPPORT_VISITE> lr)
        {
            InitializeComponent();
            label2.Text = leUtilisateur.VIS_NOM;
            label3.Text = leUtilisateur.Vis_PRENOM;
            this.leUtilisateur = leUtilisateur;
            bsRapportEnCoursRegion.DataSource = lr;
            dgvRapportEnCours.DataSource = bsRapportEnCoursRegion;
        }

        private void dgvRapportEnCours_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bsRapportEnCours_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = leUtilisateur.VIS_MATRICULE;
            FrmSaisir f = new FrmSaisir(r, true);
            if (f.ShowDialog() == DialogResult.OK)
            {
                bsRapportEnCoursRegion.Add(r);
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}

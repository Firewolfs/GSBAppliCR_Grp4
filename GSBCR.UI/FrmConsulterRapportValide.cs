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
    public partial class FrmConsulterRapportValide : Form
    {
        private VISITEUR leVisiteur;
        public FrmConsulterRapportValide(VISITEUR v, List<RAPPORT_VISITE> lr)
        {
            InitializeComponent();
            leVisiteur = v;
            label9.Text = leVisiteur.VIS_NOM;
            label11.Text = leVisiteur.Vis_PRENOM;
            bsRapportValide.DataSource = lr;
            dgvRapportValide.DataSource = bsRapportValide;
        }

        private void dgvRapportValide_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RAPPORT_VISITE r = (RAPPORT_VISITE)bsRapportValide.Current;
            FrmSaisir f = new FrmSaisir(r, true);
            f.ShowDialog();
            //On relance la liaison de données pour actualiser l'état des rapports
            if (r.RAP_ETAT == "2" || r.RAP_ETAT=="3")
            {
                //les rapports à l'état 1 ('rapport en cours') ne doivent pas apparaitre dans la liste
                bsRapportValide.RemoveCurrent();
            }
            else
            {
                bsRapportValide.ResetCurrentItem();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

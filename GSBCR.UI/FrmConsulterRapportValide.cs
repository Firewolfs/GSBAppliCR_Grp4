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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

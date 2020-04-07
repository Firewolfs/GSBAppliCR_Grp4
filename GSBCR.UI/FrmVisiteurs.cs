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
        public FrmVisiteurs()
        {
            InitializeComponent();
        }

        private void FrmVisiteurs_Load(object sender, EventArgs e)
        {
            List<VISITEUR> lesViteursRegion;

            lesViteursRegion = DelegueManager.ChargerVisiteurByRegion("RA", "Délégué");

            bsVisiteursRegion.DataSource = lesViteursRegion;
        }

        private void dgv_Visiteurs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VISITEUR visiteurSelect;
            FrmDetailsVisiteur fenetreDetails;

            visiteurSelect = (VISITEUR)bsVisiteursRegion[e.RowIndex];

            fenetreDetails = new FrmDetailsVisiteur(visiteurSelect);

            fenetreDetails.ShowDialog();
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            VISITEUR visiteurSelect;
            FrmDetailsVisiteur fenetreDetails;

            if (dgv_Visiteurs.SelectedRows.Count != 0)
            {

                visiteurSelect = (VISITEUR)bsVisiteursRegion[dgv_Visiteurs.SelectedRows[0].Index];

                fenetreDetails = new FrmDetailsVisiteur(visiteurSelect);

                fenetreDetails.ShowDialog();
            }

        }
    }
}

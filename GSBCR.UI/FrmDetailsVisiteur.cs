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

        private VISITEUR leVisiteur;

        public FrmDetailsVisiteur(VISITEUR leVisiteur)
        {
            InitializeComponent();
            this.leVisiteur = leVisiteur;
        }

        private void FrmDetailsVisiteur_Load(object sender, EventArgs e)
        {

            ucVisiteur1.AfficherVisiteur(leVisiteur);

        }
    }
}

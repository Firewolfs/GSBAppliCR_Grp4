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

        public FrmDetailsVisiteur(VAFFECTATION laAffectation)
        {
            InitializeComponent();
            this.laAffectation = laAffectation;
        }

        private void FrmDetailsVisiteur_Load(object sender, EventArgs e)
        {

            ucVisiteur1.AfficherVisiteur(laAffectation);

        }
    }
}

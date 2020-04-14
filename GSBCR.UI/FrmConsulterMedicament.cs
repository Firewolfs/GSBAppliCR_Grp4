using GSBCR.modele;
using GSBCR.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBCR.UI
{
    public partial class FrmConsulterMedicament : Form
    {
        private MEDICAMENT leMedoc;
        private VISITEUR leUtilisateur;

        public FrmConsulterMedicament(VISITEUR leUtilisateur) // voir frm praticien
        {
            InitializeComponent();
            this.leUtilisateur = leUtilisateur;
            List<MEDICAMENT> listMed = VisiteurManager.ChargerMedicaments();
            cbxMedicament.DataSource = listMed;
            cbxMedicament.DisplayMember = "MED_NOMCOMMERCIAL";
            cbxMedicament.ValueMember = "MED_DEPOTLEGAL";
            cbxMedicament.SelectedIndex = -1;
        }

        private void cbxMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMedicament.SelectedIndex != -1)
            {
                MEDICAMENT m = (MEDICAMENT)cbxMedicament.SelectedItem;
                this.leMedoc = m;
                ucMedicament1.Medic = m;
                ucMedicament1.Visible = true;
            }
            
        }

        private void FrmConsulterMedicament_Load(object sender, EventArgs e)
        {
            ucMedicament1.Visible = false;
            cbxMedicament.SelectedIndex = -1;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_voirRapport_Click(object sender, EventArgs e)
        {
            if (leMedoc != null)
            {
                FrmRapportEnCours frmRapport = new FrmRapportEnCours(leUtilisateur, leMedoc);
                frmRapport.ShowDialog();
            }
            
           
        }
    }
}

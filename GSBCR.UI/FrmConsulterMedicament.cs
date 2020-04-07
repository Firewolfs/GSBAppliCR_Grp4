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

        public FrmConsulterMedicament() // voir frm praticien
        {
            InitializeComponent();
            List<MEDICAMENT> listMed = VisiteurManager.ChargerMedicaments();
            cbxMedicament.DataSource = listMed;
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
                ucMedicament1.LeMedicament = m;
                ucMedicament1.Visible = true;
                //string idMedicament = m.MED_DEPOTLEGAL;
                //List<RAPPORT_VISITE> a;
                //a = VisiteurManager.ChargerSiRapportsExistentMedicaments(UserId , idMedicament);
                //if (a.Count != 0)
                //{
                //    btn_voirRapport.Show();
                //}
                //else
                //{
                //    btn_voirRapport.Hide();
                //}
            }
            
        }

        private void FrmConsulterMedicament_Load(object sender, EventArgs e)
        {
            ucMedicament1.Visible = false;
            cbxMedicament.SelectedIndex = -1;
        }

        //private void btn_voirRapport_Click(object sender, EventArgs e)
        //{
        //    String unDepot = ucMedicament1.LeMedicament.MED_DEPOTLEGAL;
        //    FrmDetailRapport f = new FrmDetailRapport(UserId,unDepot);
        //    f.ShowDialog();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_voirRapport_Click(object sender, EventArgs e)
        {
            
            //FrmSaisir f = new FrmSaisir();
            //f.ShowDialog();
        }
    }
}

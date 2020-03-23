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
using GSBCR.UC;

namespace GSBCR.UCTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            bsMedoc.DataSource = VisiteurManager.ChargerMedicaments();
            cbxMedi.DataSource = bsMedoc;
            cbxMedi.DisplayMember = "MED_NOMCOMMERCIAL";
        }

        private void Form1_Load(object sender, EventArgs e) {
            ucMedicament1.Visible = false;
            cbxMedi.SelectedIndex = -1;
        }

        private void cbxMedi_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbxMedi.SelectedIndex != -1) {
                MEDICAMENT m = (MEDICAMENT)cbxMedi.SelectedItem;
                ucMedicament1.Medic = m;
                ucMedicament1.Visible = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e) { this.Close(); }

        private void btnPrati_Click(object sender, EventArgs e) {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}

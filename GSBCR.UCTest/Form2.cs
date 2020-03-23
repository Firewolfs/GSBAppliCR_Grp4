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
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
            bsPrati.DataSource = VisiteurManager.ChargerPraticiens();
            cbxPraticien.DataSource = bsPrati;
            cbxPraticien.DisplayMember = "PRA_PRENOM";
        }

        private void Form2_Load(object sender, EventArgs e) {
            ucPraticien1.Visible = false;
            cbxPraticien.SelectedIndex = -1;
        }

        private void cbxPraticien_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbxPraticien.SelectedIndex != -1) {
                PRATICIEN p = (PRATICIEN)cbxPraticien.SelectedItem;
                ucPraticien1.Prati = p;
                ucPraticien1.Visible = true;
            }
        }
    }
}

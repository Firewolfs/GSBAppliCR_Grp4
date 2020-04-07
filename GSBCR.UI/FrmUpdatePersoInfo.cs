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
    public partial class FrmUpdatePersoInfo : Form
    {
        public FrmUpdatePersoInfo(VISITEUR v) {
            InitializeComponent();

            txtMatri.Text = v.VIS_MATRICULE;
            txtName.Text = v.VIS_NOM;
            txtFirstName.Text = v.Vis_PRENOM;

            txtAddr.Text = v.VIS_ADRESSE;
            txtCp.Text = v.VIS_CP;
            txtTown.Text = v.VIS_VILLE;

            txtPhone.Text = v.tel;
            txtMail.Text = v.mail;
        }

        private void btnCancel_Click(object sender, EventArgs e) { this.Close(); }

        private void btnValid_Click(object sender, EventArgs e) {

        }
    }
}

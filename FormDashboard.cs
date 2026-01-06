using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionRendezVous
{
    public partial class FormDashboard : Form
    {
        private object nomUtilisateur;

        public FormDashboard()
        {
            InitializeComponent();
            lblBienvenue.Text = $"Bienvenue, {nomUtilisateur}";
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnVoirRdv_Click(object sender, EventArgs e)
        {
            FormListeRendezVous f = new FormListeRendezVous();
            f.ShowDialog();
        }

        private void btnAjouterRdv_Click(object sender, EventArgs e)
        {
            FormAjouterRendezVous f = new FormAjouterRendezVous();
            f.ShowDialog();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin().Show();
        }
    }
}

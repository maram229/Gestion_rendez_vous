using MySql.Data.MySqlClient;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            using (var conn = ConnexionBD.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM utilisateurs WHERE nom_utilisateur=@user AND mot_de_passe=@pass";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@user", txtUtilisateur.Text);
                //cmd.Parameters.AddWithValue("@pass", txtMotDePasse.Text);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    this.Hide();
                    //FormDashboard dashboard = new FormDashboard(txtUtilisateur.Text);
                    //dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Identifiants invalides !");
                }
            }
        }

        private void txtMotDePasse_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtUtilisateur_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            using (var conn = ConnexionBD.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM utilisateurs WHERE nom_utilisateur=@user AND mot_de_passe=@pass";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtUtilisateur.Text);
                cmd.Parameters.AddWithValue("@pass", txtMotDePasse.Text);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    this.Hide();
                    FormDashboard dashboard = new FormDashboard(txtUtilisateur.Text);
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Identifiants invalides !");
                }
            }
        }
    }
}

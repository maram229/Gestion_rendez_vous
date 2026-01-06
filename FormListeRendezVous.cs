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
    public partial class FormListeRendezVous : Form
    {

        public FormListeRendezVous()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {

        }

        private void FormListedRendezVous_Load(object sender, EventArgs e)
        {

        }
        private void ChargerRendezVous()
        {
            using (var conn = ConnexionBD.GetConnection())
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM rendezvous", conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridRdv.DataSource = table;
            }
        }

        private void FormListeRendezVous_Load(object sender, EventArgs e)
        {
            ChargerRendezVous();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calulette
{
    public partial class Enregistrement : Form
    {
        public Enregistrement()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtNom.Text = row.Cells["Nom"].Value?.ToString();
                txtSexe.Text = row.Cells["Sexe"].Value?.ToString();
                txtContact.Text = row.Cells["Contact"].Value?.ToString();
                txtAdresse.Text = row.Cells["Adresse"].Value?.ToString();

            }

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtNom.Text, txtAdresse.Text, txtSexe.Text, txtContact.Text);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null) // Vérifier qu'une ligne est sélectionnée
            {
                int index = dataGridView1.CurrentRow.Index;

                // Modifier les valeurs en utilisant les indices des colonnes
                dataGridView1.Rows[index].Cells[0].Value = txtNom.Text;
                dataGridView1.Rows[index].Cells[1].Value = txtAdresse.Text;
                dataGridView1.Rows[index].Cells[2].Value = txtSexe.Text;  // Si txtSexe est un TextBox
                dataGridView1.Rows[index].Cells[3].Value = txtContact.Text;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Enregistrement_Load(object sender, EventArgs e)
        {

        }
    }
}

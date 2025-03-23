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
    public partial class Calculette : Form
    {
        public Calculette()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vPlus.Checked == true)
            {
                int nombre1 = int.Parse(txtNombre1.Text);
                int nombre2 = int.Parse(txtNombre2.Text);
                int resultat = nombre1 + nombre2;

                txtResultat.Text = resultat.ToString();
            }

            if (vMoins.Checked == true)
            {
                int nombre1 = int.Parse(txtNombre1.Text);
                int nombre2 = int.Parse(txtNombre2.Text);
                int resultat = nombre1 - nombre2;

                txtResultat.Text = resultat.ToString();
            }


            if (vFois.Checked == true)
            {
                int nombre1 = int.Parse(txtNombre1.Text);
                int nombre2 = int.Parse(txtNombre2.Text);
                int resultat = nombre1 * nombre2;

                txtResultat.Text = resultat.ToString();
            }


            if (vDiv.Checked == true)
            {
                int nombre1 = int.Parse(txtNombre1.Text);
                int nombre2 = int.Parse(txtNombre2.Text);
                int resultat = nombre1 / nombre2;

                txtResultat.Text = resultat.ToString();
            }

        }
    }
}

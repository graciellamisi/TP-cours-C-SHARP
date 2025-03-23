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
    public partial class Cotation : Form
    {
        public Cotation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cotation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int math = int.Parse(txtMath.Text);
            int francais = int.Parse(txtFrancais.Text);
            int progr = int.Parse(txtProgr.Text);
            int algo = int.Parse(txtProgr.Text);
            int bur = int.Parse(txtBur.Text);
            int sommResultat = math + francais + progr + algo + bur;
            int resultatFinal = sommResultat * 100 / 300;
            
            //femme
            if(txtSexe.Text == "F"  && resultatFinal<50)
            {
                txtResultat.Text = "Résultat : Madame " + txtNom.Text + " vous avez " + resultatFinal.ToString() +  "% " + "et vous êtes ajournée";
            }
            else if (txtSexe.Text == "F" && resultatFinal >=50 && resultatFinal<70)
            {
                txtResultat.Text = "Résultat : Madame " + txtNom.Text + " vous avez " + resultatFinal.ToString() + "% " + "et vous avez satisfait";
            }
            else if (txtSexe.Text == "F" && resultatFinal >=70 && resultatFinal < 80)
            {
                txtResultat.Text = "Résultat : Madame " + txtNom.Text + " vous avez " + resultatFinal.ToString() + "% " + "et vous avez distingué";
            }
            else if (txtSexe.Text == "F" && resultatFinal >= 80 && resultatFinal < 90)
            {
                txtResultat.Text = "Résultat : Madame " + txtNom.Text + " vous avez " + resultatFinal.ToString() + "% " + "et vous avez fait une grande distinction";
            }
            else if (txtSexe.Text == "F" && resultatFinal >= 90 && resultatFinal < 100)
            {
                txtResultat.Text = "Résultat : Madame " + txtNom.Text + " vous avez " + resultatFinal.ToString() + "% " + "et vous avez fait une très grande distinction";
            }
            //homme
            else if (txtSexe.Text == "M" && resultatFinal < 50)
            {
                txtResultat.Text = "Résultat : Monsieur " + txtNom.Text + " vous avez " + resultatFinal.ToString() + "% " + "et vous êtes ajournée";
            }
            else if (txtSexe.Text == "M" && resultatFinal >= 50 && resultatFinal < 70)
            {
                txtResultat.Text = "Résultat : Monsieur " + txtNom.Text + " vous avez " + resultatFinal.ToString() + "% " + "et vous avez satisfait";
            }
            else if (txtSexe.Text == "M" && resultatFinal >= 70 && resultatFinal < 80)
            {
                txtResultat.Text = "Résultat : Monsieur " + txtNom.Text + " vous avez " + resultatFinal.ToString() + "% " + "et vous avez distingué";
            }
            else if (txtSexe.Text == "M" && resultatFinal >= 80 && resultatFinal < 90)
            {
                txtResultat.Text = "Résultat : Monsieur " + txtNom.Text + " vous avez " + resultatFinal.ToString() + "% " + "et vous avez fait une grande distinction";
            }
            else if (txtSexe.Text == "M" && resultatFinal >= 90 && resultatFinal < 100)
            {
                txtResultat.Text = "Résultat : Monsieur " + txtNom.Text + " vous avez " + resultatFinal.ToString() + "% " + "et vous avez fait une très grande distinction";
            }

        }

        private void txtSexe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMath_TextChanged(object sender, EventArgs e)
        {

            
          
        }
    }
}

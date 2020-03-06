using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compte_rendu
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            labelInfo.Hide();
        }
        
        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            String identifiant, motdepasse;
            identifiant = bmtUsername.Text;
            motdepasse = bmtPassword.Text;
            labelInfo.Show();
            if (identifiant == "aymnms" && motdepasse == "weshalors")
            {
                labelInfo.Text = "Connexion en cour...";
                labelInfo.ForeColor = Color.FromArgb(102, 109, 211);
                Close();
                FormHome home = new FormHome();
                home.Show();
            }
            if (identifiant.Length < 6 && motdepasse.Length < 1)
            {
                return;
            }
            else
            {
                labelInfo.Text = "Le couple identifiant / mot de passe\nest incorrecte.";
                labelInfo.ForeColor = Color.Red;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

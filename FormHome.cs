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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            displayCategory(category.HOME);
        }

        private void bDisconnection_Click(object sender, EventArgs e)
        {
            Close();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            displayCategory(category.HOME);
        }

        private void bProfile_Click(object sender, EventArgs e)
        {
            displayCategory(category.PROFILE);
        }

        private void bWriteCR_Click(object sender, EventArgs e)
        {
            displayCategory(category.WRITE_CR);
        }

        private void bReadCR_Click(object sender, EventArgs e)
        {
            displayCategory(category.READ_CR);
        }

        private enum category // onglet d'accueil
        {
            HOME,
            PROFILE,
            WRITE_CR,
            READ_CR
        }

        private void displayCategory(category c) // taches a executer lors des changements d'onglet
        {
            switch (c)
            {
                case category.HOME:
                    ucHome.Visible = true; // afficher partie home
                    ucProfile.Visible = false; // cacher les autres partie
                    ucWriteCR.Visible = false;
                    panelSide.Height = bHome.Height; // deplacer le curseur bleu sur l'onglet selectionné
                    panelSide.Top = bHome.Top;
                    break;

                case category.PROFILE:
                    ucHome.Visible = false;
                    ucProfile.Visible = true;
                    ucWriteCR.Visible = false;
                    panelSide.Height = bProfile.Height;
                    panelSide.Top = bProfile.Top;
                    break;
                
                case category.WRITE_CR:
                    ucHome.Visible = false;
                    ucProfile.Visible = false;
                    ucWriteCR.Visible = true;
                    panelSide.Height = bWriteCR.Height;
                    panelSide.Top = bWriteCR.Top;
                    break;
                
                case category.READ_CR:
                    ucHome.Visible = false;
                    ucProfile.Visible = false;
                    ucWriteCR.Visible = false;
                    panelSide.Height = bReadCR.Height;
                    panelSide.Top = bReadCR.Top;
                    break;
            }
        }
    }
}
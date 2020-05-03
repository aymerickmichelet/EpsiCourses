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
            displayCategory(category.PROFILE);
        }

        private void bDisconnection_Click(object sender, EventArgs e)
        {
            Close();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void buttonTopRight_Click(object sender, EventArgs e)
        {
            displayCategory(category.PROFILE);
        }

        private void bWriteCR_Click(object sender, EventArgs e)
        {
            displayCategory(category.WRITE_CR);
        }
        
        private void bReadVisiteur_Click(object sender, EventArgs e)
        {
            displayCategory(category.SEARCH_VISITEUR);
        }

        private void bReadMedecin_Click(object sender, EventArgs e)
        {
            displayCategory(category.SEARCH_MEDECIN);
        }

        private void bReadMedicament_Click(object sender, EventArgs e)
        {
            displayCategory(category.SEARCH_MEDICAMENT);
        }

        private void bReadCR_Click(object sender, EventArgs e)
        {
            displayCategory(category.READ_CR);
        }

        private enum category // onglet d'accueil
        {
            PROFILE,
            WRITE_CR,
            SEARCH_VISITEUR,
            SEARCH_MEDECIN,
            SEARCH_MEDICAMENT,
            READ_CR
        }

        private void displayCategory(category c) // taches a executer lors des changements d'onglet
        {
            switch (c)
            {
                case category.PROFILE:
                    panelSideTopRight.Visible = true;
                    panelSide.Visible = false;
                    UCProfile p = new UCProfile();
                    p.Top = panelTopRight.Size.Height;
                    p.Left = panelLeft.Size.Width;
                    Controls.Add(p);
                    p.Show();
                    break;
                
                case category.WRITE_CR:
                    panelSideTopRight.Visible = false;
                    panelSide.Visible = true;
                    panelSide.Height = bWriteCR.Height;
                    panelSide.Top = bWriteCR.Top;
                    break;

                case category.SEARCH_VISITEUR:
                    panelSideTopRight.Visible = false;
                    panelSide.Visible = true;
                    panelSide.Height = bReadVisiteur.Height;
                    panelSide.Top = bReadVisiteur.Top;
                    break;

                case category.SEARCH_MEDECIN:
                    panelSideTopRight.Visible = false;
                    panelSide.Visible = true;
                    panelSide.Height = bReadMedecin.Height;
                    panelSide.Top = bReadMedecin.Top;
                    break;

                case category.SEARCH_MEDICAMENT:
                    panelSideTopRight.Visible = false;
                    panelSide.Visible = true;
                    panelSide.Height = bReadMedicament.Height;
                    panelSide.Top = bReadMedicament.Top;
                    break;

                case category.READ_CR:
                    panelSideTopRight.Visible = false;
                    panelSide.Visible = true;
                    panelSide.Height = bReadCR.Height;
                    panelSide.Top = bReadCR.Top;
                    break;
            }
        }        
    }
}
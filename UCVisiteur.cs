using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using compte_rendu.Class;
//using System.Windows.Forms.VisualStyles;

namespace compte_rendu
{
    public partial class UCVisiteur : UserControl
    {
        public UCVisiteur()
        {
            InitializeComponent();
            this.labelNom.Text = "";
            this.labelRole.Text = "";
            this.labelRegion.Text = "";
            this.labelSecteur.Text = "";
            this.labelIdentifiant.Text = "";
            this.labelAdresse.Text = "";
            this.labelLaboratoire.Text = "";
            this.labelDateEmbauche.Text = "";

            int hauteur = 5;
            for (int i = 0, imax = 10; i < imax; i++)
            {
                Button b = new Button();
                b.Text = "PICHON Maxime";
                b.Top = hauteur;
                b.Left = 0;
                b.Width = bcMedecinList.Width - 20;
                b.Height = 32;
                b.FlatStyle = FlatStyle.Flat;
                b.ForeColor = Color.FromArgb(100, 160, 210);
                b.BackColor = Color.FromArgb(255, 255, 255);
                b.TextAlign = ContentAlignment.MiddleLeft;
                b.Font = new Font(new FontFamily("Century Gothic"), 14, FontStyle.Regular);
                b.FlatAppearance.BorderSize = 0;
                hauteur += 32;
                bcMedecinList.Controls.Add(b);
                b.Show();
            }

            hauteur = 5;
            for (int i = 0, imax = 10; i < imax; i++)
            {
                Button b = new Button();
                b.Text = "19/08/2000 - PICHON Maxime - MICHELET Aymerick";
                b.Top = hauteur;
                b.Left = 0;
                b.Width = bcCRList.Width - 20;
                b.Height = 32;
                b.FlatStyle = FlatStyle.Flat;
                b.ForeColor = Color.FromArgb(100, 160, 210);
                b.BackColor = Color.FromArgb(255, 255, 255);
                b.TextAlign = ContentAlignment.MiddleLeft;
                b.Font = new Font(new FontFamily("Century Gothic"), 14, FontStyle.Regular);
                b.FlatAppearance.BorderSize = 0;
                hauteur += 32;
                bcCRList.Controls.Add(b);
                b.Show();
            }
        }
    }
}

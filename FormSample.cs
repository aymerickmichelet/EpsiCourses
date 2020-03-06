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
    public partial class FormSample : Form
    {
        public FormSample()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            UCSample uce = new UCSample();
            uce.Top = panelListSample.Top + 50;
            uce.Height = panelListSample.Height + 50;
            uce.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
        public List<UCSample> listSample = new List<UCSample>();

        public FormSample()
        {
            InitializeComponent();
        }

        private void bibAddSample_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Item selected: " + bddSample.selectedIndex);

            if (bddSample.selectedIndex > 0)
            {
                addSample(new UCSample(bddSample.selectedValue), true);
                bddSample.selectedIndex = 0;
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void addSample(UCSample sample, Boolean addListSample)
        {
            panelListSample.Controls.Add(sample);
            sample.Left = 10;
            sample.Top = (sample.Height + 5) * listSample.Count();
            sample.Visible = true;
            if(addListSample)
                listSample.Add(sample);
        }

        public void removeSample(UCSample sample)
        {
            int index = listSample.IndexOf(sample);
            for (int i = index + 1, imax = listSample.Count; i < imax; i++)
            {
                listSample[i].Top -= listSample[i].Height + 5;
            }
            listSample.Remove(sample);
            sample.Delete();
        }
    }
}

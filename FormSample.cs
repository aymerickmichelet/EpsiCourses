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
        /*public static FormSample FS;
        public static FormSample getInstance()
        {
            return FS;
        }*/
        
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
                UCSample sample = new UCSample(bddSample.selectedValue);

                panelListSample.Controls.Add(sample);

                sample.Left = 10;
                sample.Top = (sample.Height + 5) * listSample.Count();
                sample.Visible = true;

                listSample.Add(sample);
                bddSample.selectedIndex = 0;
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        /*public void removeSample(UCSample sample)
        {
            Console.WriteLine(sample);
            //listSample.Remove(sample);
            sample.Delete();
        }*/
    }
}

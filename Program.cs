using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace compte_rendu
{
    static class Program
    {
        //mettre a jour le framwork du projet
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin login = new FormLogin();
            login.Show();
            Application.Run();
        }
    }
}

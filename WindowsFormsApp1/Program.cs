using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Affichage());
            //Application.Run(new facteur());
            //Application.Run(new maintenance());
            //Application.Run(new R_conteur());
            //Application.Run(new R_facteur());
            //Application.Run(new payment());
            //Application.Run(new P_facteur());
            //Application.Run(new NP_facteur());
            //Application.Run(new parametre());
            //Application.Run(new rapportD());
            //Application.Run(new loging());
            Application.Run(new first1cs());
            //Application.Run(new RfacCon());
        }
    }
}

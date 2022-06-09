using Gestion_Ecole.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Ecole
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Gestion_Ecole db = new Gestion_Ecole();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool connected = db.Helper.Where(c => c.ID == "CONNECTED" && c.VALUE != 0).Count() > 0;
            if (connected)
            {
                Application.Run(new main());
            }
            else
            {
                Application.Run(new Connect_form());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ecole
{
    class Helper_class
    {
        Gestion_Ecole db = new Gestion_Ecole();

        //
        // Connected user
        //
        public int Connected
        {
            get { return Convert.ToInt32(db.Helper.Where(u => u.ID == "CONNECTED").First().VALUE); }
        }
    }
}

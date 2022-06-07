using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Gestion_Ecole.Main.Forms;

namespace Gestion_Ecole.Main.UserControls.Options
{
    public partial class options_uc : MetroUserControl
    {
        public options_uc()
        {
            InitializeComponent();
        }

        private void options_uc_Load(object sender, EventArgs e)
        {
            if (main.user_type == "user")
            {
                btn_manage.Hide();
                btn_backup.Hide();

                btn_about.Location = btn_how_to.Location;
                btn_how_to.Location = btn_backup.Location;
            }
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            main.go_to_manage = true;
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            main.go_to_backup = true;
        }

        private void btn_how_to_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\AD1\Documents\Visual Studio 2013\Projects\Gestion_Ecole\School_Management_User_Guide.pdf");
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.ShowDialog();
        }
    }
}

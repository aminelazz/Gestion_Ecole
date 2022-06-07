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
using System.Data.SqlClient;

namespace Gestion_Ecole.Main.UserControls
{
    public partial class dashboard_uc : MetroUserControl
    {
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");

        string count;

        main main = new main();

        public dashboard_uc()
        {
            InitializeComponent();
        }

        private void get_count(string table)
        {
            SqlCommand cmd = new SqlCommand("select count(*) from " + table, cnx);
            SqlDataReader dr;
            cnx.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                count = dr.GetValue(0).ToString();
            }
            cnx.Close();
        }

        private void color(Guna.UI2.WinForms.Guna2Panel panel_name)
        {
            if (int.Parse(count) <= 5)
            {
                panel_name.BorderColor = Color.FromArgb(255, int.Parse(count) * 25, 0);
            }
            else if (int.Parse(count) > 5 && int.Parse(count) <= 10)
            {
                panel_name.BorderColor = Color.FromArgb(255 - ((int.Parse(count) - 5) * 51), (int.Parse(count) - 5) * 25 + 128, 0);
            }
            else
            {
                panel_name.BorderColor = Color.FromArgb(0, 255, 0);
            }
        }

        private void dashboard_uc_Load(object sender, EventArgs e)
        {
            get_count("Filiere");
            nbr_sec.Text = count;
            color(section_panel);

            get_count("Grp_etudiant");
            nbr_grp.Text = count;
            color(group_panel);

            get_count("Etudiant");
            nbr_std.Text = count;
            color(student_panel);

            get_count("Matiere");
            nbr_sbj.Text = count;
            color(subject_panel);
        }

        private void go_to_section_Click(object sender, EventArgs e)
        {
            main.go_to_section = true;
        }

        private void go_to_group_Click(object sender, EventArgs e)
        {
            main.go_to_group = true;
        }

        private void go_to_student_Click(object sender, EventArgs e)
        {
            main.go_to_student = true;
        }

        private void go_to_subject_Click(object sender, EventArgs e)
        {
            main.go_to_subject = true;
        }
    }
}

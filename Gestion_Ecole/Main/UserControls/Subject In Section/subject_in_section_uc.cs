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

namespace Gestion_Ecole.Main.UserControls.Subject_In_Section
{
    public partial class subject_in_section_uc : MetroUserControl
    {
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
        public static bool refresh;
        public static string user_type;

        public subject_in_section_uc()
        {
            InitializeComponent();
        }

        private void select_subject_in_section()
        {
            int row_count;
            section_subject_panel.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select_table", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@table", "Section & Subject");
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnx.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            row_count = dt.Rows.Count;
            for (int i = 0; i < row_count; i++)
            {
                show_subject_in_section show_subject_in_section = new show_subject_in_section();
                section_subject_panel.Controls.Add(show_subject_in_section);
                show_subject_in_section.show_section_id.Text = dt.Rows[i].ItemArray[0].ToString();
                show_subject_in_section.section_name.Text = dt.Rows[i].ItemArray[1].ToString();
                show_subject_in_section.show_subject_id.Text = dt.Rows[i].ItemArray[2].ToString();
                show_subject_in_section.subject_name.Text = dt.Rows[i].ItemArray[3].ToString();
            }
            
            cnx.Close();
        }

        private void search_subject_in_section(string attribut)
        {
            int row_count;
            section_subject_panel.Controls.Clear();
            SqlCommand cmd = new SqlCommand(/*"select id_filiere1, nom_filiere, id_matiere1, nom_matiere from Filiere_contient_matiere inner join Filiere on filiere.id_filiere = filiere_contient_matiere.id_filiere1 inner join Matiere on Matiere.id_matiere = filiere_contient_matiere.id_matiere1 where upper(" + attribut + ") like upper('%" + search.Text + "%') order by id_filiere1 asc"*/"search_table", cnx);

            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnx.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            row_count = dt.Rows.Count;
            for (int i = 0; i < row_count; i++)
            {
                show_subject_in_section show_subject_in_section = new show_subject_in_section();
                section_subject_panel.Controls.Add(show_subject_in_section);
                show_subject_in_section.show_section_id.Text = dt.Rows[i].ItemArray[0].ToString();
                show_subject_in_section.section_name.Text = dt.Rows[i].ItemArray[1].ToString();
                show_subject_in_section.show_subject_id.Text = dt.Rows[i].ItemArray[2].ToString();
                show_subject_in_section.subject_name.Text = dt.Rows[i].ItemArray[3].ToString();
            }
            cnx.Close();
        }

        private void subject_in_section_uc_Load(object sender, EventArgs e)
        {
            select_subject_in_section();
            refresh_timer.Start();
            check_user_type_timer.Start();
        }

        private void refresh_timer_Tick(object sender, EventArgs e)
        {
            if (refresh == true)
            {
                select_subject_in_section();

                refresh = false;

                show_subject_in_section.refresh = true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            section_subject_panel.Controls.Remove(add_refresh_panel);
            show_subject_in_section show_subject_in_section = new show_subject_in_section();
            section_subject_panel.Controls.Add(show_subject_in_section);
            section_subject_panel.Controls.Add(add_refresh_panel);

            show_subject_in_section.new_data = true;

            show_subject_in_section.show_section_id.Hide();
            show_subject_in_section.show_subject_id.Hide();

            show_subject_in_section.section_id.Show();
            show_subject_in_section.subject_id.Show();

            show_subject_in_section.section_id.SelectedIndex = -1;
            show_subject_in_section.subject_id.SelectedIndex = -1;

            show_subject_in_section.section_name.Text = "Section Name";
            show_subject_in_section.subject_name.Text = "Subject Name";

            show_subject_in_section.modify.Hide();
            show_subject_in_section.save.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            select_subject_in_section();
            check_user_type_timer.Start();
        }

        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si "Search by" = "Section ID" juste les nombres peuvent être écrits
            if (search_by.Text == "ID")
            {
                if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                select_subject_in_section();
                check_user_type_timer.Start();
            }
            else if (search_by.Text == "Section  ID")
            {
                search_subject_in_section("id_filiere1");
            }
            else if (search_by.Text == "Section  Name")
            {
                search_subject_in_section("nom_filiere");
            }
            else if (search_by.Text == "Subject  ID")
            {
                search_subject_in_section("id_matiere1");
            }
            else if (search_by.Text == "Subject  Name")
            {
                search_subject_in_section("nom_matiere");
            }
        }

        private void check_user_type_timer_Tick(object sender, EventArgs e)
        {
            if (user_type != "user")
            {
                section_subject_panel.Controls.Add(add_refresh_panel);
            }
            check_user_type_timer.Stop();
        }
    }
}

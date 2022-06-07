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
    public partial class section_uc : MetroUserControl
    {
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
        public static bool refresh;
        public static string user_type;
        int new_id;

        public section_uc()
        {
            InitializeComponent();
        }

        private void select_section()
        {
            int row_count;
            section_panel.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select_table", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@table", "Section");
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnx.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            row_count = dt.Rows.Count;
            new_id = row_count;
            for (int i = 0; i < row_count; i++)
            {
                show_section show_section = new show_section();
                section_panel.Controls.Add(show_section);
                show_section.id.Text = dt.Rows[i].ItemArray[0].ToString();
                show_section.name.Text = dt.Rows[i].ItemArray[1].ToString();
            }
            
            cnx.Close();
        }

        private void search_section(string attribut)
        {
            int row_count;
            section_panel.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select id_filiere as [Section ID], nom_filiere as [Section Name] from Filiere where upper(" + attribut + ") like upper('%" + search.Text + "%')", cnx);
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnx.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            row_count = dt.Rows.Count;
            for (int i = 0; i < row_count; i++)
            {
                show_section show_section = new show_section();
                section_panel.Controls.Add(show_section);
                show_section.id.Text = dt.Rows[i].ItemArray[0].ToString();
                show_section.name.Text = dt.Rows[i].ItemArray[1].ToString();
            }
            cnx.Close();
        }
        
        private void section_uc_Load(object sender, EventArgs e)
        {
            select_section();
            refresh_timer.Start();
            check_user_type_timer.Start();
        }

        private void refresh_timer_Tick(object sender, EventArgs e)
        {
            if (refresh==true)
            {
                select_section();

                refresh = false;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            section_panel.Controls.Remove(add_refresh_panel);
            show_section show_section=new Main.show_section();
            section_panel.Controls.Add(show_section);
            section_panel.Controls.Add(add_refresh_panel);
            new_id++;
            show_section.id.Enabled = true;
            show_section.id.Text = new_id.ToString();
            show_section.name.Text = "";
            show_section.name.Enabled = true;

            show_section.modify.Hide();
            show_section.save.Show();
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
            if (search.Text != "")
            {
                if (search_by.Text=="ID")
                {
                    search_section("id_filiere");
                }
                else if (search_by.Text=="Name")
                {
                    search_section("nom_filiere");
                }
            }
            else if (search.Text == "")
            {
                select_section();
                check_user_type_timer.Start();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            select_section();
            check_user_type_timer.Start();
        }

        private void check_user_type_timer_Tick(object sender, EventArgs e)
        {
            if (user_type != "user")
            {
                section_panel.Controls.Add(add_refresh_panel);
            }
            check_user_type_timer.Stop();
        }
    }
}

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
    public partial class group_uc : MetroUserControl
    {
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
        public static bool refresh;
        public static string user_type;
        int new_id;

        public group_uc()
        {
            InitializeComponent();
        }

        private void select_group()
        {
            int row_count;
            group_panel.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select_table", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@table", "Group");
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnx.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            row_count = dt.Rows.Count;
            new_id = row_count;
            for (int i = 0; i < row_count; i++)
            {
                show_group show_group = new show_group();
                group_panel.Controls.Add(show_group);
                show_group.id.Text = dt.Rows[i].ItemArray[0].ToString();
                show_group.name.Text = dt.Rows[i].ItemArray[1].ToString();
                show_group.section_name.Text = dt.Rows[i].ItemArray[2].ToString();
            }
            
            cnx.Close();
        }

        private void search_group(string attribut)
        {
            int row_count;
            group_panel.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select id_groupe as [Group ID],nom_groupe as [Group Name], nom_filiere as [Section Name] from grp_etudiant inner join filiere on grp_etudiant.id_filiere = filiere.id_filiere where upper(" + attribut + ") like upper('%" + search.Text + "%') order by id_groupe asc", cnx);
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnx.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            row_count = dt.Rows.Count;
            new_id = row_count;
            for (int i = 0; i < row_count; i++)
            {
                show_group show_group = new show_group();
                group_panel.Controls.Add(show_group);
                show_group.id.Text = dt.Rows[i].ItemArray[0].ToString();
                show_group.name.Text = dt.Rows[i].ItemArray[1].ToString();
                show_group.section_name.Text = dt.Rows[i].ItemArray[2].ToString();
            }
            cnx.Close();
        }

        private void group_uc_Load(object sender, EventArgs e)
        {
            select_group();
            refresh_timer.Start();
            check_user_type_timer.Start();
        }

        private void add_Click(object sender, EventArgs e)
        {
            group_panel.Controls.Remove(add_refresh_panel);
            show_group show_group = new show_group();
            group_panel.Controls.Add(show_group);
            group_panel.Controls.Add(add_refresh_panel);
            new_id++;
            show_group.id.Enabled = true;
            show_group.id.Text = new_id.ToString();
            show_group.name.Enabled = true;
            show_group.name.Text = "";
            show_group.section_name.Hide();
            show_group.new_section_name.Show();
            show_group.modify.Hide();
            show_group.save.Show();
        }

        private void refresh_timer_Tick(object sender, EventArgs e)
        {
            if (refresh == true)
            {
                select_group();

                refresh = false;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            select_group();
            check_user_type_timer.Start();
        }

        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (search_by.Text == "ID")
            {
                //Critères sur "Search" si "ID" est sélectionné
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
                select_group();
                check_user_type_timer.Start();
            }
            else if (search_by.Text == "ID")
            {
                search_group("id_groupe");
            }
            else if (search_by.Text == "Name")
            {
                search_group("nom_groupe");
            }
            else if (search_by.Text == "Section Name")
            {
                search_group("nom_filiere");
            }
        }

        private void check_user_type_timer_Tick(object sender, EventArgs e)
        {
            if (user_type != "user")
            {
                group_panel.Controls.Add(add_refresh_panel);
            }
            check_user_type_timer.Stop();
        }
    }
}

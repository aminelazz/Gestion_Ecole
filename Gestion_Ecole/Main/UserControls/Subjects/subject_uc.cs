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
    public partial class subject_uc : MetroUserControl
    {
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
        public static bool refresh;
        public static string user_type;
        int new_id;

        public subject_uc()
        {
            InitializeComponent();
        }

        private void select_subject()
        {
            int row_count;
            subject_panel.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select_table", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@table", "Subject");
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnx.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            row_count = dt.Rows.Count;
            new_id = row_count;
            for (int i = 0; i < row_count; i++)
            {
                show_subject show_subject = new show_subject();
                subject_panel.Controls.Add(show_subject);
                show_subject.id.Text = dt.Rows[i].ItemArray[0].ToString();
                show_subject.name.Text = dt.Rows[i].ItemArray[1].ToString();
            }
            
            cnx.Close();
        }

        private void search_subject(string attribut)
        {
            int row_count;
            subject_panel.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select ID_matiere as [Subject ID], nom_matiere as [Subject Name] from Matiere where upper(" + attribut + ") like upper('%" + search.Text + "%') order by id_matiere asc", cnx);
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnx.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            row_count = dt.Rows.Count;
            new_id = row_count;
            for (int i = 0; i < row_count; i++)
            {
                show_subject show_subject = new show_subject();
                subject_panel.Controls.Add(show_subject);
                show_subject.id.Text = dt.Rows[i].ItemArray[0].ToString();
                show_subject.name.Text = dt.Rows[i].ItemArray[1].ToString();
            }
            cnx.Close();
        }

        private void subject_uc_Load(object sender, EventArgs e)
        {
            select_subject();
            refresh_timer.Start();
            check_user_type_timer.Start();
        }

        private void add_Click(object sender, EventArgs e)
        {
            subject_panel.Controls.Remove(add_refresh_panel);
            show_subject show_subject = new show_subject();
            subject_panel.Controls.Add(show_subject);
            subject_panel.Controls.Add(add_refresh_panel);
            new_id++;
            show_subject.id.Enabled = true;
            show_subject.id.Text = new_id.ToString();
            show_subject.name.Enabled = true;
            show_subject.name.Text = "";
            show_subject.modify.Hide();
            show_subject.save.Show();
        }

        private void refresh_timer_Tick(object sender, EventArgs e)
        {
            if (refresh == true)
            {
                select_subject();

                refresh = false;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            select_subject();
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
                select_subject();
                check_user_type_timer.Start();
            }
            else if (search_by.Text == "ID")
            {
                search_subject("id_matiere");
            }
            else if (search_by.Text == "Name")
            {
                search_subject("nom_matiere");
            }
        }

        private void check_user_type_timer_Tick(object sender, EventArgs e)
        {
            if (user_type != "user")
            {
                subject_panel.Controls.Add(add_refresh_panel);
            }
            check_user_type_timer.Stop();
        }
    }
}

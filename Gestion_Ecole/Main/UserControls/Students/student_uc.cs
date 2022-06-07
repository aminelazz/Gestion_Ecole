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
    public partial class student_uc : MetroUserControl
    {
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
        public static bool refresh;
        public static string user_type;
        int new_id;

        public student_uc()
        {
            InitializeComponent();
        }

        private void select_student()
        {
            int row_count;
            student_panel.Controls.Clear();
            student_panel.Controls.Add(header_panel);
            SqlCommand cmd = new SqlCommand("select_table", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@table", "Student");
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnx.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            row_count = dt.Rows.Count;
            new_id = row_count;
            for (int i = 0; i < row_count; i++)
            {
                show_student show_student = new show_student();
                student_panel.Controls.Add(show_student);
                show_student.id.Text = dt.Rows[i].ItemArray[0].ToString();
                show_student.name.Text = dt.Rows[i].ItemArray[1].ToString();
                show_student.group_name.Text = dt.Rows[i].ItemArray[2].ToString();
                show_student.new_group_name.SelectedText = dt.Rows[i].ItemArray[2].ToString();
                show_student.section_name.Text = dt.Rows[i].ItemArray[3].ToString();
                show_student.date_birth.Text = dt.Rows[i].ItemArray[4].ToString();
                show_student.new_date_birth.Value = DateTime.Parse(dt.Rows[i].ItemArray[4].ToString());
            }
            
            cnx.Close();
        }

        private void search_student(string attribut)
        {
            int row_count;
            student_panel.Controls.Clear();
            student_panel.Controls.Add(header_panel);
            SqlCommand cmd = new SqlCommand("select id_etudiant as [Student ID], nom_etudiant as [Student Name], nom_groupe as [Group Name], nom_filiere as [Section Name], concat(day(date_naissance),'/',month(date_naissance),'/',year(date_naissance)) as date_birth from etudiant inner join grp_etudiant on etudiant.id_groupe=grp_etudiant.id_groupe inner join filiere on grp_etudiant.id_groupe=filiere.id_filiere where upper(" + attribut + ") like upper('%" + search.Text + "%') order by id_etudiant asc", cnx);
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnx.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            row_count = dt.Rows.Count;
            for (int i = 0; i < row_count; i++)
            {
                show_student show_student = new show_student();
                student_panel.Controls.Add(show_student);
                show_student.id.Text = dt.Rows[i].ItemArray[0].ToString();
                show_student.name.Text = dt.Rows[i].ItemArray[1].ToString();
                show_student.group_name.Text = dt.Rows[i].ItemArray[2].ToString();
                show_student.new_group_name.SelectedText = dt.Rows[i].ItemArray[2].ToString();
                show_student.section_name.Text = dt.Rows[i].ItemArray[3].ToString();
                show_student.date_birth.Text = dt.Rows[i].ItemArray[4].ToString();
                show_student.new_date_birth.Value = DateTime.Parse(dt.Rows[i].ItemArray[4].ToString());
            }
            cnx.Close();
        }

        private void student_uc_Load(object sender, EventArgs e)
        {
            select_student();
            refresh_timer.Start();
            check_user_type_timer.Start();
        }

        private void refresh_timer_Tick(object sender, EventArgs e)
        {
            if (refresh == true)
            {
                select_student();

                refresh = false;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            select_student();
            check_user_type_timer.Start();
        }

        private void add_Click(object sender, EventArgs e)
        {
            student_panel.Controls.Remove(add_refresh_panel);
            show_student show_student = new show_student();
            student_panel.Controls.Add(show_student);
            student_panel.Controls.Add(add_refresh_panel);
            new_id++;

            show_student.id.Enabled = true;
            show_student.name.Enabled = true;

            show_student.id.Text = new_id.ToString();
            show_student.name.Text = "";

            show_student.group_name.Hide();
            show_student.date_birth.Hide();
            show_student.modify.Hide();

            show_student.new_group_name.Show();
            show_student.new_date_birth.Show();
            show_student.save.Show();

            show_student.new_group_name.SelectedIndex = 0;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                select_student();
                check_user_type_timer.Start();
            }
            else if (search_by.Text == "ID")
            {
                search_student("id_etudiant");
            }
            else if (search_by.Text == "Name")
            {
                search_student("nom_etudiant");
            }
            else if (search_by.Text == "Group Name")
            {
                search_student("nom_groupe");
            }
            else if (search_by.Text == "Section Name")
            {
                search_student("nom_filiere");
            }
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

        private void check_user_type_timer_Tick(object sender, EventArgs e)
        {
            if (user_type != "user")
            {
                student_panel.Controls.Add(add_refresh_panel);
            }
            check_user_type_timer.Stop();
        }
    }
}

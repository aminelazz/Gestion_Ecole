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
using Gestion_Ecole.Main.UserControls;
using Gestion_Ecole.Main;

namespace Gestion_Ecole
{
    public partial class show_student : MetroUserControl
    {
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
        public static string user_type;

        public show_student()
        {
            InitializeComponent();
        }

        private void populate_group_combobox()
        {
            SqlCommand cmd = new SqlCommand("select nom_groupe from grp_etudiant", cnx);
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnx.Close();
            cnx.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            DataRow select_row = dt.NewRow();
            select_row["nom_groupe"] = "-- Select --";
            dt.Rows.InsertAt(select_row, 0);
            new_group_name.Refresh();
            new_group_name.DataSource = dt;
            new_group_name.DisplayMember = "nom_groupe";
            cnx.Close();
        }

        private void show_student_Load(object sender, EventArgs e)
        {
            populate_group_combobox();
            
            id.Enabled = false;
            name.Enabled = false;
            group_name.Enabled = false;
            section_name.Enabled = false;
            date_birth.Enabled = false;


            user_type_timer.Start();

            group_name.Show();
            date_birth.Show();
            modify.Show();

            new_group_name.Hide();
            new_date_birth.Hide();
            save.Hide();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            name.Enabled = true;

            group_name.Hide();
            date_birth.Hide();
            modify.Hide();

            new_group_name.Show();
            new_date_birth.Show();
            save.Show();

            new_group_name.SelectedIndex = 0;
        }

        private void save_Click(object sender, EventArgs e)
        {
            DialogResult confirm_save = MessageBox.Show("Save ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm_save == DialogResult.Yes)
            {
                if (new_group_name.Text == "-- Select --")
                {
                    MessageBox.Show("Please select a valid Group Name .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (id.Text == "" || name.Text == "")
                {
                    MessageBox.Show("Please fill all the fields .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("add_update_student", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id.Text);
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@group_name", new_group_name.Text);

                    string new_sql_date_birth = new_date_birth.Value.Month.ToString() + "/" + new_date_birth.Value.Day.ToString() + "/" + new_date_birth.Value.Year.ToString(); 

                    cmd.Parameters.AddWithValue("@date_birth",new_sql_date_birth);
                    try
                    {
                        cnx.Close();
                        cnx.Open();
                        cmd.ExecuteNonQuery();
                        cnx.Close();

                        id.Enabled = false;
                        name.Enabled = false;
                        group_name.Enabled = false;
                        section_name.Enabled = false;
                        date_birth.Enabled = false;

                        group_name.Show();
                        date_birth.Show();
                        modify.Show();

                        new_group_name.Hide();
                        new_date_birth.Hide();
                        save.Hide();

                        group_name.Text = new_group_name.Text;
                        date_birth.Text = new_date_birth.Text;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Student Name or Student ID already exists !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                student_uc.refresh = true;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult delete_confirm = MessageBox.Show("Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete_confirm == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete_student", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@enter_id_etudiant", id.Text);
                cmd.Parameters.AddWithValue("@username", Environment.UserName);
                cmd.Parameters.AddWithValue("@delete_date", DateTime.Now);
                SqlDataReader dr;
                cnx.Close();
                cnx.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string message = dr.GetValue(0).ToString();
                    MessageBox.Show(this, "Message : " + message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Critères sur "ID"
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void new_group_name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (new_group_name.Text == "-- Select --")
            {
                section_name.Text = "Section Name";
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select nom_filiere from grp_etudiant inner join filiere on grp_etudiant.id_filiere = filiere.id_filiere where nom_groupe = '" + new_group_name.Text + "'", cnx);
                SqlDataReader dr;
                cnx.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    section_name.Text = dr.GetValue(0).ToString();
                }
                cnx.Close();
            }
        }

        private void user_type_timer_Tick(object sender, EventArgs e)
        {
            if (user_type == "user")
            {
                modify.Enabled = false;
                save.Enabled = false;
                delete.Enabled = false;
            }
            else
            {
                modify.Enabled = true;
                save.Enabled = true;
                delete.Enabled = true;
            }

            user_type_timer.Stop();
        }
    }
}

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

namespace Gestion_Ecole.Main
{
    public partial class show_group : MetroUserControl
    {
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
        public static string user_type;

        public show_group()
        {
            InitializeComponent();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            modify.Hide();
            save.Show();

            name.Enabled = true;
            section_name.Hide();
            new_section_name.Show();
            new_section_name.SelectedIndex = 0;
        }

        private void populate_section_combobox()
        {
            SqlCommand cmd = new SqlCommand("select nom_filiere from filiere", cnx);
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnx.Close();
            cnx.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            DataRow select_row = dt.NewRow();
            select_row["nom_filiere"] = "-- Select --";
            dt.Rows.InsertAt(select_row, 0);
            new_section_name.Refresh();
            new_section_name.DataSource = dt;
            new_section_name.DisplayMember = "nom_filiere";
            cnx.Close();
        }

        private void show_group_Load(object sender, EventArgs e)
        {
            populate_section_combobox();

            user_type_timer.Start();

            section_name.Show();
            new_section_name.Hide();

            modify.Show();
            save.Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {
            DialogResult confirm_save = MessageBox.Show("Save ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm_save == DialogResult.Yes)
            {
                if (new_section_name.Text == "-- Select --")
                {
                    MessageBox.Show("Please select a valid Section Name .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (id.Text == "" || name.Text == "")
                {
                    MessageBox.Show("Please fill all the fields .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("add_update_groupe", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id.Text);
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@section_name", new_section_name.Text);
                    try
                    {
                        cnx.Close();
                        cnx.Open();
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                        modify.Show();
                        save.Hide();

                        id.Enabled = false;
                        name.Enabled = false;
                        section_name.Show();
                        section_name.Text = new_section_name.Text;
                        new_section_name.Hide();
                        student_uc.refresh = true;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Group Name or Group ID already exists !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                group_uc.refresh = true;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult delete_confirm = MessageBox.Show("Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete_confirm == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("check_id_groupe", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@enter_id_groupe", id.Text);
                cmd.Parameters.AddWithValue("@username", Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@delete_date", DateTime.Now);
                SqlDataReader dr;
                cnx.Close();
                cnx.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string message = dr.GetValue(0).ToString();
                    if (message == "0")
                    {
                        this.Hide();
                    }
                    else if (message == "1")
                    {
                        MessageBox.Show("Message : Deleted Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(this, "Message : " + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                cnx.Close();

                student_uc.refresh = true;
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

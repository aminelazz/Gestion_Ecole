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
using Gestion_Ecole.Main.UserControls.Subject_In_Section;

namespace Gestion_Ecole.Main
{
    public partial class show_section : MetroUserControl
    {
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
        public static string user_type;

        public show_section()
        {
            InitializeComponent();
        }

        private void show_section_Load(object sender, EventArgs e)
        {
            user_type_timer.Start();

            modify.Show();
            save.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult delete_confirm = MessageBox.Show("Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete_confirm == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("check_id_filiere", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@enter_id_filiere", id.Text);
                cmd.Parameters.AddWithValue("@username", Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@delete_date", DateTime.Now);
                SqlDataReader dr;
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
                        group_uc.refresh = true;
                        subject_in_section_uc.refresh = true;
                    }
                    else
                    {
                        MessageBox.Show(this, "Message : " + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                cnx.Close();
            }
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                save_Click(sender, e);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            DialogResult save_confirm = MessageBox.Show("Save ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (save_confirm == DialogResult.Yes)
            {
                if (id.Text == "" || name.Text == "")
                {
                    MessageBox.Show("Please fill all the fields .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("add_update_filiere", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id.Text);
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    try
                    {
                        cnx.Open();
                        cmd.ExecuteNonQuery();
                        cnx.Close();

                        modify.Show();
                        save.Hide();

                        id.Enabled = false;
                        name.Enabled = false;
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Section Name or Section ID already exists !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    group_uc.refresh = true;
                    student_uc.refresh = true;
                    subject_in_section_uc.refresh = true;

                }
            }
            else if (save_confirm == DialogResult.No)
            {
                section_uc.refresh = true;
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

        private void modify_Click(object sender, EventArgs e)
        {
            modify.Hide();
            save.Show();

            name.Enabled = true;
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

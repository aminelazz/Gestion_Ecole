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
    public partial class show_subject : MetroUserControl
    {
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
        public static string user_type;

        public show_subject()
        {
            InitializeComponent();
        }

        private void show_subject_Load(object sender, EventArgs e)
        {
            modify.Show();
            save.Hide();

            user_type_timer.Start();
        }

        private void save_Click(object sender, EventArgs e)
        {
            DialogResult confirm_save = MessageBox.Show("Save ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm_save == DialogResult.Yes)
            {
                if (id.Text == "" || name.Text == "")
                {
                    MessageBox.Show("Please fill all the fields .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("add_update_matiere", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id.Text);
                    cmd.Parameters.AddWithValue("@name", name.Text);
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
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Subject Name or Subject ID already exists !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    subject_in_section_uc.refresh = true;
                }
            }
            else
            {
                subject_uc.refresh = true;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult delete_confirm = MessageBox.Show("Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete_confirm == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete_from_matiere", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@enter_id_matiere", id.Text);
                cmd.Parameters.AddWithValue("@username", Environment.UserName.ToString());
                cmd.Parameters.AddWithValue("@delete_date", DateTime.Now);
                SqlDataReader dr;
                cnx.Close();
                cnx.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string message = dr.GetValue(0).ToString();
                    if (message == "true")
                    {
                        MessageBox.Show("Message : Successfully Deleted !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();


                        subject_in_section_uc.refresh = true;
                    }
                    else
                    {
                        MessageBox.Show("Message : " + dr.GetValue(0).ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                cnx.Close();
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

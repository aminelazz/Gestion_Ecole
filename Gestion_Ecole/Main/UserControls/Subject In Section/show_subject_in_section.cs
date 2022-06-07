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
    public partial class show_subject_in_section : MetroUserControl
    {
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
        public static bool new_data;
        public static string user_type;
        public static bool refresh;

        public show_subject_in_section()
        {
            InitializeComponent();
        }

        private void populate_id_combobox(string table, Guna.UI2.WinForms.Guna2ComboBox combobox)
        {
            SqlCommand cmd = new SqlCommand("select * from " + table + " order by id_" + table + " asc", cnx);
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnx.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            combobox.DataSource = dt;
            combobox.DisplayMember = "id_" + table;
            combobox.SelectedIndex = -1;
            cnx.Close();
        }

        private void show_name(string table, Guna.UI2.WinForms.Guna2ComboBox combobox, Guna.UI2.WinForms.Guna2TextBox field)
        {
            SqlCommand cmd = new SqlCommand("select * from " + table + " where id_" + table + " = " + combobox.Text, cnx);
            SqlDataReader dr;
            cnx.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                field.Text = dr.GetValue(1).ToString();
            }
            cnx.Close();
        }

        private void show_subject_in_section_Load(object sender, EventArgs e)
        {
            show_section_id.Show();
            show_subject_id.Show();
            
            section_id.Hide();
            subject_id.Hide();

            modify.Show();
            save.Hide();

            populate_id_combobox("filiere", section_id);
            populate_id_combobox("matiere", subject_id);

            user_type_timer.Start();
            refresh_timer.Start();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            show_subject_id.Hide();
            modify.Hide();

            subject_id.Show();
            save.Show();

            section_id.SelectedIndex = int.Parse(show_section_id.Text) - 1;
            subject_id.SelectedIndex = int.Parse(show_subject_id.Text) - 1;
        }

        private void section_id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            show_name("filiere", section_id, section_name);
        }

        private void subject_id_SelectionChangeCommitted(object sender, EventArgs e)
        {
            show_name("matiere", subject_id, subject_name);
        }

        private void save_Click(object sender, EventArgs e)
        {
            DialogResult save_confirm = MessageBox.Show("Save ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (save_confirm == DialogResult.Yes)
            {
                if (section_id.Text == "" || subject_id.Text == "")
                {
                    MessageBox.Show("Please fill all the fields .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (new_data == true)
                    {
                        SqlCommand cmd = new SqlCommand("add_section_contains_subject", cnx);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@enter_section_id", section_id.Text);
                        cmd.Parameters.AddWithValue("@enter_subject_id", subject_id.Text);

                        cnx.Open();
                        cmd.ExecuteNonQuery();
                        cnx.Close();

                        modify.Show();
                        save.Hide();

                        show_section_id.Text = section_id.Text;
                        show_subject_id.Text = subject_id.Text;

                        show_section_id.Show();
                        show_subject_id.Show();

                        section_id.Hide();
                        subject_id.Hide();

                        new_data = false;
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("update_section_contains_subject", cnx);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@section_id", show_section_id.Text);
                        cmd.Parameters.AddWithValue("@enter_subject_id", subject_id.Text);
                        cmd.Parameters.AddWithValue("@subject_id", show_subject_id.Text);

                        cnx.Open();
                        cmd.ExecuteNonQuery();
                        cnx.Close();

                        modify.Show();
                        save.Hide();

                        show_section_id.Text = section_id.Text;
                        show_subject_id.Text = subject_id.Text;

                        show_section_id.Show();
                        show_subject_id.Show();

                        section_id.Hide();
                        subject_id.Hide();
                    }
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult delete_confirm = MessageBox.Show("Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (delete_confirm == DialogResult.Yes)
            {
                if (section_id.Text == "" || subject_id.Text == "")
                {
                    this.Hide();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("delete_section_contains_subject", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@section_id", show_section_id.Text);
                    cmd.Parameters.AddWithValue("@subject_id", show_subject_id.Text);
                    cmd.Parameters.AddWithValue("@section_name", section_name.Text);
                    cmd.Parameters.AddWithValue("@subject_name", subject_name.Text);
                    cmd.Parameters.AddWithValue("@username", Environment.UserName.ToString());
                    cmd.Parameters.AddWithValue("@delete_date", DateTime.Now);
                    SqlDataReader dr;
                    cnx.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string message = dr.GetValue(0).ToString();
                        MessageBox.Show(this, "Message : " + message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    cnx.Close();
                }
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

        private void refresh_timer_Tick(object sender, EventArgs e)
        {
            if (refresh == true)
            {
                populate_id_combobox("filiere", section_id);
                populate_id_combobox("matiere", subject_id);
                refresh = false;
            }
        }
    }
}

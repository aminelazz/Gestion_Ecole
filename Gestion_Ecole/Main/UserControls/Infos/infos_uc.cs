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
using MetroFramework;

namespace Gestion_Ecole.Main.UserControls
{
    public partial class infos_uc : MetroUserControl
    {
        bool fname_hided = true;
        bool lname_hided = true;
        bool password_hided = true;

        main main = new main();
        
        public infos_uc()
        {
            InitializeComponent();
        }

        private void infos_uc_Load(object sender, EventArgs e)
        {
            //Réorganisation des contrôles
            fname_panel.Size = new Size(408, 35);
            lname_panel.Size = new Size(408, 35);
            password_panel.Size = new Size(408, 35);

            lname_panel.Location = Point.Subtract(lname_panel.Location, new Size(0, 42));
            username_panel.Location = Point.Subtract(username_panel.Location, new Size(0, 84));
            password_panel.Location = Point.Subtract(password_panel.Location, new Size(0, 84));
            user_type_panel.Location = Point.Subtract(user_type_panel.Location, new Size(0, 178));

            //Sélection des informations d'utilisateur
            select_info_user();
        }

        private void select_info_user()
        {
            //Requête de sélection du "first_name" et "last_name" du table "authentication"
            SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select first_name, last_name from authentication where username = '" + main.username_value + "'", cnx);
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnx.Open();
            dr = cmd.ExecuteReader();
            //Affichage du nom complet et du type dans les label
            if (dr.Read())
            {
                lbl_first_name.Text = dr.GetValue(0).ToString();
                lbl_last_name.Text = dr.GetValue(1).ToString();
                lbl_username.Text = main.username_value;
                lbl_user_type.Text = main.user_type;
                main.full_name = lbl_first_name.Text + " " + lbl_last_name.Text;
            }
            cnx.Close();
        }

        private void fname_slide_down_Click(object sender, EventArgs e)
        {
            //Afficher le champs de changement du "First Name"
            new_first_name.Clear();
            timer_fname.Start();
        }

        private void fname_slide_up_Click(object sender, EventArgs e)
        {
            //Cacher le champs de changement du "First Name"
            timer_fname.Start();
        }

        private void timer_fname_Tick(object sender, EventArgs e)
        {
            if (fname_hided==true)
            {
                fname_panel.Height += 2;
                lname_panel.Location = Point.Add(lname_panel.Location, new Size(0, 2));
                username_panel.Location = Point.Add(username_panel.Location, new Size(0, 2));
                password_panel.Location = Point.Add(password_panel.Location, new Size(0, 2));
                user_type_panel.Location = Point.Add(user_type_panel.Location, new Size(0, 2));
                
                if (fname_panel.Height==77)
                {
                    timer_fname.Stop();
                    fname_hided = false;
                    fname_slide_down.Hide();
                    fname_slide_up.Show();
                }
            }
            else if (fname_hided == false)
            {
                fname_panel.Height -= 2;
                lname_panel.Location = Point.Subtract(lname_panel.Location, new Size(0, 2));
                username_panel.Location = Point.Subtract(username_panel.Location, new Size(0, 2));
                password_panel.Location = Point.Subtract(password_panel.Location, new Size(0, 2));
                user_type_panel.Location = Point.Subtract(user_type_panel.Location, new Size(0, 2));
                
                if (fname_panel.Height==35)
                {
                    timer_fname.Stop();
                    fname_hided = true;
                    fname_slide_down.Show();
                    fname_slide_up.Hide();
                }
            }
        }

        private void lname_slide_down_Click(object sender, EventArgs e)
        {
            //Afficher le champs de changement du "Last Name"
            new_last_name.Clear();
            timer_lname.Start();
        }

        private void lname_slide_up_Click(object sender, EventArgs e)
        {
            //Cacher le champs de changement du "First Name"
            timer_lname.Start();
        }

        private void timer_lname_Tick(object sender, EventArgs e)
        {
            if (lname_hided == true)
            {
                lname_panel.Height += 2;
                username_panel.Location = Point.Add(username_panel.Location, new Size(0, 2));
                password_panel.Location = Point.Add(password_panel.Location, new Size(0, 2));
                user_type_panel.Location = Point.Add(user_type_panel.Location, new Size(0, 2));
                
                if (lname_panel.Height == 77)
                {
                    timer_lname.Stop();
                    lname_hided = false;
                    lname_slide_down.Hide();
                    lname_slide_up.Show();

                }
            }
            else if (lname_hided == false)
            {
                lname_panel.Height -= 2;
                username_panel.Location = Point.Subtract(username_panel.Location, new Size(0, 2));
                password_panel.Location = Point.Subtract(password_panel.Location, new Size(0, 2));
                user_type_panel.Location = Point.Subtract(user_type_panel.Location, new Size(0, 2));
                
                if (lname_panel.Height == 35)
                {
                    timer_lname.Stop();
                    lname_hided = true;
                    lname_slide_down.Show();
                    lname_slide_up.Hide();
                }
            }
        }

        private void password_slide_down_Click(object sender, EventArgs e)
        {
            //Afficher les champs de changement du "Password"
            current_password.Clear();
            new_password.Clear();
            confirm_new_password.Clear();
            timer_password.Start();
        }

        private void password_slide_up_Click(object sender, EventArgs e)
        {
            //Cacher le champs de changement du "Password"
            timer_password.Start();
        }
        
        private void timer_password_Tick(object sender, EventArgs e)
        {
            if (password_hided == true)
            {
                password_panel.Height += 2;
                user_type_panel.Location = Point.Add(user_type_panel.Location, new Size(0, 2));

                if (password_panel.Height == 129)
                {
                    timer_password.Stop();
                    password_hided = false;
                    password_slide_down.Hide();
                    password_slide_up.Show();
                }
            }
            else if (password_hided == false)
            {
                password_panel.Height -= 2;
                user_type_panel.Location = Point.Subtract(user_type_panel.Location, new Size(0, 2));

                if (password_panel.Height == 35)
                {
                    timer_password.Stop();
                    password_hided = true;
                    password_slide_down.Show();
                    password_slide_up.Hide();
                }
            }
        } 

        private void save(string attribut, string value)
        {
            SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update authentication set " + attribut + " = '" + value + "' where username = '" + main.username_value + "'", cnx);
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btn_save_1_Click(object sender, EventArgs e)
        {
            //Si "New First Name" n'est pas vide
            if (new_first_name.Text!="")
            {
                save("first_name", new_first_name.Text);
                MessageBox.Show(this, "First Name Updated !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                select_info_user();
                new_first_name.Clear();
            }
            //Si "New First Name" est vide
            else
            {
                MessageBox.Show(this, "Please fill all the fields !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_2_Click(object sender, EventArgs e)
        {
            //Si "New Last Name" n'est pas vide
            if (new_last_name.Text != "")
            {
                save("last_name", new_last_name.Text);
                MessageBox.Show(this, "First Name Updated !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                select_info_user();
                new_last_name.Clear();
            }
            //Si "New First Name" est vide
            else
            {
                MessageBox.Show(this, "Please fill all the fields !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_save_3_Click(object sender, EventArgs e)
        {
            //Si "Current Password" ou "New Password" ou "Confirm New Password" sont vide
            if (current_password.Text=="" || new_password.Text=="" || confirm_new_password.Text=="")
            {
                MessageBox.Show(this, "Please fill all the fields !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Si "New Password" est différent de "Confirm New Password"
            else if (new_password.Text!=confirm_new_password.Text)
            {
                MessageBox.Show(this, "Passwords are different !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Si "Current Password" n'est pas vide et "New Password" est égale à "Confirm New Password"
            else
            {
                SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("update_password", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", main.username_value);
                cmd.Parameters.AddWithValue("@current_password", current_password.Text);
                cmd.Parameters.AddWithValue("@new_password", new_password.Text);
                SqlDataReader dr;
                cnx.Open();
                dr=cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show(dr.GetValue(0).ToString());
                }
                cnx.Close();
                select_info_user();
                current_password.Clear();
                new_password.Clear();
                confirm_new_password.Clear();
            }
        }
    }
}

using Gestion_Ecole.Main;
using Gestion_Ecole.Main.UserControls;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Ecole
{
    public partial class Register_form : MetroForm
    {
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
        Connect_form connect_form = new Connect_form();
        public Register_form()
        {
            InitializeComponent();
        }

        private void Register_form_Load(object sender, EventArgs e)
        {
            //Définition du caractère du mot de passe du système
            password.UseSystemPasswordChar = true;
            confirm_password.UseSystemPasswordChar = true;

            //Limitation du nombre des caractères
            first_name.MaxLength = 20;
            last_name.MaxLength = 20;
            username.MaxLength = 20;
            password.MaxLength = 20;
            confirm_password.MaxLength = 20;

            //Remplissage du comboBox "user_type"
            user_type.Items.Add("User");
            user_type.Items.Add("Administrator");
            user_type.SelectedItem = "User";
        }

        private void first_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Critères sur "First Name"
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void last_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Critères sur "Last Name"
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Critères sur "Username"
            if (char.IsSeparator(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Critères sur "Password"
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void confirm_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Critères sur "Confirm Password"
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //Si "First Name" ou "Last Name" ou "Username" ou "Password" ou "Comfirm Passworm" sont vides
            if (first_name.Text=="" || last_name.Text=="" || username.Text=="" || password.Text=="" || confirm_password.Text=="")
            {
                MetroMessageBox.Show(this,"Please fill all the fields !","Empty fields",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //Si "Password" et "Confirm Password" sont différenrts"
            else if (password.Text != confirm_password.Text)
	        {
		        MetroMessageBox.Show(this,"Passwords aren't the same","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
	        }
            //S'il n'y a pas d'erreurs
            else
	        {
                //Requête d'insertion
                string type;
                if (user_type.Text=="User")
                {
                    type = "user";
                }
                else
                {
                    type = "admin";
                }
                SqlCommand cmd = new SqlCommand("insert into authentication values ('" + username.Text + "','" + first_name.Text + "','" + last_name.Text + "','" + password.Text + "','" + type + "')", cnx);
                cnx.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MetroMessageBox.Show(this,"Registration Complete !", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    manage_uc.register_full_name = first_name.Text + " " + last_name.Text;
                    manage_uc.register_username = username.Text;
                    manage_uc.create_new_account = true;
                    this.Hide();
                }
                //Cas où "Username" existe déjà
                catch (SqlException)
                {
                    MetroMessageBox.Show(this,"Username already exists !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cnx.Close();
                
        	}
        }

        

        
    }
}

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

namespace Gestion_Ecole.Main
{
    public partial class recover_form : MetroForm
    {
        public recover_form()
        {
            InitializeComponent();
        }

        private void recover_form_Load(object sender, EventArgs e)
        {
            //Régler la taille du forme
            this.Size = new Size(387, 217);

            //Cacher les boutons et les labels et les textBox
            new_password.Visible = false;
            comfirm_new_password.Visible = false;
            btn_confirm.Visible = false;
            metroLabel4.Visible = false;
            metroLabel5.Visible = false;

            //Régler le nombre maximum des caractères
            first_name.MaxLength = 20;
            last_name.MaxLength = 20;
            username.MaxLength = 20;
            new_password.MaxLength = 20;
            comfirm_new_password.MaxLength = 20;
            
            //Utiliser le caratère du mot de passe du système
            new_password.UseSystemPasswordChar = true;
            comfirm_new_password.UseSystemPasswordChar = true;
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

        private void new_password_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comfirm_new_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Critères sur "Comfirm New Password"
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        
        public void btn_check_Click(object sender, EventArgs e)
        {
            //Si "First Name" ou "Last Name" ou "Username"
            if (first_name.Text == "" || last_name.Text == "" || username.Text == "")
            {
                MetroMessageBox.Show(this,"Please fill all the fields !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Si non
            else
            {
                SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from authentication where first_name = '" + first_name.Text + "' and last_name = '" + last_name.Text + "' and username = '" + username.Text + "'", cnx);
                SqlDataReader dr;
                cnx.Open();
                dr = cmd.ExecuteReader();
                //S'il y a des valeurs après l'exécution du requête 
                if (dr.Read())
                {
                    //Redimenssionner la form
                    this.Size = new Size(387, 285);

                    //Afficher les labels et les textBox
                    new_password.Visible = true;
                    comfirm_new_password.Visible = true;
                    btn_confirm.Visible = true;
                    metroLabel4.Visible = true;
                    metroLabel5.Visible = true;

                    //Caher les boutons et les labels et les textBox
                    btn_check.Visible = false;
                    first_name.Enabled = false;
                    last_name.Enabled = false;
                    username.Enabled = false;
                    metroLabel1.Enabled = false;
                    metroLabel2.Enabled = false;
                    metroLabel3.Enabled = false;
                }
                //S'il n'y a pas de valeurs
                else
                {
                    MetroMessageBox.Show(this,"Please enter a valid informations !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cnx.Close();
            }
        }

        

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            //Si "New Password" ou "Comfirm New Password" sont vides
            if (new_password.Text == "" || comfirm_new_password.Text == "")
            {
                MetroMessageBox.Show(this,"Please fill all the fields !", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Si "New Password" ou "Comfirm New Password" ne sont pas les mêmes
            else if (new_password.Text != comfirm_new_password.Text)
            {
                MetroMessageBox.Show(this,"Passwords doesn't match !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Si tout est vrai
            else
            {
                SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("update authentication set password = '" + new_password.Text + "' where username ='" + username.Text + "'", cnx);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                MetroMessageBox.Show(this,"Password Updated !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
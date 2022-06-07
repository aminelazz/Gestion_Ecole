using Gestion_Ecole.Main;
using Gestion_Ecole.Main.UserControls;
using Gestion_Ecole.Main.UserControls.Subject_In_Section;
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
    public partial class Connect_form : MetroForm
    {
        //Déclaration de la connexion ave la base de données "Gestion_Ecole"
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");

        public Connect_form()
        {
            InitializeComponent();
        }

        public void Connect_form_Load(object sender, EventArgs e)
        {
            //Cacher les caractères du mot de passe
            password.UseSystemPasswordChar = true;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            //Si username ou password sont vides
            if (username.Text=="" || password.Text=="")
            {
                MetroMessageBox.Show(this,"Please fill all the fields !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select first_name, last_name, user_type from authentication where username='" + username.Text + "' and password='" + password.Text + "'", cnx);
                SqlDataReader dr;
                cnx.Open();
                dr = cmd.ExecuteReader();
                //S'il y a du valeurs après l'execution du requête
                if (dr.Read())
                {
                    main main = new main();
                    main.username_value = username.Text;
                    show_account.username_value = username.Text;
                    main.full_name = dr.GetValue(0).ToString() + " " + dr.GetValue(1).ToString();
                    main.user_type = dr.GetValue(2).ToString();

                    show_section.user_type = dr.GetValue(2).ToString();
                    show_group.user_type = dr.GetValue(2).ToString();
                    show_student.user_type = dr.GetValue(2).ToString();
                    show_subject.user_type = dr.GetValue(2).ToString();
                    show_subject_in_section.user_type = dr.GetValue(2).ToString();

                    section_uc.user_type = dr.GetValue(2).ToString();
                    group_uc.user_type = dr.GetValue(2).ToString();
                    student_uc.user_type = dr.GetValue(2).ToString();
                    subject_uc.user_type = dr.GetValue(2).ToString();
                    subject_in_section_uc.user_type = dr.GetValue(2).ToString();

                    main.Show();
                    this.Hide();
                }
                //Si non
                else
                {
                    MetroMessageBox.Show(this,"Username or Password invalid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cnx.Close();
            }
        }

        private void forgot_password_Click(object sender, EventArgs e)
        {
            //Cliquer sur "Forgot Password ?"
            recover_form recover_form = new recover_form();
            recover_form.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //Cliquer sur "Register"
            Register_form register_form = new Register_form();
            register_form.Show();
        }

        private void eye_close_MouseHover(object sender, EventArgs e)
        {
            //Affichage du mot de passe
            eye_close.Visible = false;
            password.UseSystemPasswordChar = false;
        }

        private void eye_open_MouseLeave(object sender, EventArgs e)
        {
            //Cacher le mot de passe
            eye_close.Visible = true;
            password.UseSystemPasswordChar = true;
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Critères sur le textBox de username
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
            //Critères sur le textBox de password
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

            //Lors du click sur "Entrée"
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_connect_Click(sender, e);
            }
        }

        private void close_off_MouseHover(object sender, EventArgs e)
        {
            close_off.Hide();
            close_on.Show();
        }

        private void close_on_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_on_MouseLeave(object sender, EventArgs e)
        {
            close_off.Show();
        }

        private void minimize_off_MouseHover(object sender, EventArgs e)
        {
            minimize_off.Hide();
            minimize_on.Show();
        }

        private void minimize_on_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimize_on_MouseLeave(object sender, EventArgs e)
        {
            minimize_off.Show();
        }
    }
}

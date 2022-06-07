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
    public partial class manage_uc : MetroUserControl
    {
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");

        public static bool create_new_account = false;

        public static string register_full_name;
        public static string register_username;


        public manage_uc()
        {
            InitializeComponent();
        }

        private void manage_uc_Load(object sender, EventArgs e)
        {
            show_accounts();

            create_account_timer.Start();
        }

        private void show_accounts()
        {
            account_panel.Controls.Clear();
            SqlCommand cmd = new SqlCommand("select concat(first_name,' ',last_name), username from authentication", cnx);
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cnx.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            account_panel.Controls.Clear();
            int row_count = dt.Rows.Count;
            for (int i = 0; i < row_count; i++)
            {
                show_account show_account = new show_account();
                show_account.full_name.Text = dt.Rows[i].ItemArray[0].ToString();
                show_account.username.Text = dt.Rows[i].ItemArray[1].ToString();
                account_panel.Controls.Add(show_account);
            }
            account_panel.Controls.Add(create_account_panel);
            cnx.Close();
        }

        private void create_account_Click(object sender, EventArgs e)
        {
            Register_form register_form = new Register_form();
            register_form.Show();
        }

        private void create_account_timer_Tick(object sender, EventArgs e)
        {
            if (create_new_account == true)
            {
                account_panel.Controls.Remove(create_account_panel);
                show_account show_account = new show_account();
                show_account.full_name.Text = register_full_name;
                show_account.username.Text = register_username;
                account_panel.Controls.Add(show_account);
                account_panel.Controls.Add(create_account_panel);
                create_new_account = false;
            }
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            main.go_to_options = true;
        }

    }
}

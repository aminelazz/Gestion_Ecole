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
    public partial class show_account : MetroUserControl
    {
        SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
        public static string username_value;

        public show_account()
        {
            InitializeComponent();
        }

        private void delete_account()
        {
            SqlCommand cmd = new SqlCommand("del_account", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username_del", username.Text);
            cmd.Parameters.AddWithValue("@user", Environment.UserName);
            cmd.Parameters.AddWithValue("@delete_date", DateTime.Now);
            SqlDataReader dr;
            cnx.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string message = dr.GetValue(0).ToString();
                MessageBox.Show("Message = " + message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //manage_uc.refresh = true;
                this.Hide();
            }
            cnx.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("'" + username.Text + "' will be delete permanently !", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                delete_account();
            }
        }

        private void show_account_Load(object sender, EventArgs e)
        {
            username_timer.Start();
        }

        private void username_timer_Tick(object sender, EventArgs e)
        {
            if (username.Text == username_value)
            {
                delete.Enabled = false;
                username_timer.Stop();
            }
        }
    }
}

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

namespace Gestion_Ecole.Main.UserControls.Create_Backup
{
    public partial class backup_uc : MetroUserControl
    {
        public backup_uc()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            DialogResult folderpath = folderBrowserDialog1.ShowDialog();
            if (folderpath == DialogResult.OK)
            {
                path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (file_name.Text == "")
            {
                MessageBox.Show("Please enter a valid file name !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (path.Text == "")
            {
                MessageBox.Show("Please enter a valid folder directory !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection cnx = new SqlConnection("Data Source=LAPTOP;Initial Catalog=Gestion_Ecole;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("create_backup", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@file_name",file_name.Text);
                cmd.Parameters.AddWithValue("@path",path.Text);

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();

                MessageBox.Show("Backup Created Successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            main.go_to_options = true;
        }
    }
}

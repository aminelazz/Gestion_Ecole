using Gestion_Ecole.Main;
using Gestion_Ecole.Main.UserControls;
using Gestion_Ecole.Main.UserControls.Create_Backup;
using Gestion_Ecole.Main.UserControls.Options;
using Gestion_Ecole.Main.UserControls.Subject_In_Section;
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
    public partial class main : MetroForm
    {
        public static string username_value;
        public static string full_name;
        public static string user_type;

        public static bool go_to_section;
        public static bool go_to_group;
        public static bool go_to_student;
        public static bool go_to_subject;

        public static bool go_to_options;
        public static bool go_to_manage;
        public static bool go_to_backup;

        Connect_form connect_form = new Connect_form();
        section_uc section_uc = new section_uc();
        group_uc group_uc = new group_uc();
        student_uc student_uc = new student_uc();
        subject_uc subject_uc = new subject_uc();
        manage_uc manage_uc = new manage_uc();
        backup_uc backup_uc = new backup_uc();
        subject_in_section_uc subject_in_section_uc = new subject_in_section_uc();

        
        public main()
        {
            InitializeComponent();
        }
        
        private void main_Load(object sender, EventArgs e)
        {
            infos_uc infos_uc = new UserControls.infos_uc();
            btn_info.FillColor = Color.FromArgb(0, 192, 0);
            this.main_panel.Controls.Add(infos_uc);
            infos_uc.Location = new Point(5, 5);

            lbl_name.Text = full_name;
            
            timer1.Start();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            btn_info.FillColor = Color.FromArgb(0, 192, 0);
            btn_dashboard.FillColor = Color.FromArgb(0, 174, 219);
            btn_section.FillColor = Color.FromArgb(0, 174, 219);
            btn_group.FillColor = Color.FromArgb(0, 174, 219);
            btn_student.FillColor = Color.FromArgb(0, 174, 219);
            btn_subject.FillColor = Color.FromArgb(0, 174, 219);
            btn_section_subject.FillColor = Color.FromArgb(0, 174, 219);
            btn_options.FillColor = Color.FromArgb(0, 174, 219);

            if (main_panel.Controls.Contains(student_uc))
            {
                this.Size = new Size(Point.Subtract(new Point(this.Size), new Size(251, 0)));
                CenterToScreen();

                version_lbl.Location = Point.Subtract(version_lbl.Location, new Size(251, 0));
            }

            this.main_panel.Controls.Clear();
            infos_uc infos_uc = new infos_uc();
            this.main_panel.Controls.Add(infos_uc);
            infos_uc.Location = new Point(5, 5);
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            btn_info.FillColor = Color.FromArgb(0, 174, 219);
            btn_dashboard.FillColor = Color.FromArgb(0, 192, 0);
            btn_section.FillColor = Color.FromArgb(0, 174, 219);
            btn_group.FillColor = Color.FromArgb(0, 174, 219);
            btn_student.FillColor = Color.FromArgb(0, 174, 219);
            btn_subject.FillColor = Color.FromArgb(0, 174, 219);
            btn_section_subject.FillColor = Color.FromArgb(0, 174, 219);
            btn_options.FillColor = Color.FromArgb(0, 174, 219);

            if (main_panel.Controls.Contains(student_uc))
            {
                this.Size = new Size(Point.Subtract(new Point(this.Size), new Size(251, 0)));
                CenterToScreen();

                version_lbl.Location = Point.Subtract(version_lbl.Location, new Size(251, 0));
            }

            this.main_panel.Controls.Clear();
            dashboard_uc dashboard_uc = new dashboard_uc();
            this.main_panel.Controls.Add(dashboard_uc);
            dashboard_uc.Location = new Point(5, 5);
        }

        private void btn_section_Click(object sender, EventArgs e)
        {
            btn_info.FillColor = Color.FromArgb(0, 174, 219);
            btn_dashboard.FillColor = Color.FromArgb(0, 174, 219);
            btn_section.FillColor = Color.FromArgb(0, 192, 0);
            btn_group.FillColor = Color.FromArgb(0, 174, 219);
            btn_student.FillColor = Color.FromArgb(0, 174, 219);
            btn_subject.FillColor = Color.FromArgb(0, 174, 219);
            btn_section_subject.FillColor = Color.FromArgb(0, 174, 219);
            btn_options.FillColor = Color.FromArgb(0, 174, 219);

            if (main_panel.Controls.Contains(student_uc))
            {
                this.Size = new Size(Point.Subtract(new Point(this.Size), new Size(251, 0)));
                CenterToScreen();

                version_lbl.Location = Point.Subtract(version_lbl.Location, new Size(251, 0));
            }

            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(section_uc);
            section_uc.Location = new Point(5, 5);
        }

        private void btn_group_Click(object sender, EventArgs e)
        {
            btn_info.FillColor = Color.FromArgb(0, 174, 219);
            btn_dashboard.FillColor = Color.FromArgb(0, 174, 219);
            btn_section.FillColor = Color.FromArgb(0, 174, 219);
            btn_group.FillColor = Color.FromArgb(0, 192, 0);
            btn_student.FillColor = Color.FromArgb(0, 174, 219);
            btn_subject.FillColor = Color.FromArgb(0, 174, 219);
            btn_section_subject.FillColor = Color.FromArgb(0, 174, 219);
            btn_options.FillColor = Color.FromArgb(0, 174, 219);

            if (main_panel.Controls.Contains(student_uc))
            {
                this.Size = new Size(Point.Subtract(new Point(this.Size), new Size(251, 0)));
                CenterToScreen();

                version_lbl.Location = Point.Subtract(version_lbl.Location, new Size(251, 0));
            }

            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(group_uc);
            group_uc.Location = new Point(5, 5);
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            btn_info.FillColor = Color.FromArgb(0, 174, 219);
            btn_dashboard.FillColor = Color.FromArgb(0, 174, 219);
            btn_section.FillColor = Color.FromArgb(0, 174, 219);
            btn_group.FillColor = Color.FromArgb(0, 174, 219);
            btn_student.FillColor = Color.FromArgb(0, 192, 0);
            btn_subject.FillColor = Color.FromArgb(0, 174, 219);
            btn_section_subject.FillColor = Color.FromArgb(0, 174, 219);
            btn_options.FillColor = Color.FromArgb(0, 174, 219);

            if (!main_panel.Controls.Contains(student_uc))
            {
                this.Size=new Size(Point.Add(new Point(this.Size),new Size(251,0)));
                CenterToScreen();

                version_lbl.Location = Point.Add(version_lbl.Location, new Size(251, 0));
            }

            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(student_uc);
            student_uc.Location = new Point(5, 5);
        }

        private void btn_subject_Click(object sender, EventArgs e)
        {
            btn_info.FillColor = Color.FromArgb(0, 174, 219);
            btn_dashboard.FillColor = Color.FromArgb(0, 174, 219);
            btn_section.FillColor = Color.FromArgb(0, 174, 219);
            btn_group.FillColor = Color.FromArgb(0, 174, 219);
            btn_student.FillColor = Color.FromArgb(0, 174, 219);
            btn_subject.FillColor = Color.FromArgb(0, 192, 0);
            btn_section_subject.FillColor = Color.FromArgb(0, 174, 219);
            btn_options.FillColor = Color.FromArgb(0, 174, 219);

            if (main_panel.Controls.Contains(student_uc))
            {
                this.Size = new Size(Point.Subtract(new Point(this.Size), new Size(251, 0)));
                CenterToScreen();

                version_lbl.Location = Point.Subtract(version_lbl.Location, new Size(251, 0));
            }

            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(subject_uc);
            subject_uc.Location = new Point(5, 5);
        }

        private void btn_section_subject_Click(object sender, EventArgs e)
        {
            btn_info.FillColor = Color.FromArgb(0, 174, 219);
            btn_dashboard.FillColor = Color.FromArgb(0, 174, 219);
            btn_section.FillColor = Color.FromArgb(0, 174, 219);
            btn_group.FillColor = Color.FromArgb(0, 174, 219);
            btn_student.FillColor = Color.FromArgb(0, 174, 219);
            btn_subject.FillColor = Color.FromArgb(0, 174, 219);
            btn_section_subject.FillColor = Color.FromArgb(0, 192, 0);
            btn_options.FillColor = Color.FromArgb(0, 174, 219);

            if (main_panel.Controls.Contains(student_uc))
            {
                this.Size = new Size(Point.Subtract(new Point(this.Size), new Size(251, 0)));
                CenterToScreen();

                version_lbl.Location = Point.Subtract(version_lbl.Location, new Size(251, 0));
            }

            this.main_panel.Controls.Clear();
            this.main_panel.Controls.Add(subject_in_section_uc);
            subject_in_section_uc.Location = new Point(5, 5);
        }

        private void btn_options_Click(object sender, EventArgs e)
        {
            btn_info.FillColor = Color.FromArgb(0, 174, 219);
            btn_dashboard.FillColor = Color.FromArgb(0, 174, 219);
            btn_section.FillColor = Color.FromArgb(0, 174, 219);
            btn_group.FillColor = Color.FromArgb(0, 174, 219);
            btn_student.FillColor = Color.FromArgb(0, 174, 219);
            btn_subject.FillColor = Color.FromArgb(0, 174, 219);
            btn_section_subject.FillColor = Color.FromArgb(0, 174, 219);
            btn_options.FillColor = Color.FromArgb(0, 192, 0);

            if (main_panel.Controls.Contains(student_uc))
            {
                this.Size = new Size(Point.Subtract(new Point(this.Size), new Size(251, 0)));
                CenterToScreen();

                version_lbl.Location = Point.Subtract(version_lbl.Location, new Size(251, 0));
            }

            this.main_panel.Controls.Clear();
            options_uc options_uc = new options_uc();
            this.main_panel.Controls.Add(options_uc);
            options_uc.Location = new Point(5, 5);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_name.Text = full_name;

            if (go_to_section == true)
            {
                btn_section_Click(sender, e);
                go_to_section = false;
            }
            else if (go_to_group == true)
            {
                btn_group_Click(sender, e);
                go_to_group = false;
            }
            else if (go_to_student == true)
            {
                btn_student_Click(sender, e);
                go_to_student = false;
            }
            else if (go_to_subject == true)
            {
                btn_subject_Click(sender, e);
                go_to_subject = false;
            }
            else if (go_to_options == true)
            {
                btn_options_Click(sender,e);
                go_to_options = false;
            }
            else if (go_to_manage == true)
            {
                main_panel.Controls.Clear();
                main_panel.Controls.Add(manage_uc);
                manage_uc.Location = new Point(5, 5);
                go_to_manage = false;
            }
            else if (go_to_backup == true)
            {
                main_panel.Controls.Clear();
                main_panel.Controls.Add(backup_uc);
                backup_uc.Location = new Point(5, 5);
                go_to_backup = false;
            }
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            this.Close();
            connect_form.Show();
        }
    }
}

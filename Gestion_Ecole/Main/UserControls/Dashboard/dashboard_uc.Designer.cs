namespace Gestion_Ecole.Main.UserControls
{
    partial class dashboard_uc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.section_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.go_to_section = new MetroFramework.Controls.MetroLink();
            this.nbr_sec = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.student_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.go_to_student = new MetroFramework.Controls.MetroLink();
            this.nbr_std = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.group_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.go_to_group = new MetroFramework.Controls.MetroLink();
            this.nbr_grp = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.subject_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.go_to_subject = new MetroFramework.Controls.MetroLink();
            this.nbr_sbj = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.section_panel.SuspendLayout();
            this.student_panel.SuspendLayout();
            this.group_panel.SuspendLayout();
            this.subject_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(239, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 25);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "Dashboard";
            // 
            // section_panel
            // 
            this.section_panel.BackColor = System.Drawing.Color.Transparent;
            this.section_panel.BorderColor = System.Drawing.Color.Black;
            this.section_panel.BorderRadius = 25;
            this.section_panel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.section_panel.BorderThickness = 9;
            this.section_panel.Controls.Add(this.go_to_section);
            this.section_panel.Controls.Add(this.nbr_sec);
            this.section_panel.Controls.Add(this.metroLabel2);
            this.section_panel.Location = new System.Drawing.Point(68, 92);
            this.section_panel.Name = "section_panel";
            this.section_panel.ShadowDecoration.Parent = this.section_panel;
            this.section_panel.Size = new System.Drawing.Size(193, 183);
            this.section_panel.TabIndex = 0;
            // 
            // go_to_section
            // 
            this.go_to_section.Location = new System.Drawing.Point(21, 124);
            this.go_to_section.Name = "go_to_section";
            this.go_to_section.Size = new System.Drawing.Size(150, 23);
            this.go_to_section.TabIndex = 5;
            this.go_to_section.Text = "Go to Sections >>";
            this.go_to_section.UseSelectable = true;
            this.go_to_section.Click += new System.EventHandler(this.go_to_section_Click);
            // 
            // nbr_sec
            // 
            this.nbr_sec.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.nbr_sec.Location = new System.Drawing.Point(10, 82);
            this.nbr_sec.Name = "nbr_sec";
            this.nbr_sec.Size = new System.Drawing.Size(173, 19);
            this.nbr_sec.TabIndex = 3;
            this.nbr_sec.Text = "<nbr_sec>";
            this.nbr_sec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(22, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(149, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Number of Sections :";
            // 
            // student_panel
            // 
            this.student_panel.BackColor = System.Drawing.Color.Transparent;
            this.student_panel.BorderColor = System.Drawing.Color.Black;
            this.student_panel.BorderRadius = 25;
            this.student_panel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.student_panel.BorderThickness = 9;
            this.student_panel.Controls.Add(this.go_to_student);
            this.student_panel.Controls.Add(this.nbr_std);
            this.student_panel.Controls.Add(this.metroLabel4);
            this.student_panel.Location = new System.Drawing.Point(68, 332);
            this.student_panel.Name = "student_panel";
            this.student_panel.ShadowDecoration.Parent = this.student_panel;
            this.student_panel.Size = new System.Drawing.Size(193, 183);
            this.student_panel.TabIndex = 1;
            // 
            // go_to_student
            // 
            this.go_to_student.Location = new System.Drawing.Point(21, 124);
            this.go_to_student.Name = "go_to_student";
            this.go_to_student.Size = new System.Drawing.Size(150, 23);
            this.go_to_student.TabIndex = 6;
            this.go_to_student.Text = "Go to Students >>";
            this.go_to_student.UseSelectable = true;
            this.go_to_student.Click += new System.EventHandler(this.go_to_student_Click);
            // 
            // nbr_std
            // 
            this.nbr_std.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.nbr_std.Location = new System.Drawing.Point(10, 82);
            this.nbr_std.Name = "nbr_std";
            this.nbr_std.Size = new System.Drawing.Size(173, 19);
            this.nbr_std.TabIndex = 4;
            this.nbr_std.Text = "<nbr_std>";
            this.nbr_std.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(21, 40);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(151, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Number of Students :";
            // 
            // group_panel
            // 
            this.group_panel.BackColor = System.Drawing.Color.Transparent;
            this.group_panel.BorderColor = System.Drawing.Color.Black;
            this.group_panel.BorderRadius = 25;
            this.group_panel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.group_panel.BorderThickness = 9;
            this.group_panel.Controls.Add(this.go_to_group);
            this.group_panel.Controls.Add(this.nbr_grp);
            this.group_panel.Controls.Add(this.metroLabel3);
            this.group_panel.Location = new System.Drawing.Point(318, 92);
            this.group_panel.Name = "group_panel";
            this.group_panel.ShadowDecoration.Parent = this.group_panel;
            this.group_panel.Size = new System.Drawing.Size(193, 183);
            this.group_panel.TabIndex = 1;
            // 
            // go_to_group
            // 
            this.go_to_group.Location = new System.Drawing.Point(21, 124);
            this.go_to_group.Name = "go_to_group";
            this.go_to_group.Size = new System.Drawing.Size(150, 23);
            this.go_to_group.TabIndex = 7;
            this.go_to_group.Text = "Go to Groups >>";
            this.go_to_group.UseSelectable = true;
            this.go_to_group.Click += new System.EventHandler(this.go_to_group_Click);
            // 
            // nbr_grp
            // 
            this.nbr_grp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.nbr_grp.Location = new System.Drawing.Point(10, 82);
            this.nbr_grp.Name = "nbr_grp";
            this.nbr_grp.Size = new System.Drawing.Size(173, 19);
            this.nbr_grp.TabIndex = 5;
            this.nbr_grp.Text = "<nbr_grp>";
            this.nbr_grp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(25, 40);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(142, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Number of Groups :";
            // 
            // subject_panel
            // 
            this.subject_panel.BackColor = System.Drawing.Color.Transparent;
            this.subject_panel.BorderColor = System.Drawing.Color.Black;
            this.subject_panel.BorderRadius = 25;
            this.subject_panel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.subject_panel.BorderThickness = 9;
            this.subject_panel.Controls.Add(this.go_to_subject);
            this.subject_panel.Controls.Add(this.nbr_sbj);
            this.subject_panel.Controls.Add(this.metroLabel5);
            this.subject_panel.Location = new System.Drawing.Point(318, 332);
            this.subject_panel.Name = "subject_panel";
            this.subject_panel.ShadowDecoration.Parent = this.subject_panel;
            this.subject_panel.Size = new System.Drawing.Size(193, 183);
            this.subject_panel.TabIndex = 1;
            // 
            // go_to_subject
            // 
            this.go_to_subject.Location = new System.Drawing.Point(21, 124);
            this.go_to_subject.Name = "go_to_subject";
            this.go_to_subject.Size = new System.Drawing.Size(150, 23);
            this.go_to_subject.TabIndex = 7;
            this.go_to_subject.Text = "Go to Subjects >>";
            this.go_to_subject.UseSelectable = true;
            this.go_to_subject.Click += new System.EventHandler(this.go_to_subject_Click);
            // 
            // nbr_sbj
            // 
            this.nbr_sbj.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.nbr_sbj.Location = new System.Drawing.Point(10, 82);
            this.nbr_sbj.Name = "nbr_sbj";
            this.nbr_sbj.Size = new System.Drawing.Size(173, 19);
            this.nbr_sbj.TabIndex = 5;
            this.nbr_sbj.Text = "<nbr_sbj>";
            this.nbr_sbj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(22, 40);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(149, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Number of Subjects :";
            // 
            // dashboard_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.student_panel);
            this.Controls.Add(this.group_panel);
            this.Controls.Add(this.subject_panel);
            this.Controls.Add(this.section_panel);
            this.Controls.Add(this.metroLabel1);
            this.Name = "dashboard_uc";
            this.Size = new System.Drawing.Size(579, 549);
            this.Load += new System.EventHandler(this.dashboard_uc_Load);
            this.section_panel.ResumeLayout(false);
            this.section_panel.PerformLayout();
            this.student_panel.ResumeLayout(false);
            this.student_panel.PerformLayout();
            this.group_panel.ResumeLayout(false);
            this.group_panel.PerformLayout();
            this.subject_panel.ResumeLayout(false);
            this.subject_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Guna.UI2.WinForms.Guna2Panel section_panel;
        private Guna.UI2.WinForms.Guna2Panel student_panel;
        private Guna.UI2.WinForms.Guna2Panel group_panel;
        private Guna.UI2.WinForms.Guna2Panel subject_panel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel nbr_sec;
        private MetroFramework.Controls.MetroLabel nbr_std;
        private MetroFramework.Controls.MetroLabel nbr_grp;
        private MetroFramework.Controls.MetroLabel nbr_sbj;
        private MetroFramework.Controls.MetroLink go_to_section;
        private MetroFramework.Controls.MetroLink go_to_student;
        private MetroFramework.Controls.MetroLink go_to_group;
        private MetroFramework.Controls.MetroLink go_to_subject;
    }
}

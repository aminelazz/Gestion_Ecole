namespace Gestion_Ecole.Main.UserControls.Subject_In_Section
{
    partial class subject_in_section_uc
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
            this.components = new System.ComponentModel.Container();
            this.refresh_timer = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.section_subject_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.show_subject_in_section1 = new Gestion_Ecole.Main.UserControls.Subject_In_Section.show_subject_in_section();
            this.add_refresh_panel = new System.Windows.Forms.Panel();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.add = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.search_by = new Guna.UI2.WinForms.Guna2ComboBox();
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            this.check_user_type_timer = new System.Windows.Forms.Timer(this.components);
            this.section_subject_panel.SuspendLayout();
            this.add_refresh_panel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // refresh_timer
            // 
            this.refresh_timer.Tick += new System.EventHandler(this.refresh_timer_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(205, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(168, 25);
            this.metroLabel1.TabIndex = 46;
            this.metroLabel1.Text = "Sections && Subjects";
            // 
            // section_subject_panel
            // 
            this.section_subject_panel.AutoScroll = true;
            this.section_subject_panel.Controls.Add(this.show_subject_in_section1);
            this.section_subject_panel.Controls.Add(this.add_refresh_panel);
            this.section_subject_panel.Location = new System.Drawing.Point(48, 182);
            this.section_subject_panel.Name = "section_subject_panel";
            this.section_subject_panel.Size = new System.Drawing.Size(483, 276);
            this.section_subject_panel.TabIndex = 49;
            // 
            // show_subject_in_section1
            // 
            this.show_subject_in_section1.Location = new System.Drawing.Point(0, 0);
            this.show_subject_in_section1.Margin = new System.Windows.Forms.Padding(0);
            this.show_subject_in_section1.Name = "show_subject_in_section1";
            this.show_subject_in_section1.Size = new System.Drawing.Size(460, 27);
            this.show_subject_in_section1.TabIndex = 2;
            this.show_subject_in_section1.UseSelectable = true;
            // 
            // add_refresh_panel
            // 
            this.add_refresh_panel.Controls.Add(this.btn_refresh);
            this.add_refresh_panel.Controls.Add(this.add);
            this.add_refresh_panel.Location = new System.Drawing.Point(0, 27);
            this.add_refresh_panel.Margin = new System.Windows.Forms.Padding(0);
            this.add_refresh_panel.Name = "add_refresh_panel";
            this.add_refresh_panel.Size = new System.Drawing.Size(460, 84);
            this.add_refresh_panel.TabIndex = 1;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Animated = true;
            this.btn_refresh.AutoRoundedCorners = true;
            this.btn_refresh.BorderRadius = 14;
            this.btn_refresh.CheckedState.Parent = this.btn_refresh;
            this.btn_refresh.CustomImages.Parent = this.btn_refresh;
            this.btn_refresh.FillColor = System.Drawing.Color.Teal;
            this.btn_refresh.Font = new System.Drawing.Font("Open Sans", 9F);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.HoverState.Parent = this.btn_refresh;
            this.btn_refresh.Location = new System.Drawing.Point(132, 45);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.ShadowDecoration.Parent = this.btn_refresh;
            this.btn_refresh.Size = new System.Drawing.Size(224, 31);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // add
            // 
            this.add.Animated = true;
            this.add.AutoRoundedCorners = true;
            this.add.BorderRadius = 14;
            this.add.CheckedState.Parent = this.add;
            this.add.CustomImages.Parent = this.add;
            this.add.FillColor = System.Drawing.Color.LimeGreen;
            this.add.Font = new System.Drawing.Font("Open Sans", 9F);
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.HoverState.Parent = this.add;
            this.add.Location = new System.Drawing.Point(132, 8);
            this.add.Name = "add";
            this.add.ShadowDecoration.Parent = this.add;
            this.add.Size = new System.Drawing.Size(224, 31);
            this.add.TabIndex = 6;
            this.add.Text = "Add New Section && Subject";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Panel1.Location = new System.Drawing.Point(48, 159);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(483, 23);
            this.guna2Panel1.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(196, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Subject ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(281, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Subject Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Section Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Section ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(406, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Actions";
            // 
            // search_by
            // 
            this.search_by.Animated = true;
            this.search_by.BackColor = System.Drawing.Color.Transparent;
            this.search_by.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.search_by.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_by.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_by.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_by.FocusedState.Parent = this.search_by;
            this.search_by.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.search_by.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.search_by.HoverState.Parent = this.search_by;
            this.search_by.ItemHeight = 30;
            this.search_by.Items.AddRange(new object[] {
            "Section  ID",
            "Section  Name",
            "Subject  ID",
            "Subject  Name"});
            this.search_by.ItemsAppearance.Parent = this.search_by;
            this.search_by.Location = new System.Drawing.Point(119, 90);
            this.search_by.Margin = new System.Windows.Forms.Padding(0);
            this.search_by.Name = "search_by";
            this.search_by.ShadowDecoration.Parent = this.search_by;
            this.search_by.Size = new System.Drawing.Size(140, 36);
            this.search_by.StartIndex = 0;
            this.search_by.TabIndex = 52;
            this.search_by.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // search
            // 
            this.search.Animated = true;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.DefaultText = "";
            this.search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.DisabledState.Parent = this.search;
            this.search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.FocusedState.Parent = this.search;
            this.search.Font = new System.Drawing.Font("Open Sans", 9F);
            this.search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search.HoverState.Parent = this.search;
            this.search.Location = new System.Drawing.Point(259, 90);
            this.search.Margin = new System.Windows.Forms.Padding(0);
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.PlaceholderText = "Search...";
            this.search.SelectedText = "";
            this.search.ShadowDecoration.Parent = this.search;
            this.search.Size = new System.Drawing.Size(200, 36);
            this.search.TabIndex = 51;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_KeyPress);
            // 
            // check_user_type_timer
            // 
            this.check_user_type_timer.Interval = 1;
            this.check_user_type_timer.Tick += new System.EventHandler(this.check_user_type_timer_Tick);
            // 
            // subject_in_section_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.search_by);
            this.Controls.Add(this.search);
            this.Controls.Add(this.section_subject_panel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "subject_in_section_uc";
            this.Size = new System.Drawing.Size(579, 549);
            this.Load += new System.EventHandler(this.subject_in_section_uc_Load);
            this.section_subject_panel.ResumeLayout(false);
            this.add_refresh_panel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer refresh_timer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FlowLayoutPanel section_subject_panel;
        private show_subject_in_section show_subject_in_section1;
        private System.Windows.Forms.Panel add_refresh_panel;
        private Guna.UI2.WinForms.Guna2Button btn_refresh;
        private Guna.UI2.WinForms.Guna2Button add;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox search_by;
        private Guna.UI2.WinForms.Guna2TextBox search;
        private System.Windows.Forms.Timer check_user_type_timer;
    }
}

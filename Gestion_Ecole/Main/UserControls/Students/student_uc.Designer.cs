namespace Gestion_Ecole.Main.UserControls
{
    partial class student_uc
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.search_by = new Guna.UI2.WinForms.Guna2ComboBox();
            this.search = new Guna.UI2.WinForms.Guna2TextBox();
            this.student_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.header_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.show_student1 = new Gestion_Ecole.show_student();
            this.add_refresh_panel = new System.Windows.Forms.Panel();
            this.add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.refresh_timer = new System.Windows.Forms.Timer(this.components);
            this.check_user_type_timer = new System.Windows.Forms.Timer(this.components);
            this.student_panel.SuspendLayout();
            this.header_panel.SuspendLayout();
            this.add_refresh_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(373, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 25);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "Students";
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
            "ID",
            "Name",
            "Group Name",
            "Section Name"});
            this.search_by.ItemsAppearance.Parent = this.search_by;
            this.search_by.Location = new System.Drawing.Point(246, 90);
            this.search_by.Margin = new System.Windows.Forms.Padding(0);
            this.search_by.Name = "search_by";
            this.search_by.ShadowDecoration.Parent = this.search_by;
            this.search_by.Size = new System.Drawing.Size(136, 36);
            this.search_by.StartIndex = 0;
            this.search_by.TabIndex = 44;
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
            this.search.Location = new System.Drawing.Point(382, 90);
            this.search.Margin = new System.Windows.Forms.Padding(0);
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.PlaceholderText = "Search...";
            this.search.SelectedText = "";
            this.search.ShadowDecoration.Parent = this.search;
            this.search.Size = new System.Drawing.Size(200, 36);
            this.search.TabIndex = 43;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_KeyPress);
            // 
            // student_panel
            // 
            this.student_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.student_panel.AutoScroll = true;
            this.student_panel.Controls.Add(this.header_panel);
            this.student_panel.Controls.Add(this.show_student1);
            this.student_panel.Controls.Add(this.add_refresh_panel);
            this.student_panel.Location = new System.Drawing.Point(37, 159);
            this.student_panel.Name = "student_panel";
            this.student_panel.Size = new System.Drawing.Size(756, 299);
            this.student_panel.TabIndex = 46;
            // 
            // header_panel
            // 
            this.header_panel.BorderRadius = 5;
            this.header_panel.Controls.Add(this.label6);
            this.header_panel.Controls.Add(this.label5);
            this.header_panel.Controls.Add(this.label4);
            this.header_panel.Controls.Add(this.label2);
            this.header_panel.Controls.Add(this.label3);
            this.header_panel.Controls.Add(this.label1);
            this.header_panel.FillColor = System.Drawing.SystemColors.Highlight;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Margin = new System.Windows.Forms.Padding(0);
            this.header_panel.Name = "header_panel";
            this.header_panel.ShadowDecoration.Parent = this.header_panel;
            this.header_panel.Size = new System.Drawing.Size(733, 23);
            this.header_panel.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(530, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(385, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Section Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(240, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Group Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(118, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(652, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Actions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // show_student1
            // 
            this.show_student1.Location = new System.Drawing.Point(0, 23);
            this.show_student1.Margin = new System.Windows.Forms.Padding(0);
            this.show_student1.Name = "show_student1";
            this.show_student1.Size = new System.Drawing.Size(733, 27);
            this.show_student1.TabIndex = 49;
            this.show_student1.UseSelectable = true;
            // 
            // add_refresh_panel
            // 
            this.add_refresh_panel.Controls.Add(this.add);
            this.add_refresh_panel.Controls.Add(this.btn_refresh);
            this.add_refresh_panel.Location = new System.Drawing.Point(0, 50);
            this.add_refresh_panel.Margin = new System.Windows.Forms.Padding(0);
            this.add_refresh_panel.Name = "add_refresh_panel";
            this.add_refresh_panel.Size = new System.Drawing.Size(733, 84);
            this.add_refresh_panel.TabIndex = 1;
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add.Animated = true;
            this.add.AutoRoundedCorners = true;
            this.add.BorderRadius = 14;
            this.add.CheckedState.Parent = this.add;
            this.add.CustomImages.Parent = this.add;
            this.add.FillColor = System.Drawing.Color.LimeGreen;
            this.add.Font = new System.Drawing.Font("Open Sans", 9F);
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.HoverState.Parent = this.add;
            this.add.Location = new System.Drawing.Point(161, 8);
            this.add.Name = "add";
            this.add.ShadowDecoration.Parent = this.add;
            this.add.Size = new System.Drawing.Size(411, 31);
            this.add.TabIndex = 4;
            this.add.Text = "Add New Student";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Animated = true;
            this.btn_refresh.AutoRoundedCorners = true;
            this.btn_refresh.BorderRadius = 14;
            this.btn_refresh.CheckedState.Parent = this.btn_refresh;
            this.btn_refresh.CustomImages.Parent = this.btn_refresh;
            this.btn_refresh.FillColor = System.Drawing.Color.Teal;
            this.btn_refresh.Font = new System.Drawing.Font("Open Sans", 9F);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.HoverState.Parent = this.btn_refresh;
            this.btn_refresh.Location = new System.Drawing.Point(161, 45);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.ShadowDecoration.Parent = this.btn_refresh;
            this.btn_refresh.Size = new System.Drawing.Size(411, 31);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // refresh_timer
            // 
            this.refresh_timer.Interval = 1;
            this.refresh_timer.Tick += new System.EventHandler(this.refresh_timer_Tick);
            // 
            // check_user_type_timer
            // 
            this.check_user_type_timer.Interval = 1;
            this.check_user_type_timer.Tick += new System.EventHandler(this.check_user_type_timer_Tick);
            // 
            // student_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.student_panel);
            this.Controls.Add(this.search_by);
            this.Controls.Add(this.search);
            this.Controls.Add(this.metroLabel1);
            this.Name = "student_uc";
            this.Size = new System.Drawing.Size(830, 549);
            this.Load += new System.EventHandler(this.student_uc_Load);
            this.student_panel.ResumeLayout(false);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.add_refresh_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox search_by;
        private Guna.UI2.WinForms.Guna2TextBox search;
        private System.Windows.Forms.FlowLayoutPanel student_panel;
        private System.Windows.Forms.Panel add_refresh_panel;
        private Guna.UI2.WinForms.Guna2Button btn_refresh;
        private Guna.UI2.WinForms.Guna2Panel header_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private show_student show_student1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button add;
        private System.Windows.Forms.Timer refresh_timer;
        private System.Windows.Forms.Timer check_user_type_timer;

    }
}

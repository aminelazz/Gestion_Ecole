namespace Gestion_Ecole.Main.UserControls
{
    partial class infos_uc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infos_uc));
            this.lname_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.lname_slide_down = new System.Windows.Forms.PictureBox();
            this.btn_save_2 = new MetroFramework.Controls.MetroButton();
            this.new_last_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lbl_last_name = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lname_slide_up = new System.Windows.Forms.PictureBox();
            this.fname_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.fname_slide_down = new System.Windows.Forms.PictureBox();
            this.btn_save_1 = new MetroFramework.Controls.MetroButton();
            this.new_first_name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lbl_first_name = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.fname_slide_up = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.password_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.password_slide_down = new System.Windows.Forms.PictureBox();
            this.btn_save_3 = new MetroFramework.Controls.MetroButton();
            this.confirm_new_password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.new_password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.current_password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.password_slide_up = new System.Windows.Forms.PictureBox();
            this.username_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_username = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.user_type_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_user_type = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.timer_fname = new System.Windows.Forms.Timer(this.components);
            this.timer_lname = new System.Windows.Forms.Timer(this.components);
            this.timer_password = new System.Windows.Forms.Timer(this.components);
            this.lname_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lname_slide_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lname_slide_up)).BeginInit();
            this.fname_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fname_slide_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fname_slide_up)).BeginInit();
            this.password_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_slide_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_slide_up)).BeginInit();
            this.username_panel.SuspendLayout();
            this.user_type_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lname_panel
            // 
            this.lname_panel.BackColor = System.Drawing.Color.Transparent;
            this.lname_panel.BorderColor = System.Drawing.Color.Black;
            this.lname_panel.BorderRadius = 16;
            this.lname_panel.BorderThickness = 1;
            this.lname_panel.Controls.Add(this.lname_slide_down);
            this.lname_panel.Controls.Add(this.btn_save_2);
            this.lname_panel.Controls.Add(this.new_last_name);
            this.lname_panel.Controls.Add(this.metroLabel7);
            this.lname_panel.Controls.Add(this.lbl_last_name);
            this.lname_panel.Controls.Add(this.metroLabel3);
            this.lname_panel.Controls.Add(this.lname_slide_up);
            this.lname_panel.Location = new System.Drawing.Point(85, 163);
            this.lname_panel.Name = "lname_panel";
            this.lname_panel.ShadowDecoration.Parent = this.lname_panel;
            this.lname_panel.Size = new System.Drawing.Size(408, 77);
            this.lname_panel.TabIndex = 36;
            // 
            // lname_slide_down
            // 
            this.lname_slide_down.Image = ((System.Drawing.Image)(resources.GetObject("lname_slide_down.Image")));
            this.lname_slide_down.Location = new System.Drawing.Point(381, 7);
            this.lname_slide_down.Name = "lname_slide_down";
            this.lname_slide_down.Size = new System.Drawing.Size(20, 20);
            this.lname_slide_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lname_slide_down.TabIndex = 18;
            this.lname_slide_down.TabStop = false;
            this.lname_slide_down.Click += new System.EventHandler(this.lname_slide_down_Click);
            // 
            // btn_save_2
            // 
            this.btn_save_2.Location = new System.Drawing.Point(305, 42);
            this.btn_save_2.Name = "btn_save_2";
            this.btn_save_2.Size = new System.Drawing.Size(75, 23);
            this.btn_save_2.TabIndex = 24;
            this.btn_save_2.Text = "Save";
            this.btn_save_2.UseSelectable = true;
            this.btn_save_2.Click += new System.EventHandler(this.btn_save_2_Click);
            // 
            // new_last_name
            // 
            // 
            // 
            // 
            this.new_last_name.CustomButton.Image = null;
            this.new_last_name.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.new_last_name.CustomButton.Name = "";
            this.new_last_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.new_last_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.new_last_name.CustomButton.TabIndex = 1;
            this.new_last_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.new_last_name.CustomButton.UseSelectable = true;
            this.new_last_name.CustomButton.Visible = false;
            this.new_last_name.Lines = new string[0];
            this.new_last_name.Location = new System.Drawing.Point(186, 42);
            this.new_last_name.MaxLength = 20;
            this.new_last_name.Name = "new_last_name";
            this.new_last_name.PasswordChar = '\0';
            this.new_last_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.new_last_name.SelectedText = "";
            this.new_last_name.SelectionLength = 0;
            this.new_last_name.SelectionStart = 0;
            this.new_last_name.Size = new System.Drawing.Size(100, 23);
            this.new_last_name.TabIndex = 23;
            this.new_last_name.UseSelectable = true;
            this.new_last_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.new_last_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(55, 43);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(112, 19);
            this.metroLabel7.TabIndex = 22;
            this.metroLabel7.Text = "New Last Name :";
            // 
            // lbl_last_name
            // 
            this.lbl_last_name.Location = new System.Drawing.Point(195, 7);
            this.lbl_last_name.Name = "lbl_last_name";
            this.lbl_last_name.Size = new System.Drawing.Size(185, 19);
            this.lbl_last_name.TabIndex = 21;
            this.lbl_last_name.Text = "last_name";
            this.lbl_last_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(35, 7);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Last Name :";
            // 
            // lname_slide_up
            // 
            this.lname_slide_up.Image = ((System.Drawing.Image)(resources.GetObject("lname_slide_up.Image")));
            this.lname_slide_up.Location = new System.Drawing.Point(381, 7);
            this.lname_slide_up.Name = "lname_slide_up";
            this.lname_slide_up.Size = new System.Drawing.Size(20, 20);
            this.lname_slide_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lname_slide_up.TabIndex = 19;
            this.lname_slide_up.TabStop = false;
            this.lname_slide_up.Click += new System.EventHandler(this.lname_slide_up_Click);
            // 
            // fname_panel
            // 
            this.fname_panel.BackColor = System.Drawing.Color.Transparent;
            this.fname_panel.BorderColor = System.Drawing.Color.Black;
            this.fname_panel.BorderRadius = 16;
            this.fname_panel.BorderThickness = 1;
            this.fname_panel.Controls.Add(this.fname_slide_down);
            this.fname_panel.Controls.Add(this.btn_save_1);
            this.fname_panel.Controls.Add(this.new_first_name);
            this.fname_panel.Controls.Add(this.metroLabel6);
            this.fname_panel.Controls.Add(this.lbl_first_name);
            this.fname_panel.Controls.Add(this.metroLabel2);
            this.fname_panel.Controls.Add(this.fname_slide_up);
            this.fname_panel.Location = new System.Drawing.Point(85, 80);
            this.fname_panel.Name = "fname_panel";
            this.fname_panel.ShadowDecoration.Parent = this.fname_panel;
            this.fname_panel.Size = new System.Drawing.Size(408, 77);
            this.fname_panel.TabIndex = 35;
            // 
            // fname_slide_down
            // 
            this.fname_slide_down.Image = ((System.Drawing.Image)(resources.GetObject("fname_slide_down.Image")));
            this.fname_slide_down.Location = new System.Drawing.Point(381, 7);
            this.fname_slide_down.Name = "fname_slide_down";
            this.fname_slide_down.Size = new System.Drawing.Size(20, 20);
            this.fname_slide_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fname_slide_down.TabIndex = 17;
            this.fname_slide_down.TabStop = false;
            this.fname_slide_down.Click += new System.EventHandler(this.fname_slide_down_Click);
            // 
            // btn_save_1
            // 
            this.btn_save_1.Location = new System.Drawing.Point(305, 46);
            this.btn_save_1.Name = "btn_save_1";
            this.btn_save_1.Size = new System.Drawing.Size(75, 23);
            this.btn_save_1.TabIndex = 16;
            this.btn_save_1.Text = "Save";
            this.btn_save_1.UseSelectable = true;
            this.btn_save_1.Click += new System.EventHandler(this.btn_save_1_Click);
            // 
            // new_first_name
            // 
            // 
            // 
            // 
            this.new_first_name.CustomButton.Image = null;
            this.new_first_name.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.new_first_name.CustomButton.Name = "";
            this.new_first_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.new_first_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.new_first_name.CustomButton.TabIndex = 1;
            this.new_first_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.new_first_name.CustomButton.UseSelectable = true;
            this.new_first_name.CustomButton.Visible = false;
            this.new_first_name.Lines = new string[0];
            this.new_first_name.Location = new System.Drawing.Point(186, 46);
            this.new_first_name.MaxLength = 20;
            this.new_first_name.Name = "new_first_name";
            this.new_first_name.PasswordChar = '\0';
            this.new_first_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.new_first_name.SelectedText = "";
            this.new_first_name.SelectionLength = 0;
            this.new_first_name.SelectionStart = 0;
            this.new_first_name.Size = new System.Drawing.Size(100, 23);
            this.new_first_name.TabIndex = 15;
            this.new_first_name.UseSelectable = true;
            this.new_first_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.new_first_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(55, 47);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(113, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "New First Name :";
            // 
            // lbl_first_name
            // 
            this.lbl_first_name.Location = new System.Drawing.Point(195, 7);
            this.lbl_first_name.Name = "lbl_first_name";
            this.lbl_first_name.Size = new System.Drawing.Size(185, 19);
            this.lbl_first_name.TabIndex = 13;
            this.lbl_first_name.Text = "first_name";
            this.lbl_first_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(35, 7);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "First Name :";
            // 
            // fname_slide_up
            // 
            this.fname_slide_up.Image = ((System.Drawing.Image)(resources.GetObject("fname_slide_up.Image")));
            this.fname_slide_up.Location = new System.Drawing.Point(381, 7);
            this.fname_slide_up.Name = "fname_slide_up";
            this.fname_slide_up.Size = new System.Drawing.Size(20, 20);
            this.fname_slide_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fname_slide_up.TabIndex = 18;
            this.fname_slide_up.TabStop = false;
            this.fname_slide_up.Click += new System.EventHandler(this.fname_slide_up_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(241, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 25);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Welcome !";
            // 
            // password_panel
            // 
            this.password_panel.BackColor = System.Drawing.Color.Transparent;
            this.password_panel.BorderColor = System.Drawing.Color.Black;
            this.password_panel.BorderRadius = 16;
            this.password_panel.BorderThickness = 1;
            this.password_panel.Controls.Add(this.password_slide_down);
            this.password_panel.Controls.Add(this.btn_save_3);
            this.password_panel.Controls.Add(this.confirm_new_password);
            this.password_panel.Controls.Add(this.metroLabel11);
            this.password_panel.Controls.Add(this.new_password);
            this.password_panel.Controls.Add(this.metroLabel10);
            this.password_panel.Controls.Add(this.current_password);
            this.password_panel.Controls.Add(this.metroLabel9);
            this.password_panel.Controls.Add(this.metroLabel8);
            this.password_panel.Controls.Add(this.password_slide_up);
            this.password_panel.Location = new System.Drawing.Point(85, 286);
            this.password_panel.Name = "password_panel";
            this.password_panel.ShadowDecoration.Parent = this.password_panel;
            this.password_panel.Size = new System.Drawing.Size(408, 129);
            this.password_panel.TabIndex = 37;
            // 
            // password_slide_down
            // 
            this.password_slide_down.Image = ((System.Drawing.Image)(resources.GetObject("password_slide_down.Image")));
            this.password_slide_down.Location = new System.Drawing.Point(381, 7);
            this.password_slide_down.Name = "password_slide_down";
            this.password_slide_down.Size = new System.Drawing.Size(20, 20);
            this.password_slide_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.password_slide_down.TabIndex = 19;
            this.password_slide_down.TabStop = false;
            this.password_slide_down.Click += new System.EventHandler(this.password_slide_down_Click);
            // 
            // btn_save_3
            // 
            this.btn_save_3.Location = new System.Drawing.Point(305, 65);
            this.btn_save_3.Name = "btn_save_3";
            this.btn_save_3.Size = new System.Drawing.Size(75, 23);
            this.btn_save_3.TabIndex = 25;
            this.btn_save_3.Text = "Save";
            this.btn_save_3.UseSelectable = true;
            this.btn_save_3.Click += new System.EventHandler(this.btn_save_3_Click);
            // 
            // confirm_new_password
            // 
            // 
            // 
            // 
            this.confirm_new_password.CustomButton.Image = null;
            this.confirm_new_password.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.confirm_new_password.CustomButton.Name = "";
            this.confirm_new_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.confirm_new_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirm_new_password.CustomButton.TabIndex = 1;
            this.confirm_new_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirm_new_password.CustomButton.UseSelectable = true;
            this.confirm_new_password.CustomButton.Visible = false;
            this.confirm_new_password.Lines = new string[0];
            this.confirm_new_password.Location = new System.Drawing.Point(186, 91);
            this.confirm_new_password.MaxLength = 20;
            this.confirm_new_password.Name = "confirm_new_password";
            this.confirm_new_password.PasswordChar = '●';
            this.confirm_new_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirm_new_password.SelectedText = "";
            this.confirm_new_password.SelectionLength = 0;
            this.confirm_new_password.SelectionStart = 0;
            this.confirm_new_password.Size = new System.Drawing.Size(100, 23);
            this.confirm_new_password.TabIndex = 21;
            this.confirm_new_password.UseSelectable = true;
            this.confirm_new_password.UseSystemPasswordChar = true;
            this.confirm_new_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirm_new_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(11, 91);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(158, 19);
            this.metroLabel11.TabIndex = 20;
            this.metroLabel11.Text = "Confirm New Password :";
            // 
            // new_password
            // 
            // 
            // 
            // 
            this.new_password.CustomButton.Image = null;
            this.new_password.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.new_password.CustomButton.Name = "";
            this.new_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.new_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.new_password.CustomButton.TabIndex = 1;
            this.new_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.new_password.CustomButton.UseSelectable = true;
            this.new_password.CustomButton.Visible = false;
            this.new_password.Lines = new string[0];
            this.new_password.Location = new System.Drawing.Point(186, 65);
            this.new_password.MaxLength = 20;
            this.new_password.Name = "new_password";
            this.new_password.PasswordChar = '●';
            this.new_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.new_password.SelectedText = "";
            this.new_password.SelectionLength = 0;
            this.new_password.SelectionStart = 0;
            this.new_password.Size = new System.Drawing.Size(100, 23);
            this.new_password.TabIndex = 19;
            this.new_password.UseSelectable = true;
            this.new_password.UseSystemPasswordChar = true;
            this.new_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.new_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(64, 65);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(105, 19);
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "New Password :";
            // 
            // current_password
            // 
            // 
            // 
            // 
            this.current_password.CustomButton.Image = null;
            this.current_password.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.current_password.CustomButton.Name = "";
            this.current_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.current_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.current_password.CustomButton.TabIndex = 1;
            this.current_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.current_password.CustomButton.UseSelectable = true;
            this.current_password.CustomButton.Visible = false;
            this.current_password.Lines = new string[0];
            this.current_password.Location = new System.Drawing.Point(186, 39);
            this.current_password.MaxLength = 20;
            this.current_password.Name = "current_password";
            this.current_password.PasswordChar = '●';
            this.current_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.current_password.SelectedText = "";
            this.current_password.SelectionLength = 0;
            this.current_password.SelectionStart = 0;
            this.current_password.Size = new System.Drawing.Size(100, 23);
            this.current_password.TabIndex = 17;
            this.current_password.UseSelectable = true;
            this.current_password.UseSystemPasswordChar = true;
            this.current_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.current_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(44, 39);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(125, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Current Password :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(35, 7);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(121, 19);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Modify Password :";
            // 
            // password_slide_up
            // 
            this.password_slide_up.Image = ((System.Drawing.Image)(resources.GetObject("password_slide_up.Image")));
            this.password_slide_up.Location = new System.Drawing.Point(381, 7);
            this.password_slide_up.Name = "password_slide_up";
            this.password_slide_up.Size = new System.Drawing.Size(20, 20);
            this.password_slide_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.password_slide_up.TabIndex = 20;
            this.password_slide_up.TabStop = false;
            this.password_slide_up.Click += new System.EventHandler(this.password_slide_up_Click);
            // 
            // username_panel
            // 
            this.username_panel.BackColor = System.Drawing.Color.Transparent;
            this.username_panel.BorderColor = System.Drawing.Color.Black;
            this.username_panel.BorderRadius = 16;
            this.username_panel.BorderThickness = 1;
            this.username_panel.Controls.Add(this.lbl_username);
            this.username_panel.Controls.Add(this.metroLabel4);
            this.username_panel.Location = new System.Drawing.Point(85, 245);
            this.username_panel.Name = "username_panel";
            this.username_panel.ShadowDecoration.Parent = this.username_panel;
            this.username_panel.Size = new System.Drawing.Size(408, 35);
            this.username_panel.TabIndex = 38;
            // 
            // lbl_username
            // 
            this.lbl_username.Location = new System.Drawing.Point(195, 8);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(185, 19);
            this.lbl_username.TabIndex = 36;
            this.lbl_username.Text = "username";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(35, 8);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 35;
            this.metroLabel4.Text = "Username :";
            // 
            // user_type_panel
            // 
            this.user_type_panel.BackColor = System.Drawing.Color.Transparent;
            this.user_type_panel.BorderColor = System.Drawing.Color.Black;
            this.user_type_panel.BorderRadius = 16;
            this.user_type_panel.BorderThickness = 1;
            this.user_type_panel.Controls.Add(this.lbl_user_type);
            this.user_type_panel.Controls.Add(this.metroLabel5);
            this.user_type_panel.Location = new System.Drawing.Point(85, 421);
            this.user_type_panel.Name = "user_type_panel";
            this.user_type_panel.ShadowDecoration.Parent = this.user_type_panel;
            this.user_type_panel.Size = new System.Drawing.Size(408, 35);
            this.user_type_panel.TabIndex = 39;
            // 
            // lbl_user_type
            // 
            this.lbl_user_type.Location = new System.Drawing.Point(195, 8);
            this.lbl_user_type.Name = "lbl_user_type";
            this.lbl_user_type.Size = new System.Drawing.Size(185, 19);
            this.lbl_user_type.TabIndex = 35;
            this.lbl_user_type.Text = "user_type";
            this.lbl_user_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(35, 8);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(99, 19);
            this.metroLabel5.TabIndex = 34;
            this.metroLabel5.Text = "Account Type :";
            // 
            // timer_fname
            // 
            this.timer_fname.Interval = 1;
            this.timer_fname.Tick += new System.EventHandler(this.timer_fname_Tick);
            // 
            // timer_lname
            // 
            this.timer_lname.Interval = 1;
            this.timer_lname.Tick += new System.EventHandler(this.timer_lname_Tick);
            // 
            // timer_password
            // 
            this.timer_password.Interval = 1;
            this.timer_password.Tick += new System.EventHandler(this.timer_password_Tick);
            // 
            // infos_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fname_panel);
            this.Controls.Add(this.user_type_panel);
            this.Controls.Add(this.username_panel);
            this.Controls.Add(this.lname_panel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.password_panel);
            this.Name = "infos_uc";
            this.Size = new System.Drawing.Size(579, 549);
            this.Load += new System.EventHandler(this.infos_uc_Load);
            this.lname_panel.ResumeLayout(false);
            this.lname_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lname_slide_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lname_slide_up)).EndInit();
            this.fname_panel.ResumeLayout(false);
            this.fname_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fname_slide_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fname_slide_up)).EndInit();
            this.password_panel.ResumeLayout(false);
            this.password_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.password_slide_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_slide_up)).EndInit();
            this.username_panel.ResumeLayout(false);
            this.username_panel.PerformLayout();
            this.user_type_panel.ResumeLayout(false);
            this.user_type_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel lname_panel;
        private System.Windows.Forms.PictureBox lname_slide_down;
        private MetroFramework.Controls.MetroButton btn_save_2;
        private MetroFramework.Controls.MetroTextBox new_last_name;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lbl_last_name;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private Guna.UI2.WinForms.Guna2Panel fname_panel;
        private System.Windows.Forms.PictureBox fname_slide_down;
        private MetroFramework.Controls.MetroButton btn_save_1;
        private MetroFramework.Controls.MetroTextBox new_first_name;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lbl_first_name;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Guna.UI2.WinForms.Guna2Panel password_panel;
        private System.Windows.Forms.PictureBox password_slide_down;
        private MetroFramework.Controls.MetroButton btn_save_3;
        private MetroFramework.Controls.MetroTextBox confirm_new_password;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox new_password;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox current_password;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private Guna.UI2.WinForms.Guna2Panel username_panel;
        private MetroFramework.Controls.MetroLabel lbl_username;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private Guna.UI2.WinForms.Guna2Panel user_type_panel;
        private MetroFramework.Controls.MetroLabel lbl_user_type;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Timer timer_fname;
        private System.Windows.Forms.Timer timer_lname;
        private System.Windows.Forms.Timer timer_password;
        private System.Windows.Forms.PictureBox lname_slide_up;
        private System.Windows.Forms.PictureBox fname_slide_up;
        private System.Windows.Forms.PictureBox password_slide_up;

    }
}

namespace Gestion_Ecole
{
    partial class Register_form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_form));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.first_name = new MetroFramework.Controls.MetroTextBox();
            this.last_name = new MetroFramework.Controls.MetroTextBox();
            this.username = new MetroFramework.Controls.MetroTextBox();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.confirm_password = new MetroFramework.Controls.MetroTextBox();
            this.btn_register = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.user_type = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel1.Location = new System.Drawing.Point(76, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "First Name :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(78, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Last Name :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(81, 146);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Username :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(86, 173);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Password :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(34, 200);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(122, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Confirm Password :";
            // 
            // first_name
            // 
            // 
            // 
            // 
            this.first_name.CustomButton.Image = null;
            this.first_name.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.first_name.CustomButton.Name = "";
            this.first_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.first_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.first_name.CustomButton.TabIndex = 1;
            this.first_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.first_name.CustomButton.UseSelectable = true;
            this.first_name.CustomButton.Visible = false;
            this.first_name.Lines = new string[0];
            this.first_name.Location = new System.Drawing.Point(183, 88);
            this.first_name.MaxLength = 32767;
            this.first_name.Name = "first_name";
            this.first_name.PasswordChar = '\0';
            this.first_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.first_name.SelectedText = "";
            this.first_name.SelectionLength = 0;
            this.first_name.SelectionStart = 0;
            this.first_name.Size = new System.Drawing.Size(137, 23);
            this.first_name.TabIndex = 6;
            this.first_name.UseSelectable = true;
            this.first_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.first_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.first_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.first_name_KeyPress);
            // 
            // last_name
            // 
            // 
            // 
            // 
            this.last_name.CustomButton.Image = null;
            this.last_name.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.last_name.CustomButton.Name = "";
            this.last_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.last_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.last_name.CustomButton.TabIndex = 1;
            this.last_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.last_name.CustomButton.UseSelectable = true;
            this.last_name.CustomButton.Visible = false;
            this.last_name.Lines = new string[0];
            this.last_name.Location = new System.Drawing.Point(183, 116);
            this.last_name.MaxLength = 32767;
            this.last_name.Name = "last_name";
            this.last_name.PasswordChar = '\0';
            this.last_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.last_name.SelectedText = "";
            this.last_name.SelectionLength = 0;
            this.last_name.SelectionStart = 0;
            this.last_name.Size = new System.Drawing.Size(137, 23);
            this.last_name.TabIndex = 7;
            this.last_name.UseSelectable = true;
            this.last_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.last_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.last_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.last_name_KeyPress);
            // 
            // username
            // 
            // 
            // 
            // 
            this.username.CustomButton.Image = null;
            this.username.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.username.CustomButton.Name = "";
            this.username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.username.CustomButton.TabIndex = 1;
            this.username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.username.CustomButton.UseSelectable = true;
            this.username.CustomButton.Visible = false;
            this.username.Lines = new string[0];
            this.username.Location = new System.Drawing.Point(183, 144);
            this.username.MaxLength = 32767;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.Size = new System.Drawing.Size(137, 23);
            this.username.TabIndex = 8;
            this.username.UseSelectable = true;
            this.username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            // 
            // password
            // 
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(183, 172);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(137, 23);
            this.password.TabIndex = 9;
            this.password.UseSelectable = true;
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // confirm_password
            // 
            // 
            // 
            // 
            this.confirm_password.CustomButton.Image = null;
            this.confirm_password.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.confirm_password.CustomButton.Name = "";
            this.confirm_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.confirm_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirm_password.CustomButton.TabIndex = 1;
            this.confirm_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirm_password.CustomButton.UseSelectable = true;
            this.confirm_password.CustomButton.Visible = false;
            this.confirm_password.Lines = new string[0];
            this.confirm_password.Location = new System.Drawing.Point(183, 200);
            this.confirm_password.MaxLength = 32767;
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.PasswordChar = '\0';
            this.confirm_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirm_password.SelectedText = "";
            this.confirm_password.SelectionLength = 0;
            this.confirm_password.SelectionStart = 0;
            this.confirm_password.Size = new System.Drawing.Size(137, 23);
            this.confirm_password.TabIndex = 10;
            this.confirm_password.UseSelectable = true;
            this.confirm_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.confirm_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.confirm_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirm_password_KeyPress);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(357, 264);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 12;
            this.btn_register.Text = "Register";
            this.btn_register.UseSelectable = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(83, 229);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(73, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "User Type :";
            // 
            // user_type
            // 
            this.user_type.FormattingEnabled = true;
            this.user_type.ItemHeight = 23;
            this.user_type.Location = new System.Drawing.Point(183, 226);
            this.user_type.Name = "user_type";
            this.user_type.Size = new System.Drawing.Size(136, 29);
            this.user_type.TabIndex = 14;
            this.user_type.UseSelectable = true;
            // 
            // Register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 310);
            this.Controls.Add(this.user_type);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.confirm_password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Register_form";
            this.Resizable = false;
            this.Text = "Create New Account";
            this.Load += new System.EventHandler(this.Register_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox first_name;
        private MetroFramework.Controls.MetroTextBox last_name;
        private MetroFramework.Controls.MetroTextBox confirm_password;
        private MetroFramework.Controls.MetroButton btn_register;
        private MetroFramework.Controls.MetroTextBox username;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox user_type;
    }
}
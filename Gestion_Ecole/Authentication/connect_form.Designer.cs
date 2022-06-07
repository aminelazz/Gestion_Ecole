namespace Gestion_Ecole
{
    partial class Connect_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect_form));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.username = new MetroFramework.Controls.MetroTextBox();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.forgot_password = new MetroFramework.Controls.MetroLink();
            this.eye_open = new System.Windows.Forms.PictureBox();
            this.eye_close = new System.Windows.Forms.PictureBox();
            this.close_off = new System.Windows.Forms.PictureBox();
            this.minimize_off = new System.Windows.Forms.PictureBox();
            this.close_on = new System.Windows.Forms.PictureBox();
            this.minimize_on = new System.Windows.Forms.PictureBox();
            this.btn_connect = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.eye_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_on)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_on)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(92, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(97, 123);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Password :";
            // 
            // username
            // 
            // 
            // 
            // 
            this.username.CustomButton.Image = null;
            this.username.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.username.CustomButton.Name = "";
            this.username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.username.CustomButton.TabIndex = 1;
            this.username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.username.CustomButton.UseSelectable = true;
            this.username.CustomButton.Visible = false;
            this.username.Lines = new string[0];
            this.username.Location = new System.Drawing.Point(185, 90);
            this.username.MaxLength = 32767;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.Size = new System.Drawing.Size(140, 23);
            this.username.TabIndex = 2;
            this.username.UseSelectable = true;
            this.username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            // 
            // password
            // 
            this.password.AccessibleDescription = "";
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(185, 123);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(140, 23);
            this.password.TabIndex = 3;
            this.password.UseSelectable = true;
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // forgot_password
            // 
            this.forgot_password.Location = new System.Drawing.Point(220, 147);
            this.forgot_password.Name = "forgot_password";
            this.forgot_password.Size = new System.Drawing.Size(108, 23);
            this.forgot_password.TabIndex = 6;
            this.forgot_password.Text = "Forgot Password ?";
            this.forgot_password.UseSelectable = true;
            this.forgot_password.Click += new System.EventHandler(this.forgot_password_Click);
            // 
            // eye_open
            // 
            this.eye_open.Image = ((System.Drawing.Image)(resources.GetObject("eye_open.Image")));
            this.eye_open.Location = new System.Drawing.Point(331, 123);
            this.eye_open.Name = "eye_open";
            this.eye_open.Size = new System.Drawing.Size(27, 23);
            this.eye_open.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eye_open.TabIndex = 7;
            this.eye_open.TabStop = false;
            this.eye_open.MouseLeave += new System.EventHandler(this.eye_open_MouseLeave);
            // 
            // eye_close
            // 
            this.eye_close.Image = ((System.Drawing.Image)(resources.GetObject("eye_close.Image")));
            this.eye_close.Location = new System.Drawing.Point(331, 123);
            this.eye_close.Name = "eye_close";
            this.eye_close.Size = new System.Drawing.Size(27, 23);
            this.eye_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eye_close.TabIndex = 8;
            this.eye_close.TabStop = false;
            this.eye_close.MouseHover += new System.EventHandler(this.eye_close_MouseHover);
            // 
            // close_off
            // 
            this.close_off.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.close_off.Image = ((System.Drawing.Image)(resources.GetObject("close_off.Image")));
            this.close_off.Location = new System.Drawing.Point(409, 16);
            this.close_off.Name = "close_off";
            this.close_off.Size = new System.Drawing.Size(15, 15);
            this.close_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_off.TabIndex = 11;
            this.close_off.TabStop = false;
            this.close_off.MouseHover += new System.EventHandler(this.close_off_MouseHover);
            // 
            // minimize_off
            // 
            this.minimize_off.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.minimize_off.Image = ((System.Drawing.Image)(resources.GetObject("minimize_off.Image")));
            this.minimize_off.Location = new System.Drawing.Point(370, 19);
            this.minimize_off.Name = "minimize_off";
            this.minimize_off.Size = new System.Drawing.Size(15, 15);
            this.minimize_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_off.TabIndex = 10;
            this.minimize_off.TabStop = false;
            this.minimize_off.MouseHover += new System.EventHandler(this.minimize_off_MouseHover);
            // 
            // close_on
            // 
            this.close_on.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.close_on.Image = ((System.Drawing.Image)(resources.GetObject("close_on.Image")));
            this.close_on.Location = new System.Drawing.Point(409, 16);
            this.close_on.Name = "close_on";
            this.close_on.Size = new System.Drawing.Size(15, 15);
            this.close_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_on.TabIndex = 12;
            this.close_on.TabStop = false;
            this.close_on.Click += new System.EventHandler(this.close_on_Click);
            this.close_on.MouseLeave += new System.EventHandler(this.close_on_MouseLeave);
            // 
            // minimize_on
            // 
            this.minimize_on.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.minimize_on.Image = ((System.Drawing.Image)(resources.GetObject("minimize_on.Image")));
            this.minimize_on.Location = new System.Drawing.Point(370, 19);
            this.minimize_on.Name = "minimize_on";
            this.minimize_on.Size = new System.Drawing.Size(15, 15);
            this.minimize_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_on.TabIndex = 13;
            this.minimize_on.TabStop = false;
            this.minimize_on.Click += new System.EventHandler(this.minimize_on_Click);
            this.minimize_on.MouseLeave += new System.EventHandler(this.minimize_on_MouseLeave);
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.Transparent;
            this.btn_connect.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_connect.BorderThickness = 1;
            this.btn_connect.CheckedState.Parent = this.btn_connect;
            this.btn_connect.CustomImages.Parent = this.btn_connect;
            this.btn_connect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_connect.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.btn_connect.ForeColor = System.Drawing.Color.Black;
            this.btn_connect.HoverState.Parent = this.btn_connect;
            this.btn_connect.Image = ((System.Drawing.Image)(resources.GetObject("btn_connect.Image")));
            this.btn_connect.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_connect.Location = new System.Drawing.Point(159, 182);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.ShadowDecoration.Parent = this.btn_connect;
            this.btn_connect.Size = new System.Drawing.Size(128, 33);
            this.btn_connect.TabIndex = 16;
            this.btn_connect.Text = "Connect";
            this.btn_connect.TextOffset = new System.Drawing.Point(5, 0);
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // Connect_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 235);
            this.ControlBox = false;
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.eye_close);
            this.Controls.Add(this.eye_open);
            this.Controls.Add(this.forgot_password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.close_off);
            this.Controls.Add(this.close_on);
            this.Controls.Add(this.minimize_off);
            this.Controls.Add(this.minimize_on);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Connect_form";
            this.Resizable = false;
            this.Text = "Authentication";
            this.Load += new System.EventHandler(this.Connect_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eye_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_on)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_on)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink forgot_password;
        private System.Windows.Forms.PictureBox eye_open;
        private System.Windows.Forms.PictureBox eye_close;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroTextBox username;
        private System.Windows.Forms.PictureBox close_off;
        private System.Windows.Forms.PictureBox minimize_off;
        private System.Windows.Forms.PictureBox close_on;
        private System.Windows.Forms.PictureBox minimize_on;
        private Guna.UI2.WinForms.Guna2Button btn_connect;

    }
}


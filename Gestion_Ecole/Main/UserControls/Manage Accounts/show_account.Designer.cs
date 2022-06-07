namespace Gestion_Ecole.Main.UserControls
{
    partial class show_account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_account));
            this.full_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.delete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ToolTip = new MetroFramework.Components.MetroToolTip();
            this.username_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // full_name
            // 
            this.full_name.Animated = true;
            this.full_name.AutoRoundedCorners = true;
            this.full_name.BorderColor = System.Drawing.Color.White;
            this.full_name.BorderRadius = 11;
            this.full_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.full_name.DefaultText = "Full Name";
            this.full_name.DisabledState.BorderColor = System.Drawing.Color.White;
            this.full_name.DisabledState.FillColor = System.Drawing.Color.White;
            this.full_name.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.full_name.DisabledState.Parent = this.full_name;
            this.full_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.full_name.Enabled = false;
            this.full_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.full_name.FocusedState.Parent = this.full_name;
            this.full_name.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_name.ForeColor = System.Drawing.Color.Black;
            this.full_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.full_name.HoverState.Parent = this.full_name;
            this.full_name.Location = new System.Drawing.Point(25, 1);
            this.full_name.Name = "full_name";
            this.full_name.PasswordChar = '\0';
            this.full_name.PlaceholderText = "ID Here...";
            this.full_name.SelectedText = "";
            this.full_name.ShadowDecoration.Parent = this.full_name;
            this.full_name.Size = new System.Drawing.Size(143, 24);
            this.full_name.TabIndex = 17;
            this.full_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // username
            // 
            this.username.Animated = true;
            this.username.AutoRoundedCorners = true;
            this.username.BorderColor = System.Drawing.Color.White;
            this.username.BorderRadius = 11;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "Username";
            this.username.DisabledState.BorderColor = System.Drawing.Color.White;
            this.username.DisabledState.FillColor = System.Drawing.Color.White;
            this.username.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.username.DisabledState.Parent = this.username;
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.username.Enabled = false;
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.FocusedState.Parent = this.username;
            this.username.Font = new System.Drawing.Font("Open Sans", 9F);
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.HoverState.Parent = this.username;
            this.username.Location = new System.Drawing.Point(183, 1);
            this.username.MaxLength = 20;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderText = "Name here...";
            this.username.SelectedText = "";
            this.username.ShadowDecoration.Parent = this.username;
            this.username.Size = new System.Drawing.Size(143, 24);
            this.username.TabIndex = 16;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delete
            // 
            this.delete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.delete.CheckedState.Parent = this.delete;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.HoverState.ImageSize = new System.Drawing.Size(21, 21);
            this.delete.HoverState.Parent = this.delete;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageRotate = 0F;
            this.delete.ImageSize = new System.Drawing.Size(21, 21);
            this.delete.Location = new System.Drawing.Point(355, 3);
            this.delete.Name = "delete";
            this.delete.PressedState.ImageSize = new System.Drawing.Size(21, 21);
            this.delete.PressedState.Parent = this.delete;
            this.delete.Size = new System.Drawing.Size(21, 21);
            this.delete.TabIndex = 15;
            this.ToolTip.SetToolTip(this.delete, "Delete");
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // ToolTip
            // 
            this.ToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.ToolTip.StyleManager = null;
            this.ToolTip.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // username_timer
            // 
            this.username_timer.Tick += new System.EventHandler(this.username_timer_Tick);
            // 
            // show_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.full_name);
            this.Controls.Add(this.username);
            this.Controls.Add(this.delete);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "show_account";
            this.Size = new System.Drawing.Size(403, 27);
            this.Load += new System.EventHandler(this.show_account_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroToolTip ToolTip;
        public Guna.UI2.WinForms.Guna2TextBox full_name;
        public Guna.UI2.WinForms.Guna2TextBox username;
        private System.Windows.Forms.Timer username_timer;
        public Guna.UI2.WinForms.Guna2ImageButton delete;
    }
}

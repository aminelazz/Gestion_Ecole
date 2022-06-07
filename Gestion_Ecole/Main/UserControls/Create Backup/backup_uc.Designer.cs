namespace Gestion_Ecole.Main.UserControls.Create_Backup
{
    partial class backup_uc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(backup_uc));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.browse = new Guna.UI2.WinForms.Guna2Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.path = new Guna.UI2.WinForms.Guna2TextBox();
            this.file_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.save = new Guna.UI2.WinForms.Guna2Button();
            this.go_back = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ToolTip = new MetroFramework.Components.MetroToolTip();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(227, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 25);
            this.metroLabel1.TabIndex = 58;
            this.metroLabel1.Text = "Create Backup";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.save);
            this.guna2Panel1.Controls.Add(this.metroLabel4);
            this.guna2Panel1.Controls.Add(this.metroLabel3);
            this.guna2Panel1.Controls.Add(this.browse);
            this.guna2Panel1.Controls.Add(this.metroLabel2);
            this.guna2Panel1.Controls.Add(this.path);
            this.guna2Panel1.Controls.Add(this.file_name);
            this.guna2Panel1.Location = new System.Drawing.Point(45, 197);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(489, 205);
            this.guna2Panel1.TabIndex = 60;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(57, 18);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 19);
            this.metroLabel4.TabIndex = 79;
            this.metroLabel4.Text = "File Name :";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 63);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(112, 19);
            this.metroLabel3.TabIndex = 78;
            this.metroLabel3.Text = "Folder Directory :";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // browse
            // 
            this.browse.CheckedState.Parent = this.browse;
            this.browse.CustomImages.Parent = this.browse;
            this.browse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.browse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.browse.ForeColor = System.Drawing.Color.White;
            this.browse.HoverState.Parent = this.browse;
            this.browse.Location = new System.Drawing.Point(346, 59);
            this.browse.Name = "browse";
            this.browse.ShadowDecoration.Parent = this.browse;
            this.browse.Size = new System.Drawing.Size(122, 27);
            this.browse.TabIndex = 77;
            this.browse.Text = "Browse";
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(243, 18);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(33, 19);
            this.metroLabel2.TabIndex = 76;
            this.metroLabel2.Text = ".bak";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // path
            // 
            this.path.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.path.DefaultText = "";
            this.path.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.path.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.path.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.path.DisabledState.Parent = this.path;
            this.path.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.path.Enabled = false;
            this.path.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.path.FocusedState.Parent = this.path;
            this.path.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.path.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.path.HoverState.Parent = this.path;
            this.path.Location = new System.Drawing.Point(139, 59);
            this.path.Name = "path";
            this.path.PasswordChar = '\0';
            this.path.PlaceholderText = "";
            this.path.SelectedText = "";
            this.path.ShadowDecoration.Parent = this.path;
            this.path.Size = new System.Drawing.Size(201, 27);
            this.path.TabIndex = 75;
            // 
            // file_name
            // 
            this.file_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.file_name.DefaultText = "";
            this.file_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.file_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.file_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.file_name.DisabledState.Parent = this.file_name;
            this.file_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.file_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.file_name.FocusedState.Parent = this.file_name;
            this.file_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.file_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.file_name.HoverState.Parent = this.file_name;
            this.file_name.Location = new System.Drawing.Point(139, 14);
            this.file_name.Name = "file_name";
            this.file_name.PasswordChar = '\0';
            this.file_name.PlaceholderText = "";
            this.file_name.SelectedText = "";
            this.file_name.ShadowDecoration.Parent = this.file_name;
            this.file_name.Size = new System.Drawing.Size(98, 27);
            this.file_name.TabIndex = 74;
            // 
            // save
            // 
            this.save.CheckedState.Parent = this.save;
            this.save.CustomImages.Parent = this.save;
            this.save.FillColor = System.Drawing.Color.LimeGreen;
            this.save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.HoverState.Parent = this.save;
            this.save.Location = new System.Drawing.Point(154, 127);
            this.save.Name = "save";
            this.save.ShadowDecoration.Parent = this.save;
            this.save.Size = new System.Drawing.Size(180, 45);
            this.save.TabIndex = 81;
            this.save.Text = "Save Backup File";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // go_back
            // 
            this.go_back.BackColor = System.Drawing.Color.Transparent;
            this.go_back.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.go_back.CheckedState.Parent = this.go_back;
            this.go_back.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image")));
            this.go_back.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.go_back.HoverState.Parent = this.go_back;
            this.go_back.Image = ((System.Drawing.Image)(resources.GetObject("go_back.Image")));
            this.go_back.ImageRotate = 0F;
            this.go_back.ImageSize = new System.Drawing.Size(40, 40);
            this.go_back.Location = new System.Drawing.Point(45, 18);
            this.go_back.Name = "go_back";
            this.go_back.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.PressedState.Image")));
            this.go_back.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.go_back.PressedState.Parent = this.go_back;
            this.go_back.Size = new System.Drawing.Size(40, 40);
            this.go_back.TabIndex = 62;
            this.ToolTip.SetToolTip(this.go_back, "Go Back");
            this.go_back.UseTransparentBackground = true;
            this.go_back.Click += new System.EventHandler(this.go_back_Click);
            // 
            // ToolTip
            // 
            this.ToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.ToolTip.StyleManager = null;
            this.ToolTip.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // backup_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.go_back);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "backup_uc";
            this.Size = new System.Drawing.Size(579, 549);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private Guna.UI2.WinForms.Guna2Button browse;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Guna.UI2.WinForms.Guna2TextBox path;
        private Guna.UI2.WinForms.Guna2TextBox file_name;
        private Guna.UI2.WinForms.Guna2Button save;
        private Guna.UI2.WinForms.Guna2ImageButton go_back;
        private MetroFramework.Components.MetroToolTip ToolTip;
    }
}

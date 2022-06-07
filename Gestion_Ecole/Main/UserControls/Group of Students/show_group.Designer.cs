namespace Gestion_Ecole.Main
{
    partial class show_group
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_group));
            this.modify = new Guna.UI2.WinForms.Guna2ImageButton();
            this.id = new Guna.UI2.WinForms.Guna2TextBox();
            this.new_section_name = new Guna.UI2.WinForms.Guna2ComboBox();
            this.name = new Guna.UI2.WinForms.Guna2TextBox();
            this.save = new Guna.UI2.WinForms.Guna2ImageButton();
            this.delete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.section_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.ToolTip = new MetroFramework.Components.MetroToolTip();
            this.user_type_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // modify
            // 
            this.modify.BackColor = System.Drawing.Color.Transparent;
            this.modify.CheckedState.Parent = this.modify;
            this.modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modify.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("modify.HoverState.Image")));
            this.modify.HoverState.ImageSize = new System.Drawing.Size(21, 21);
            this.modify.HoverState.Parent = this.modify;
            this.modify.Image = ((System.Drawing.Image)(resources.GetObject("modify.Image")));
            this.modify.ImageRotate = 0F;
            this.modify.ImageSize = new System.Drawing.Size(21, 21);
            this.modify.Location = new System.Drawing.Point(406, 3);
            this.modify.Name = "modify";
            this.modify.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("modify.PressedState.Image")));
            this.modify.PressedState.ImageSize = new System.Drawing.Size(21, 21);
            this.modify.PressedState.Parent = this.modify;
            this.modify.Size = new System.Drawing.Size(21, 21);
            this.modify.TabIndex = 1;
            this.ToolTip.SetToolTip(this.modify, "Modify");
            this.modify.UseTransparentBackground = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // id
            // 
            this.id.Animated = true;
            this.id.AutoRoundedCorners = true;
            this.id.BorderColor = System.Drawing.Color.White;
            this.id.BorderRadius = 11;
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.DefaultText = "ID";
            this.id.DisabledState.BorderColor = System.Drawing.Color.White;
            this.id.DisabledState.FillColor = System.Drawing.Color.White;
            this.id.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.id.DisabledState.Parent = this.id;
            this.id.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.id.Enabled = false;
            this.id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id.FocusedState.Parent = this.id;
            this.id.Font = new System.Drawing.Font("Open Sans", 9F);
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id.HoverState.Parent = this.id;
            this.id.Location = new System.Drawing.Point(17, 2);
            this.id.Name = "id";
            this.id.PasswordChar = '\0';
            this.id.PlaceholderText = "ID Here...";
            this.id.SelectedText = "";
            this.id.SelectionStart = 2;
            this.id.ShadowDecoration.Parent = this.id;
            this.id.Size = new System.Drawing.Size(51, 24);
            this.id.TabIndex = 8;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // new_section_name
            // 
            this.new_section_name.Animated = true;
            this.new_section_name.AutoRoundedCorners = true;
            this.new_section_name.BackColor = System.Drawing.Color.Transparent;
            this.new_section_name.BorderColor = System.Drawing.Color.White;
            this.new_section_name.BorderRadius = 11;
            this.new_section_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.new_section_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.new_section_name.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.new_section_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.new_section_name.FocusedState.Parent = this.new_section_name;
            this.new_section_name.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.new_section_name.ForeColor = System.Drawing.Color.Black;
            this.new_section_name.HoverState.Parent = this.new_section_name;
            this.new_section_name.ItemHeight = 18;
            this.new_section_name.ItemsAppearance.Parent = this.new_section_name;
            this.new_section_name.Location = new System.Drawing.Point(223, 1);
            this.new_section_name.Margin = new System.Windows.Forms.Padding(0);
            this.new_section_name.Name = "new_section_name";
            this.new_section_name.ShadowDecoration.Parent = this.new_section_name;
            this.new_section_name.Size = new System.Drawing.Size(156, 24);
            this.new_section_name.TabIndex = 9;
            this.new_section_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name
            // 
            this.name.Animated = true;
            this.name.AutoRoundedCorners = true;
            this.name.BorderColor = System.Drawing.Color.White;
            this.name.BorderRadius = 11;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.DefaultText = "Name";
            this.name.DisabledState.BorderColor = System.Drawing.Color.White;
            this.name.DisabledState.FillColor = System.Drawing.Color.White;
            this.name.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.name.DisabledState.Parent = this.name;
            this.name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.Enabled = false;
            this.name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.FocusedState.Parent = this.name;
            this.name.Font = new System.Drawing.Font("Open Sans", 9F);
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.HoverState.Parent = this.name;
            this.name.Location = new System.Drawing.Point(74, 1);
            this.name.MaxLength = 20;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.PlaceholderText = "Name here...";
            this.name.SelectedText = "";
            this.name.SelectionStart = 4;
            this.name.ShadowDecoration.Parent = this.name;
            this.name.Size = new System.Drawing.Size(143, 24);
            this.name.TabIndex = 10;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // save
            // 
            this.save.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.save.CheckedState.Parent = this.save;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.HoverState.ImageSize = new System.Drawing.Size(21, 21);
            this.save.HoverState.Parent = this.save;
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.ImageRotate = 0F;
            this.save.ImageSize = new System.Drawing.Size(21, 21);
            this.save.Location = new System.Drawing.Point(406, 3);
            this.save.Margin = new System.Windows.Forms.Padding(0);
            this.save.Name = "save";
            this.save.PressedState.ImageSize = new System.Drawing.Size(21, 21);
            this.save.PressedState.Parent = this.save;
            this.save.Size = new System.Drawing.Size(21, 21);
            this.save.TabIndex = 12;
            this.ToolTip.SetToolTip(this.save, "Save");
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.CheckedState.ImageSize = new System.Drawing.Size(21, 21);
            this.delete.CheckedState.Parent = this.delete;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.HoverState.ImageSize = new System.Drawing.Size(21, 21);
            this.delete.HoverState.Parent = this.delete;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.ImageRotate = 0F;
            this.delete.ImageSize = new System.Drawing.Size(21, 21);
            this.delete.Location = new System.Drawing.Point(430, 3);
            this.delete.Name = "delete";
            this.delete.PressedState.ImageSize = new System.Drawing.Size(21, 21);
            this.delete.PressedState.Parent = this.delete;
            this.delete.Size = new System.Drawing.Size(21, 21);
            this.delete.TabIndex = 11;
            this.ToolTip.SetToolTip(this.delete, "Delete");
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // section_name
            // 
            this.section_name.Animated = true;
            this.section_name.AutoRoundedCorners = true;
            this.section_name.BorderColor = System.Drawing.Color.White;
            this.section_name.BorderRadius = 11;
            this.section_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.section_name.DefaultText = "Section Name";
            this.section_name.DisabledState.BorderColor = System.Drawing.Color.White;
            this.section_name.DisabledState.FillColor = System.Drawing.Color.White;
            this.section_name.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.section_name.DisabledState.Parent = this.section_name;
            this.section_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.section_name.Enabled = false;
            this.section_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.section_name.FocusedState.Parent = this.section_name;
            this.section_name.Font = new System.Drawing.Font("Open Sans", 9F);
            this.section_name.ForeColor = System.Drawing.Color.Black;
            this.section_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.section_name.HoverState.Parent = this.section_name;
            this.section_name.Location = new System.Drawing.Point(223, 1);
            this.section_name.MaxLength = 20;
            this.section_name.Name = "section_name";
            this.section_name.PasswordChar = '\0';
            this.section_name.PlaceholderText = "Name here...";
            this.section_name.ReadOnly = true;
            this.section_name.SelectedText = "";
            this.section_name.SelectionStart = 12;
            this.section_name.ShadowDecoration.Parent = this.section_name;
            this.section_name.Size = new System.Drawing.Size(156, 24);
            this.section_name.TabIndex = 13;
            this.section_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToolTip
            // 
            this.ToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.ToolTip.StyleManager = null;
            this.ToolTip.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // user_type_timer
            // 
            this.user_type_timer.Tick += new System.EventHandler(this.user_type_timer_Tick);
            // 
            // show_group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delete);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.section_name);
            this.Controls.Add(this.new_section_name);
            this.Controls.Add(this.save);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "show_group";
            this.Size = new System.Drawing.Size(482, 27);
            this.Load += new System.EventHandler(this.show_group_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox id;
        public Guna.UI2.WinForms.Guna2TextBox name;
        public Guna.UI2.WinForms.Guna2ComboBox new_section_name;
        public Guna.UI2.WinForms.Guna2TextBox section_name;
        public Guna.UI2.WinForms.Guna2ImageButton modify;
        public Guna.UI2.WinForms.Guna2ImageButton save;
        private MetroFramework.Components.MetroToolTip ToolTip;
        public Guna.UI2.WinForms.Guna2ImageButton delete;
        private System.Windows.Forms.Timer user_type_timer;

    }
}

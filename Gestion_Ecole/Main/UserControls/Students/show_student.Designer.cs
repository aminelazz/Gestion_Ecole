namespace Gestion_Ecole
{
    partial class show_student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_student));
            this.delete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.name = new Guna.UI2.WinForms.Guna2TextBox();
            this.id = new Guna.UI2.WinForms.Guna2TextBox();
            this.modify = new Guna.UI2.WinForms.Guna2ImageButton();
            this.new_group_name = new Guna.UI2.WinForms.Guna2ComboBox();
            this.save = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ToolTip = new MetroFramework.Components.MetroToolTip();
            this.group_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.section_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.new_date_birth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.date_birth = new Guna.UI2.WinForms.Guna2TextBox();
            this.user_type_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            this.delete.Location = new System.Drawing.Point(681, 3);
            this.delete.Name = "delete";
            this.delete.PressedState.ImageSize = new System.Drawing.Size(21, 21);
            this.delete.PressedState.Parent = this.delete;
            this.delete.Size = new System.Drawing.Size(21, 21);
            this.delete.TabIndex = 18;
            this.ToolTip.SetToolTip(this.delete, "Delete");
            this.delete.Click += new System.EventHandler(this.delete_Click);
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
            this.name.Size = new System.Drawing.Size(129, 24);
            this.name.TabIndex = 17;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.id.TabIndex = 15;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
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
            this.modify.Location = new System.Drawing.Point(657, 3);
            this.modify.Name = "modify";
            this.modify.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("modify.PressedState.Image")));
            this.modify.PressedState.ImageSize = new System.Drawing.Size(21, 21);
            this.modify.PressedState.Parent = this.modify;
            this.modify.Size = new System.Drawing.Size(21, 21);
            this.modify.TabIndex = 14;
            this.ToolTip.SetToolTip(this.modify, "Modify");
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // new_group_name
            // 
            this.new_group_name.Animated = true;
            this.new_group_name.AutoRoundedCorners = true;
            this.new_group_name.BackColor = System.Drawing.Color.Transparent;
            this.new_group_name.BorderColor = System.Drawing.Color.White;
            this.new_group_name.BorderRadius = 11;
            this.new_group_name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.new_group_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.new_group_name.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.new_group_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.new_group_name.FocusedState.Parent = this.new_group_name;
            this.new_group_name.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.new_group_name.ForeColor = System.Drawing.Color.Black;
            this.new_group_name.HoverState.Parent = this.new_group_name;
            this.new_group_name.ItemHeight = 18;
            this.new_group_name.ItemsAppearance.Parent = this.new_group_name;
            this.new_group_name.Location = new System.Drawing.Point(209, 1);
            this.new_group_name.Margin = new System.Windows.Forms.Padding(0);
            this.new_group_name.Name = "new_group_name";
            this.new_group_name.ShadowDecoration.Parent = this.new_group_name;
            this.new_group_name.Size = new System.Drawing.Size(142, 24);
            this.new_group_name.TabIndex = 16;
            this.new_group_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.new_group_name.SelectionChangeCommitted += new System.EventHandler(this.new_group_name_SelectionChangeCommitted);
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
            this.save.Location = new System.Drawing.Point(657, 3);
            this.save.Margin = new System.Windows.Forms.Padding(0);
            this.save.Name = "save";
            this.save.PressedState.ImageSize = new System.Drawing.Size(21, 21);
            this.save.PressedState.Parent = this.save;
            this.save.Size = new System.Drawing.Size(21, 21);
            this.save.TabIndex = 19;
            this.ToolTip.SetToolTip(this.save, "Save");
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ToolTip
            // 
            this.ToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.ToolTip.StyleManager = null;
            this.ToolTip.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // group_name
            // 
            this.group_name.Animated = true;
            this.group_name.AutoRoundedCorners = true;
            this.group_name.BorderColor = System.Drawing.Color.White;
            this.group_name.BorderRadius = 11;
            this.group_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.group_name.DefaultText = "Group Name";
            this.group_name.DisabledState.BorderColor = System.Drawing.Color.White;
            this.group_name.DisabledState.FillColor = System.Drawing.Color.White;
            this.group_name.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.group_name.DisabledState.Parent = this.group_name;
            this.group_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.group_name.Enabled = false;
            this.group_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.group_name.FocusedState.Parent = this.group_name;
            this.group_name.Font = new System.Drawing.Font("Open Sans", 9F);
            this.group_name.ForeColor = System.Drawing.Color.Black;
            this.group_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.group_name.HoverState.Parent = this.group_name;
            this.group_name.Location = new System.Drawing.Point(209, 1);
            this.group_name.MaxLength = 20;
            this.group_name.Name = "group_name";
            this.group_name.PasswordChar = '\0';
            this.group_name.PlaceholderText = "";
            this.group_name.ReadOnly = true;
            this.group_name.SelectedText = "";
            this.group_name.SelectionStart = 10;
            this.group_name.ShadowDecoration.Parent = this.group_name;
            this.group_name.Size = new System.Drawing.Size(142, 24);
            this.group_name.TabIndex = 22;
            this.group_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.section_name.Location = new System.Drawing.Point(357, 1);
            this.section_name.MaxLength = 20;
            this.section_name.Name = "section_name";
            this.section_name.PasswordChar = '\0';
            this.section_name.PlaceholderText = "";
            this.section_name.ReadOnly = true;
            this.section_name.SelectedText = "";
            this.section_name.SelectionStart = 12;
            this.section_name.ShadowDecoration.Parent = this.section_name;
            this.section_name.Size = new System.Drawing.Size(142, 24);
            this.section_name.TabIndex = 23;
            this.section_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // new_date_birth
            // 
            this.new_date_birth.Animated = true;
            this.new_date_birth.BorderRadius = 11;
            this.new_date_birth.CheckedState.Parent = this.new_date_birth;
            this.new_date_birth.CustomFormat = "MM/dd/yyyy";
            this.new_date_birth.FillColor = System.Drawing.Color.White;
            this.new_date_birth.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_date_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.new_date_birth.HoverState.Parent = this.new_date_birth;
            this.new_date_birth.Location = new System.Drawing.Point(506, 1);
            this.new_date_birth.MaxDate = new System.DateTime(2021, 3, 21, 0, 0, 0, 0);
            this.new_date_birth.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.new_date_birth.Name = "new_date_birth";
            this.new_date_birth.ShadowDecoration.Parent = this.new_date_birth;
            this.new_date_birth.Size = new System.Drawing.Size(129, 24);
            this.new_date_birth.TabIndex = 24;
            this.new_date_birth.Value = new System.DateTime(2021, 3, 21, 0, 0, 0, 0);
            // 
            // date_birth
            // 
            this.date_birth.Animated = true;
            this.date_birth.AutoRoundedCorners = true;
            this.date_birth.BorderColor = System.Drawing.Color.White;
            this.date_birth.BorderRadius = 11;
            this.date_birth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.date_birth.DefaultText = "Date of birth";
            this.date_birth.DisabledState.BorderColor = System.Drawing.Color.White;
            this.date_birth.DisabledState.FillColor = System.Drawing.Color.White;
            this.date_birth.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.date_birth.DisabledState.Parent = this.date_birth;
            this.date_birth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.date_birth.Enabled = false;
            this.date_birth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.date_birth.FocusedState.Parent = this.date_birth;
            this.date_birth.Font = new System.Drawing.Font("Open Sans", 9F);
            this.date_birth.ForeColor = System.Drawing.Color.Black;
            this.date_birth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.date_birth.HoverState.Parent = this.date_birth;
            this.date_birth.Location = new System.Drawing.Point(506, 1);
            this.date_birth.MaxLength = 20;
            this.date_birth.Name = "date_birth";
            this.date_birth.PasswordChar = '\0';
            this.date_birth.PlaceholderText = "";
            this.date_birth.ReadOnly = true;
            this.date_birth.SelectedText = "";
            this.date_birth.SelectionStart = 13;
            this.date_birth.ShadowDecoration.Parent = this.date_birth;
            this.date_birth.Size = new System.Drawing.Size(129, 24);
            this.date_birth.TabIndex = 25;
            this.date_birth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // user_type_timer
            // 
            this.user_type_timer.Tick += new System.EventHandler(this.user_type_timer_Tick);
            // 
            // show_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.section_name);
            this.Controls.Add(this.group_name);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.new_group_name);
            this.Controls.Add(this.save);
            this.Controls.Add(this.date_birth);
            this.Controls.Add(this.new_date_birth);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "show_student";
            this.Size = new System.Drawing.Size(733, 27);
            this.Load += new System.EventHandler(this.show_student_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton delete;
        public Guna.UI2.WinForms.Guna2TextBox name;
        public Guna.UI2.WinForms.Guna2TextBox id;
        public Guna.UI2.WinForms.Guna2ImageButton modify;
        public Guna.UI2.WinForms.Guna2ComboBox new_group_name;
        public Guna.UI2.WinForms.Guna2ImageButton save;
        private MetroFramework.Components.MetroToolTip ToolTip;
        public Guna.UI2.WinForms.Guna2TextBox group_name;
        public Guna.UI2.WinForms.Guna2TextBox section_name;
        public Guna.UI2.WinForms.Guna2TextBox date_birth;
        public Guna.UI2.WinForms.Guna2DateTimePicker new_date_birth;
        private System.Windows.Forms.Timer user_type_timer;

    }
}

namespace Gestion_Ecole.Main
{
    partial class show_subject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_subject));
            this.modify = new Guna.UI2.WinForms.Guna2ImageButton();
            this.save = new Guna.UI2.WinForms.Guna2ImageButton();
            this.id = new Guna.UI2.WinForms.Guna2TextBox();
            this.name = new Guna.UI2.WinForms.Guna2TextBox();
            this.delete = new Guna.UI2.WinForms.Guna2ImageButton();
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
            this.modify.Location = new System.Drawing.Point(348, 3);
            this.modify.Name = "modify";
            this.modify.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("modify.PressedState.Image")));
            this.modify.PressedState.ImageSize = new System.Drawing.Size(21, 21);
            this.modify.PressedState.Parent = this.modify;
            this.modify.Size = new System.Drawing.Size(21, 21);
            this.modify.TabIndex = 14;
            this.ToolTip.SetToolTip(this.modify, "Modify");
            this.modify.Click += new System.EventHandler(this.modify_Click);
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
            this.save.Location = new System.Drawing.Point(348, 3);
            this.save.Name = "save";
            this.save.PressedState.ImageSize = new System.Drawing.Size(21, 21);
            this.save.PressedState.Parent = this.save;
            this.save.Size = new System.Drawing.Size(21, 21);
            this.save.TabIndex = 13;
            this.ToolTip.SetToolTip(this.save, "Save");
            this.save.Click += new System.EventHandler(this.save_Click);
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
            this.id.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.Black;
            this.id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id.HoverState.Parent = this.id;
            this.id.Location = new System.Drawing.Point(3, 1);
            this.id.Name = "id";
            this.id.PasswordChar = '\0';
            this.id.PlaceholderText = "ID Here...";
            this.id.SelectedText = "";
            this.id.SelectionStart = 2;
            this.id.ShadowDecoration.Parent = this.id;
            this.id.Size = new System.Drawing.Size(104, 24);
            this.id.TabIndex = 12;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
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
            this.name.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.name.Enabled = false;
            this.name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.FocusedState.Parent = this.name;
            this.name.Font = new System.Drawing.Font("Open Sans", 9F);
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.HoverState.Parent = this.name;
            this.name.Location = new System.Drawing.Point(113, 1);
            this.name.MaxLength = 20;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.PlaceholderText = "Name here...";
            this.name.SelectedText = "";
            this.name.SelectionStart = 4;
            this.name.ShadowDecoration.Parent = this.name;
            this.name.Size = new System.Drawing.Size(200, 24);
            this.name.TabIndex = 11;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.delete.Location = new System.Drawing.Point(375, 3);
            this.delete.Name = "delete";
            this.delete.PressedState.ImageSize = new System.Drawing.Size(21, 21);
            this.delete.PressedState.Parent = this.delete;
            this.delete.Size = new System.Drawing.Size(21, 21);
            this.delete.TabIndex = 10;
            this.ToolTip.SetToolTip(this.delete, "Delete");
            this.delete.Click += new System.EventHandler(this.delete_Click);
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
            // show_subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modify);
            this.Controls.Add(this.save);
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.delete);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "show_subject";
            this.Size = new System.Drawing.Size(403, 27);
            this.Load += new System.EventHandler(this.show_subject_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2ImageButton modify;
        public Guna.UI2.WinForms.Guna2TextBox id;
        public Guna.UI2.WinForms.Guna2TextBox name;
        private Guna.UI2.WinForms.Guna2ImageButton delete;
        private MetroFramework.Components.MetroToolTip ToolTip;
        public Guna.UI2.WinForms.Guna2ImageButton save;
        private System.Windows.Forms.Timer user_type_timer;


    }
}

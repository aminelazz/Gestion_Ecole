namespace Gestion_Ecole.Main.UserControls
{
    partial class manage_uc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manage_uc));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.account_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.create_account_panel = new System.Windows.Forms.Panel();
            this.create_account = new Guna.UI2.WinForms.Guna2Button();
            this.create_account_timer = new System.Windows.Forms.Timer(this.components);
            this.show_account1 = new Gestion_Ecole.Main.UserControls.show_account();
            this.ToolTip = new MetroFramework.Components.MetroToolTip();
            this.go_back = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1.SuspendLayout();
            this.account_panel.SuspendLayout();
            this.create_account_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(212, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(154, 25);
            this.metroLabel1.TabIndex = 56;
            this.metroLabel1.Text = "Manage Accounts";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Panel1.Location = new System.Drawing.Point(76, 159);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(426, 23);
            this.guna2Panel1.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(223, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(349, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // account_panel
            // 
            this.account_panel.AutoScroll = true;
            this.account_panel.Controls.Add(this.show_account1);
            this.account_panel.Controls.Add(this.create_account_panel);
            this.account_panel.Location = new System.Drawing.Point(76, 182);
            this.account_panel.Name = "account_panel";
            this.account_panel.Size = new System.Drawing.Size(426, 276);
            this.account_panel.TabIndex = 58;
            // 
            // create_account_panel
            // 
            this.create_account_panel.Controls.Add(this.create_account);
            this.create_account_panel.Location = new System.Drawing.Point(0, 27);
            this.create_account_panel.Margin = new System.Windows.Forms.Padding(0);
            this.create_account_panel.Name = "create_account_panel";
            this.create_account_panel.Size = new System.Drawing.Size(403, 49);
            this.create_account_panel.TabIndex = 1;
            // 
            // create_account
            // 
            this.create_account.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.create_account.Animated = true;
            this.create_account.AutoRoundedCorners = true;
            this.create_account.BorderRadius = 14;
            this.create_account.CheckedState.Parent = this.create_account;
            this.create_account.CustomImages.Parent = this.create_account;
            this.create_account.FillColor = System.Drawing.Color.LimeGreen;
            this.create_account.Font = new System.Drawing.Font("Open Sans", 9F);
            this.create_account.ForeColor = System.Drawing.Color.White;
            this.create_account.HoverState.Parent = this.create_account;
            this.create_account.Location = new System.Drawing.Point(113, 8);
            this.create_account.Name = "create_account";
            this.create_account.ShadowDecoration.Parent = this.create_account;
            this.create_account.Size = new System.Drawing.Size(200, 31);
            this.create_account.TabIndex = 2;
            this.create_account.Text = "Create New Account";
            this.create_account.Click += new System.EventHandler(this.create_account_Click);
            // 
            // create_account_timer
            // 
            this.create_account_timer.Tick += new System.EventHandler(this.create_account_timer_Tick);
            // 
            // show_account1
            // 
            this.show_account1.Location = new System.Drawing.Point(0, 0);
            this.show_account1.Margin = new System.Windows.Forms.Padding(0);
            this.show_account1.Name = "show_account1";
            this.show_account1.Size = new System.Drawing.Size(403, 27);
            this.show_account1.TabIndex = 2;
            this.show_account1.UseSelectable = true;
            // 
            // ToolTip
            // 
            this.ToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.ToolTip.StyleManager = null;
            this.ToolTip.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // go_back
            // 
            this.go_back.BackColor = System.Drawing.Color.Transparent;
            this.go_back.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.go_back.CheckedState.Parent = this.go_back;
            this.go_back.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("go_back.HoverState.Image")));
            this.go_back.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.go_back.HoverState.Parent = this.go_back;
            this.go_back.Image = ((System.Drawing.Image)(resources.GetObject("go_back.Image")));
            this.go_back.ImageRotate = 0F;
            this.go_back.ImageSize = new System.Drawing.Size(40, 40);
            this.go_back.Location = new System.Drawing.Point(45, 18);
            this.go_back.Name = "go_back";
            this.go_back.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("go_back.PressedState.Image")));
            this.go_back.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.go_back.PressedState.Parent = this.go_back;
            this.go_back.Size = new System.Drawing.Size(40, 40);
            this.go_back.TabIndex = 63;
            this.ToolTip.SetToolTip(this.go_back, "Go Back");
            this.go_back.UseTransparentBackground = true;
            this.go_back.Click += new System.EventHandler(this.go_back_Click);
            // 
            // manage_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.go_back);
            this.Controls.Add(this.account_panel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "manage_uc";
            this.Size = new System.Drawing.Size(579, 549);
            this.Load += new System.EventHandler(this.manage_uc_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.account_panel.ResumeLayout(false);
            this.create_account_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel account_panel;
        private System.Windows.Forms.Panel create_account_panel;
        private Guna.UI2.WinForms.Guna2Button create_account;
        private show_account show_account1;
        private System.Windows.Forms.Timer create_account_timer;
        private MetroFramework.Components.MetroToolTip ToolTip;
        private Guna.UI2.WinForms.Guna2ImageButton go_back;

    }
}

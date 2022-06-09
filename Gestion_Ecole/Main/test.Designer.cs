namespace Gestion_Ecole.Main
{
    partial class test
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
            //this.options_uc1 = new Gestion_Ecole.Main.UserControls.Options.options_uc();
            this.SuspendLayout();
            // 
            // options_uc1
            // 
            this.options_uc1.Location = new System.Drawing.Point(85, 12);
            this.options_uc1.Name = "options_uc1";
            this.options_uc1.Size = new System.Drawing.Size(579, 549);
            this.options_uc1.TabIndex = 0;
            this.options_uc1.UseSelectable = true;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 566);
            this.Controls.Add(this.options_uc1);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Options.options_uc options_uc1;


















    }
}
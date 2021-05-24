
namespace ChapooUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lbl_errormessagebox = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tbx_Password = new System.Windows.Forms.TextBox();
            this.tbx_Username = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_errormessagebox
            // 
            this.lbl_errormessagebox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_errormessagebox.AutoSize = true;
            this.lbl_errormessagebox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errormessagebox.ForeColor = System.Drawing.Color.Red;
            this.lbl_errormessagebox.Location = new System.Drawing.Point(97, 624);
            this.lbl_errormessagebox.Name = "lbl_errormessagebox";
            this.lbl_errormessagebox.Size = new System.Drawing.Size(0, 28);
            this.lbl_errormessagebox.TabIndex = 14;
            // 
            // lbl_Username
            // 
            this.lbl_Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(97, 501);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(118, 28);
            this.lbl_Username.TabIndex = 9;
            this.lbl_Username.Text = "User Name:";
            // 
            // tbx_Password
            // 
            this.tbx_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Password.Location = new System.Drawing.Point(253, 574);
            this.tbx_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.Size = new System.Drawing.Size(275, 34);
            this.tbx_Password.TabIndex = 12;
            this.tbx_Password.UseSystemPasswordChar = true;
            // 
            // tbx_Username
            // 
            this.tbx_Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbx_Username.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Username.Location = new System.Drawing.Point(253, 501);
            this.tbx_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_Username.Name = "tbx_Username";
            this.tbx_Username.Size = new System.Drawing.Size(275, 34);
            this.tbx_Username.TabIndex = 11;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(97, 579);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(102, 28);
            this.lbl_Password.TabIndex = 10;
            this.lbl_Password.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::ChapooUI.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(-47, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(753, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(554, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(89, 27);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // BTN_Login
            // 
            this.BTN_Login.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_Login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Login.Location = new System.Drawing.Point(102, 662);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(113, 38);
            this.BTN_Login.TabIndex = 18;
            this.BTN_Login.Text = "Log in";
            this.BTN_Login.UseVisualStyleBackColor = false;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click_1);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.BTN_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 742);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.lbl_errormessagebox);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.tbx_Password);
            this.Controls.Add(this.tbx_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_errormessagebox;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox tbx_Password;
        private System.Windows.Forms.TextBox tbx_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Login;
    }
}
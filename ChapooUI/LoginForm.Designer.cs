
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
            this.btn_login = new System.Windows.Forms.Button();
            this.tbx_Username = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(95, 681);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(103, 42);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(-53, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(753, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(643, 742);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_errormessagebox);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.tbx_Password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbx_Username);
            this.Controls.Add(this.lbl_Password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_errormessagebox;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox tbx_Password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tbx_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
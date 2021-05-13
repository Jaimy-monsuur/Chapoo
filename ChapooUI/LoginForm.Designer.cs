
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
            this.lbl_errormessagebox.AutoSize = true;
            this.lbl_errormessagebox.ForeColor = System.Drawing.Color.Red;
            this.lbl_errormessagebox.Location = new System.Drawing.Point(35, 462);
            this.lbl_errormessagebox.Name = "lbl_errormessagebox";
            this.lbl_errormessagebox.Size = new System.Drawing.Size(0, 17);
            this.lbl_errormessagebox.TabIndex = 14;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(35, 363);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(83, 17);
            this.lbl_Username.TabIndex = 9;
            this.lbl_Username.Text = "User Name:";
            // 
            // tbx_Password
            // 
            this.tbx_Password.Location = new System.Drawing.Point(191, 420);
            this.tbx_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_Password.Name = "tbx_Password";
            this.tbx_Password.Size = new System.Drawing.Size(187, 22);
            this.tbx_Password.TabIndex = 12;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(38, 500);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 27);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tbx_Username
            // 
            this.tbx_Username.Location = new System.Drawing.Point(191, 363);
            this.tbx_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_Username.Name = "tbx_Username";
            this.tbx_Username.Size = new System.Drawing.Size(187, 22);
            this.tbx_Username.TabIndex = 11;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(35, 425);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(73, 17);
            this.lbl_Password.TabIndex = 10;
            this.lbl_Password.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChapooUI.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 557);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_errormessagebox);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.tbx_Password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbx_Username);
            this.Controls.Add(this.lbl_Password);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
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

namespace ChapooUI
{
    partial class AddCustomers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Toevoegen = new System.Windows.Forms.Button();
            this.BTN_terug = new System.Windows.Forms.Button();
            this.txb_Vnaam = new System.Windows.Forms.TextBox();
            this.txb_Anaam = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_nummer = new System.Windows.Forms.TextBox();
            this.LBL_ERROR = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nieuwe klant toevoegen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voornaam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Achternaam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "*E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "*Telefoon nummer:";
            // 
            // BTN_Toevoegen
            // 
            this.BTN_Toevoegen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_Toevoegen.Location = new System.Drawing.Point(11, 328);
            this.BTN_Toevoegen.Name = "BTN_Toevoegen";
            this.BTN_Toevoegen.Size = new System.Drawing.Size(88, 45);
            this.BTN_Toevoegen.TabIndex = 5;
            this.BTN_Toevoegen.Text = "Toevoegen";
            this.BTN_Toevoegen.UseVisualStyleBackColor = false;
            this.BTN_Toevoegen.Click += new System.EventHandler(this.BTN_Toevoegen_Click);
            // 
            // BTN_terug
            // 
            this.BTN_terug.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_terug.Location = new System.Drawing.Point(235, 328);
            this.BTN_terug.Name = "BTN_terug";
            this.BTN_terug.Size = new System.Drawing.Size(88, 45);
            this.BTN_terug.TabIndex = 6;
            this.BTN_terug.Text = "Terug";
            this.BTN_terug.UseVisualStyleBackColor = false;
            this.BTN_terug.Click += new System.EventHandler(this.BTN_terug_Click);
            // 
            // txb_Vnaam
            // 
            this.txb_Vnaam.Location = new System.Drawing.Point(136, 57);
            this.txb_Vnaam.Name = "txb_Vnaam";
            this.txb_Vnaam.Size = new System.Drawing.Size(156, 25);
            this.txb_Vnaam.TabIndex = 7;
            // 
            // txb_Anaam
            // 
            this.txb_Anaam.Location = new System.Drawing.Point(136, 104);
            this.txb_Anaam.Name = "txb_Anaam";
            this.txb_Anaam.Size = new System.Drawing.Size(156, 25);
            this.txb_Anaam.TabIndex = 8;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(136, 149);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(175, 25);
            this.txb_email.TabIndex = 9;
            // 
            // txb_nummer
            // 
            this.txb_nummer.Location = new System.Drawing.Point(136, 198);
            this.txb_nummer.Name = "txb_nummer";
            this.txb_nummer.Size = new System.Drawing.Size(175, 25);
            this.txb_nummer.TabIndex = 10;
            this.txb_nummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_nummer_KeyPress);
            // 
            // LBL_ERROR
            // 
            this.LBL_ERROR.AutoSize = true;
            this.LBL_ERROR.ForeColor = System.Drawing.Color.Red;
            this.LBL_ERROR.Location = new System.Drawing.Point(8, 287);
            this.LBL_ERROR.Name = "LBL_ERROR";
            this.LBL_ERROR.Size = new System.Drawing.Size(0, 19);
            this.LBL_ERROR.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "* = niet verplicht";
            // 
            // AddCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 385);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LBL_ERROR);
            this.Controls.Add(this.txb_nummer);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.txb_Anaam);
            this.Controls.Add(this.txb_Vnaam);
            this.Controls.Add(this.BTN_terug);
            this.Controls.Add(this.BTN_Toevoegen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCustomers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_Toevoegen;
        private System.Windows.Forms.Button BTN_terug;
        private System.Windows.Forms.TextBox txb_Vnaam;
        private System.Windows.Forms.TextBox txb_Anaam;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_nummer;
        private System.Windows.Forms.Label LBL_ERROR;
        private System.Windows.Forms.Label label6;
    }
}
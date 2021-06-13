namespace ChapooUI
{
    partial class VoorraadWijzigenWeergeven
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
            this.listViewVoorraad = new System.Windows.Forms.ListView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TerugtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voorraadTxtLbl = new System.Windows.Forms.Label();
            this.wijzigVoorraadBtn = new System.Windows.Forms.Button();
            this.nieuwAantalBox = new System.Windows.Forms.TextBox();
            this.nieuwAantalTxtLbl = new System.Windows.Forms.Label();
            this.errorAantalLbl = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewVoorraad
            // 
            this.listViewVoorraad.HideSelection = false;
            this.listViewVoorraad.Location = new System.Drawing.Point(86, 76);
            this.listViewVoorraad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewVoorraad.Name = "listViewVoorraad";
            this.listViewVoorraad.Size = new System.Drawing.Size(768, 327);
            this.listViewVoorraad.TabIndex = 0;
            this.listViewVoorraad.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TerugtoolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(-4, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(54, 24);
            this.menuStrip2.TabIndex = 34;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // TerugtoolStripMenuItem
            // 
            this.TerugtoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.TerugtoolStripMenuItem.Name = "TerugtoolStripMenuItem";
            this.TerugtoolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.TerugtoolStripMenuItem.Text = "Terug";
            this.TerugtoolStripMenuItem.Click += new System.EventHandler(this.TerugtoolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UitloggenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(886, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(77, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UitloggenToolStripMenuItem
            // 
            this.UitloggenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.UitloggenToolStripMenuItem.Name = "UitloggenToolStripMenuItem";
            this.UitloggenToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.UitloggenToolStripMenuItem.Text = "Uitloggen";
            this.UitloggenToolStripMenuItem.Click += new System.EventHandler(this.UitloggenToolStripMenuItem_Click);
            // 
            // voorraadTxtLbl
            // 
            this.voorraadTxtLbl.AutoSize = true;
            this.voorraadTxtLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voorraadTxtLbl.Location = new System.Drawing.Point(81, 47);
            this.voorraadTxtLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.voorraadTxtLbl.Name = "voorraadTxtLbl";
            this.voorraadTxtLbl.Size = new System.Drawing.Size(90, 25);
            this.voorraadTxtLbl.TabIndex = 35;
            this.voorraadTxtLbl.Text = "Voorraad";
            // 
            // wijzigVoorraadBtn
            // 
            this.wijzigVoorraadBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.wijzigVoorraadBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wijzigVoorraadBtn.Location = new System.Drawing.Point(86, 427);
            this.wijzigVoorraadBtn.Name = "wijzigVoorraadBtn";
            this.wijzigVoorraadBtn.Size = new System.Drawing.Size(141, 50);
            this.wijzigVoorraadBtn.TabIndex = 36;
            this.wijzigVoorraadBtn.Text = "Wijzig voorraad";
            this.wijzigVoorraadBtn.UseVisualStyleBackColor = false;
            this.wijzigVoorraadBtn.Click += new System.EventHandler(this.wijzigVoorraadBtn_Click);
            // 
            // nieuwAantalBox
            // 
            this.nieuwAantalBox.Location = new System.Drawing.Point(683, 427);
            this.nieuwAantalBox.MaxLength = 6;
            this.nieuwAantalBox.Name = "nieuwAantalBox";
            this.nieuwAantalBox.Size = new System.Drawing.Size(171, 20);
            this.nieuwAantalBox.TabIndex = 37;
            this.nieuwAantalBox.Text = " ";
            this.nieuwAantalBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nieuwAantalBox_KeyPress);
            // 
            // nieuwAantalTxtLbl
            // 
            this.nieuwAantalTxtLbl.AutoSize = true;
            this.nieuwAantalTxtLbl.Location = new System.Drawing.Point(680, 411);
            this.nieuwAantalTxtLbl.Name = "nieuwAantalTxtLbl";
            this.nieuwAantalTxtLbl.Size = new System.Drawing.Size(72, 13);
            this.nieuwAantalTxtLbl.TabIndex = 38;
            this.nieuwAantalTxtLbl.Text = "Nieuw aantal:";
            // 
            // errorAantalLbl
            // 
            this.errorAantalLbl.AutoSize = true;
            this.errorAantalLbl.ForeColor = System.Drawing.Color.Red;
            this.errorAantalLbl.Location = new System.Drawing.Point(680, 464);
            this.errorAantalLbl.Name = "errorAantalLbl";
            this.errorAantalLbl.Size = new System.Drawing.Size(0, 13);
            this.errorAantalLbl.TabIndex = 39;
            // 
            // VoorraadWijzigenWeergeven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 505);
            this.Controls.Add(this.errorAantalLbl);
            this.Controls.Add(this.nieuwAantalTxtLbl);
            this.Controls.Add(this.nieuwAantalBox);
            this.Controls.Add(this.wijzigVoorraadBtn);
            this.Controls.Add(this.voorraadTxtLbl);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listViewVoorraad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VoorraadWijzigenWeergeven";
            this.Text = "VoorraadWijzigenWeergeven";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewVoorraad;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem TerugtoolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UitloggenToolStripMenuItem;
        private System.Windows.Forms.Label voorraadTxtLbl;
        private System.Windows.Forms.Button wijzigVoorraadBtn;
        private System.Windows.Forms.TextBox nieuwAantalBox;
        private System.Windows.Forms.Label nieuwAantalTxtLbl;
        private System.Windows.Forms.Label errorAantalLbl;
    }
}
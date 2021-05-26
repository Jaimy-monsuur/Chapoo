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
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewVoorraad
            // 
            this.listViewVoorraad.HideSelection = false;
            this.listViewVoorraad.Location = new System.Drawing.Point(114, 93);
            this.listViewVoorraad.Name = "listViewVoorraad";
            this.listViewVoorraad.Size = new System.Drawing.Size(1022, 401);
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
            this.menuStrip2.Location = new System.Drawing.Point(-5, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(69, 27);
            this.menuStrip2.TabIndex = 34;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // TerugtoolStripMenuItem
            // 
            this.TerugtoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.TerugtoolStripMenuItem.Name = "TerugtoolStripMenuItem";
            this.TerugtoolStripMenuItem.Size = new System.Drawing.Size(61, 23);
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
            this.menuStrip1.Location = new System.Drawing.Point(1187, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(97, 27);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UitloggenToolStripMenuItem
            // 
            this.UitloggenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.UitloggenToolStripMenuItem.Name = "UitloggenToolStripMenuItem";
            this.UitloggenToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.UitloggenToolStripMenuItem.Text = "Uitloggen";
            this.UitloggenToolStripMenuItem.Click += new System.EventHandler(this.UitloggenToolStripMenuItem_Click);
            // 
            // voorraadTxtLbl
            // 
            this.voorraadTxtLbl.AutoSize = true;
            this.voorraadTxtLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voorraadTxtLbl.Location = new System.Drawing.Point(108, 58);
            this.voorraadTxtLbl.Name = "voorraadTxtLbl";
            this.voorraadTxtLbl.Size = new System.Drawing.Size(110, 32);
            this.voorraadTxtLbl.TabIndex = 35;
            this.voorraadTxtLbl.Text = "Voorraad";
            // 
            // wijzigVoorraadBtn
            // 
            this.wijzigVoorraadBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.wijzigVoorraadBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wijzigVoorraadBtn.Location = new System.Drawing.Point(114, 525);
            this.wijzigVoorraadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.wijzigVoorraadBtn.Name = "wijzigVoorraadBtn";
            this.wijzigVoorraadBtn.Size = new System.Drawing.Size(188, 62);
            this.wijzigVoorraadBtn.TabIndex = 36;
            this.wijzigVoorraadBtn.Text = "Wijzig voorraad";
            this.wijzigVoorraadBtn.UseVisualStyleBackColor = false;
            this.wijzigVoorraadBtn.Click += new System.EventHandler(this.wijzigVoorraadBtn_Click);
            // 
            // VoorraadWijzigenWeergeven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 622);
            this.Controls.Add(this.wijzigVoorraadBtn);
            this.Controls.Add(this.voorraadTxtLbl);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listViewVoorraad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
    }
}
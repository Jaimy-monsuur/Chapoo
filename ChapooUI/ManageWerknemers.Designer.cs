
namespace ChapooUI
{
    partial class ManageWerknemers
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TerugtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LVW_Account = new System.Windows.Forms.ListView();
            this.BTNtoevoegen = new System.Windows.Forms.Button();
            this.BTNverwijder = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TerugtoolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, -3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(69, 27);
            this.menuStrip2.TabIndex = 32;
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
            this.menuStrip1.Location = new System.Drawing.Point(937, -3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(97, 27);
            this.menuStrip1.TabIndex = 31;
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
            // LVW_Account
            // 
            this.LVW_Account.HideSelection = false;
            this.LVW_Account.Location = new System.Drawing.Point(12, 77);
            this.LVW_Account.Name = "LVW_Account";
            this.LVW_Account.Size = new System.Drawing.Size(1002, 382);
            this.LVW_Account.TabIndex = 33;
            this.LVW_Account.UseCompatibleStateImageBehavior = false;
            // 
            // BTNtoevoegen
            // 
            this.BTNtoevoegen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTNtoevoegen.Location = new System.Drawing.Point(851, 481);
            this.BTNtoevoegen.Name = "BTNtoevoegen";
            this.BTNtoevoegen.Size = new System.Drawing.Size(163, 38);
            this.BTNtoevoegen.TabIndex = 34;
            this.BTNtoevoegen.Text = "Nieuwe werknemer";
            this.BTNtoevoegen.UseVisualStyleBackColor = false;
            this.BTNtoevoegen.Click += new System.EventHandler(this.BTNtoevoegen_Click);
            // 
            // BTNverwijder
            // 
            this.BTNverwijder.BackColor = System.Drawing.Color.LightCoral;
            this.BTNverwijder.Location = new System.Drawing.Point(673, 481);
            this.BTNverwijder.Name = "BTNverwijder";
            this.BTNverwijder.Size = new System.Drawing.Size(163, 38);
            this.BTNverwijder.TabIndex = 35;
            this.BTNverwijder.Text = "Verwijder werknemer";
            this.BTNverwijder.UseVisualStyleBackColor = false;
            this.BTNverwijder.Click += new System.EventHandler(this.BTNverwijder_Click);
            // 
            // ManageWerknemers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 580);
            this.Controls.Add(this.BTNverwijder);
            this.Controls.Add(this.BTNtoevoegen);
            this.Controls.Add(this.LVW_Account);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageWerknemers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAccounts";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem TerugtoolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UitloggenToolStripMenuItem;
        private System.Windows.Forms.ListView LVW_Account;
        private System.Windows.Forms.Button BTNtoevoegen;
        private System.Windows.Forms.Button BTNverwijder;
    }
}
﻿namespace ChapooUI
{
    partial class ChapooUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChapooUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bedieningSelectBtn = new System.Windows.Forms.Button();
            this.barSelectBtn = new System.Windows.Forms.Button();
            this.keukenSelectTxtLbl = new System.Windows.Forms.Label();
            this.bedieningSelectTxtLbl = new System.Windows.Forms.Label();
            this.barSelectTxtLbl = new System.Windows.Forms.Label();
            this.keukenSelectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.dashboardToolStripMenuItem.Text = "Application";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(90, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bedieningSelectBtn
            // 
            this.bedieningSelectBtn.Location = new System.Drawing.Point(386, 129);
            this.bedieningSelectBtn.Name = "bedieningSelectBtn";
            this.bedieningSelectBtn.Size = new System.Drawing.Size(195, 191);
            this.bedieningSelectBtn.TabIndex = 3;
            this.bedieningSelectBtn.UseVisualStyleBackColor = true;
            // 
            // barSelectBtn
            // 
            this.barSelectBtn.Location = new System.Drawing.Point(706, 129);
            this.barSelectBtn.Name = "barSelectBtn";
            this.barSelectBtn.Size = new System.Drawing.Size(195, 191);
            this.barSelectBtn.TabIndex = 4;
            this.barSelectBtn.UseVisualStyleBackColor = true;
            // 
            // keukenSelectTxtLbl
            // 
            this.keukenSelectTxtLbl.AutoSize = true;
            this.keukenSelectTxtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.keukenSelectTxtLbl.Location = new System.Drawing.Point(121, 334);
            this.keukenSelectTxtLbl.Name = "keukenSelectTxtLbl";
            this.keukenSelectTxtLbl.Size = new System.Drawing.Size(69, 20);
            this.keukenSelectTxtLbl.TabIndex = 5;
            this.keukenSelectTxtLbl.Text = "Keuken";
            // 
            // bedieningSelectTxtLbl
            // 
            this.bedieningSelectTxtLbl.AutoSize = true;
            this.bedieningSelectTxtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bedieningSelectTxtLbl.Location = new System.Drawing.Point(444, 334);
            this.bedieningSelectTxtLbl.Name = "bedieningSelectTxtLbl";
            this.bedieningSelectTxtLbl.Size = new System.Drawing.Size(89, 20);
            this.bedieningSelectTxtLbl.TabIndex = 6;
            this.bedieningSelectTxtLbl.Text = "Bediening";
            // 
            // barSelectTxtLbl
            // 
            this.barSelectTxtLbl.AutoSize = true;
            this.barSelectTxtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.barSelectTxtLbl.Location = new System.Drawing.Point(787, 334);
            this.barSelectTxtLbl.Name = "barSelectTxtLbl";
            this.barSelectTxtLbl.Size = new System.Drawing.Size(37, 20);
            this.barSelectTxtLbl.TabIndex = 7;
            this.barSelectTxtLbl.Text = "Bar";
            // 
            // keukenSelectBtn
            // 
            this.keukenSelectBtn.Image = global::ChapooUI.Properties.Resources.keuken_foto1;
            this.keukenSelectBtn.Location = new System.Drawing.Point(64, 129);
            this.keukenSelectBtn.Name = "keukenSelectBtn";
            this.keukenSelectBtn.Size = new System.Drawing.Size(195, 191);
            this.keukenSelectBtn.TabIndex = 2;
            this.keukenSelectBtn.UseVisualStyleBackColor = true;
            this.keukenSelectBtn.Click += new System.EventHandler(this.keukenSelectBtn_Click);
            // 
            // ChapooUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 505);
            this.Controls.Add(this.barSelectTxtLbl);
            this.Controls.Add(this.bedieningSelectTxtLbl);
            this.Controls.Add(this.keukenSelectTxtLbl);
            this.Controls.Add(this.barSelectBtn);
            this.Controls.Add(this.bedieningSelectBtn);
            this.Controls.Add(this.keukenSelectBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChapooUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ChapooApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button keukenSelectBtn;
        private System.Windows.Forms.Button bedieningSelectBtn;
        private System.Windows.Forms.Button barSelectBtn;
        private System.Windows.Forms.Label keukenSelectTxtLbl;
        private System.Windows.Forms.Label bedieningSelectTxtLbl;
        private System.Windows.Forms.Label barSelectTxtLbl;
    }
}


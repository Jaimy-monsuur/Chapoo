namespace ChapooUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChapooUI));
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barSelectBtn = new System.Windows.Forms.Button();
            this.keukenSelectTxtLbl = new System.Windows.Forms.Label();
            this.bedieningSelectTxtLbl = new System.Windows.Forms.Label();
            this.barSelectTxtLbl = new System.Windows.Forms.Label();
            this.LBL_userdata = new System.Windows.Forms.Label();
            this.T_klok = new System.Windows.Forms.Timer(this.components);
            this.LBL_klok = new System.Windows.Forms.Label();
            this.bedieningSelectBtn = new System.Windows.Forms.Button();
            this.keukenSelectBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // barSelectBtn
            // 
            this.barSelectBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.barSelectBtn.Location = new System.Drawing.Point(941, 159);
            this.barSelectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.barSelectBtn.Name = "barSelectBtn";
            this.barSelectBtn.Size = new System.Drawing.Size(260, 235);
            this.barSelectBtn.TabIndex = 4;
            this.barSelectBtn.UseVisualStyleBackColor = true;
            // 
            // keukenSelectTxtLbl
            // 
            this.keukenSelectTxtLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.keukenSelectTxtLbl.AutoSize = true;
            this.keukenSelectTxtLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keukenSelectTxtLbl.Location = new System.Drawing.Point(161, 411);
            this.keukenSelectTxtLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.keukenSelectTxtLbl.Name = "keukenSelectTxtLbl";
            this.keukenSelectTxtLbl.Size = new System.Drawing.Size(82, 28);
            this.keukenSelectTxtLbl.TabIndex = 5;
            this.keukenSelectTxtLbl.Text = "Keuken";
            // 
            // bedieningSelectTxtLbl
            // 
            this.bedieningSelectTxtLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bedieningSelectTxtLbl.AutoSize = true;
            this.bedieningSelectTxtLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedieningSelectTxtLbl.Location = new System.Drawing.Point(592, 411);
            this.bedieningSelectTxtLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bedieningSelectTxtLbl.Name = "bedieningSelectTxtLbl";
            this.bedieningSelectTxtLbl.Size = new System.Drawing.Size(107, 28);
            this.bedieningSelectTxtLbl.TabIndex = 6;
            this.bedieningSelectTxtLbl.Text = "Bediening";
            // 
            // barSelectTxtLbl
            // 
            this.barSelectTxtLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.barSelectTxtLbl.AutoSize = true;
            this.barSelectTxtLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barSelectTxtLbl.Location = new System.Drawing.Point(1049, 411);
            this.barSelectTxtLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.barSelectTxtLbl.Name = "barSelectTxtLbl";
            this.barSelectTxtLbl.Size = new System.Drawing.Size(44, 28);
            this.barSelectTxtLbl.TabIndex = 7;
            this.barSelectTxtLbl.Text = "Bar";
            // 
            // LBL_userdata
            // 
            this.LBL_userdata.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_userdata.AutoSize = true;
            this.LBL_userdata.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_userdata.Location = new System.Drawing.Point(593, -1);
            this.LBL_userdata.Name = "LBL_userdata";
            this.LBL_userdata.Size = new System.Drawing.Size(84, 23);
            this.LBL_userdata.TabIndex = 9;
            this.LBL_userdata.Text = "user data";
            // 
            // T_klok
            // 
            this.T_klok.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LBL_klok
            // 
            this.LBL_klok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_klok.AutoSize = true;
            this.LBL_klok.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_klok.Location = new System.Drawing.Point(1050, -1);
            this.LBL_klok.Name = "LBL_klok";
            this.LBL_klok.Size = new System.Drawing.Size(45, 23);
            this.LBL_klok.TabIndex = 10;
            this.LBL_klok.Text = "klok";
            // 
            // bedieningSelectBtn
            // 
            this.bedieningSelectBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bedieningSelectBtn.BackgroundImage = global::ChapooUI.Properties.Resources.bediening_removebg_preview;
            this.bedieningSelectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bedieningSelectBtn.Location = new System.Drawing.Point(515, 159);
            this.bedieningSelectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.bedieningSelectBtn.Name = "bedieningSelectBtn";
            this.bedieningSelectBtn.Size = new System.Drawing.Size(260, 235);
            this.bedieningSelectBtn.TabIndex = 3;
            this.bedieningSelectBtn.UseVisualStyleBackColor = true;
            this.bedieningSelectBtn.Click += new System.EventHandler(this.bedieningSelectBtn_Click);
            // 
            // keukenSelectBtn
            // 
            this.keukenSelectBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.keukenSelectBtn.BackgroundImage = global::ChapooUI.Properties.Resources.keuken_foto;
            this.keukenSelectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.keukenSelectBtn.Location = new System.Drawing.Point(85, 159);
            this.keukenSelectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.keukenSelectBtn.Name = "keukenSelectBtn";
            this.keukenSelectBtn.Size = new System.Drawing.Size(260, 235);
            this.keukenSelectBtn.TabIndex = 2;
            this.keukenSelectBtn.UseVisualStyleBackColor = true;
            this.keukenSelectBtn.Click += new System.EventHandler(this.keukenSelectBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1185, -1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(99, 30);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.afsluitenToolStripMenuItem.Text = "Uitloggen";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // ChapooUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 622);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LBL_klok);
            this.Controls.Add(this.LBL_userdata);
            this.Controls.Add(this.barSelectTxtLbl);
            this.Controls.Add(this.bedieningSelectTxtLbl);
            this.Controls.Add(this.keukenSelectTxtLbl);
            this.Controls.Add(this.barSelectBtn);
            this.Controls.Add(this.bedieningSelectBtn);
            this.Controls.Add(this.keukenSelectBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChapooUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChapooApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button keukenSelectBtn;
        private System.Windows.Forms.Button bedieningSelectBtn;
        private System.Windows.Forms.Button barSelectBtn;
        private System.Windows.Forms.Label keukenSelectTxtLbl;
        private System.Windows.Forms.Label bedieningSelectTxtLbl;
        private System.Windows.Forms.Label barSelectTxtLbl;
        private System.Windows.Forms.Label LBL_userdata;
        private System.Windows.Forms.Timer T_klok;
        private System.Windows.Forms.Label LBL_klok;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
    }
}


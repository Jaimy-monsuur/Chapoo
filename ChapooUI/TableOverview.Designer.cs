
namespace ChapooUI
{
    partial class TableOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableOverview));
            this.LBL_TableStats = new System.Windows.Forms.Label();
            this.LBL_klok = new System.Windows.Forms.Label();
            this.T_klok = new System.Windows.Forms.Timer(this.components);
            this.LBL_UserData = new System.Windows.Forms.Label();
            this.LBL_legenda1 = new System.Windows.Forms.Label();
            this.LBL_legenda2 = new System.Windows.Forms.Label();
            this.LBL_legenda3 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MI_terug = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.BTN_ManageReservations = new System.Windows.Forms.Button();
            this.PNL_tafel10 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.LBL_tafel10_info = new System.Windows.Forms.Label();
            this.PNL_tafel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.LBL_tafel8_info = new System.Windows.Forms.Label();
            this.PNL_tafel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.LBL_tafel6_info = new System.Windows.Forms.Label();
            this.PNL_tafel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.LBL_tafel4_info = new System.Windows.Forms.Label();
            this.PNL_tafel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.LBL_tafel2_info = new System.Windows.Forms.Label();
            this.PNL_tafel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_tafel9_info = new System.Windows.Forms.Label();
            this.PNL_tafel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_tafel7_info = new System.Windows.Forms.Label();
            this.PNL_tafel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_tafel5_info = new System.Windows.Forms.Label();
            this.PNL_tafel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_tafel3_info = new System.Windows.Forms.Label();
            this.PNL_tafel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.LBL_tafel1_info = new System.Windows.Forms.Label();
            this.TUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.PNL_tafel10.SuspendLayout();
            this.PNL_tafel8.SuspendLayout();
            this.PNL_tafel6.SuspendLayout();
            this.PNL_tafel4.SuspendLayout();
            this.PNL_tafel2.SuspendLayout();
            this.PNL_tafel9.SuspendLayout();
            this.PNL_tafel7.SuspendLayout();
            this.PNL_tafel5.SuspendLayout();
            this.PNL_tafel3.SuspendLayout();
            this.PNL_tafel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_TableStats
            // 
            this.LBL_TableStats.AutoSize = true;
            this.LBL_TableStats.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TableStats.Location = new System.Drawing.Point(0, 525);
            this.LBL_TableStats.Name = "LBL_TableStats";
            this.LBL_TableStats.Size = new System.Drawing.Size(88, 23);
            this.LBL_TableStats.TabIndex = 22;
            this.LBL_TableStats.Text = "table info";
            // 
            // LBL_klok
            // 
            this.LBL_klok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_klok.AutoSize = true;
            this.LBL_klok.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_klok.Location = new System.Drawing.Point(1096, 0);
            this.LBL_klok.Name = "LBL_klok";
            this.LBL_klok.Size = new System.Drawing.Size(45, 23);
            this.LBL_klok.TabIndex = 24;
            this.LBL_klok.Text = "klok";
            // 
            // T_klok
            // 
            this.T_klok.Tick += new System.EventHandler(this.Timer_klok_Tick);
            // 
            // LBL_UserData
            // 
            this.LBL_UserData.AutoSize = true;
            this.LBL_UserData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UserData.Location = new System.Drawing.Point(71, 0);
            this.LBL_UserData.Name = "LBL_UserData";
            this.LBL_UserData.Size = new System.Drawing.Size(88, 23);
            this.LBL_UserData.TabIndex = 25;
            this.LBL_UserData.Text = "User Data";
            // 
            // LBL_legenda1
            // 
            this.LBL_legenda1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_legenda1.AutoSize = true;
            this.LBL_legenda1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LBL_legenda1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_legenda1.Location = new System.Drawing.Point(15, 57);
            this.LBL_legenda1.Name = "LBL_legenda1";
            this.LBL_legenda1.Size = new System.Drawing.Size(37, 23);
            this.LBL_legenda1.TabIndex = 26;
            this.LBL_legenda1.Text = "Vrij";
            // 
            // LBL_legenda2
            // 
            this.LBL_legenda2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_legenda2.AutoSize = true;
            this.LBL_legenda2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LBL_legenda2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_legenda2.Location = new System.Drawing.Point(71, 57);
            this.LBL_legenda2.Name = "LBL_legenda2";
            this.LBL_legenda2.Size = new System.Drawing.Size(116, 23);
            this.LBL_legenda2.TabIndex = 27;
            this.LBL_legenda2.Text = "Gereserveerd";
            // 
            // LBL_legenda3
            // 
            this.LBL_legenda3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBL_legenda3.AutoSize = true;
            this.LBL_legenda3.BackColor = System.Drawing.Color.Red;
            this.LBL_legenda3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_legenda3.Location = new System.Drawing.Point(219, 57);
            this.LBL_legenda3.Name = "LBL_legenda3";
            this.LBL_legenda3.Size = new System.Drawing.Size(54, 23);
            this.LBL_legenda3.TabIndex = 28;
            this.LBL_legenda3.Text = "Bezet";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_terug});
            this.menuStrip2.Location = new System.Drawing.Point(-1, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(69, 27);
            this.menuStrip2.TabIndex = 30;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MI_terug
            // 
            this.MI_terug.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.MI_terug.Name = "MI_terug";
            this.MI_terug.Size = new System.Drawing.Size(61, 23);
            this.MI_terug.Text = "Terug";
            this.MI_terug.Click += new System.EventHandler(this.TerugToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1195, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(97, 27);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.afsluitenToolStripMenuItem.Text = "Uitloggen";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.UitloggenToolStripMenuItem_Click);
            // 
            // BTN_Update
            // 
            this.BTN_Update.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_Update.Location = new System.Drawing.Point(1132, 571);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(141, 39);
            this.BTN_Update.TabIndex = 31;
            this.BTN_Update.Text = "Update";
            this.BTN_Update.UseVisualStyleBackColor = false;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // BTN_ManageReservations
            // 
            this.BTN_ManageReservations.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_ManageReservations.Location = new System.Drawing.Point(951, 571);
            this.BTN_ManageReservations.Name = "BTN_ManageReservations";
            this.BTN_ManageReservations.Size = new System.Drawing.Size(141, 39);
            this.BTN_ManageReservations.TabIndex = 32;
            this.BTN_ManageReservations.Text = "Reserveringen";
            this.BTN_ManageReservations.UseVisualStyleBackColor = false;
            this.BTN_ManageReservations.Click += new System.EventHandler(this.BTN_ManageReservations_Click);
            // 
            // PNL_tafel10
            // 
            this.PNL_tafel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PNL_tafel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PNL_tafel10.BackgroundImage")));
            this.PNL_tafel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PNL_tafel10.Controls.Add(this.label9);
            this.PNL_tafel10.Controls.Add(this.LBL_tafel10_info);
            this.PNL_tafel10.Location = new System.Drawing.Point(1030, 305);
            this.PNL_tafel10.Name = "PNL_tafel10";
            this.PNL_tafel10.Size = new System.Drawing.Size(250, 200);
            this.PNL_tafel10.TabIndex = 21;
            this.PNL_tafel10.Click += new System.EventHandler(this.PNL_tafel10_Click);
            // 
            // label9
            // 
            this.label9.AccessibleName = "";
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(95, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 38);
            this.label9.TabIndex = 25;
            this.label9.Text = "10";
            // 
            // LBL_tafel10_info
            // 
            this.LBL_tafel10_info.AutoSize = true;
            this.LBL_tafel10_info.Location = new System.Drawing.Point(11, 143);
            this.LBL_tafel10_info.Name = "LBL_tafel10_info";
            this.LBL_tafel10_info.Size = new System.Drawing.Size(51, 17);
            this.LBL_tafel10_info.TabIndex = 28;
            this.LBL_tafel10_info.Text = "tafel10";
            // 
            // PNL_tafel8
            // 
            this.PNL_tafel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PNL_tafel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PNL_tafel8.BackgroundImage")));
            this.PNL_tafel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PNL_tafel8.Controls.Add(this.label8);
            this.PNL_tafel8.Controls.Add(this.LBL_tafel8_info);
            this.PNL_tafel8.Location = new System.Drawing.Point(774, 305);
            this.PNL_tafel8.Name = "PNL_tafel8";
            this.PNL_tafel8.Size = new System.Drawing.Size(250, 200);
            this.PNL_tafel8.TabIndex = 18;
            this.PNL_tafel8.Click += new System.EventHandler(this.PNL_tafel8_Click);
            // 
            // label8
            // 
            this.label8.AccessibleName = "";
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(105, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 38);
            this.label8.TabIndex = 25;
            this.label8.Text = "8";
            // 
            // LBL_tafel8_info
            // 
            this.LBL_tafel8_info.AutoSize = true;
            this.LBL_tafel8_info.Location = new System.Drawing.Point(18, 143);
            this.LBL_tafel8_info.Name = "LBL_tafel8_info";
            this.LBL_tafel8_info.Size = new System.Drawing.Size(43, 17);
            this.LBL_tafel8_info.TabIndex = 28;
            this.LBL_tafel8_info.Text = "tafel8";
            // 
            // PNL_tafel6
            // 
            this.PNL_tafel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PNL_tafel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PNL_tafel6.BackgroundImage")));
            this.PNL_tafel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PNL_tafel6.Controls.Add(this.label7);
            this.PNL_tafel6.Controls.Add(this.LBL_tafel6_info);
            this.PNL_tafel6.Location = new System.Drawing.Point(518, 305);
            this.PNL_tafel6.Name = "PNL_tafel6";
            this.PNL_tafel6.Size = new System.Drawing.Size(250, 200);
            this.PNL_tafel6.TabIndex = 19;
            this.PNL_tafel6.Click += new System.EventHandler(this.PNL_tafel6_Click);
            // 
            // label7
            // 
            this.label7.AccessibleName = "";
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(104, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 38);
            this.label7.TabIndex = 25;
            this.label7.Text = "6";
            // 
            // LBL_tafel6_info
            // 
            this.LBL_tafel6_info.AutoSize = true;
            this.LBL_tafel6_info.Location = new System.Drawing.Point(22, 143);
            this.LBL_tafel6_info.Name = "LBL_tafel6_info";
            this.LBL_tafel6_info.Size = new System.Drawing.Size(43, 17);
            this.LBL_tafel6_info.TabIndex = 28;
            this.LBL_tafel6_info.Text = "tafel6";
            // 
            // PNL_tafel4
            // 
            this.PNL_tafel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PNL_tafel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PNL_tafel4.BackgroundImage")));
            this.PNL_tafel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PNL_tafel4.Controls.Add(this.label6);
            this.PNL_tafel4.Controls.Add(this.LBL_tafel4_info);
            this.PNL_tafel4.Location = new System.Drawing.Point(262, 305);
            this.PNL_tafel4.Name = "PNL_tafel4";
            this.PNL_tafel4.Size = new System.Drawing.Size(250, 200);
            this.PNL_tafel4.TabIndex = 20;
            this.PNL_tafel4.Click += new System.EventHandler(this.PNL_tafel4_Click);
            // 
            // label6
            // 
            this.label6.AccessibleName = "";
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(102, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 38);
            this.label6.TabIndex = 25;
            this.label6.Text = "4";
            // 
            // LBL_tafel4_info
            // 
            this.LBL_tafel4_info.AutoSize = true;
            this.LBL_tafel4_info.Location = new System.Drawing.Point(13, 143);
            this.LBL_tafel4_info.Name = "LBL_tafel4_info";
            this.LBL_tafel4_info.Size = new System.Drawing.Size(43, 17);
            this.LBL_tafel4_info.TabIndex = 28;
            this.LBL_tafel4_info.Text = "tafel4";
            // 
            // PNL_tafel2
            // 
            this.PNL_tafel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PNL_tafel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PNL_tafel2.BackgroundImage")));
            this.PNL_tafel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PNL_tafel2.Controls.Add(this.label5);
            this.PNL_tafel2.Controls.Add(this.LBL_tafel2_info);
            this.PNL_tafel2.Location = new System.Drawing.Point(6, 305);
            this.PNL_tafel2.Name = "PNL_tafel2";
            this.PNL_tafel2.Size = new System.Drawing.Size(250, 200);
            this.PNL_tafel2.TabIndex = 17;
            this.PNL_tafel2.Click += new System.EventHandler(this.PNL_tafel2_Click);
            // 
            // label5
            // 
            this.label5.AccessibleName = "";
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(103, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 38);
            this.label5.TabIndex = 25;
            this.label5.Text = "2";
            // 
            // LBL_tafel2_info
            // 
            this.LBL_tafel2_info.AutoSize = true;
            this.LBL_tafel2_info.Location = new System.Drawing.Point(9, 143);
            this.LBL_tafel2_info.Name = "LBL_tafel2_info";
            this.LBL_tafel2_info.Size = new System.Drawing.Size(43, 17);
            this.LBL_tafel2_info.TabIndex = 27;
            this.LBL_tafel2_info.Text = "tafel2";
            // 
            // PNL_tafel9
            // 
            this.PNL_tafel9.AccessibleName = "nummer";
            this.PNL_tafel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PNL_tafel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PNL_tafel9.BackgroundImage")));
            this.PNL_tafel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PNL_tafel9.Controls.Add(this.label4);
            this.PNL_tafel9.Controls.Add(this.LBL_tafel9_info);
            this.PNL_tafel9.Location = new System.Drawing.Point(1030, 99);
            this.PNL_tafel9.Name = "PNL_tafel9";
            this.PNL_tafel9.Size = new System.Drawing.Size(250, 200);
            this.PNL_tafel9.TabIndex = 15;
            this.PNL_tafel9.Click += new System.EventHandler(this.PNL_tafel9_Click);
            // 
            // label4
            // 
            this.label4.AccessibleName = "";
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(104, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 38);
            this.label4.TabIndex = 25;
            this.label4.Text = "9";
            // 
            // LBL_tafel9_info
            // 
            this.LBL_tafel9_info.AutoSize = true;
            this.LBL_tafel9_info.Location = new System.Drawing.Point(19, 141);
            this.LBL_tafel9_info.Name = "LBL_tafel9_info";
            this.LBL_tafel9_info.Size = new System.Drawing.Size(43, 17);
            this.LBL_tafel9_info.TabIndex = 26;
            this.LBL_tafel9_info.Text = "tafel9";
            // 
            // PNL_tafel7
            // 
            this.PNL_tafel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PNL_tafel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PNL_tafel7.BackgroundImage")));
            this.PNL_tafel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PNL_tafel7.Controls.Add(this.label3);
            this.PNL_tafel7.Controls.Add(this.LBL_tafel7_info);
            this.PNL_tafel7.Location = new System.Drawing.Point(774, 99);
            this.PNL_tafel7.Name = "PNL_tafel7";
            this.PNL_tafel7.Size = new System.Drawing.Size(250, 200);
            this.PNL_tafel7.TabIndex = 14;
            this.PNL_tafel7.Click += new System.EventHandler(this.PNL_tafel7_Click);
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(105, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 38);
            this.label3.TabIndex = 26;
            this.label3.Text = "7";
            // 
            // LBL_tafel7_info
            // 
            this.LBL_tafel7_info.AutoSize = true;
            this.LBL_tafel7_info.Location = new System.Drawing.Point(18, 141);
            this.LBL_tafel7_info.Name = "LBL_tafel7_info";
            this.LBL_tafel7_info.Size = new System.Drawing.Size(43, 17);
            this.LBL_tafel7_info.TabIndex = 25;
            this.LBL_tafel7_info.Text = "tafel7";
            // 
            // PNL_tafel5
            // 
            this.PNL_tafel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PNL_tafel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PNL_tafel5.BackgroundImage")));
            this.PNL_tafel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PNL_tafel5.Controls.Add(this.label2);
            this.PNL_tafel5.Controls.Add(this.LBL_tafel5_info);
            this.PNL_tafel5.Location = new System.Drawing.Point(518, 99);
            this.PNL_tafel5.Name = "PNL_tafel5";
            this.PNL_tafel5.Size = new System.Drawing.Size(250, 200);
            this.PNL_tafel5.TabIndex = 14;
            this.PNL_tafel5.Click += new System.EventHandler(this.PNL_tafel5_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 38);
            this.label2.TabIndex = 25;
            this.label2.Text = "5";
            // 
            // LBL_tafel5_info
            // 
            this.LBL_tafel5_info.AutoSize = true;
            this.LBL_tafel5_info.Location = new System.Drawing.Point(22, 141);
            this.LBL_tafel5_info.Name = "LBL_tafel5_info";
            this.LBL_tafel5_info.Size = new System.Drawing.Size(43, 17);
            this.LBL_tafel5_info.TabIndex = 24;
            this.LBL_tafel5_info.Text = "tafel5";
            // 
            // PNL_tafel3
            // 
            this.PNL_tafel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PNL_tafel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PNL_tafel3.BackgroundImage")));
            this.PNL_tafel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PNL_tafel3.Controls.Add(this.label1);
            this.PNL_tafel3.Controls.Add(this.LBL_tafel3_info);
            this.PNL_tafel3.Location = new System.Drawing.Point(262, 99);
            this.PNL_tafel3.Name = "PNL_tafel3";
            this.PNL_tafel3.Size = new System.Drawing.Size(250, 200);
            this.PNL_tafel3.TabIndex = 14;
            this.PNL_tafel3.Click += new System.EventHandler(this.PNL_tafel3_Click);
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "3";
            // 
            // LBL_tafel3_info
            // 
            this.LBL_tafel3_info.AutoSize = true;
            this.LBL_tafel3_info.Location = new System.Drawing.Point(13, 141);
            this.LBL_tafel3_info.Name = "LBL_tafel3_info";
            this.LBL_tafel3_info.Size = new System.Drawing.Size(43, 17);
            this.LBL_tafel3_info.TabIndex = 23;
            this.LBL_tafel3_info.Text = "tafel3";
            // 
            // PNL_tafel1
            // 
            this.PNL_tafel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PNL_tafel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PNL_tafel1.BackgroundImage")));
            this.PNL_tafel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PNL_tafel1.Controls.Add(this.label);
            this.PNL_tafel1.Controls.Add(this.LBL_tafel1_info);
            this.PNL_tafel1.Location = new System.Drawing.Point(6, 99);
            this.PNL_tafel1.Name = "PNL_tafel1";
            this.PNL_tafel1.Size = new System.Drawing.Size(250, 200);
            this.PNL_tafel1.TabIndex = 13;
            this.PNL_tafel1.Click += new System.EventHandler(this.PNL_tafel1_Click);
            // 
            // label
            // 
            this.label.AccessibleName = "";
            this.label.AutoEllipsis = true;
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(103, 52);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(36, 38);
            this.label.TabIndex = 24;
            this.label.Text = "1";
            // 
            // LBL_tafel1_info
            // 
            this.LBL_tafel1_info.AutoSize = true;
            this.LBL_tafel1_info.Location = new System.Drawing.Point(9, 141);
            this.LBL_tafel1_info.Name = "LBL_tafel1_info";
            this.LBL_tafel1_info.Size = new System.Drawing.Size(43, 17);
            this.LBL_tafel1_info.TabIndex = 22;
            this.LBL_tafel1_info.Text = "tafel1";
            // 
            // TUpdateTimer
            // 
            this.TUpdateTimer.Interval = 60000;
            this.TUpdateTimer.Tick += new System.EventHandler(this.TUpdateTimer_Tick);
            // 
            // TableOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1286, 622);
            this.Controls.Add(this.BTN_ManageReservations);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LBL_legenda3);
            this.Controls.Add(this.LBL_legenda2);
            this.Controls.Add(this.LBL_legenda1);
            this.Controls.Add(this.LBL_UserData);
            this.Controls.Add(this.LBL_klok);
            this.Controls.Add(this.LBL_TableStats);
            this.Controls.Add(this.PNL_tafel10);
            this.Controls.Add(this.PNL_tafel8);
            this.Controls.Add(this.PNL_tafel6);
            this.Controls.Add(this.PNL_tafel4);
            this.Controls.Add(this.PNL_tafel2);
            this.Controls.Add(this.PNL_tafel9);
            this.Controls.Add(this.PNL_tafel7);
            this.Controls.Add(this.PNL_tafel5);
            this.Controls.Add(this.PNL_tafel3);
            this.Controls.Add(this.PNL_tafel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TableOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "table info";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PNL_tafel10.ResumeLayout(false);
            this.PNL_tafel10.PerformLayout();
            this.PNL_tafel8.ResumeLayout(false);
            this.PNL_tafel8.PerformLayout();
            this.PNL_tafel6.ResumeLayout(false);
            this.PNL_tafel6.PerformLayout();
            this.PNL_tafel4.ResumeLayout(false);
            this.PNL_tafel4.PerformLayout();
            this.PNL_tafel2.ResumeLayout(false);
            this.PNL_tafel2.PerformLayout();
            this.PNL_tafel9.ResumeLayout(false);
            this.PNL_tafel9.PerformLayout();
            this.PNL_tafel7.ResumeLayout(false);
            this.PNL_tafel7.PerformLayout();
            this.PNL_tafel5.ResumeLayout(false);
            this.PNL_tafel5.PerformLayout();
            this.PNL_tafel3.ResumeLayout(false);
            this.PNL_tafel3.PerformLayout();
            this.PNL_tafel1.ResumeLayout(false);
            this.PNL_tafel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PNL_tafel1;
        private System.Windows.Forms.Panel PNL_tafel3;
        private System.Windows.Forms.Panel PNL_tafel5;
        private System.Windows.Forms.Panel PNL_tafel7;
        private System.Windows.Forms.Panel PNL_tafel9;
        private System.Windows.Forms.Label LBL_tafel1_info;
        private System.Windows.Forms.Label LBL_tafel3_info;
        private System.Windows.Forms.Label LBL_tafel5_info;
        private System.Windows.Forms.Label LBL_tafel7_info;
        private System.Windows.Forms.Label LBL_tafel9_info;
        private System.Windows.Forms.Label LBL_tafel2_info;
        private System.Windows.Forms.Panel PNL_tafel2;
        private System.Windows.Forms.Panel PNL_tafel4;
        private System.Windows.Forms.Label LBL_tafel4_info;
        private System.Windows.Forms.Panel PNL_tafel6;
        private System.Windows.Forms.Label LBL_tafel6_info;
        private System.Windows.Forms.Panel PNL_tafel8;
        private System.Windows.Forms.Label LBL_tafel8_info;
        private System.Windows.Forms.Panel PNL_tafel10;
        private System.Windows.Forms.Label LBL_tafel10_info;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBL_TableStats;
        private System.Windows.Forms.Label LBL_klok;
        private System.Windows.Forms.Timer T_klok;
        private System.Windows.Forms.Label LBL_UserData;
        private System.Windows.Forms.Label LBL_legenda1;
        private System.Windows.Forms.Label LBL_legenda2;
        private System.Windows.Forms.Label LBL_legenda3;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MI_terug;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.Button BTN_ManageReservations;
        private System.Windows.Forms.Timer TUpdateTimer;
    }
}
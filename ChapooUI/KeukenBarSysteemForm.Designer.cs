
namespace ChapooUI
{
    partial class KeukenBarSysteemForm
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
            this.listViewKeukenBarOpenstaand = new System.Windows.Forms.ListView();
            this.listViewKeukenBarOpmerkingen = new System.Windows.Forms.ListView();
            this.gereedKeukenBarBtn = new System.Windows.Forms.Button();
            this.openstaandeBestellingenTxtLbl = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TerugtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.LBL_userdata = new System.Windows.Forms.Label();
            this.LBL_klok = new System.Windows.Forms.Label();
            this.T_klok = new System.Windows.Forms.Timer(this.components);
            this.TUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewKeukenBarOpenstaand
            // 
            this.listViewKeukenBarOpenstaand.HideSelection = false;
            this.listViewKeukenBarOpenstaand.Location = new System.Drawing.Point(25, 85);
            this.listViewKeukenBarOpenstaand.Name = "listViewKeukenBarOpenstaand";
            this.listViewKeukenBarOpenstaand.Size = new System.Drawing.Size(522, 347);
            this.listViewKeukenBarOpenstaand.TabIndex = 1;
            this.listViewKeukenBarOpenstaand.UseCompatibleStateImageBehavior = false;
            // 
            // listViewKeukenBarOpmerkingen
            // 
            this.listViewKeukenBarOpmerkingen.HideSelection = false;
            this.listViewKeukenBarOpmerkingen.Location = new System.Drawing.Point(590, 85);
            this.listViewKeukenBarOpmerkingen.Name = "listViewKeukenBarOpmerkingen";
            this.listViewKeukenBarOpmerkingen.Size = new System.Drawing.Size(317, 220);
            this.listViewKeukenBarOpmerkingen.TabIndex = 2;
            this.listViewKeukenBarOpmerkingen.UseCompatibleStateImageBehavior = false;
            // 
            // gereedKeukenBarBtn
            // 
            this.gereedKeukenBarBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gereedKeukenBarBtn.Location = new System.Drawing.Point(673, 382);
            this.gereedKeukenBarBtn.Name = "gereedKeukenBarBtn";
            this.gereedKeukenBarBtn.Size = new System.Drawing.Size(141, 50);
            this.gereedKeukenBarBtn.TabIndex = 3;
            this.gereedKeukenBarBtn.Text = "Gereed melden";
            this.gereedKeukenBarBtn.UseVisualStyleBackColor = false;
            this.gereedKeukenBarBtn.Click += new System.EventHandler(this.gereedKeukenBarBtn_Click);
            // 
            // openstaandeBestellingenTxtLbl
            // 
            this.openstaandeBestellingenTxtLbl.AutoSize = true;
            this.openstaandeBestellingenTxtLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openstaandeBestellingenTxtLbl.Location = new System.Drawing.Point(20, 48);
            this.openstaandeBestellingenTxtLbl.Name = "openstaandeBestellingenTxtLbl";
            this.openstaandeBestellingenTxtLbl.Size = new System.Drawing.Size(232, 25);
            this.openstaandeBestellingenTxtLbl.TabIndex = 5;
            this.openstaandeBestellingenTxtLbl.Text = "Openstaande bestellingen";
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
            this.menuStrip2.TabIndex = 30;
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
            this.menuStrip1.TabIndex = 29;
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
            // BTN_Update
            // 
            this.BTN_Update.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_Update.Location = new System.Drawing.Point(845, 462);
            this.BTN_Update.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(106, 32);
            this.BTN_Update.TabIndex = 32;
            this.BTN_Update.Text = "Update";
            this.BTN_Update.UseVisualStyleBackColor = false;
            this.BTN_Update.Click += new System.EventHandler(this.BTN_Update_Click);
            // 
            // LBL_userdata
            // 
            this.LBL_userdata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_userdata.AutoSize = true;
            this.LBL_userdata.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_userdata.Location = new System.Drawing.Point(52, 0);
            this.LBL_userdata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_userdata.Name = "LBL_userdata";
            this.LBL_userdata.Size = new System.Drawing.Size(71, 19);
            this.LBL_userdata.TabIndex = 33;
            this.LBL_userdata.Text = "user data";
            // 
            // LBL_klok
            // 
            this.LBL_klok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_klok.AutoSize = true;
            this.LBL_klok.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_klok.Location = new System.Drawing.Point(820, -1);
            this.LBL_klok.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_klok.Name = "LBL_klok";
            this.LBL_klok.Size = new System.Drawing.Size(38, 19);
            this.LBL_klok.TabIndex = 34;
            this.LBL_klok.Text = "klok";
            // 
            // T_klok
            // 
            this.T_klok.Tick += new System.EventHandler(this.T_klok_Tick);
            // 
            // TUpdateTimer
            // 
            this.TUpdateTimer.Interval = 60000;
            this.TUpdateTimer.Tick += new System.EventHandler(this.TUpdateTimer_Tick);
            // 
            // KeukenBarSysteemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 505);
            this.Controls.Add(this.LBL_klok);
            this.Controls.Add(this.LBL_userdata);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.openstaandeBestellingenTxtLbl);
            this.Controls.Add(this.gereedKeukenBarBtn);
            this.Controls.Add(this.listViewKeukenBarOpmerkingen);
            this.Controls.Add(this.listViewKeukenBarOpenstaand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KeukenBarSysteemForm";
            this.Text = "KeukenSysteemForm";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewKeukenBarOpenstaand;
        private System.Windows.Forms.ListView listViewKeukenBarOpmerkingen;
        private System.Windows.Forms.Button gereedKeukenBarBtn;
        private System.Windows.Forms.Label openstaandeBestellingenTxtLbl;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem TerugtoolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UitloggenToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.Label LBL_userdata;
        private System.Windows.Forms.Label LBL_klok;
        private System.Windows.Forms.Timer T_klok;
        private System.Windows.Forms.Timer TUpdateTimer;
    }
}
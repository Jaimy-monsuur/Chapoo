
namespace ChapooUI
{
    partial class MenuWijzigen
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
            this.Btn_VerwijderMenuItem = new System.Windows.Forms.Button();
            this.BTNtoevoegen = new System.Windows.Forms.Button();
            this.LV_MenuWijzig = new System.Windows.Forms.ListView();
            this.itemNummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NaamMenu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrijsMenu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TsMenuTerug = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rBDranken = new System.Windows.Forms.RadioButton();
            this.rBAvond = new System.Windows.Forms.RadioButton();
            this.rBLunch = new System.Windows.Forms.RadioButton();
            this.lblErrorBox = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_VerwijderMenuItem
            // 
            this.Btn_VerwijderMenuItem.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_VerwijderMenuItem.Location = new System.Drawing.Point(521, 408);
            this.Btn_VerwijderMenuItem.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_VerwijderMenuItem.Name = "Btn_VerwijderMenuItem";
            this.Btn_VerwijderMenuItem.Size = new System.Drawing.Size(122, 31);
            this.Btn_VerwijderMenuItem.TabIndex = 40;
            this.Btn_VerwijderMenuItem.Text = "Verwijder menuitem";
            this.Btn_VerwijderMenuItem.UseVisualStyleBackColor = false;
            this.Btn_VerwijderMenuItem.Click += new System.EventHandler(this.Btn_VerwijderMenuItem_Click);
            // 
            // BTNtoevoegen
            // 
            this.BTNtoevoegen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTNtoevoegen.Location = new System.Drawing.Point(654, 408);
            this.BTNtoevoegen.Margin = new System.Windows.Forms.Padding(2);
            this.BTNtoevoegen.Name = "BTNtoevoegen";
            this.BTNtoevoegen.Size = new System.Drawing.Size(122, 31);
            this.BTNtoevoegen.TabIndex = 39;
            this.BTNtoevoegen.Text = "Nieuw menuitem";
            this.BTNtoevoegen.UseVisualStyleBackColor = false;
            this.BTNtoevoegen.Click += new System.EventHandler(this.BTNtoevoegen_Click);
            // 
            // LV_MenuWijzig
            // 
            this.LV_MenuWijzig.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemNummer,
            this.NaamMenu,
            this.PrijsMenu});
            this.LV_MenuWijzig.FullRowSelect = true;
            this.LV_MenuWijzig.GridLines = true;
            this.LV_MenuWijzig.HideSelection = false;
            this.LV_MenuWijzig.Location = new System.Drawing.Point(73, 47);
            this.LV_MenuWijzig.Margin = new System.Windows.Forms.Padding(2);
            this.LV_MenuWijzig.Name = "LV_MenuWijzig";
            this.LV_MenuWijzig.Size = new System.Drawing.Size(703, 329);
            this.LV_MenuWijzig.TabIndex = 38;
            this.LV_MenuWijzig.UseCompatibleStateImageBehavior = false;
            this.LV_MenuWijzig.View = System.Windows.Forms.View.Details;
            // 
            // itemNummer
            // 
            this.itemNummer.Text = "ItemNummer";
            this.itemNummer.Width = 78;
            // 
            // NaamMenu
            // 
            this.NaamMenu.Text = "Naam:";
            this.NaamMenu.Width = 539;
            // 
            // PrijsMenu
            // 
            this.PrijsMenu.Text = "Prijs:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsMenuTerug});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(174, 24);
            this.menuStrip2.TabIndex = 37;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // TsMenuTerug
            // 
            this.TsMenuTerug.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.TsMenuTerug.Name = "TsMenuTerug";
            this.TsMenuTerug.Size = new System.Drawing.Size(48, 20);
            this.TsMenuTerug.Text = "Terug";
            this.TsMenuTerug.Click += new System.EventHandler(this.TsMenuTerug_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UitloggenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(723, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(77, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UitloggenToolStripMenuItem
            // 
            this.UitloggenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.UitloggenToolStripMenuItem.Name = "UitloggenToolStripMenuItem";
            this.UitloggenToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.UitloggenToolStripMenuItem.Text = "Uitloggen";
            // 
            // rBDranken
            // 
            this.rBDranken.AutoSize = true;
            this.rBDranken.Checked = true;
            this.rBDranken.Location = new System.Drawing.Point(12, 91);
            this.rBDranken.Name = "rBDranken";
            this.rBDranken.Size = new System.Drawing.Size(54, 17);
            this.rBDranken.TabIndex = 43;
            this.rBDranken.TabStop = true;
            this.rBDranken.Text = "Drank";
            this.rBDranken.UseVisualStyleBackColor = true;
            this.rBDranken.CheckedChanged += new System.EventHandler(this.rBDranken_CheckedChanged);
            // 
            // rBAvond
            // 
            this.rBAvond.AutoSize = true;
            this.rBAvond.Location = new System.Drawing.Point(12, 68);
            this.rBAvond.Name = "rBAvond";
            this.rBAvond.Size = new System.Drawing.Size(56, 17);
            this.rBAvond.TabIndex = 42;
            this.rBAvond.Text = "Avond";
            this.rBAvond.UseVisualStyleBackColor = true;
            this.rBAvond.CheckedChanged += new System.EventHandler(this.rBAvond_CheckedChanged);
            // 
            // rBLunch
            // 
            this.rBLunch.AutoSize = true;
            this.rBLunch.Location = new System.Drawing.Point(12, 45);
            this.rBLunch.Name = "rBLunch";
            this.rBLunch.Size = new System.Drawing.Size(55, 17);
            this.rBLunch.TabIndex = 41;
            this.rBLunch.Text = "Lunch";
            this.rBLunch.UseVisualStyleBackColor = true;
            this.rBLunch.CheckedChanged += new System.EventHandler(this.rBLunch_CheckedChanged);
            // 
            // lblErrorBox
            // 
            this.lblErrorBox.AutoSize = true;
            this.lblErrorBox.Location = new System.Drawing.Point(521, 390);
            this.lblErrorBox.Name = "lblErrorBox";
            this.lblErrorBox.Size = new System.Drawing.Size(0, 13);
            this.lblErrorBox.TabIndex = 44;
            // 
            // MenuWijzigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErrorBox);
            this.Controls.Add(this.rBDranken);
            this.Controls.Add(this.rBAvond);
            this.Controls.Add(this.rBLunch);
            this.Controls.Add(this.Btn_VerwijderMenuItem);
            this.Controls.Add(this.BTNtoevoegen);
            this.Controls.Add(this.LV_MenuWijzig);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuWijzigen";
            this.Text = "MenuWijzigen";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_VerwijderMenuItem;
        private System.Windows.Forms.Button BTNtoevoegen;
        private System.Windows.Forms.ListView LV_MenuWijzig;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem TsMenuTerug;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UitloggenToolStripMenuItem;
        private System.Windows.Forms.RadioButton rBDranken;
        private System.Windows.Forms.RadioButton rBAvond;
        private System.Windows.Forms.RadioButton rBLunch;
        private System.Windows.Forms.Label lblErrorBox;
        private System.Windows.Forms.ColumnHeader itemNummer;
        private System.Windows.Forms.ColumnHeader NaamMenu;
        private System.Windows.Forms.ColumnHeader PrijsMenu;
    }
}
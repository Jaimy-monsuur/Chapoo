
namespace ChapooUI
{
    partial class Bestellingen
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
            this.lblDrankTxt = new System.Windows.Forms.Label();
            this.lblEtenTxt = new System.Windows.Forms.Label();
            this.plaatsOrderBarBtn = new System.Windows.Forms.Button();
            this.terugKeukenBarBtn = new System.Windows.Forms.Button();
            this.LvDrankenMenu = new System.Windows.Forms.ListView();
            this.Dranken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrijsDr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AantalDr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvEtenMenu = new System.Windows.Forms.ListView();
            this.Gerecht = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTafelnr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTafelNummerIn = new System.Windows.Forms.Label();
            this.txtOpmerkingBestelling = new System.Windows.Forms.TextBox();
            this.LBL_UserData = new System.Windows.Forms.Label();
            this.LBL_klok = new System.Windows.Forms.Label();
            this.btn_Uitlog = new System.Windows.Forms.MenuStrip();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.btn_Uitlog.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDrankTxt
            // 
            this.lblDrankTxt.AutoSize = true;
            this.lblDrankTxt.Location = new System.Drawing.Point(394, 55);
            this.lblDrankTxt.Name = "lblDrankTxt";
            this.lblDrankTxt.Size = new System.Drawing.Size(48, 13);
            this.lblDrankTxt.TabIndex = 12;
            this.lblDrankTxt.Text = "Dranken";
            // 
            // lblEtenTxt
            // 
            this.lblEtenTxt.AutoSize = true;
            this.lblEtenTxt.Location = new System.Drawing.Point(71, 55);
            this.lblEtenTxt.Name = "lblEtenTxt";
            this.lblEtenTxt.Size = new System.Drawing.Size(29, 13);
            this.lblEtenTxt.TabIndex = 11;
            this.lblEtenTxt.Text = "Eten";
            // 
            // plaatsOrderBarBtn
            // 
            this.plaatsOrderBarBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.plaatsOrderBarBtn.Location = new System.Drawing.Point(74, 388);
            this.plaatsOrderBarBtn.Name = "plaatsOrderBarBtn";
            this.plaatsOrderBarBtn.Size = new System.Drawing.Size(142, 50);
            this.plaatsOrderBarBtn.TabIndex = 10;
            this.plaatsOrderBarBtn.Text = "Plaats order";
            this.plaatsOrderBarBtn.UseVisualStyleBackColor = false;
            // 
            // terugKeukenBarBtn
            // 
            this.terugKeukenBarBtn.BackColor = System.Drawing.Color.LightCoral;
            this.terugKeukenBarBtn.Location = new System.Drawing.Point(71, 12);
            this.terugKeukenBarBtn.Name = "terugKeukenBarBtn";
            this.terugKeukenBarBtn.Size = new System.Drawing.Size(101, 36);
            this.terugKeukenBarBtn.TabIndex = 9;
            this.terugKeukenBarBtn.Text = "Terug naar home menu";
            this.terugKeukenBarBtn.UseVisualStyleBackColor = false;
            // 
            // LvDrankenMenu
            // 
            this.LvDrankenMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dranken,
            this.PrijsDr,
            this.AantalDr});
            this.LvDrankenMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LvDrankenMenu.FullRowSelect = true;
            this.LvDrankenMenu.GridLines = true;
            this.LvDrankenMenu.HideSelection = false;
            this.LvDrankenMenu.Location = new System.Drawing.Point(397, 71);
            this.LvDrankenMenu.Name = "LvDrankenMenu";
            this.LvDrankenMenu.Size = new System.Drawing.Size(318, 304);
            this.LvDrankenMenu.TabIndex = 8;
            this.LvDrankenMenu.UseCompatibleStateImageBehavior = false;
            // 
            // Dranken
            // 
            this.Dranken.Text = "Dranken";
            // 
            // PrijsDr
            // 
            this.PrijsDr.Text = "Prijs";
            this.PrijsDr.Width = 30;
            // 
            // AantalDr
            // 
            this.AantalDr.Text = "Aantal";
            this.AantalDr.Width = 30;
            // 
            // LvEtenMenu
            // 
            this.LvEtenMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Gerecht,
            this.Prijs,
            this.Aantal});
            this.LvEtenMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LvEtenMenu.FullRowSelect = true;
            this.LvEtenMenu.GridLines = true;
            this.LvEtenMenu.HideSelection = false;
            this.LvEtenMenu.Location = new System.Drawing.Point(71, 71);
            this.LvEtenMenu.Name = "LvEtenMenu";
            this.LvEtenMenu.Size = new System.Drawing.Size(318, 304);
            this.LvEtenMenu.TabIndex = 7;
            this.LvEtenMenu.UseCompatibleStateImageBehavior = false;
            // 
            // Gerecht
            // 
            this.Gerecht.Text = "Gerecht";
            this.Gerecht.Width = 120;
            // 
            // Prijs
            // 
            this.Prijs.Text = "Prijs";
            this.Prijs.Width = 30;
            // 
            // Aantal
            // 
            this.Aantal.Text = "Aantal";
            this.Aantal.Width = 30;
            // 
            // lblTafelnr
            // 
            this.lblTafelnr.AutoSize = true;
            this.lblTafelnr.BackColor = System.Drawing.Color.Transparent;
            this.lblTafelnr.Location = new System.Drawing.Point(3, 4);
            this.lblTafelnr.Name = "lblTafelnr";
            this.lblTafelnr.Size = new System.Drawing.Size(43, 13);
            this.lblTafelnr.TabIndex = 13;
            this.lblTafelnr.Text = "Tafelnr.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblTafelNummerIn);
            this.panel1.Controls.Add(this.lblTafelnr);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 56);
            this.panel1.TabIndex = 14;
            // 
            // lblTafelNummerIn
            // 
            this.lblTafelNummerIn.AutoSize = true;
            this.lblTafelNummerIn.Location = new System.Drawing.Point(16, 32);
            this.lblTafelNummerIn.Name = "lblTafelNummerIn";
            this.lblTafelNummerIn.Size = new System.Drawing.Size(16, 13);
            this.lblTafelNummerIn.TabIndex = 14;
            this.lblTafelNummerIn.Text = "...";
            this.lblTafelNummerIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtOpmerkingBestelling
            // 
            this.txtOpmerkingBestelling.Location = new System.Drawing.Point(397, 388);
            this.txtOpmerkingBestelling.Name = "txtOpmerkingBestelling";
            this.txtOpmerkingBestelling.Size = new System.Drawing.Size(318, 20);
            this.txtOpmerkingBestelling.TabIndex = 15;
            this.txtOpmerkingBestelling.Text = "Opmerkingen:";
            // 
            // LBL_UserData
            // 
            this.LBL_UserData.AutoSize = true;
            this.LBL_UserData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UserData.Location = new System.Drawing.Point(356, 5);
            this.LBL_UserData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_UserData.Name = "LBL_UserData";
            this.LBL_UserData.Size = new System.Drawing.Size(74, 19);
            this.LBL_UserData.TabIndex = 26;
            this.LBL_UserData.Text = "User Data";
            // 
            // LBL_klok
            // 
            this.LBL_klok.AutoSize = true;
            this.LBL_klok.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_klok.Location = new System.Drawing.Point(611, 5);
            this.LBL_klok.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_klok.Name = "LBL_klok";
            this.LBL_klok.Size = new System.Drawing.Size(38, 19);
            this.LBL_klok.TabIndex = 27;
            this.LBL_klok.Text = "klok";
            this.LBL_klok.Click += new System.EventHandler(this.LBL_klok_Click);
            // 
            // btn_Uitlog
            // 
            this.btn_Uitlog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Uitlog.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Uitlog.Dock = System.Windows.Forms.DockStyle.None;
            this.btn_Uitlog.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.btn_Uitlog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem});
            this.btn_Uitlog.Location = new System.Drawing.Point(724, 5);
            this.btn_Uitlog.Name = "btn_Uitlog";
            this.btn_Uitlog.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.btn_Uitlog.Size = new System.Drawing.Size(77, 24);
            this.btn_Uitlog.TabIndex = 30;
            this.btn_Uitlog.Text = "Uitloggen";
            this.btn_Uitlog.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btn_Uitlog_ItemClicked);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.afsluitenToolStripMenuItem.Text = "Uitloggen";
            // 
            // Bestellingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Uitlog);
            this.Controls.Add(this.LBL_klok);
            this.Controls.Add(this.LBL_UserData);
            this.Controls.Add(this.txtOpmerkingBestelling);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDrankTxt);
            this.Controls.Add(this.lblEtenTxt);
            this.Controls.Add(this.plaatsOrderBarBtn);
            this.Controls.Add(this.terugKeukenBarBtn);
            this.Controls.Add(this.LvDrankenMenu);
            this.Controls.Add(this.LvEtenMenu);
            this.Name = "Bestellingen";
            this.Text = "Bestellingen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.btn_Uitlog.ResumeLayout(false);
            this.btn_Uitlog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrankTxt;
        private System.Windows.Forms.Label lblEtenTxt;
        private System.Windows.Forms.Button plaatsOrderBarBtn;
        private System.Windows.Forms.Button terugKeukenBarBtn;
        private System.Windows.Forms.ListView LvDrankenMenu;
        private System.Windows.Forms.ListView LvEtenMenu;
        private System.Windows.Forms.Label lblTafelnr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTafelNummerIn;
        private System.Windows.Forms.ColumnHeader Gerecht;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.ColumnHeader Aantal;
        private System.Windows.Forms.ColumnHeader Dranken;
        private System.Windows.Forms.ColumnHeader PrijsDr;
        private System.Windows.Forms.ColumnHeader AantalDr;
        private System.Windows.Forms.TextBox txtOpmerkingBestelling;
        private System.Windows.Forms.Label LBL_UserData;
        private System.Windows.Forms.Label LBL_klok;
        private System.Windows.Forms.MenuStrip btn_Uitlog;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
    }
}

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
            this.LvDrankenMenu = new System.Windows.Forms.ListView();
            this.Dranken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrijsDr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvEtenMenu = new System.Windows.Forms.ListView();
            this.Gerecht = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTafelnr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTafelNummerIn = new System.Windows.Forms.Label();
            this.txtOpmerkingBestelling = new System.Windows.Forms.TextBox();
            this.LBL_UserDataOr = new System.Windows.Forms.Label();
            this.LBL_klokOr = new System.Windows.Forms.Label();
            this.btn_Uitlog = new System.Windows.Forms.MenuStrip();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MI_terug = new System.Windows.Forms.ToolStripMenuItem();
            this.GbOrderDetails = new System.Windows.Forms.GroupBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.LvOrderDetails = new System.Windows.Forms.ListView();
            this.GererchtOrDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrankOrDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpmerkingOrDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.btn_Uitlog.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.GbOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDrankTxt
            // 
            this.lblDrankTxt.AutoSize = true;
            this.lblDrankTxt.Location = new System.Drawing.Point(394, 26);
            this.lblDrankTxt.Name = "lblDrankTxt";
            this.lblDrankTxt.Size = new System.Drawing.Size(48, 13);
            this.lblDrankTxt.TabIndex = 12;
            this.lblDrankTxt.Text = "Dranken";
            this.lblDrankTxt.Click += new System.EventHandler(this.lblDrankTxt_Click);
            // 
            // lblEtenTxt
            // 
            this.lblEtenTxt.AutoSize = true;
            this.lblEtenTxt.Location = new System.Drawing.Point(71, 26);
            this.lblEtenTxt.Name = "lblEtenTxt";
            this.lblEtenTxt.Size = new System.Drawing.Size(29, 13);
            this.lblEtenTxt.TabIndex = 11;
            this.lblEtenTxt.Text = "Eten";
            this.lblEtenTxt.Click += new System.EventHandler(this.lblEtenTxt_Click);
            // 
            // plaatsOrderBarBtn
            // 
            this.plaatsOrderBarBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.plaatsOrderBarBtn.Location = new System.Drawing.Point(476, 125);
            this.plaatsOrderBarBtn.Name = "plaatsOrderBarBtn";
            this.plaatsOrderBarBtn.Size = new System.Drawing.Size(142, 50);
            this.plaatsOrderBarBtn.TabIndex = 10;
            this.plaatsOrderBarBtn.Text = "Plaats order";
            this.plaatsOrderBarBtn.UseVisualStyleBackColor = false;
            this.plaatsOrderBarBtn.Click += new System.EventHandler(this.plaatsOrderBarBtn_Click);
            // 
            // LvDrankenMenu
            // 
            this.LvDrankenMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dranken,
            this.PrijsDr});
            this.LvDrankenMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LvDrankenMenu.FullRowSelect = true;
            this.LvDrankenMenu.GridLines = true;
            this.LvDrankenMenu.HideSelection = false;
            this.LvDrankenMenu.Location = new System.Drawing.Point(397, 42);
            this.LvDrankenMenu.Name = "LvDrankenMenu";
            this.LvDrankenMenu.Size = new System.Drawing.Size(318, 178);
            this.LvDrankenMenu.TabIndex = 8;
            this.LvDrankenMenu.UseCompatibleStateImageBehavior = false;
            this.LvDrankenMenu.View = System.Windows.Forms.View.Details;
            this.LvDrankenMenu.SelectedIndexChanged += new System.EventHandler(this.LvDrankenMenu_SelectedIndexChanged);
            // 
            // Dranken
            // 
            this.Dranken.Text = "Dranken:";
            this.Dranken.Width = 208;
            // 
            // PrijsDr
            // 
            this.PrijsDr.Text = "Prijs:";
            this.PrijsDr.Width = 43;
            // 
            // LvEtenMenu
            // 
            this.LvEtenMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Gerecht,
            this.Prijs});
            this.LvEtenMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LvEtenMenu.FullRowSelect = true;
            this.LvEtenMenu.GridLines = true;
            this.LvEtenMenu.HideSelection = false;
            this.LvEtenMenu.Location = new System.Drawing.Point(74, 42);
            this.LvEtenMenu.Name = "LvEtenMenu";
            this.LvEtenMenu.Size = new System.Drawing.Size(318, 178);
            this.LvEtenMenu.TabIndex = 7;
            this.LvEtenMenu.UseCompatibleStateImageBehavior = false;
            this.LvEtenMenu.View = System.Windows.Forms.View.Details;
            // 
            // Gerecht
            // 
            this.Gerecht.Text = "Gerecht:";
            this.Gerecht.Width = 271;
            // 
            // Prijs
            // 
            this.Prijs.Text = "Prijs:";
            this.Prijs.Width = 43;
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
            this.panel1.Location = new System.Drawing.Point(13, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 56);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTafelNummerIn
            // 
            this.lblTafelNummerIn.AutoSize = true;
            this.lblTafelNummerIn.Location = new System.Drawing.Point(4, 29);
            this.lblTafelNummerIn.Name = "lblTafelNummerIn";
            this.lblTafelNummerIn.Size = new System.Drawing.Size(44, 13);
            this.lblTafelNummerIn.TabIndex = 14;
            this.lblTafelNummerIn.Text = "nummer";
            this.lblTafelNummerIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtOpmerkingBestelling
            // 
            this.txtOpmerkingBestelling.Location = new System.Drawing.Point(397, 226);
            this.txtOpmerkingBestelling.Name = "txtOpmerkingBestelling";
            this.txtOpmerkingBestelling.Size = new System.Drawing.Size(318, 20);
            this.txtOpmerkingBestelling.TabIndex = 15;
            this.txtOpmerkingBestelling.Text = "Opmerkingen:";
            this.txtOpmerkingBestelling.TextChanged += new System.EventHandler(this.txtOpmerkingBestelling_TextChanged);
            // 
            // LBL_UserDataOr
            // 
            this.LBL_UserDataOr.AutoSize = true;
            this.LBL_UserDataOr.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UserDataOr.Location = new System.Drawing.Point(356, 0);
            this.LBL_UserDataOr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_UserDataOr.Name = "LBL_UserDataOr";
            this.LBL_UserDataOr.Size = new System.Drawing.Size(74, 19);
            this.LBL_UserDataOr.TabIndex = 26;
            this.LBL_UserDataOr.Text = "User Data";
            // 
            // LBL_klokOr
            // 
            this.LBL_klokOr.AutoSize = true;
            this.LBL_klokOr.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_klokOr.Location = new System.Drawing.Point(611, 0);
            this.LBL_klokOr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_klokOr.Name = "LBL_klokOr";
            this.LBL_klokOr.Size = new System.Drawing.Size(38, 19);
            this.LBL_klokOr.TabIndex = 27;
            this.LBL_klokOr.Text = "klok";
            this.LBL_klokOr.Click += new System.EventHandler(this.LBL_klok_Click);
            // 
            // btn_Uitlog
            // 
            this.btn_Uitlog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Uitlog.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Uitlog.Dock = System.Windows.Forms.DockStyle.None;
            this.btn_Uitlog.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.btn_Uitlog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem});
            this.btn_Uitlog.Location = new System.Drawing.Point(724, 0);
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
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_terug});
            this.menuStrip2.Location = new System.Drawing.Point(-2, -2);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(54, 24);
            this.menuStrip2.TabIndex = 31;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MI_terug
            // 
            this.MI_terug.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.MI_terug.Name = "MI_terug";
            this.MI_terug.Size = new System.Drawing.Size(48, 20);
            this.MI_terug.Text = "Terug";
            // 
            // GbOrderDetails
            // 
            this.GbOrderDetails.Controls.Add(this.btnDeleteItem);
            this.GbOrderDetails.Controls.Add(this.btnAddItem);
            this.GbOrderDetails.Controls.Add(this.LvOrderDetails);
            this.GbOrderDetails.Controls.Add(this.plaatsOrderBarBtn);
            this.GbOrderDetails.Location = new System.Drawing.Point(74, 252);
            this.GbOrderDetails.Name = "GbOrderDetails";
            this.GbOrderDetails.Size = new System.Drawing.Size(641, 181);
            this.GbOrderDetails.TabIndex = 32;
            this.GbOrderDetails.TabStop = false;
            this.GbOrderDetails.Text = "Order Details";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteItem.Location = new System.Drawing.Point(476, 69);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(142, 39);
            this.btnDeleteItem.TabIndex = 18;
            this.btnDeleteItem.Text = "Verwijderen";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddItem.Location = new System.Drawing.Point(476, 24);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(142, 39);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.Text = "Toevoegen";
            this.btnAddItem.UseVisualStyleBackColor = false;
            // 
            // LvOrderDetails
            // 
            this.LvOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GererchtOrDe,
            this.DrankOrDe,
            this.OpmerkingOrDe});
            this.LvOrderDetails.FullRowSelect = true;
            this.LvOrderDetails.GridLines = true;
            this.LvOrderDetails.HideSelection = false;
            this.LvOrderDetails.Location = new System.Drawing.Point(12, 24);
            this.LvOrderDetails.Name = "LvOrderDetails";
            this.LvOrderDetails.Size = new System.Drawing.Size(404, 111);
            this.LvOrderDetails.TabIndex = 16;
            this.LvOrderDetails.UseCompatibleStateImageBehavior = false;
            this.LvOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // GererchtOrDe
            // 
            this.GererchtOrDe.Text = "Gerecht:";
            this.GererchtOrDe.Width = 106;
            // 
            // DrankOrDe
            // 
            this.DrankOrDe.Text = "Drank:";
            // 
            // OpmerkingOrDe
            // 
            this.OpmerkingOrDe.Text = "Opmerking:";
            this.OpmerkingOrDe.Width = 234;
            // 
            // Bestellingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GbOrderDetails);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.txtOpmerkingBestelling);
            this.Controls.Add(this.btn_Uitlog);
            this.Controls.Add(this.LBL_klokOr);
            this.Controls.Add(this.LBL_UserDataOr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDrankTxt);
            this.Controls.Add(this.lblEtenTxt);
            this.Controls.Add(this.LvDrankenMenu);
            this.Controls.Add(this.LvEtenMenu);
            this.Name = "Bestellingen";
            this.Text = "Bestellingen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.btn_Uitlog.ResumeLayout(false);
            this.btn_Uitlog.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.GbOrderDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrankTxt;
        private System.Windows.Forms.Label lblEtenTxt;
        private System.Windows.Forms.Button plaatsOrderBarBtn;
        private System.Windows.Forms.ListView LvDrankenMenu;
        private System.Windows.Forms.ListView LvEtenMenu;
        private System.Windows.Forms.Label lblTafelnr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTafelNummerIn;
        private System.Windows.Forms.ColumnHeader Gerecht;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.ColumnHeader Dranken;
        private System.Windows.Forms.ColumnHeader PrijsDr;
        private System.Windows.Forms.TextBox txtOpmerkingBestelling;
        private System.Windows.Forms.Label LBL_UserDataOr;
        private System.Windows.Forms.Label LBL_klokOr;
        private System.Windows.Forms.MenuStrip btn_Uitlog;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MI_terug;
        private System.Windows.Forms.GroupBox GbOrderDetails;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListView LvOrderDetails;
        private System.Windows.Forms.ColumnHeader GererchtOrDe;
        private System.Windows.Forms.ColumnHeader DrankOrDe;
        private System.Windows.Forms.ColumnHeader OpmerkingOrDe;
    }
}

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
            this.lblEtenTxt = new System.Windows.Forms.Label();
            this.plaatsOrderBarBtn = new System.Windows.Forms.Button();
            this.LvEtenMenu = new System.Windows.Forms.ListView();
            this.ItemNummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gerechten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lblErrorMenuBox = new System.Windows.Forms.Label();
            this.lblErrorBox = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.LvOrderDetails = new System.Windows.Forms.ListView();
            this.ItemNummer2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GererchtOrDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpmerkingOrDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rBLunch = new System.Windows.Forms.RadioButton();
            this.rBAvond = new System.Windows.Forms.RadioButton();
            this.rBDranken = new System.Windows.Forms.RadioButton();
            this.cb_Aantal = new System.Windows.Forms.ComboBox();
            this.lblAantal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.btn_Uitlog.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.GbOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEtenTxt
            // 
            this.lblEtenTxt.AutoSize = true;
            this.lblEtenTxt.Location = new System.Drawing.Point(71, 26);
            this.lblEtenTxt.Name = "lblEtenTxt";
            this.lblEtenTxt.Size = new System.Drawing.Size(29, 13);
            this.lblEtenTxt.TabIndex = 11;
            this.lblEtenTxt.Text = "Eten";
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
            // LvEtenMenu
            // 
            this.LvEtenMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemNummer,
            this.Gerechten,
            this.Prijs});
            this.LvEtenMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LvEtenMenu.FullRowSelect = true;
            this.LvEtenMenu.GridLines = true;
            this.LvEtenMenu.HideSelection = false;
            this.LvEtenMenu.Location = new System.Drawing.Point(74, 42);
            this.LvEtenMenu.Name = "LvEtenMenu";
            this.LvEtenMenu.Size = new System.Drawing.Size(641, 178);
            this.LvEtenMenu.TabIndex = 7;
            this.LvEtenMenu.UseCompatibleStateImageBehavior = false;
            this.LvEtenMenu.View = System.Windows.Forms.View.Details;
            // 
            // ItemNummer
            // 
            this.ItemNummer.Text = "Itemnummer:";
            this.ItemNummer.Width = 77;
            // 
            // Gerechten
            // 
            this.Gerechten.Text = "Gerechten:";
            this.Gerechten.Width = 453;
            // 
            // Prijs
            // 
            this.Prijs.Text = "Prijs:";
            this.Prijs.Width = 72;
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
            this.txtOpmerkingBestelling.Location = new System.Drawing.Point(74, 226);
            this.txtOpmerkingBestelling.Name = "txtOpmerkingBestelling";
            this.txtOpmerkingBestelling.Size = new System.Drawing.Size(543, 20);
            this.txtOpmerkingBestelling.TabIndex = 15;
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
            this.MI_terug.Click += new System.EventHandler(this.MI_terug_Click);
            // 
            // GbOrderDetails
            // 
            this.GbOrderDetails.Controls.Add(this.lblErrorMenuBox);
            this.GbOrderDetails.Controls.Add(this.lblErrorBox);
            this.GbOrderDetails.Controls.Add(this.btnDeleteItem);
            this.GbOrderDetails.Controls.Add(this.btnAddItem);
            this.GbOrderDetails.Controls.Add(this.LvOrderDetails);
            this.GbOrderDetails.Controls.Add(this.plaatsOrderBarBtn);
            this.GbOrderDetails.Location = new System.Drawing.Point(74, 256);
            this.GbOrderDetails.Name = "GbOrderDetails";
            this.GbOrderDetails.Size = new System.Drawing.Size(641, 192);
            this.GbOrderDetails.TabIndex = 32;
            this.GbOrderDetails.TabStop = false;
            this.GbOrderDetails.Text = "Order Details";
            // 
            // lblErrorMenuBox
            // 
            this.lblErrorMenuBox.AutoSize = true;
            this.lblErrorMenuBox.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMenuBox.Location = new System.Drawing.Point(443, 8);
            this.lblErrorMenuBox.Name = "lblErrorMenuBox";
            this.lblErrorMenuBox.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMenuBox.TabIndex = 20;
            // 
            // lblErrorBox
            // 
            this.lblErrorBox.AutoSize = true;
            this.lblErrorBox.ForeColor = System.Drawing.Color.Red;
            this.lblErrorBox.Location = new System.Drawing.Point(6, 161);
            this.lblErrorBox.Name = "lblErrorBox";
            this.lblErrorBox.Size = new System.Drawing.Size(0, 13);
            this.lblErrorBox.TabIndex = 19;
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
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
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
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // LvOrderDetails
            // 
            this.LvOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemNummer2,
            this.GererchtOrDe,
            this.OpmerkingOrDe,
            this.Aantal});
            this.LvOrderDetails.FullRowSelect = true;
            this.LvOrderDetails.GridLines = true;
            this.LvOrderDetails.HideSelection = false;
            this.LvOrderDetails.Location = new System.Drawing.Point(6, 25);
            this.LvOrderDetails.Name = "LvOrderDetails";
            this.LvOrderDetails.Size = new System.Drawing.Size(441, 111);
            this.LvOrderDetails.TabIndex = 16;
            this.LvOrderDetails.UseCompatibleStateImageBehavior = false;
            this.LvOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // ItemNummer2
            // 
            this.ItemNummer2.Text = "Itemnummer:";
            this.ItemNummer2.Width = 34;
            // 
            // GererchtOrDe
            // 
            this.GererchtOrDe.Text = "Gerecht:";
            this.GererchtOrDe.Width = 188;
            // 
            // OpmerkingOrDe
            // 
            this.OpmerkingOrDe.Text = "Opmerking:";
            this.OpmerkingOrDe.Width = 134;
            // 
            // Aantal
            // 
            this.Aantal.Text = "Aantal:";
            this.Aantal.Width = 71;
            // 
            // rBLunch
            // 
            this.rBLunch.AutoSize = true;
            this.rBLunch.Location = new System.Drawing.Point(12, 97);
            this.rBLunch.Name = "rBLunch";
            this.rBLunch.Size = new System.Drawing.Size(55, 17);
            this.rBLunch.TabIndex = 33;
            this.rBLunch.Text = "Lunch";
            this.rBLunch.UseVisualStyleBackColor = true;
            this.rBLunch.CheckedChanged += new System.EventHandler(this.rBLunch_CheckedChanged);
            // 
            // rBAvond
            // 
            this.rBAvond.AutoSize = true;
            this.rBAvond.Location = new System.Drawing.Point(12, 120);
            this.rBAvond.Name = "rBAvond";
            this.rBAvond.Size = new System.Drawing.Size(56, 17);
            this.rBAvond.TabIndex = 34;
            this.rBAvond.Text = "Avond";
            this.rBAvond.UseVisualStyleBackColor = true;
            this.rBAvond.CheckedChanged += new System.EventHandler(this.rBAvond_CheckedChanged);
            // 
            // rBDranken
            // 
            this.rBDranken.AutoSize = true;
            this.rBDranken.Checked = true;
            this.rBDranken.Location = new System.Drawing.Point(12, 143);
            this.rBDranken.Name = "rBDranken";
            this.rBDranken.Size = new System.Drawing.Size(54, 17);
            this.rBDranken.TabIndex = 35;
            this.rBDranken.TabStop = true;
            this.rBDranken.Text = "Drank";
            this.rBDranken.UseVisualStyleBackColor = true;
            this.rBDranken.CheckedChanged += new System.EventHandler(this.rBDranken_CheckedChanged);
            // 
            // cb_Aantal
            // 
            this.cb_Aantal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Aantal.FormattingEnabled = true;
            this.cb_Aantal.Location = new System.Drawing.Point(685, 226);
            this.cb_Aantal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Aantal.Name = "cb_Aantal";
            this.cb_Aantal.Size = new System.Drawing.Size(30, 21);
            this.cb_Aantal.TabIndex = 36;
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(623, 229);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(40, 13);
            this.lblAantal.TabIndex = 37;
            this.lblAantal.Text = "Aantal:";
            // 
            // Bestellingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.cb_Aantal);
            this.Controls.Add(this.rBDranken);
            this.Controls.Add(this.rBAvond);
            this.Controls.Add(this.rBLunch);
            this.Controls.Add(this.GbOrderDetails);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.txtOpmerkingBestelling);
            this.Controls.Add(this.btn_Uitlog);
            this.Controls.Add(this.LBL_klokOr);
            this.Controls.Add(this.LBL_UserDataOr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEtenTxt);
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
            this.GbOrderDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEtenTxt;
        private System.Windows.Forms.Button plaatsOrderBarBtn;
        private System.Windows.Forms.ListView LvEtenMenu;
        private System.Windows.Forms.Label lblTafelnr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTafelNummerIn;
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
        private System.Windows.Forms.ColumnHeader OpmerkingOrDe;
        private System.Windows.Forms.RadioButton rBLunch;
        private System.Windows.Forms.RadioButton rBAvond;
        private System.Windows.Forms.RadioButton rBDranken;
        private System.Windows.Forms.Label lblErrorBox;
        private System.Windows.Forms.Label lblErrorMenuBox;
        private System.Windows.Forms.ComboBox cb_Aantal;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.ColumnHeader Aantal;
        private System.Windows.Forms.ColumnHeader ItemNummer;
        private System.Windows.Forms.ColumnHeader Gerechten;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.ColumnHeader ItemNummer2;
    }
}
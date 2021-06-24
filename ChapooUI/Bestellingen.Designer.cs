
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
            this.btn_Clear_List = new System.Windows.Forms.Button();
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
            this.BTN_plus = new System.Windows.Forms.Button();
            this.Btn_min = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.btn_Uitlog.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.GbOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEtenTxt
            // 
            this.lblEtenTxt.AutoSize = true;
            this.lblEtenTxt.Location = new System.Drawing.Point(95, 32);
            this.lblEtenTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtenTxt.Name = "lblEtenTxt";
            this.lblEtenTxt.Size = new System.Drawing.Size(37, 17);
            this.lblEtenTxt.TabIndex = 11;
            this.lblEtenTxt.Text = "Eten";
            // 
            // plaatsOrderBarBtn
            // 
            this.plaatsOrderBarBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.plaatsOrderBarBtn.Location = new System.Drawing.Point(635, 154);
            this.plaatsOrderBarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.plaatsOrderBarBtn.Name = "plaatsOrderBarBtn";
            this.plaatsOrderBarBtn.Size = new System.Drawing.Size(189, 62);
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
            this.LvEtenMenu.Location = new System.Drawing.Point(99, 52);
            this.LvEtenMenu.Margin = new System.Windows.Forms.Padding(4);
            this.LvEtenMenu.Name = "LvEtenMenu";
            this.LvEtenMenu.Size = new System.Drawing.Size(853, 218);
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
            this.lblTafelnr.Location = new System.Drawing.Point(4, 5);
            this.lblTafelnr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTafelnr.Name = "lblTafelnr";
            this.lblTafelnr.Size = new System.Drawing.Size(57, 17);
            this.lblTafelnr.TabIndex = 13;
            this.lblTafelnr.Text = "Tafelnr.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblTafelNummerIn);
            this.panel1.Controls.Add(this.lblTafelnr);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(17, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 69);
            this.panel1.TabIndex = 14;
            // 
            // lblTafelNummerIn
            // 
            this.lblTafelNummerIn.AutoSize = true;
            this.lblTafelNummerIn.Location = new System.Drawing.Point(5, 36);
            this.lblTafelNummerIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTafelNummerIn.Name = "lblTafelNummerIn";
            this.lblTafelNummerIn.Size = new System.Drawing.Size(59, 17);
            this.lblTafelNummerIn.TabIndex = 14;
            this.lblTafelNummerIn.Text = "nummer";
            this.lblTafelNummerIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtOpmerkingBestelling
            // 
            this.txtOpmerkingBestelling.Location = new System.Drawing.Point(99, 278);
            this.txtOpmerkingBestelling.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpmerkingBestelling.Name = "txtOpmerkingBestelling";
            this.txtOpmerkingBestelling.Size = new System.Drawing.Size(723, 22);
            this.txtOpmerkingBestelling.TabIndex = 15;
            // 
            // LBL_UserDataOr
            // 
            this.LBL_UserDataOr.AutoSize = true;
            this.LBL_UserDataOr.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_UserDataOr.Location = new System.Drawing.Point(475, 0);
            this.LBL_UserDataOr.Name = "LBL_UserDataOr";
            this.LBL_UserDataOr.Size = new System.Drawing.Size(88, 23);
            this.LBL_UserDataOr.TabIndex = 26;
            this.LBL_UserDataOr.Text = "User Data";
            // 
            // LBL_klokOr
            // 
            this.LBL_klokOr.AutoSize = true;
            this.LBL_klokOr.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_klokOr.Location = new System.Drawing.Point(815, 0);
            this.LBL_klokOr.Name = "LBL_klokOr";
            this.LBL_klokOr.Size = new System.Drawing.Size(45, 23);
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
            this.btn_Uitlog.Location = new System.Drawing.Point(972, 0);
            this.btn_Uitlog.Name = "btn_Uitlog";
            this.btn_Uitlog.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.btn_Uitlog.Size = new System.Drawing.Size(96, 27);
            this.btn_Uitlog.TabIndex = 30;
            this.btn_Uitlog.Text = "Uitloggen";
            this.btn_Uitlog.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.btn_Uitlog_ItemClicked);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.afsluitenToolStripMenuItem.Text = "Uitloggen";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_terug});
            this.menuStrip2.Location = new System.Drawing.Point(-3, -2);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(68, 27);
            this.menuStrip2.TabIndex = 31;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MI_terug
            // 
            this.MI_terug.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.MI_terug.Name = "MI_terug";
            this.MI_terug.Size = new System.Drawing.Size(61, 23);
            this.MI_terug.Text = "Terug";
            this.MI_terug.Click += new System.EventHandler(this.MI_terug_Click);
            // 
            // GbOrderDetails
            // 
            this.GbOrderDetails.Controls.Add(this.Btn_min);
            this.GbOrderDetails.Controls.Add(this.BTN_plus);
            this.GbOrderDetails.Controls.Add(this.btn_Clear_List);
            this.GbOrderDetails.Controls.Add(this.lblErrorMenuBox);
            this.GbOrderDetails.Controls.Add(this.lblErrorBox);
            this.GbOrderDetails.Controls.Add(this.btnDeleteItem);
            this.GbOrderDetails.Controls.Add(this.btnAddItem);
            this.GbOrderDetails.Controls.Add(this.LvOrderDetails);
            this.GbOrderDetails.Controls.Add(this.plaatsOrderBarBtn);
            this.GbOrderDetails.Location = new System.Drawing.Point(99, 315);
            this.GbOrderDetails.Margin = new System.Windows.Forms.Padding(4);
            this.GbOrderDetails.Name = "GbOrderDetails";
            this.GbOrderDetails.Padding = new System.Windows.Forms.Padding(4);
            this.GbOrderDetails.Size = new System.Drawing.Size(855, 236);
            this.GbOrderDetails.TabIndex = 32;
            this.GbOrderDetails.TabStop = false;
            this.GbOrderDetails.Text = "Order Details";
            // 
            // btn_Clear_List
            // 
            this.btn_Clear_List.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Clear_List.Location = new System.Drawing.Point(8, 182);
            this.btn_Clear_List.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clear_List.Name = "btn_Clear_List";
            this.btn_Clear_List.Size = new System.Drawing.Size(97, 33);
            this.btn_Clear_List.TabIndex = 21;
            this.btn_Clear_List.Text = "Clear order";
            this.btn_Clear_List.UseVisualStyleBackColor = false;
            this.btn_Clear_List.Click += new System.EventHandler(this.btn_Clear_List_Click);
            // 
            // lblErrorMenuBox
            // 
            this.lblErrorMenuBox.AutoSize = true;
            this.lblErrorMenuBox.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMenuBox.Location = new System.Drawing.Point(591, 10);
            this.lblErrorMenuBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorMenuBox.Name = "lblErrorMenuBox";
            this.lblErrorMenuBox.Size = new System.Drawing.Size(0, 17);
            this.lblErrorMenuBox.TabIndex = 20;
            // 
            // lblErrorBox
            // 
            this.lblErrorBox.AutoSize = true;
            this.lblErrorBox.ForeColor = System.Drawing.Color.Red;
            this.lblErrorBox.Location = new System.Drawing.Point(119, 190);
            this.lblErrorBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorBox.Name = "lblErrorBox";
            this.lblErrorBox.Size = new System.Drawing.Size(0, 17);
            this.lblErrorBox.TabIndex = 19;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteItem.Location = new System.Drawing.Point(635, 85);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(189, 48);
            this.btnDeleteItem.TabIndex = 18;
            this.btnDeleteItem.Text = "Verwijderen";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddItem.Location = new System.Drawing.Point(635, 30);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(189, 48);
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
            this.LvOrderDetails.Location = new System.Drawing.Point(8, 31);
            this.LvOrderDetails.Margin = new System.Windows.Forms.Padding(4);
            this.LvOrderDetails.Name = "LvOrderDetails";
            this.LvOrderDetails.Size = new System.Drawing.Size(587, 136);
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
            this.rBLunch.Location = new System.Drawing.Point(16, 119);
            this.rBLunch.Margin = new System.Windows.Forms.Padding(4);
            this.rBLunch.Name = "rBLunch";
            this.rBLunch.Size = new System.Drawing.Size(68, 21);
            this.rBLunch.TabIndex = 33;
            this.rBLunch.Text = "Lunch";
            this.rBLunch.UseVisualStyleBackColor = true;
            this.rBLunch.CheckedChanged += new System.EventHandler(this.rBLunch_CheckedChanged);
            // 
            // rBAvond
            // 
            this.rBAvond.AutoSize = true;
            this.rBAvond.Location = new System.Drawing.Point(16, 148);
            this.rBAvond.Margin = new System.Windows.Forms.Padding(4);
            this.rBAvond.Name = "rBAvond";
            this.rBAvond.Size = new System.Drawing.Size(69, 21);
            this.rBAvond.TabIndex = 34;
            this.rBAvond.Text = "Avond";
            this.rBAvond.UseVisualStyleBackColor = true;
            this.rBAvond.CheckedChanged += new System.EventHandler(this.rBAvond_CheckedChanged);
            // 
            // rBDranken
            // 
            this.rBDranken.AutoSize = true;
            this.rBDranken.Checked = true;
            this.rBDranken.Location = new System.Drawing.Point(16, 176);
            this.rBDranken.Margin = new System.Windows.Forms.Padding(4);
            this.rBDranken.Name = "rBDranken";
            this.rBDranken.Size = new System.Drawing.Size(67, 21);
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
            this.cb_Aantal.Location = new System.Drawing.Point(913, 278);
            this.cb_Aantal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Aantal.Name = "cb_Aantal";
            this.cb_Aantal.Size = new System.Drawing.Size(39, 24);
            this.cb_Aantal.TabIndex = 36;
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(831, 282);
            this.lblAantal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(52, 17);
            this.lblAantal.TabIndex = 37;
            this.lblAantal.Text = "Aantal:";
            // 
            // BTN_plus
            // 
            this.BTN_plus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_plus.Location = new System.Drawing.Point(555, 182);
            this.BTN_plus.Name = "BTN_plus";
            this.BTN_plus.Size = new System.Drawing.Size(40, 40);
            this.BTN_plus.TabIndex = 38;
            this.BTN_plus.Text = "+";
            this.BTN_plus.UseVisualStyleBackColor = false;
            this.BTN_plus.Click += new System.EventHandler(this.BTN_plus_Click);
            // 
            // Btn_min
            // 
            this.Btn_min.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_min.Location = new System.Drawing.Point(509, 182);
            this.Btn_min.Name = "Btn_min";
            this.Btn_min.Size = new System.Drawing.Size(40, 40);
            this.Btn_min.TabIndex = 39;
            this.Btn_min.Text = "-";
            this.Btn_min.UseVisualStyleBackColor = false;
            this.Btn_min.Click += new System.EventHandler(this.Btn_min_Click);
            // 
            // Bestellingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bestellingen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Button btn_Clear_List;
        private System.Windows.Forms.Button Btn_min;
        private System.Windows.Forms.Button BTN_plus;
    }
}
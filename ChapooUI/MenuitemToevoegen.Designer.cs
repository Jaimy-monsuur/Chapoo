
namespace ChapooUI
{
    partial class MenuitemToevoegen
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.BTN_terug = new System.Windows.Forms.Button();
            this.BTN_Toevoegen = new System.Windows.Forms.Button();
            this.Tbx_functie = new System.Windows.Forms.TextBox();
            this.tbx_achternaam = new System.Windows.Forms.TextBox();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.lblMenuitem = new System.Windows.Forms.Label();
            this.lblBtw = new System.Windows.Forms.Label();
            this.cb_Btw = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cb_TypeSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(11, 9);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(224, 18);
            this.lblInfo.TabIndex = 26;
            this.lblInfo.Text = "Nieuwe menuitem toevoegen";
            // 
            // BTN_terug
            // 
            this.BTN_terug.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_terug.Location = new System.Drawing.Point(14, 231);
            this.BTN_terug.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_terug.Name = "BTN_terug";
            this.BTN_terug.Size = new System.Drawing.Size(83, 37);
            this.BTN_terug.TabIndex = 25;
            this.BTN_terug.Text = "Terug";
            this.BTN_terug.UseVisualStyleBackColor = false;
            this.BTN_terug.Click += new System.EventHandler(this.BTN_terug_Click);
            // 
            // BTN_Toevoegen
            // 
            this.BTN_Toevoegen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_Toevoegen.Location = new System.Drawing.Point(160, 231);
            this.BTN_Toevoegen.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Toevoegen.Name = "BTN_Toevoegen";
            this.BTN_Toevoegen.Size = new System.Drawing.Size(83, 37);
            this.BTN_Toevoegen.TabIndex = 24;
            this.BTN_Toevoegen.Text = "Toevoegen";
            this.BTN_Toevoegen.UseVisualStyleBackColor = false;
            this.BTN_Toevoegen.Click += new System.EventHandler(this.BTN_Toevoegen_Click);
            // 
            // Tbx_functie
            // 
            this.Tbx_functie.Location = new System.Drawing.Point(151, 111);
            this.Tbx_functie.Margin = new System.Windows.Forms.Padding(2);
            this.Tbx_functie.Name = "Tbx_functie";
            this.Tbx_functie.Size = new System.Drawing.Size(92, 20);
            this.Tbx_functie.TabIndex = 21;
            this.Tbx_functie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_functie_KeyPress);
            // 
            // tbx_achternaam
            // 
            this.tbx_achternaam.Location = new System.Drawing.Point(14, 61);
            this.tbx_achternaam.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_achternaam.Name = "tbx_achternaam";
            this.tbx_achternaam.Size = new System.Drawing.Size(229, 20);
            this.tbx_achternaam.TabIndex = 20;
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(12, 114);
            this.lblPrijs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(29, 13);
            this.lblPrijs.TabIndex = 16;
            this.lblPrijs.Text = "Prijs:";
            // 
            // lblMenuitem
            // 
            this.lblMenuitem.AutoSize = true;
            this.lblMenuitem.Location = new System.Drawing.Point(12, 46);
            this.lblMenuitem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuitem.Name = "lblMenuitem";
            this.lblMenuitem.Size = new System.Drawing.Size(87, 13);
            this.lblMenuitem.TabIndex = 15;
            this.lblMenuitem.Text = "Naam Menuitem:";
            // 
            // lblBtw
            // 
            this.lblBtw.AutoSize = true;
            this.lblBtw.Location = new System.Drawing.Point(12, 145);
            this.lblBtw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBtw.Name = "lblBtw";
            this.lblBtw.Size = new System.Drawing.Size(28, 13);
            this.lblBtw.TabIndex = 27;
            this.lblBtw.Text = "Btw:";
            // 
            // cb_Btw
            // 
            this.cb_Btw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Btw.FormattingEnabled = true;
            this.cb_Btw.Location = new System.Drawing.Point(151, 142);
            this.cb_Btw.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Btw.Name = "cb_Btw";
            this.cb_Btw.Size = new System.Drawing.Size(92, 21);
            this.cb_Btw.TabIndex = 28;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(13, 179);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 29;
            this.lblType.Text = "Type:";
            // 
            // cb_TypeSelect
            // 
            this.cb_TypeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TypeSelect.FormattingEnabled = true;
            this.cb_TypeSelect.Location = new System.Drawing.Point(151, 176);
            this.cb_TypeSelect.Margin = new System.Windows.Forms.Padding(2);
            this.cb_TypeSelect.Name = "cb_TypeSelect";
            this.cb_TypeSelect.Size = new System.Drawing.Size(92, 21);
            this.cb_TypeSelect.TabIndex = 30;
            // 
            // MenuitemToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 281);
            this.Controls.Add(this.cb_TypeSelect);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cb_Btw);
            this.Controls.Add(this.lblBtw);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.BTN_terug);
            this.Controls.Add(this.BTN_Toevoegen);
            this.Controls.Add(this.Tbx_functie);
            this.Controls.Add(this.tbx_achternaam);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.lblMenuitem);
            this.Name = "MenuitemToevoegen";
            this.Text = "MenuitemToevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button BTN_terug;
        private System.Windows.Forms.Button BTN_Toevoegen;
        private System.Windows.Forms.TextBox Tbx_functie;
        private System.Windows.Forms.TextBox tbx_achternaam;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Label lblMenuitem;
        private System.Windows.Forms.Label lblBtw;
        private System.Windows.Forms.ComboBox cb_Btw;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cb_TypeSelect;
    }
}
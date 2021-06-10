
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
            this.tbx_voornaam = new System.Windows.Forms.TextBox();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.lblMenuitem = new System.Windows.Forms.Label();
            this.lblItemNum = new System.Windows.Forms.Label();
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
            this.BTN_terug.Location = new System.Drawing.Point(14, 167);
            this.BTN_terug.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_terug.Name = "BTN_terug";
            this.BTN_terug.Size = new System.Drawing.Size(83, 37);
            this.BTN_terug.TabIndex = 25;
            this.BTN_terug.Text = "Terug";
            this.BTN_terug.UseVisualStyleBackColor = false;
            // 
            // BTN_Toevoegen
            // 
            this.BTN_Toevoegen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_Toevoegen.Location = new System.Drawing.Point(160, 167);
            this.BTN_Toevoegen.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Toevoegen.Name = "BTN_Toevoegen";
            this.BTN_Toevoegen.Size = new System.Drawing.Size(83, 37);
            this.BTN_Toevoegen.TabIndex = 24;
            this.BTN_Toevoegen.Text = "Toevoegen";
            this.BTN_Toevoegen.UseVisualStyleBackColor = false;
            // 
            // Tbx_functie
            // 
            this.Tbx_functie.Location = new System.Drawing.Point(151, 111);
            this.Tbx_functie.Margin = new System.Windows.Forms.Padding(2);
            this.Tbx_functie.Name = "Tbx_functie";
            this.Tbx_functie.Size = new System.Drawing.Size(92, 20);
            this.Tbx_functie.TabIndex = 21;
            // 
            // tbx_achternaam
            // 
            this.tbx_achternaam.Location = new System.Drawing.Point(151, 78);
            this.tbx_achternaam.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_achternaam.Name = "tbx_achternaam";
            this.tbx_achternaam.Size = new System.Drawing.Size(92, 20);
            this.tbx_achternaam.TabIndex = 20;
            // 
            // tbx_voornaam
            // 
            this.tbx_voornaam.Location = new System.Drawing.Point(151, 39);
            this.tbx_voornaam.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_voornaam.Name = "tbx_voornaam";
            this.tbx_voornaam.Size = new System.Drawing.Size(92, 20);
            this.tbx_voornaam.TabIndex = 19;
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(11, 115);
            this.lblPrijs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(29, 13);
            this.lblPrijs.TabIndex = 16;
            this.lblPrijs.Text = "Prijs:";
            // 
            // lblMenuitem
            // 
            this.lblMenuitem.AutoSize = true;
            this.lblMenuitem.Location = new System.Drawing.Point(11, 83);
            this.lblMenuitem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenuitem.Name = "lblMenuitem";
            this.lblMenuitem.Size = new System.Drawing.Size(87, 13);
            this.lblMenuitem.TabIndex = 15;
            this.lblMenuitem.Text = "Naam Menuitem:";
            // 
            // lblItemNum
            // 
            this.lblItemNum.AutoSize = true;
            this.lblItemNum.Location = new System.Drawing.Point(11, 43);
            this.lblItemNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemNum.Name = "lblItemNum";
            this.lblItemNum.Size = new System.Drawing.Size(67, 13);
            this.lblItemNum.TabIndex = 14;
            this.lblItemNum.Text = "Itemnummer:";
            // 
            // MenuitemToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 281);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.BTN_terug);
            this.Controls.Add(this.BTN_Toevoegen);
            this.Controls.Add(this.Tbx_functie);
            this.Controls.Add(this.tbx_achternaam);
            this.Controls.Add(this.tbx_voornaam);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.lblMenuitem);
            this.Controls.Add(this.lblItemNum);
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
        private System.Windows.Forms.TextBox tbx_voornaam;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.Label lblMenuitem;
        private System.Windows.Forms.Label lblItemNum;
    }
}

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
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(15, 11);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(284, 24);
            this.lblInfo.TabIndex = 26;
            this.lblInfo.Text = "Nieuwe menuitem toevoegen";
            // 
            // BTN_terug
            // 
            this.BTN_terug.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_terug.Location = new System.Drawing.Point(19, 206);
            this.BTN_terug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_terug.Name = "BTN_terug";
            this.BTN_terug.Size = new System.Drawing.Size(111, 46);
            this.BTN_terug.TabIndex = 25;
            this.BTN_terug.Text = "Terug";
            this.BTN_terug.UseVisualStyleBackColor = false;
            this.BTN_terug.Click += new System.EventHandler(this.BTN_terug_Click);
            // 
            // BTN_Toevoegen
            // 
            this.BTN_Toevoegen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_Toevoegen.Location = new System.Drawing.Point(213, 206);
            this.BTN_Toevoegen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Toevoegen.Name = "BTN_Toevoegen";
            this.BTN_Toevoegen.Size = new System.Drawing.Size(111, 46);
            this.BTN_Toevoegen.TabIndex = 24;
            this.BTN_Toevoegen.Text = "Toevoegen";
            this.BTN_Toevoegen.UseVisualStyleBackColor = false;
            this.BTN_Toevoegen.Click += new System.EventHandler(this.BTN_Toevoegen_Click);
            // 
            // Tbx_functie
            // 
            this.Tbx_functie.Location = new System.Drawing.Point(201, 137);
            this.Tbx_functie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tbx_functie.Name = "Tbx_functie";
            this.Tbx_functie.Size = new System.Drawing.Size(121, 22);
            this.Tbx_functie.TabIndex = 21;
            this.Tbx_functie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_functie_KeyPress);
            // 
            // tbx_achternaam
            // 
            this.tbx_achternaam.Location = new System.Drawing.Point(18, 75);
            this.tbx_achternaam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_achternaam.Name = "tbx_achternaam";
            this.tbx_achternaam.Size = new System.Drawing.Size(304, 22);
            this.tbx_achternaam.TabIndex = 20;
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(16, 140);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(39, 17);
            this.lblPrijs.TabIndex = 16;
            this.lblPrijs.Text = "Prijs:";
            // 
            // lblMenuitem
            // 
            this.lblMenuitem.AutoSize = true;
            this.lblMenuitem.Location = new System.Drawing.Point(16, 56);
            this.lblMenuitem.Name = "lblMenuitem";
            this.lblMenuitem.Size = new System.Drawing.Size(114, 17);
            this.lblMenuitem.TabIndex = 15;
            this.lblMenuitem.Text = "Naam Menuitem:";
            // 
            // MenuitemToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 346);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.BTN_terug);
            this.Controls.Add(this.BTN_Toevoegen);
            this.Controls.Add(this.Tbx_functie);
            this.Controls.Add(this.tbx_achternaam);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.lblMenuitem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}
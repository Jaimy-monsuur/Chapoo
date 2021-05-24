
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
            this.terugKeukenBarBtn = new System.Windows.Forms.Button();
            this.listViewKeukenBarOpenstaand = new System.Windows.Forms.ListView();
            this.listViewKeukenBarOpmerkingen = new System.Windows.Forms.ListView();
            this.gereedKeukenBarBtn = new System.Windows.Forms.Button();
            this.annulerenKeukenBarBtn = new System.Windows.Forms.Button();
            this.openstaandeBestellingenTxtLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // terugKeukenBarBtn
            // 
            this.terugKeukenBarBtn.BackColor = System.Drawing.Color.LightCoral;
            this.terugKeukenBarBtn.Location = new System.Drawing.Point(12, 12);
            this.terugKeukenBarBtn.Name = "terugKeukenBarBtn";
            this.terugKeukenBarBtn.Size = new System.Drawing.Size(100, 36);
            this.terugKeukenBarBtn.TabIndex = 0;
            this.terugKeukenBarBtn.Text = "Terug naar home menu";
            this.terugKeukenBarBtn.UseVisualStyleBackColor = false;
            this.terugKeukenBarBtn.Click += new System.EventHandler(this.terugKeukenBarBtn_Click);
            // 
            // listViewKeukenBarOpenstaand
            // 
            this.listViewKeukenBarOpenstaand.HideSelection = false;
            this.listViewKeukenBarOpenstaand.Location = new System.Drawing.Point(25, 77);
            this.listViewKeukenBarOpenstaand.Name = "listViewKeukenBarOpenstaand";
            this.listViewKeukenBarOpenstaand.Size = new System.Drawing.Size(385, 355);
            this.listViewKeukenBarOpenstaand.TabIndex = 1;
            this.listViewKeukenBarOpenstaand.UseCompatibleStateImageBehavior = false;
            // 
            // listViewKeukenBarOpmerkingen
            // 
            this.listViewKeukenBarOpmerkingen.HideSelection = false;
            this.listViewKeukenBarOpmerkingen.Location = new System.Drawing.Point(456, 77);
            this.listViewKeukenBarOpmerkingen.Name = "listViewKeukenBarOpmerkingen";
            this.listViewKeukenBarOpmerkingen.Size = new System.Drawing.Size(317, 220);
            this.listViewKeukenBarOpmerkingen.TabIndex = 2;
            this.listViewKeukenBarOpmerkingen.UseCompatibleStateImageBehavior = false;
            // 
            // gereedKeukenBarBtn
            // 
            this.gereedKeukenBarBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gereedKeukenBarBtn.Location = new System.Drawing.Point(456, 355);
            this.gereedKeukenBarBtn.Name = "gereedKeukenBarBtn";
            this.gereedKeukenBarBtn.Size = new System.Drawing.Size(141, 50);
            this.gereedKeukenBarBtn.TabIndex = 3;
            this.gereedKeukenBarBtn.Text = "Gereed";
            this.gereedKeukenBarBtn.UseVisualStyleBackColor = false;
            this.gereedKeukenBarBtn.Click += new System.EventHandler(this.gereedKeukenBarBtn_Click);
            // 
            // annulerenKeukenBarBtn
            // 
            this.annulerenKeukenBarBtn.BackColor = System.Drawing.Color.LightCoral;
            this.annulerenKeukenBarBtn.Location = new System.Drawing.Point(632, 355);
            this.annulerenKeukenBarBtn.Name = "annulerenKeukenBarBtn";
            this.annulerenKeukenBarBtn.Size = new System.Drawing.Size(141, 50);
            this.annulerenKeukenBarBtn.TabIndex = 4;
            this.annulerenKeukenBarBtn.Text = "Annuleren";
            this.annulerenKeukenBarBtn.UseVisualStyleBackColor = false;
            this.annulerenKeukenBarBtn.Click += new System.EventHandler(this.annulerenKeukenBarBtn_Click);
            // 
            // openstaandeBestellingenTxtLbl
            // 
            this.openstaandeBestellingenTxtLbl.AutoSize = true;
            this.openstaandeBestellingenTxtLbl.Location = new System.Drawing.Point(22, 61);
            this.openstaandeBestellingenTxtLbl.Name = "openstaandeBestellingenTxtLbl";
            this.openstaandeBestellingenTxtLbl.Size = new System.Drawing.Size(130, 13);
            this.openstaandeBestellingenTxtLbl.TabIndex = 5;
            this.openstaandeBestellingenTxtLbl.Text = "Openstaande bestellingen";
            // 
            // KeukenBarSysteemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openstaandeBestellingenTxtLbl);
            this.Controls.Add(this.annulerenKeukenBarBtn);
            this.Controls.Add(this.gereedKeukenBarBtn);
            this.Controls.Add(this.listViewKeukenBarOpmerkingen);
            this.Controls.Add(this.listViewKeukenBarOpenstaand);
            this.Controls.Add(this.terugKeukenBarBtn);
            this.Name = "KeukenBarSysteemForm";
            this.Text = "KeukenSysteemForm";
            this.Load += new System.EventHandler(this.KeukenSysteemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button terugKeukenBarBtn;
        private System.Windows.Forms.ListView listViewKeukenBarOpenstaand;
        private System.Windows.Forms.ListView listViewKeukenBarOpmerkingen;
        private System.Windows.Forms.Button gereedKeukenBarBtn;
        private System.Windows.Forms.Button annulerenKeukenBarBtn;
        private System.Windows.Forms.Label openstaandeBestellingenTxtLbl;
    }
}

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
            this.listViewKeukenBarOpenstaand = new System.Windows.Forms.ListView();
            this.listViewKeukenBarOpmerkingen = new System.Windows.Forms.ListView();
            this.gereedKeukenBarBtn = new System.Windows.Forms.Button();
            this.annulerenKeukenBarBtn = new System.Windows.Forms.Button();
            this.openstaandeBestellingenTxtLbl = new System.Windows.Forms.Label();
            this.maakOrderBarBtn = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TerugtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewKeukenBarOpenstaand
            // 
            this.listViewKeukenBarOpenstaand.HideSelection = false;
            this.listViewKeukenBarOpenstaand.Location = new System.Drawing.Point(33, 105);
            this.listViewKeukenBarOpenstaand.Margin = new System.Windows.Forms.Padding(4);
            this.listViewKeukenBarOpenstaand.Name = "listViewKeukenBarOpenstaand";
            this.listViewKeukenBarOpenstaand.Size = new System.Drawing.Size(694, 426);
            this.listViewKeukenBarOpenstaand.TabIndex = 1;
            this.listViewKeukenBarOpenstaand.UseCompatibleStateImageBehavior = false;
            // 
            // listViewKeukenBarOpmerkingen
            // 
            this.listViewKeukenBarOpmerkingen.HideSelection = false;
            this.listViewKeukenBarOpmerkingen.Location = new System.Drawing.Point(786, 105);
            this.listViewKeukenBarOpmerkingen.Margin = new System.Windows.Forms.Padding(4);
            this.listViewKeukenBarOpmerkingen.Name = "listViewKeukenBarOpmerkingen";
            this.listViewKeukenBarOpmerkingen.Size = new System.Drawing.Size(421, 270);
            this.listViewKeukenBarOpmerkingen.TabIndex = 2;
            this.listViewKeukenBarOpmerkingen.UseCompatibleStateImageBehavior = false;
            // 
            // gereedKeukenBarBtn
            // 
            this.gereedKeukenBarBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gereedKeukenBarBtn.Location = new System.Drawing.Point(786, 469);
            this.gereedKeukenBarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.gereedKeukenBarBtn.Name = "gereedKeukenBarBtn";
            this.gereedKeukenBarBtn.Size = new System.Drawing.Size(188, 62);
            this.gereedKeukenBarBtn.TabIndex = 3;
            this.gereedKeukenBarBtn.Text = "Gereed";
            this.gereedKeukenBarBtn.UseVisualStyleBackColor = false;
            this.gereedKeukenBarBtn.Click += new System.EventHandler(this.gereedKeukenBarBtn_Click);
            // 
            // annulerenKeukenBarBtn
            // 
            this.annulerenKeukenBarBtn.BackColor = System.Drawing.Color.LightCoral;
            this.annulerenKeukenBarBtn.Location = new System.Drawing.Point(1019, 469);
            this.annulerenKeukenBarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.annulerenKeukenBarBtn.Name = "annulerenKeukenBarBtn";
            this.annulerenKeukenBarBtn.Size = new System.Drawing.Size(188, 62);
            this.annulerenKeukenBarBtn.TabIndex = 4;
            this.annulerenKeukenBarBtn.Text = "Annuleren";
            this.annulerenKeukenBarBtn.UseVisualStyleBackColor = false;
            this.annulerenKeukenBarBtn.Click += new System.EventHandler(this.annulerenKeukenBarBtn_Click);
            // 
            // openstaandeBestellingenTxtLbl
            // 
            this.openstaandeBestellingenTxtLbl.AutoSize = true;
            this.openstaandeBestellingenTxtLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openstaandeBestellingenTxtLbl.Location = new System.Drawing.Point(27, 59);
            this.openstaandeBestellingenTxtLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.openstaandeBestellingenTxtLbl.Name = "openstaandeBestellingenTxtLbl";
            this.openstaandeBestellingenTxtLbl.Size = new System.Drawing.Size(295, 32);
            this.openstaandeBestellingenTxtLbl.TabIndex = 5;
            this.openstaandeBestellingenTxtLbl.Text = "Openstaande bestellingen";
            // 
            // maakOrderBarBtn
            // 
            this.maakOrderBarBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.maakOrderBarBtn.Location = new System.Drawing.Point(33, 547);
            this.maakOrderBarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.maakOrderBarBtn.Name = "maakOrderBarBtn";
            this.maakOrderBarBtn.Size = new System.Drawing.Size(188, 62);
            this.maakOrderBarBtn.TabIndex = 6;
            this.maakOrderBarBtn.Text = "Maak order";
            this.maakOrderBarBtn.UseVisualStyleBackColor = false;
            this.maakOrderBarBtn.Click += new System.EventHandler(this.maakOrderBarBtn_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TerugtoolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(-6, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(69, 27);
            this.menuStrip2.TabIndex = 30;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // TerugtoolStripMenuItem
            // 
            this.TerugtoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.TerugtoolStripMenuItem.Name = "TerugtoolStripMenuItem";
            this.TerugtoolStripMenuItem.Size = new System.Drawing.Size(61, 23);
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
            this.menuStrip1.Location = new System.Drawing.Point(1186, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(97, 27);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UitloggenToolStripMenuItem
            // 
            this.UitloggenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.UitloggenToolStripMenuItem.Name = "UitloggenToolStripMenuItem";
            this.UitloggenToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.UitloggenToolStripMenuItem.Text = "Uitloggen";
            this.UitloggenToolStripMenuItem.Click += new System.EventHandler(this.UitloggenToolStripMenuItem_Click);
            // 
            // KeukenBarSysteemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 622);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.maakOrderBarBtn);
            this.Controls.Add(this.openstaandeBestellingenTxtLbl);
            this.Controls.Add(this.annulerenKeukenBarBtn);
            this.Controls.Add(this.gereedKeukenBarBtn);
            this.Controls.Add(this.listViewKeukenBarOpmerkingen);
            this.Controls.Add(this.listViewKeukenBarOpenstaand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button annulerenKeukenBarBtn;
        private System.Windows.Forms.Label openstaandeBestellingenTxtLbl;
        private System.Windows.Forms.Button maakOrderBarBtn;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem TerugtoolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UitloggenToolStripMenuItem;
    }
}
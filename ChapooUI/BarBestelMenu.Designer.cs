
namespace ChapooUI
{
    partial class BarBestelMenu
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
            this.drankenKaartListView = new System.Windows.Forms.ListView();
            this.orderDrankenListView = new System.Windows.Forms.ListView();
            this.plaatsOrderBarBtn = new System.Windows.Forms.Button();
            this.drankenKaartTxtLbl = new System.Windows.Forms.Label();
            this.orderTxtLbl = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TerugtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plusOrderBarBtn = new System.Windows.Forms.Button();
            this.minusOrderBarBtn = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drankenKaartListView
            // 
            this.drankenKaartListView.HideSelection = false;
            this.drankenKaartListView.Location = new System.Drawing.Point(144, 106);
            this.drankenKaartListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drankenKaartListView.Name = "drankenKaartListView";
            this.drankenKaartListView.Size = new System.Drawing.Size(495, 414);
            this.drankenKaartListView.TabIndex = 0;
            this.drankenKaartListView.UseCompatibleStateImageBehavior = false;
            // 
            // orderDrankenListView
            // 
            this.orderDrankenListView.HideSelection = false;
            this.orderDrankenListView.Location = new System.Drawing.Point(647, 104);
            this.orderDrankenListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderDrankenListView.Name = "orderDrankenListView";
            this.orderDrankenListView.Size = new System.Drawing.Size(495, 414);
            this.orderDrankenListView.TabIndex = 1;
            this.orderDrankenListView.UseCompatibleStateImageBehavior = false;
            // 
            // plaatsOrderBarBtn
            // 
            this.plaatsOrderBarBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.plaatsOrderBarBtn.Location = new System.Drawing.Point(144, 528);
            this.plaatsOrderBarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plaatsOrderBarBtn.Name = "plaatsOrderBarBtn";
            this.plaatsOrderBarBtn.Size = new System.Drawing.Size(188, 62);
            this.plaatsOrderBarBtn.TabIndex = 4;
            this.plaatsOrderBarBtn.Text = "Plaats order";
            this.plaatsOrderBarBtn.UseVisualStyleBackColor = false;
            this.plaatsOrderBarBtn.Click += new System.EventHandler(this.plaatsOrderBarBtn_Click);
            // 
            // drankenKaartTxtLbl
            // 
            this.drankenKaartTxtLbl.AutoSize = true;
            this.drankenKaartTxtLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drankenKaartTxtLbl.Location = new System.Drawing.Point(138, 68);
            this.drankenKaartTxtLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drankenKaartTxtLbl.Name = "drankenKaartTxtLbl";
            this.drankenKaartTxtLbl.Size = new System.Drawing.Size(164, 32);
            this.drankenKaartTxtLbl.TabIndex = 5;
            this.drankenKaartTxtLbl.Text = "Dranken kaart";
            // 
            // orderTxtLbl
            // 
            this.orderTxtLbl.AutoSize = true;
            this.orderTxtLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTxtLbl.Location = new System.Drawing.Point(641, 68);
            this.orderTxtLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderTxtLbl.Name = "orderTxtLbl";
            this.orderTxtLbl.Size = new System.Drawing.Size(76, 32);
            this.orderTxtLbl.TabIndex = 6;
            this.orderTxtLbl.Text = "Order";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TerugtoolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(69, 27);
            this.menuStrip2.TabIndex = 28;
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
            this.menuStrip1.Location = new System.Drawing.Point(1192, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(97, 27);
            this.menuStrip1.TabIndex = 27;
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
            // plusOrderBarBtn
            // 
            this.plusOrderBarBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.plusOrderBarBtn.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusOrderBarBtn.Location = new System.Drawing.Point(549, 525);
            this.plusOrderBarBtn.Name = "plusOrderBarBtn";
            this.plusOrderBarBtn.Size = new System.Drawing.Size(90, 90);
            this.plusOrderBarBtn.TabIndex = 29;
            this.plusOrderBarBtn.Text = "+";
            this.plusOrderBarBtn.UseVisualStyleBackColor = false;
            this.plusOrderBarBtn.Click += new System.EventHandler(this.plusOrderBarBtn_Click);
            // 
            // minusOrderBarBtn
            // 
            this.minusOrderBarBtn.BackColor = System.Drawing.Color.LightCoral;
            this.minusOrderBarBtn.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusOrderBarBtn.Location = new System.Drawing.Point(647, 525);
            this.minusOrderBarBtn.Name = "minusOrderBarBtn";
            this.minusOrderBarBtn.Size = new System.Drawing.Size(90, 90);
            this.minusOrderBarBtn.TabIndex = 30;
            this.minusOrderBarBtn.Text = "-";
            this.minusOrderBarBtn.UseVisualStyleBackColor = false;
            this.minusOrderBarBtn.Click += new System.EventHandler(this.minusOrderBarBtn_Click);
            // 
            // BarBestelMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 622);
            this.Controls.Add(this.minusOrderBarBtn);
            this.Controls.Add(this.plusOrderBarBtn);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.orderTxtLbl);
            this.Controls.Add(this.drankenKaartTxtLbl);
            this.Controls.Add(this.plaatsOrderBarBtn);
            this.Controls.Add(this.orderDrankenListView);
            this.Controls.Add(this.drankenKaartListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BarBestelMenu";
            this.Text = "BarBestelMenu";
            this.Load += new System.EventHandler(this.BarBestelMenu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView drankenKaartListView;
        private System.Windows.Forms.ListView orderDrankenListView;
        private System.Windows.Forms.Button plaatsOrderBarBtn;
        private System.Windows.Forms.Label drankenKaartTxtLbl;
        private System.Windows.Forms.Label orderTxtLbl;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem TerugtoolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UitloggenToolStripMenuItem;
        private System.Windows.Forms.Button plusOrderBarBtn;
        private System.Windows.Forms.Button minusOrderBarBtn;
    }
}
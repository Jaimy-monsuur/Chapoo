
namespace ChapooUI
{
    partial class Managetafel
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TerugtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GBX_verandeStatus = new System.Windows.Forms.GroupBox();
            this.TXB_Aantalmensen = new System.Windows.Forms.TextBox();
            this.LBL_aantalmensen = new System.Windows.Forms.Label();
            this.BTN_Eddit = new System.Windows.Forms.Button();
            this.LBL_Managetafel = new System.Windows.Forms.Label();
            this.GBX_ViewOrders = new System.Windows.Forms.GroupBox();
            this.BTN_Delete_reservation = new System.Windows.Forms.Button();
            this.LF_Reservations = new System.Windows.Forms.ListView();
            this.LBL_Tafelstatus = new System.Windows.Forms.Label();
            this.LBL_tafelnummer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.GBX_verandeStatus.SuspendLayout();
            this.GBX_ViewOrders.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip2.TabIndex = 26;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // TerugtoolStripMenuItem
            // 
            this.TerugtoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.TerugtoolStripMenuItem.Name = "TerugtoolStripMenuItem";
            this.TerugtoolStripMenuItem.Size = new System.Drawing.Size(61, 24);
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
            this.menuStrip1.Location = new System.Drawing.Point(631, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(97, 27);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UitloggenToolStripMenuItem
            // 
            this.UitloggenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.UitloggenToolStripMenuItem.Name = "UitloggenToolStripMenuItem";
            this.UitloggenToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.UitloggenToolStripMenuItem.Text = "Uitloggen";
            this.UitloggenToolStripMenuItem.Click += new System.EventHandler(this.UitloggenToolStripMenuItem_Click);
            // 
            // GBX_verandeStatus
            // 
            this.GBX_verandeStatus.Controls.Add(this.TXB_Aantalmensen);
            this.GBX_verandeStatus.Controls.Add(this.LBL_aantalmensen);
            this.GBX_verandeStatus.Controls.Add(this.BTN_Eddit);
            this.GBX_verandeStatus.Controls.Add(this.LBL_Managetafel);
            this.GBX_verandeStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.GBX_verandeStatus.Location = new System.Drawing.Point(17, 131);
            this.GBX_verandeStatus.Name = "GBX_verandeStatus";
            this.GBX_verandeStatus.Size = new System.Drawing.Size(698, 196);
            this.GBX_verandeStatus.TabIndex = 24;
            this.GBX_verandeStatus.TabStop = false;
            this.GBX_verandeStatus.Text = "groupBox1";
            // 
            // TXB_Aantalmensen
            // 
            this.TXB_Aantalmensen.Location = new System.Drawing.Point(186, 75);
            this.TXB_Aantalmensen.Name = "TXB_Aantalmensen";
            this.TXB_Aantalmensen.Size = new System.Drawing.Size(45, 30);
            this.TXB_Aantalmensen.TabIndex = 23;
            // 
            // LBL_aantalmensen
            // 
            this.LBL_aantalmensen.AutoSize = true;
            this.LBL_aantalmensen.Location = new System.Drawing.Point(16, 78);
            this.LBL_aantalmensen.Name = "LBL_aantalmensen";
            this.LBL_aantalmensen.Size = new System.Drawing.Size(133, 23);
            this.LBL_aantalmensen.TabIndex = 22;
            this.LBL_aantalmensen.Text = "Aantal mensen:";
            // 
            // BTN_Eddit
            // 
            this.BTN_Eddit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_Eddit.Location = new System.Drawing.Point(14, 151);
            this.BTN_Eddit.Name = "BTN_Eddit";
            this.BTN_Eddit.Size = new System.Drawing.Size(109, 39);
            this.BTN_Eddit.TabIndex = 21;
            this.BTN_Eddit.Text = "button1";
            this.BTN_Eddit.UseVisualStyleBackColor = false;
            this.BTN_Eddit.Click += new System.EventHandler(this.BTN_Eddit_Click_1);
            // 
            // LBL_Managetafel
            // 
            this.LBL_Managetafel.AutoSize = true;
            this.LBL_Managetafel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Managetafel.Location = new System.Drawing.Point(16, 39);
            this.LBL_Managetafel.Name = "LBL_Managetafel";
            this.LBL_Managetafel.Size = new System.Drawing.Size(54, 23);
            this.LBL_Managetafel.TabIndex = 5;
            this.LBL_Managetafel.Text = "Tafel:";
            // 
            // GBX_ViewOrders
            // 
            this.GBX_ViewOrders.Controls.Add(this.button1);
            this.GBX_ViewOrders.Controls.Add(this.BTN_Delete_reservation);
            this.GBX_ViewOrders.Controls.Add(this.LF_Reservations);
            this.GBX_ViewOrders.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBX_ViewOrders.Location = new System.Drawing.Point(17, 343);
            this.GBX_ViewOrders.Name = "GBX_ViewOrders";
            this.GBX_ViewOrders.Size = new System.Drawing.Size(698, 373);
            this.GBX_ViewOrders.TabIndex = 23;
            this.GBX_ViewOrders.TabStop = false;
            this.GBX_ViewOrders.Text = "Orders";
            // 
            // BTN_Delete_reservation
            // 
            this.BTN_Delete_reservation.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_Delete_reservation.Location = new System.Drawing.Point(14, 315);
            this.BTN_Delete_reservation.Name = "BTN_Delete_reservation";
            this.BTN_Delete_reservation.Size = new System.Drawing.Size(186, 47);
            this.BTN_Delete_reservation.TabIndex = 4;
            this.BTN_Delete_reservation.Text = "Verwijder";
            this.BTN_Delete_reservation.UseVisualStyleBackColor = false;
            // 
            // LF_Reservations
            // 
            this.LF_Reservations.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LF_Reservations.FullRowSelect = true;
            this.LF_Reservations.HideSelection = false;
            this.LF_Reservations.Location = new System.Drawing.Point(14, 42);
            this.LF_Reservations.Name = "LF_Reservations";
            this.LF_Reservations.Size = new System.Drawing.Size(665, 250);
            this.LF_Reservations.TabIndex = 3;
            this.LF_Reservations.UseCompatibleStateImageBehavior = false;
            // 
            // LBL_Tafelstatus
            // 
            this.LBL_Tafelstatus.AutoSize = true;
            this.LBL_Tafelstatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Tafelstatus.Location = new System.Drawing.Point(12, 100);
            this.LBL_Tafelstatus.Name = "LBL_Tafelstatus";
            this.LBL_Tafelstatus.Size = new System.Drawing.Size(128, 28);
            this.LBL_Tafelstatus.TabIndex = 22;
            this.LBL_Tafelstatus.Text = "Tafel Status:";
            // 
            // LBL_tafelnummer
            // 
            this.LBL_tafelnummer.AutoSize = true;
            this.LBL_tafelnummer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_tafelnummer.Location = new System.Drawing.Point(12, 54);
            this.LBL_tafelnummer.Name = "LBL_tafelnummer";
            this.LBL_tafelnummer.Size = new System.Drawing.Size(149, 28);
            this.LBL_tafelnummer.TabIndex = 21;
            this.LBL_tafelnummer.Text = "Tafel nummer:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(221, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Order toevoegen";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Managetafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 794);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GBX_verandeStatus);
            this.Controls.Add(this.GBX_ViewOrders);
            this.Controls.Add(this.LBL_Tafelstatus);
            this.Controls.Add(this.LBL_tafelnummer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Managetafel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GBX_verandeStatus.ResumeLayout(false);
            this.GBX_verandeStatus.PerformLayout();
            this.GBX_ViewOrders.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem TerugtoolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UitloggenToolStripMenuItem;
        private System.Windows.Forms.GroupBox GBX_verandeStatus;
        private System.Windows.Forms.TextBox TXB_Aantalmensen;
        private System.Windows.Forms.Label LBL_aantalmensen;
        private System.Windows.Forms.Button BTN_Eddit;
        private System.Windows.Forms.Label LBL_Managetafel;
        private System.Windows.Forms.GroupBox GBX_ViewOrders;
        private System.Windows.Forms.Button BTN_Delete_reservation;
        private System.Windows.Forms.ListView LF_Reservations;
        private System.Windows.Forms.Label LBL_Tafelstatus;
        private System.Windows.Forms.Label LBL_tafelnummer;
        private System.Windows.Forms.Button button1;
    }
}

namespace ChapooUI
{
    partial class TableReservations
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
            this.LBL_tafelnummer = new System.Windows.Forms.Label();
            this.GBX_ViewReservations = new System.Windows.Forms.GroupBox();
            this.BTN_Delete_reservation = new System.Windows.Forms.Button();
            this.LF_Reservations = new System.Windows.Forms.ListView();
            this.GBX_verandeStatus = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TerugtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_ManageReservations = new System.Windows.Forms.Button();
            this.GBX_ViewReservations.SuspendLayout();
            this.GBX_verandeStatus.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_tafelnummer
            // 
            this.LBL_tafelnummer.AutoSize = true;
            this.LBL_tafelnummer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_tafelnummer.Location = new System.Drawing.Point(12, 54);
            this.LBL_tafelnummer.Name = "LBL_tafelnummer";
            this.LBL_tafelnummer.Size = new System.Drawing.Size(149, 28);
            this.LBL_tafelnummer.TabIndex = 3;
            this.LBL_tafelnummer.Text = "Tafel nummer:";
            // 
            // GBX_ViewReservations
            // 
            this.GBX_ViewReservations.Controls.Add(this.BTN_Delete_reservation);
            this.GBX_ViewReservations.Controls.Add(this.LF_Reservations);
            this.GBX_ViewReservations.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBX_ViewReservations.Location = new System.Drawing.Point(12, 367);
            this.GBX_ViewReservations.Name = "GBX_ViewReservations";
            this.GBX_ViewReservations.Size = new System.Drawing.Size(698, 406);
            this.GBX_ViewReservations.TabIndex = 5;
            this.GBX_ViewReservations.TabStop = false;
            this.GBX_ViewReservations.Text = "Reserveringen";
            // 
            // BTN_Delete_reservation
            // 
            this.BTN_Delete_reservation.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_Delete_reservation.Location = new System.Drawing.Point(14, 342);
            this.BTN_Delete_reservation.Name = "BTN_Delete_reservation";
            this.BTN_Delete_reservation.Size = new System.Drawing.Size(186, 47);
            this.BTN_Delete_reservation.TabIndex = 4;
            this.BTN_Delete_reservation.Text = "Verwijder";
            this.BTN_Delete_reservation.UseVisualStyleBackColor = false;
            this.BTN_Delete_reservation.Click += new System.EventHandler(this.BTN_Delete_reservation_Click);
            // 
            // LF_Reservations
            // 
            this.LF_Reservations.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LF_Reservations.FullRowSelect = true;
            this.LF_Reservations.HideSelection = false;
            this.LF_Reservations.Location = new System.Drawing.Point(14, 42);
            this.LF_Reservations.Name = "LF_Reservations";
            this.LF_Reservations.Size = new System.Drawing.Size(665, 280);
            this.LF_Reservations.TabIndex = 3;
            this.LF_Reservations.UseCompatibleStateImageBehavior = false;
            // 
            // GBX_verandeStatus
            // 
            this.GBX_verandeStatus.Controls.Add(this.BTN_ManageReservations);
            this.GBX_verandeStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.GBX_verandeStatus.Location = new System.Drawing.Point(17, 94);
            this.GBX_verandeStatus.Name = "GBX_verandeStatus";
            this.GBX_verandeStatus.Size = new System.Drawing.Size(698, 243);
            this.GBX_verandeStatus.TabIndex = 6;
            this.GBX_verandeStatus.TabStop = false;
            this.GBX_verandeStatus.Text = "Reservering toevoegen";
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
            this.menuStrip1.Size = new System.Drawing.Size(99, 30);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UitloggenToolStripMenuItem
            // 
            this.UitloggenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.UitloggenToolStripMenuItem.Name = "UitloggenToolStripMenuItem";
            this.UitloggenToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.UitloggenToolStripMenuItem.Text = "Uitloggen";
            this.UitloggenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
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
            this.menuStrip2.Size = new System.Drawing.Size(71, 30);
            this.menuStrip2.TabIndex = 20;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // TerugtoolStripMenuItem
            // 
            this.TerugtoolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.TerugtoolStripMenuItem.Name = "TerugtoolStripMenuItem";
            this.TerugtoolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.TerugtoolStripMenuItem.Text = "Terug";
            this.TerugtoolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // BTN_ManageReservations
            // 
            this.BTN_ManageReservations.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_ManageReservations.Location = new System.Drawing.Point(14, 172);
            this.BTN_ManageReservations.Name = "BTN_ManageReservations";
            this.BTN_ManageReservations.Size = new System.Drawing.Size(197, 65);
            this.BTN_ManageReservations.TabIndex = 33;
            this.BTN_ManageReservations.Text = "Reservering toevoegen";
            this.BTN_ManageReservations.UseVisualStyleBackColor = false;
            // 
            // TableReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(726, 794);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GBX_verandeStatus);
            this.Controls.Add(this.GBX_ViewReservations);
            this.Controls.Add(this.LBL_tafelnummer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TableReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableManagement";
            this.GBX_ViewReservations.ResumeLayout(false);
            this.GBX_verandeStatus.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBL_tafelnummer;
        private System.Windows.Forms.GroupBox GBX_ViewReservations;
        private System.Windows.Forms.Button BTN_Delete_reservation;
        private System.Windows.Forms.ListView LF_Reservations;
        private System.Windows.Forms.GroupBox GBX_verandeStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UitloggenToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem TerugtoolStripMenuItem;
        private System.Windows.Forms.Button BTN_ManageReservations;
    }
}
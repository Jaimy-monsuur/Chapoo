
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
            this.LBL_error = new System.Windows.Forms.Label();
            this.BTN_newcustomer = new System.Windows.Forms.Button();
            this.CB_Klanten = new System.Windows.Forms.ComboBox();
            this.REndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RStarttimePicker = new System.Windows.Forms.DateTimePicker();
            this.RDatepicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_ManageReservations = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.TerugtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.GBX_ViewReservations.Location = new System.Drawing.Point(16, 395);
            this.GBX_ViewReservations.Name = "GBX_ViewReservations";
            this.GBX_ViewReservations.Size = new System.Drawing.Size(698, 336);
            this.GBX_ViewReservations.TabIndex = 5;
            this.GBX_ViewReservations.TabStop = false;
            this.GBX_ViewReservations.Text = "Reserveringen";
            // 
            // BTN_Delete_reservation
            // 
            this.BTN_Delete_reservation.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_Delete_reservation.Location = new System.Drawing.Point(14, 280);
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
            this.LF_Reservations.Size = new System.Drawing.Size(665, 232);
            this.LF_Reservations.TabIndex = 3;
            this.LF_Reservations.UseCompatibleStateImageBehavior = false;
            // 
            // GBX_verandeStatus
            // 
            this.GBX_verandeStatus.Controls.Add(this.LBL_error);
            this.GBX_verandeStatus.Controls.Add(this.BTN_newcustomer);
            this.GBX_verandeStatus.Controls.Add(this.CB_Klanten);
            this.GBX_verandeStatus.Controls.Add(this.REndTimePicker);
            this.GBX_verandeStatus.Controls.Add(this.RStarttimePicker);
            this.GBX_verandeStatus.Controls.Add(this.RDatepicker);
            this.GBX_verandeStatus.Controls.Add(this.label5);
            this.GBX_verandeStatus.Controls.Add(this.label4);
            this.GBX_verandeStatus.Controls.Add(this.label3);
            this.GBX_verandeStatus.Controls.Add(this.label1);
            this.GBX_verandeStatus.Controls.Add(this.BTN_ManageReservations);
            this.GBX_verandeStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.GBX_verandeStatus.Location = new System.Drawing.Point(17, 94);
            this.GBX_verandeStatus.Name = "GBX_verandeStatus";
            this.GBX_verandeStatus.Size = new System.Drawing.Size(698, 295);
            this.GBX_verandeStatus.TabIndex = 6;
            this.GBX_verandeStatus.TabStop = false;
            this.GBX_verandeStatus.Text = "Reservering toevoegen";
            // 
            // LBL_error
            // 
            this.LBL_error.AutoSize = true;
            this.LBL_error.BackColor = System.Drawing.Color.Chocolate;
            this.LBL_error.ForeColor = System.Drawing.Color.Red;
            this.LBL_error.Location = new System.Drawing.Point(225, 258);
            this.LBL_error.Name = "LBL_error";
            this.LBL_error.Size = new System.Drawing.Size(0, 23);
            this.LBL_error.TabIndex = 21;
            // 
            // BTN_newcustomer
            // 
            this.BTN_newcustomer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_newcustomer.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_newcustomer.Location = new System.Drawing.Point(546, 52);
            this.BTN_newcustomer.Name = "BTN_newcustomer";
            this.BTN_newcustomer.Size = new System.Drawing.Size(146, 34);
            this.BTN_newcustomer.TabIndex = 43;
            this.BTN_newcustomer.Text = "Klant toevoegen";
            this.BTN_newcustomer.UseVisualStyleBackColor = false;
            this.BTN_newcustomer.Click += new System.EventHandler(this.BTN_newcustomer_Click);
            // 
            // CB_Klanten
            // 
            this.CB_Klanten.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Klanten.FormattingEnabled = true;
            this.CB_Klanten.Location = new System.Drawing.Point(169, 52);
            this.CB_Klanten.Name = "CB_Klanten";
            this.CB_Klanten.Size = new System.Drawing.Size(195, 31);
            this.CB_Klanten.TabIndex = 42;
            // 
            // REndTimePicker
            // 
            this.REndTimePicker.CustomFormat = "HH:mm";
            this.REndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.REndTimePicker.Location = new System.Drawing.Point(169, 166);
            this.REndTimePicker.Name = "REndTimePicker";
            this.REndTimePicker.ShowUpDown = true;
            this.REndTimePicker.Size = new System.Drawing.Size(313, 30);
            this.REndTimePicker.TabIndex = 41;
            // 
            // RStarttimePicker
            // 
            this.RStarttimePicker.CustomFormat = "HH:mm";
            this.RStarttimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RStarttimePicker.Location = new System.Drawing.Point(169, 130);
            this.RStarttimePicker.Name = "RStarttimePicker";
            this.RStarttimePicker.ShowUpDown = true;
            this.RStarttimePicker.Size = new System.Drawing.Size(313, 30);
            this.RStarttimePicker.TabIndex = 40;
            // 
            // RDatepicker
            // 
            this.RDatepicker.CustomFormat = "dd-MM-yyyy";
            this.RDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RDatepicker.Location = new System.Drawing.Point(169, 89);
            this.RDatepicker.Name = "RDatepicker";
            this.RDatepicker.Size = new System.Drawing.Size(313, 30);
            this.RDatepicker.TabIndex = 39;
            this.RDatepicker.Value = new System.DateTime(2021, 5, 28, 13, 28, 38, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "Eindtijd: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Begintijd:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Klant: ";
            // 
            // BTN_ManageReservations
            // 
            this.BTN_ManageReservations.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_ManageReservations.Location = new System.Drawing.Point(10, 216);
            this.BTN_ManageReservations.Name = "BTN_ManageReservations";
            this.BTN_ManageReservations.Size = new System.Drawing.Size(197, 65);
            this.BTN_ManageReservations.TabIndex = 33;
            this.BTN_ManageReservations.Text = "Reservering toevoegen";
            this.BTN_ManageReservations.UseVisualStyleBackColor = false;
            this.BTN_ManageReservations.Click += new System.EventHandler(this.BTN_ManageReservations_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.LightCoral;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UitloggenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(633, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(97, 27);
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
            this.menuStrip2.Size = new System.Drawing.Size(69, 27);
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
            // TableReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(726, 736);
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
            this.GBX_verandeStatus.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker REndTimePicker;
        private System.Windows.Forms.DateTimePicker RStarttimePicker;
        private System.Windows.Forms.DateTimePicker RDatepicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Klanten;
        private System.Windows.Forms.Button BTN_newcustomer;
        private System.Windows.Forms.Label LBL_error;
    }
}
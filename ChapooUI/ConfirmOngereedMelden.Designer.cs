
namespace ChapooUI
{
    partial class ConfirmOngereedMelden
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
            this.bevestigOnGereedLbl = new System.Windows.Forms.Label();
            this.annuleerBtn = new System.Windows.Forms.Button();
            this.meldOngereedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bevestigOnGereedLbl
            // 
            this.bevestigOnGereedLbl.AutoSize = true;
            this.bevestigOnGereedLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bevestigOnGereedLbl.Location = new System.Drawing.Point(58, 25);
            this.bevestigOnGereedLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bevestigOnGereedLbl.Name = "bevestigOnGereedLbl";
            this.bevestigOnGereedLbl.Size = new System.Drawing.Size(260, 25);
            this.bevestigOnGereedLbl.TabIndex = 5;
            this.bevestigOnGereedLbl.Text = "Wil je dit ongereed melden?";
            // 
            // annuleerBtn
            // 
            this.annuleerBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.annuleerBtn.Location = new System.Drawing.Point(219, 88);
            this.annuleerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.annuleerBtn.Name = "annuleerBtn";
            this.annuleerBtn.Size = new System.Drawing.Size(119, 34);
            this.annuleerBtn.TabIndex = 4;
            this.annuleerBtn.Text = "Annuleer";
            this.annuleerBtn.UseVisualStyleBackColor = false;
            this.annuleerBtn.Click += new System.EventHandler(this.annuleerBtn_Click);
            // 
            // meldOngereedBtn
            // 
            this.meldOngereedBtn.BackColor = System.Drawing.Color.LightCoral;
            this.meldOngereedBtn.Location = new System.Drawing.Point(36, 88);
            this.meldOngereedBtn.Margin = new System.Windows.Forms.Padding(2);
            this.meldOngereedBtn.Name = "meldOngereedBtn";
            this.meldOngereedBtn.Size = new System.Drawing.Size(119, 34);
            this.meldOngereedBtn.TabIndex = 3;
            this.meldOngereedBtn.Text = "Meld ongereed";
            this.meldOngereedBtn.UseVisualStyleBackColor = false;
            this.meldOngereedBtn.Click += new System.EventHandler(this.meldOngereedBtn_Click);
            // 
            // ConfirmOngereedMelden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 157);
            this.Controls.Add(this.bevestigOnGereedLbl);
            this.Controls.Add(this.annuleerBtn);
            this.Controls.Add(this.meldOngereedBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmOngereedMelden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfirmGereedMelden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bevestigOnGereedLbl;
        private System.Windows.Forms.Button annuleerBtn;
        private System.Windows.Forms.Button meldOngereedBtn;
    }
}
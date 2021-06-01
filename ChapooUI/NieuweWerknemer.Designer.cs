
namespace ChapooUI
{
    partial class NieuweWerknemer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_voornaam = new System.Windows.Forms.TextBox();
            this.tbx_achternaam = new System.Windows.Forms.TextBox();
            this.Tbx_functie = new System.Windows.Forms.TextBox();
            this.tbx_wachtwoord = new System.Windows.Forms.TextBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.BTN_terug = new System.Windows.Forms.Button();
            this.BTN_Toevoegen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LBL_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "voornaam: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Achternaam: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Functie: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wachtwoord(4 cijfers): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Login type: ";
            // 
            // tbx_voornaam
            // 
            this.tbx_voornaam.Location = new System.Drawing.Point(216, 66);
            this.tbx_voornaam.Name = "tbx_voornaam";
            this.tbx_voornaam.Size = new System.Drawing.Size(121, 22);
            this.tbx_voornaam.TabIndex = 5;
            // 
            // tbx_achternaam
            // 
            this.tbx_achternaam.Location = new System.Drawing.Point(216, 115);
            this.tbx_achternaam.Name = "tbx_achternaam";
            this.tbx_achternaam.Size = new System.Drawing.Size(121, 22);
            this.tbx_achternaam.TabIndex = 6;
            // 
            // Tbx_functie
            // 
            this.Tbx_functie.Location = new System.Drawing.Point(216, 155);
            this.Tbx_functie.Name = "Tbx_functie";
            this.Tbx_functie.Size = new System.Drawing.Size(121, 22);
            this.Tbx_functie.TabIndex = 7;
            // 
            // tbx_wachtwoord
            // 
            this.tbx_wachtwoord.Location = new System.Drawing.Point(216, 200);
            this.tbx_wachtwoord.Name = "tbx_wachtwoord";
            this.tbx_wachtwoord.Size = new System.Drawing.Size(121, 22);
            this.tbx_wachtwoord.TabIndex = 8;
            this.tbx_wachtwoord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_wachtwoord_KeyPress);
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(216, 239);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 24);
            this.cb_type.TabIndex = 9;
            // 
            // BTN_terug
            // 
            this.BTN_terug.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_terug.Location = new System.Drawing.Point(226, 307);
            this.BTN_terug.Name = "BTN_terug";
            this.BTN_terug.Size = new System.Drawing.Size(111, 45);
            this.BTN_terug.TabIndex = 11;
            this.BTN_terug.Text = "Terug";
            this.BTN_terug.UseVisualStyleBackColor = false;
            this.BTN_terug.Click += new System.EventHandler(this.BTN_terug_Click);
            // 
            // BTN_Toevoegen
            // 
            this.BTN_Toevoegen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_Toevoegen.Location = new System.Drawing.Point(25, 307);
            this.BTN_Toevoegen.Name = "BTN_Toevoegen";
            this.BTN_Toevoegen.Size = new System.Drawing.Size(111, 45);
            this.BTN_Toevoegen.TabIndex = 10;
            this.BTN_Toevoegen.Text = "Toevoegen";
            this.BTN_Toevoegen.UseVisualStyleBackColor = false;
            this.BTN_Toevoegen.Click += new System.EventHandler(this.BTN_Toevoegen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nieuwe werknemer toevoegen";
            // 
            // LBL_error
            // 
            this.LBL_error.AutoSize = true;
            this.LBL_error.ForeColor = System.Drawing.Color.Red;
            this.LBL_error.Location = new System.Drawing.Point(33, 269);
            this.LBL_error.Name = "LBL_error";
            this.LBL_error.Size = new System.Drawing.Size(0, 17);
            this.LBL_error.TabIndex = 13;
            // 
            // NieuweWerknemer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 364);
            this.Controls.Add(this.LBL_error);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTN_terug);
            this.Controls.Add(this.BTN_Toevoegen);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.tbx_wachtwoord);
            this.Controls.Add(this.Tbx_functie);
            this.Controls.Add(this.tbx_achternaam);
            this.Controls.Add(this.tbx_voornaam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NieuweWerknemer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_voornaam;
        private System.Windows.Forms.TextBox tbx_achternaam;
        private System.Windows.Forms.TextBox Tbx_functie;
        private System.Windows.Forms.TextBox tbx_wachtwoord;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button BTN_terug;
        private System.Windows.Forms.Button BTN_Toevoegen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBL_error;
    }
}
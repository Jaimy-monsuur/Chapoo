
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
            this.terugKeukenBarBtn = new System.Windows.Forms.Button();
            this.plaatsOrderBarBtn = new System.Windows.Forms.Button();
            this.drankenKaartTxtLbl = new System.Windows.Forms.Label();
            this.orderTxtLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drankenKaartListView
            // 
            this.drankenKaartListView.HideSelection = false;
            this.drankenKaartListView.Location = new System.Drawing.Point(71, 71);
            this.drankenKaartListView.Name = "drankenKaartListView";
            this.drankenKaartListView.Size = new System.Drawing.Size(317, 304);
            this.drankenKaartListView.TabIndex = 0;
            this.drankenKaartListView.UseCompatibleStateImageBehavior = false;
            // 
            // orderDrankenListView
            // 
            this.orderDrankenListView.HideSelection = false;
            this.orderDrankenListView.Location = new System.Drawing.Point(394, 71);
            this.orderDrankenListView.Name = "orderDrankenListView";
            this.orderDrankenListView.Size = new System.Drawing.Size(317, 304);
            this.orderDrankenListView.TabIndex = 1;
            this.orderDrankenListView.UseCompatibleStateImageBehavior = false;
            // 
            // terugKeukenBarBtn
            // 
            this.terugKeukenBarBtn.BackColor = System.Drawing.Color.LightCoral;
            this.terugKeukenBarBtn.Location = new System.Drawing.Point(12, 12);
            this.terugKeukenBarBtn.Name = "terugKeukenBarBtn";
            this.terugKeukenBarBtn.Size = new System.Drawing.Size(100, 36);
            this.terugKeukenBarBtn.TabIndex = 2;
            this.terugKeukenBarBtn.Text = "Terug naar home menu";
            this.terugKeukenBarBtn.UseVisualStyleBackColor = false;
            // 
            // plaatsOrderBarBtn
            // 
            this.plaatsOrderBarBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.plaatsOrderBarBtn.Location = new System.Drawing.Point(71, 388);
            this.plaatsOrderBarBtn.Name = "plaatsOrderBarBtn";
            this.plaatsOrderBarBtn.Size = new System.Drawing.Size(141, 50);
            this.plaatsOrderBarBtn.TabIndex = 4;
            this.plaatsOrderBarBtn.Text = "Plaats order";
            this.plaatsOrderBarBtn.UseVisualStyleBackColor = false;
            this.plaatsOrderBarBtn.Click += new System.EventHandler(this.plaatsOrderBarBtn_Click);
            // 
            // drankenKaartTxtLbl
            // 
            this.drankenKaartTxtLbl.AutoSize = true;
            this.drankenKaartTxtLbl.Location = new System.Drawing.Point(68, 55);
            this.drankenKaartTxtLbl.Name = "drankenKaartTxtLbl";
            this.drankenKaartTxtLbl.Size = new System.Drawing.Size(75, 13);
            this.drankenKaartTxtLbl.TabIndex = 5;
            this.drankenKaartTxtLbl.Text = "Dranken kaart";
            // 
            // orderTxtLbl
            // 
            this.orderTxtLbl.AutoSize = true;
            this.orderTxtLbl.Location = new System.Drawing.Point(391, 55);
            this.orderTxtLbl.Name = "orderTxtLbl";
            this.orderTxtLbl.Size = new System.Drawing.Size(33, 13);
            this.orderTxtLbl.TabIndex = 6;
            this.orderTxtLbl.Text = "Order";
            // 
            // BarBestelMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderTxtLbl);
            this.Controls.Add(this.drankenKaartTxtLbl);
            this.Controls.Add(this.plaatsOrderBarBtn);
            this.Controls.Add(this.terugKeukenBarBtn);
            this.Controls.Add(this.orderDrankenListView);
            this.Controls.Add(this.drankenKaartListView);
            this.Name = "BarBestelMenu";
            this.Text = "BarBestelMenu";
            this.Load += new System.EventHandler(this.BarBestelMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView drankenKaartListView;
        private System.Windows.Forms.ListView orderDrankenListView;
        private System.Windows.Forms.Button terugKeukenBarBtn;
        private System.Windows.Forms.Button plaatsOrderBarBtn;
        private System.Windows.Forms.Label drankenKaartTxtLbl;
        private System.Windows.Forms.Label orderTxtLbl;
    }
}
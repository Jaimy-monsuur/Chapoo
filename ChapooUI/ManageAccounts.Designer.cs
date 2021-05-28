
namespace ChapooUI
{
    partial class ManageAccounts
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.LVW_Account = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // LVW_Account
            // 
            this.LVW_Account.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "Gebruikersnaam";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "Wachtwoord";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup1";
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "Type";
            this.LVW_Account.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.LVW_Account.HideSelection = false;
            this.LVW_Account.Location = new System.Drawing.Point(29, 87);
            this.LVW_Account.Name = "LVW_Account";
            this.LVW_Account.Size = new System.Drawing.Size(484, 353);
            this.LVW_Account.TabIndex = 0;
            this.LVW_Account.UseCompatibleStateImageBehavior = false;
            // 
            // ManageAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 580);
            this.Controls.Add(this.LVW_Account);
            this.Name = "ManageAccounts";
            this.Text = "ManageAccounts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LVW_Account;
    }
}
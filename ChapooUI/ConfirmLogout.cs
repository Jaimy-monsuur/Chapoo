using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
    public partial class ConfirmLogout : Form
    {
        public ConfirmLogout()
        {
            InitializeComponent();
        }

        private void BTN_loguit_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
                if (f.Name != "LoginForm")
                {
                    f.Close();
                }
        }

        private void BTN_annuleer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using ChapooUI;
using ChapooLogic;
using ChapooModel;
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
    public partial class LoginForm : Form
    {
        //maakt form movable vanaf elk punt.
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        public LoginForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Login_Click_1(object sender, EventArgs e)
        {
            lbl_errormessagebox.Text = "";
            if (tbx_Username.Text == "" || tbx_Password.Text == "")
            {
                lbl_errormessagebox.Text = "Enter Username and Password!";
            }
            else
            {
                Account_Service logIn_Service = new Account_Service();
                Account login = logIn_Service.Login(tbx_Username.Text, tbx_Password.Text);
                if (login.UserName == tbx_Username.Text && login.Password == tbx_Password.Text)
                {
                    CurrentUser user = CurrentUser.Getlnstance();
                    user.SetUser(login);
                    this.Hide();
                    ChapooUI ui = new ChapooUI();
                    ui.ShowDialog();
                    tbx_Username.Clear();
                    tbx_Password.Clear();
                    this.Show();
                }
                else
                {
                    lbl_errormessagebox.Text = "Wrong Username or Password!";
                }
            }
        }
    }
}

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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
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
                    this.Hide();
                    ChapooUI ui = new ChapooUI();
                    ui.ShowDialog();
                    this.Close();
                }
                else
                {
                    lbl_errormessagebox.Text = "Wrong Username or Password!";
                }
            }
        }
    }
}

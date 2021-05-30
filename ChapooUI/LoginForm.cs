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
            this.ControlBox = false;//haalt de border weg
            this.Text = "";
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();// sluit huidige form
        }

        private void BTN_Login_Click_1(object sender, EventArgs e)
        {
            lbl_errormessagebox.Text = "";
            if (tbx_Username.Text == "" || tbx_Password.Text == "")// kijkt of er wel gegevens ingevuld zijn
            {
                lbl_errormessagebox.Text = "Enter Username and Password!";//vertel de gebruiker gegevens in te vullen
            }
            else// de gebruiker heeft iets ingevuld
            {
                Account_Service logIn_Service = new Account_Service();
                Account login = logIn_Service.Login(tbx_Username.Text, tbx_Password.Text);//check de gegevens een haal de huidige gebruiker op uit de database.
                if (login.UserName == tbx_Username.Text && login.Password == tbx_Password.Text)
                {
                    CurrentUser user = CurrentUser.Getlnstance();
                    user.SetUser(login);//sets current user.
                    this.Hide();
                    ChapooUI ui = new ChapooUI();// open chapoo UI
                    ui.ShowDialog();
                    tbx_Username.Clear();// leegmaken
                    tbx_Password.Clear();//leegmaken
                    this.Show();
                }
                else// wachtwoord of username was fout
                {
                    lbl_errormessagebox.Text = "Wrong Username or Password!";
                }
            }
        }
    }
}

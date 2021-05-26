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
    public partial class ChapooUI : Form
    {
        public string Type;
        public string Username;

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
        public ChapooUI(string type,string username)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";

            this.Type = type;
            this.Username = username;
            LBL_userdata.Text = $"{Username}, {Type}";
            T_klok.Start();
            /*
            if (type == "bar")
            {

            }
            else if (type == "keuken")
            {

            }
            else if (type == "restaurant")
            {

            }
            */
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keukenSelectBtn_Click(object sender, EventArgs e)
        {
            KeukenBarSysteemForm keukenBarScherm = new KeukenBarSysteemForm();
            keukenBarScherm.ShowDialog();
        }

        private void bedieningSelectBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableOverview tafel_Overzicht = new TableOverview(Type, Username);
            tafel_Overzicht.ShowDialog();
            this.Show();
        }

        private void BTN__Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBL_klok.Text = DateTime.Now.ToString(("HH:mm:ss"));
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }
    }
}

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
    public partial class Managetafel : Form
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
        public Tafel_Service Tafel_Service = new Tafel_Service();
        public int Tafelnummer { get; set; }
        public string Status { get; set; }
        public Managetafel(int tafelnummer, string status)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";

            //tafel gegevens
            this.Tafelnummer = tafelnummer;
            this.Status = status;
            Eddittafel();
        }

        public void Eddittafel()
        {
            if (Status == "bezet")
            {
                LBL_Managetafel.Text = "Tafel is momenteel bezet";
                BTN_Eddit.Text = "Tafel vrij maken";
                BTN_Eddit.BackColor = Color.LightCoral;

                LBL_aantalmensen.Hide();
                TXB_Aantalmensen.Hide();
            }
            else if (Status == "gereserveerd")
            {
                LBL_Managetafel.Text = "Tafel is gereserveerd";
                BTN_Eddit.Text = "";
                BTN_Eddit.Enabled = false;

                LBL_aantalmensen.Hide();
                TXB_Aantalmensen.Hide();
                GBX_ViewOrders.Hide();
            }
            else
            {
                LBL_Managetafel.Text = "Tafel Toewijzen aan klant";
                BTN_Eddit.Text = "Toewijzen";
                GBX_ViewOrders.Hide();
            }
        }

        private void UitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        private void TerugtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Eddit_Click_1(object sender, EventArgs e)
        {
            if (Status == "bezet")
            {
                Tafel_Service.ClearTafel(Tafelnummer);
            }
            else if (Status == "vrij" && TXB_Aantalmensen.Text != "")
            {
                Tafel_Service.AlterBezetting(Tafelnummer, int.Parse(TXB_Aantalmensen.Text));
            }
            this.Close();
        }
    }
}

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
    public partial class BeheerHome : Form
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

        public BeheerHome()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
        }

        private void AccountpersoneelBtn_Click(object sender, EventArgs e)
        {

        }

        private void voorraadSelectBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VoorraadWijzigenWeergeven voorraad = new VoorraadWijzigenWeergeven();
            voorraad.ShowDialog();
            this.Show();
        }

        private void menuSelectBtn_Click(object sender, EventArgs e)
        {

        }

        private void UitloggenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConfirmLogout confirm = new ConfirmLogout();
            confirm.ShowDialog();
        }

        private void TerugtoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

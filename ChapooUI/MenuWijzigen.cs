using ChapooLogic;
using ChapooModel;
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
    public partial class MenuWijzigen : Form
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

        public Menuitems_Service menuitems_Service = new Menuitems_Service();
        public Voorraad_Service voorraad_Service = new Voorraad_Service();

        public MenuWijzigen()
        {
            InitializeComponent();
            //zorg er voor dat er geen border is
            this.ControlBox = false;
            this.Text = "";


            //Vul de listview met drank menu.

            ChapooLogic.Menuitems_Service menuServDra = new ChapooLogic.Menuitems_Service();
            List<Menuitems> MenuDrank = menuServDra.GetMenuitems();

            LV_MenuWijzig.View = View.Details;
            foreach (ChapooModel.Menuitems menuitems in MenuDrank)
            {
                if (menuitems.type == "Drank")
                {
                    LV_MenuWijzig.Items.Add(new ListViewItem(new string[] { $"{menuitems.itemNummer}", $"{menuitems.naam}", $"{menuitems.prijs}" }));
                }
            }
        }

        private void rBLunch_CheckedChanged(object sender, EventArgs e)
        {
            //Listview leegmaken
            LV_MenuWijzig.Items.Clear();

            //Vul de listview met middag menu.

            ChapooLogic.Menuitems_Service menuServMid = new ChapooLogic.Menuitems_Service();
            List<Menuitems> MenuMiddag = menuServMid.GetMenuitems();

            LV_MenuWijzig.View = View.Details;
            foreach (ChapooModel.Menuitems menuitems in MenuMiddag)
            {
                if (menuitems.type == "Lunch")
                {
                    LV_MenuWijzig.Items.Add(new ListViewItem(new string[] { $"{menuitems.itemNummer}", $"{menuitems.naam}", $"{menuitems.prijs}" }));
                }
            }
        }

        private void rBAvond_CheckedChanged(object sender, EventArgs e)
        {
            //Listview leegmaken
            LV_MenuWijzig.Items.Clear();

            //Vul de listview met middag menu.

            ChapooLogic.Menuitems_Service menuServAvo = new ChapooLogic.Menuitems_Service();
            List<Menuitems> MenuAvond = menuServAvo.GetMenuitems();

            LV_MenuWijzig.View = View.Details;
            foreach (ChapooModel.Menuitems menuitems in MenuAvond)
            {
                if (menuitems.type == "Avond")
                {
                    LV_MenuWijzig.Items.Add(new ListViewItem(new string[] { $"{menuitems.itemNummer}", $"{menuitems.naam}", $"{menuitems.prijs}" }));
                }
            }
        }

        private void rBDranken_CheckedChanged(object sender, EventArgs e)
        {
            //Listview leegmaken
            LV_MenuWijzig.Items.Clear();

           //Vul de listview met drank menu.

                ChapooLogic.Menuitems_Service menuServDra = new ChapooLogic.Menuitems_Service();
                List<Menuitems> MenuDrank = menuServDra.GetMenuitems();
                
                LV_MenuWijzig.View = View.Details;
                foreach (ChapooModel.Menuitems menuitems in MenuDrank)
                {
                    if (menuitems.type == "Drank")
                    {
                        LV_MenuWijzig.Items.Add(new ListViewItem(new string[] { $"{menuitems.itemNummer}", $"{menuitems.naam}", $"{menuitems.prijs}" }));
                    }
                }
        }

        private void BTNtoevoegen_Click(object sender, EventArgs e)
        {
            MenuitemToevoegen toevoegen = new MenuitemToevoegen();
            toevoegen.ShowDialog();
        }

        private void Btn_VerwijderMenuItem_Click(object sender, EventArgs e)
        {
            if (LV_MenuWijzig.SelectedItems.Count != 0)
            {
                voorraad_Service.DeleteMenuItem(int.Parse(LV_MenuWijzig.SelectedItems[0].SubItems[0].Text));
                menuitems_Service.DeleteMenuItem(int.Parse(LV_MenuWijzig.SelectedItems[0].SubItems[0].Text));


                lblErrorBox.ForeColor = Color.Green;
                lblErrorBox.Text = "Gelukt, Je hebt een menuitem verwijderd!";

            }
            else
            {
                lblErrorBox.ForeColor = Color.Red;
                lblErrorBox.Text = "Klik eerst een item aan in de menulijst!";
            }

            LV_MenuWijzig.Refresh();
        }

        private void TsMenuTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }
    }
}

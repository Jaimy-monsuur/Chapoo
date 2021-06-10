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
        public Menuitems_Service menuitems_Service = new Menuitems_Service();
        public Voorraad_Service voorraad_Service = new Voorraad_Service();

        public MenuWijzigen()
        {
            InitializeComponent();

            if (rBLunch.Checked)
            {
                //Vul de listview met middag menu.

                ChapooLogic.Menuitems_Service menuServMid = new ChapooLogic.Menuitems_Service();
                List<Menuitems> MenuMiddag = menuServMid.GetMenuMiddag();
                LV_MenuWijzig.View = View.Details;
                foreach (ChapooModel.Menuitems menuitems in MenuMiddag)
                {
                    LV_MenuWijzig.Items.Add(new ListViewItem(new string[] { $"{menuitems.itemNummer}", $"{menuitems.naam}", $"{menuitems.prijs}" }));
                }
            }
            else if (rBAvond.Checked)
            {
                //Vul de listview met middag menu.

                ChapooLogic.Menuitems_Service menuServAvo = new ChapooLogic.Menuitems_Service();
                List<Menuitems> MenuAvond = menuServAvo.GetMenuAvond();
                LV_MenuWijzig.View = View.Details;
                foreach (ChapooModel.Menuitems menuitems in MenuAvond)
                {
                    LV_MenuWijzig.Items.Add(new ListViewItem(new string[] { $"{menuitems.itemNummer}", $"{menuitems.naam}", $"{menuitems.prijs}" }));
                }
            }
            else
            {
                //Vul de listview met drank menu.

                ChapooLogic.Menuitems_Service menuServDra = new ChapooLogic.Menuitems_Service();
                List<Menuitems> MenuDrank = menuServDra.GetMenuDrankItems();
                LV_MenuWijzig.View = View.Details;
                foreach (ChapooModel.Menuitems menuitems in MenuDrank)
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
            List<Menuitems> MenuMiddag = menuServMid.GetMenuMiddag();
            LV_MenuWijzig.View = View.Details;
            foreach (ChapooModel.Menuitems menuitems in MenuMiddag)
            {
                LV_MenuWijzig.Items.Add(new ListViewItem(new string[] { $"{menuitems.itemNummer}", $"{menuitems.naam}", $"{menuitems.prijs}" }));
            }
        }

        private void rBAvond_CheckedChanged(object sender, EventArgs e)
        {
            //Listview leegmaken
            LV_MenuWijzig.Items.Clear();

            //Vul de listview met middag menu.

            ChapooLogic.Menuitems_Service menuServAvo = new ChapooLogic.Menuitems_Service();
            List<Menuitems> MenuAvond = menuServAvo.GetMenuAvond();
            LV_MenuWijzig.View = View.Details;
            foreach (ChapooModel.Menuitems menuitems in MenuAvond)
            {
                LV_MenuWijzig.Items.Add(new ListViewItem(new string[] { $"{menuitems.itemNummer}", $"{menuitems.naam}", $"{menuitems.prijs}" }));
            }
        }

        private void rBDranken_CheckedChanged(object sender, EventArgs e)
        {
            //Listview leegmaken
            LV_MenuWijzig.Items.Clear();

            //Vul de listview met drank menu.

            ChapooLogic.Menuitems_Service menuServDra = new ChapooLogic.Menuitems_Service();
            List<Menuitems> MenuDrank = menuServDra.GetMenuDrankItems();
            LV_MenuWijzig.View = View.Details;
            foreach (ChapooModel.Menuitems menuitems in MenuDrank)
            {
                LV_MenuWijzig.Items.Add(new ListViewItem(new string[] { $"{menuitems.itemNummer}", $"{menuitems.naam}", $"{menuitems.prijs}"}));
            }
        }

        private void BTNtoevoegen_Click(object sender, EventArgs e)
        {

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
        }
    }
}

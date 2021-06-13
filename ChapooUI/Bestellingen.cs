using ChapooModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
   
    public partial class Bestellingen : Form
    {
        //Code voor de placeholder.

        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public int Tafelnummer { get; set; }
        public int Ordernummer { get; set; }

        public Bestellingen(int Ordernummer, int tafelnummer)
        {
            InitializeComponent();
            this.Tafelnummer = tafelnummer;
            this.Ordernummer = Ordernummer;
            lblTafelNummerIn.Text = Tafelnummer.ToString();

            cb_Aantal.DisplayMember = '1'.ToString();
            cb_Aantal.Items.Add('2');
            cb_Aantal.Items.Add('3');
            cb_Aantal.Items.Add('4');
            cb_Aantal.Items.Add('5');
            cb_Aantal.Items.Add('6');
            cb_Aantal.Items.Add('7');
            cb_Aantal.Items.Add('8');
            cb_Aantal.Items.Add('9');
            cb_Aantal.Items.Add("10");
            cb_Aantal.Items.Add("11");
            cb_Aantal.Items.Add("12");
            cb_Aantal.Items.Add("13");
            cb_Aantal.Items.Add("14");


            if (rBLunch.Checked)
            {
                //Vul de listview met middag menu.

               ChapooLogic.Menuitems_Service menuServMid = new ChapooLogic.Menuitems_Service();
                List<Menuitems> MenuMiddag = menuServMid.GetMenuMiddag();
                LvEtenMenu.View = View.Details;
                foreach (ChapooModel.Menuitems menuitems in MenuMiddag)
                {
                    LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{menuitems.naam}", $"{menuitems.prijs}" }));
                } 
            }
            else if (rBAvond.Checked)
            {
                //Vul de listview met middag menu.

                ChapooLogic.Menuitems_Service menuServAvo = new ChapooLogic.Menuitems_Service();
                List<Menuitems> MenuAvond = menuServAvo.GetMenuAvond();
                LvEtenMenu.View = View.Details;
                foreach (ChapooModel.Menuitems menuitems in MenuAvond)
                {
                    LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{menuitems.naam}", $"{menuitems.prijs}" }));
                }
            }
            else
            {
                //Vul de listview met drank menu.

                ChapooLogic.Menuitems_Service menuServDra= new ChapooLogic.Menuitems_Service();
                List<Menuitems> MenuDrank = menuServDra.GetMenuDrankItems();
                LvEtenMenu.View = View.Details;
                foreach (ChapooModel.Menuitems menuitems in MenuDrank)
                {
                    LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{menuitems.naam}", $"{menuitems.prijs}" }));
                }
            }

            if (Ordernummer >= 0)
            {
                //Vul de listview met een order die al aanwezig is.

                ChapooLogic.Orderitems_Service Ordernr = new ChapooLogic.Orderitems_Service();
                List<Orderitems> ordernummer = Ordernr.Db_Get_All_Orderitems_for_Order(Ordernummer);

                LvOrderDetails.View = View.Details;
                foreach (ChapooModel.Orderitems OrdNumr in ordernummer)
                {
                    
                    LvOrderDetails.Items.Add(new ListViewItem(new string[] { $"{OrdNumr.menuItem.naam}", $"{OrdNumr.opmerking}"}));
                }
            }
            else
            {
                // Maakt hij gewoon een nieuwe aan.
            }

            
            //Zorgt voor een placeholder "Opmerking:" in de textbox opmerking.

            SendMessage(txtOpmerkingBestelling.Handle, EM_SETCUEBANNER, 0, "Opmerking:");

            CurrentUser user = CurrentUser.Getlnstance();
            LBL_UserDataOr.Text = user.ToString();

            LBL_klokOr.Text = DateTime.Now.ToString(("HH:mm:ss"));

        }
        private void btn_Uitlog_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Checked of er een item is geselecteerd zoniet dan geeft hij een waarschuwing
                if (LvEtenMenu.SelectedItems.Count > 0)
                {
                    //De opmerkingen aan de orderdetails toevoegen
                    Orderitems opmerking = new Orderitems();

                    opmerking.opmerking = txtOpmerkingBestelling.Text;

                    //listview geselecteerde items toevoegen aan de orderdetails
                    ListViewItem item = LvEtenMenu.SelectedItems[0];
                    Menuitems menuitem = new Menuitems()
                    {
                        naam = item.SubItems[0].Text,
                        prijs = decimal.Parse(item.SubItems[1].Text),
                    };

                    LvOrderDetails.Items.Add(new ListViewItem(new string[] { $"{menuitem.naam}", $"{opmerking.opmerking}" }));

                    lblErrorMenuBox.Text = "";
                }
                else
                {
                    btnDeleteItem.Enabled = false;

                    lblErrorMenuBox.Text = "Klik eerst een item aan in de menulijst!";
                }

                btnDeleteItem.Enabled = true;
        }


        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            //Checked of er een item is geselecteerd zoniet dan geeft hij een waarschuwing
                if (LvOrderDetails.SelectedItems.Count > 0)
                {
                    LvOrderDetails.Items.RemoveAt(LvOrderDetails.SelectedIndices[0]);
                    lblErrorBox.Text = "";
                }
                else
                {
                    btnDeleteItem.Enabled = false;

                    lblErrorBox.Text = "Klik eerst een item aan in de orderlijst!";                    
                }
                
                btnDeleteItem.Enabled = true;
        }

        private void rBLunch_CheckedChanged(object sender, EventArgs e)
        {
            // Label boven de listview van naam veranderen
            lblEtenTxt.Text = "Lunch(Menu)";

            //opmerkingen tekstbox leegmaken
            txtOpmerkingBestelling.Clear();

            //Listview leegmaken
            LvEtenMenu.Items.Clear();

            //Vul de listview met middag menu.

            ChapooLogic.Menuitems_Service menuServMid = new ChapooLogic.Menuitems_Service();
            List<Menuitems> MenuMiddag = menuServMid.GetMenuMiddag();
            LvEtenMenu.View = View.Details;
            foreach (ChapooModel.Menuitems menuitems in MenuMiddag)
            {
                LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{menuitems.naam}", $"{menuitems.prijs}", $"{menuitems.type}" }));
            }
        }

        private void rBAvond_CheckedChanged(object sender, EventArgs e)
        {
            // Label boven de listview van naam veranderen
            lblEtenTxt.Text = "Avond(Menu)";

            //opmerkingen tekstbox leegmaken
            txtOpmerkingBestelling.Clear();

            //Listview leegmaken
            LvEtenMenu.Items.Clear();

            //Vul de listview met middag menu.

            ChapooLogic.Menuitems_Service menuServAvo = new ChapooLogic.Menuitems_Service();
            List<Menuitems> MenuAvond = menuServAvo.GetMenuAvond();
            LvEtenMenu.View = View.Details;
            foreach (ChapooModel.Menuitems menuitems in MenuAvond)
            {
                LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{menuitems.naam}", $"{menuitems.prijs}", $"{menuitems.type}" }));
            }
        }

        private void rBDranken_CheckedChanged(object sender, EventArgs e)
        {
            // Label boven de listview van naam veranderen
            lblEtenTxt.Text = "Dranken(Menu)";

            //opmerkingen tekstbox leegmaken
            txtOpmerkingBestelling.Clear();

            //Listview leegmaken
            LvEtenMenu.Items.Clear();

            //Vul de listview met drank menu.

            ChapooLogic.Menuitems_Service menuServDra = new ChapooLogic.Menuitems_Service();
            List<Menuitems> MenuDrank = menuServDra.GetMenuDrankItems();
            LvEtenMenu.View = View.Details;
            foreach (ChapooModel.Menuitems menuitems in MenuDrank)
            {
                LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{menuitems.naam}", $"{menuitems.prijs}", $"{menuitems.type}" }));
            }
        }

        private void MI_terug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void plaatsOrderBarBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

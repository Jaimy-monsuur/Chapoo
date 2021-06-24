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

        //Code voor de placeholder.

        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        // Order en tafelnummer ophalen, order_Service aanmaken en een user aanmaken
        public ChapooLogic.Order_Service Order_Service = new ChapooLogic.Order_Service();
        public ChapooLogic.Voorraad_Service Voorraad_Service = new ChapooLogic.Voorraad_Service(); 
        public int Tafelnummer;
        public int Ordernummer;
        public CurrentUser user;

        public Bestellingen(int Ordernummer, int tafelnummer)
        {
            InitializeComponent();
            //zorg er voor dat er geen border is
            this.ControlBox = false;
            this.Text = "";

            //haalt de tafel -ordernummers op en een user in de constructor
            this.Tafelnummer = tafelnummer;
            this.Ordernummer = Ordernummer;
            this.user = CurrentUser.Getlnstance();

            //laat het tafelnummer zien op de form.
            lblTafelNummerIn.Text = Tafelnummer.ToString();

            //Vullen van waardes in de combobox 'Aantal'.
            cb_Aantal.Items.Add('1');
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

            //Dit checked welke radio button er is geselcteerd bij het laden van de form. Dit zorgt ervoor dat niet het verkeerde menu wordt weergegeven.
            if (rBLunch.Checked)
            {
                //Vul de listview met middag menu.

               ChapooLogic.Menuitems_Service menuServMid = new ChapooLogic.Menuitems_Service();
                List<Menuitems> MenuMiddag = menuServMid.GetMenuMiddag();
                LvEtenMenu.View = View.Details;
                foreach (ChapooModel.Menuitems menuitems in MenuMiddag)
                {
                    LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{menuitems.itemNummer}", $"{menuitems.naam}", $"{menuitems.prijs}" }));
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
                    LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{menuitems.itemNummer}", $"{menuitems.naam}", $"{menuitems.prijs}" }));
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
                    LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{menuitems.itemNummer}", $"{menuitems.naam}", $"{menuitems.prijs}" }));
                }
            }

            if (this.Ordernummer == 0)
            {
                //Maakt een nieuwe order aan als deze er nog niet was.
                string personeelNummer = this.user.personeelsNummer.ToString();
                Order order = Order_Service.NewOrder(Tafelnummer, personeelNummer);
                this.Ordernummer = order.orderNummer;
            }

            //Zorgt voor een placeholder "Opmerking:" in de textbox opmerking.

            SendMessage(txtOpmerkingBestelling.Handle, EM_SETCUEBANNER, 0, "Opmerking:");

            //Stelt de klok in en laat zien welke user er is ingelogd.
            CurrentUser user = CurrentUser.Getlnstance();
            LBL_UserDataOr.Text = user.ToString();

            LBL_klokOr.Text = DateTime.Now.ToString(("HH:mm:ss"));

        }
        private void btn_Uitlog_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //uitlog
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        private bool IsInCollection(ListViewItem lvi)
        {
            bool contains = false;
            foreach (ListViewItem item in LvOrderDetails.Items)
            {
                
                for (int i = 0; i < lvi.SubItems.Count; i++)
                {
                    string sub1 = item.SubItems[i].Text;
                    string sub2 = lvi.SubItems[i].Text;
                    if (sub1 == sub2)
                    {
                        contains = true;
                    }
                }
            }
            return contains;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Checked of er een item is geselecteerd zoniet dan geeft hij een waarschuwing
            if (LvEtenMenu.SelectedItems.Count > 0)
                {
                    //listview geselecteerde items toevoegen aan de orderdetails
                    ListViewItem item = LvEtenMenu.SelectedItems[0];
                    Menuitems menuitem = new Menuitems()
                    {
                        itemNummer = int.Parse(item.SubItems[0].Text),
                        naam = item.SubItems[1].Text,
                        prijs = decimal.Parse(item.SubItems[2].Text),
                    };

                

                item = new ListViewItem(new string[] { $"{menuitem.itemNummer}", $"{menuitem.naam}" });

                //Als er een aantal geselcteerd is dan wordt de listview gevuld
                if (cb_Aantal.SelectedIndex > -1)
                    {
                       if(LvOrderDetails.Items.Count > 0)
                       {
                            if (IsInCollection(item) ==  true)
                            {
                                if (item.SubItems[0].Text == menuitem.itemNummer.ToString())
                                {
                                    //De opmerkingen en aantal aan de orderdetails toevoegen
                                    Orderitems opmerking = new Orderitems()
                                    {
                                        opmerking = txtOpmerkingBestelling.Text,
                                        aantal = int.Parse(cb_Aantal.Text)
                                    };

                                    foreach (ListViewItem items in LvOrderDetails.Items)
                                    {
                                        if (items.SubItems[0].Text == menuitem.itemNummer.ToString())
                                        {
                                            items.SubItems[3].Text = Convert.ToString(Convert.ToInt32(opmerking.aantal.ToString()) + Convert.ToInt32(items.SubItems[3].Text));
                                        }
                                    }
                                }
                           
                            }
                            else
                            {
                                //De opmerkingen en aantal aan de orderdetails toevoegen
                                Orderitems opmerking = new Orderitems()
                                {
                                    opmerking = txtOpmerkingBestelling.Text,
                                    aantal = int.Parse(cb_Aantal.Text)
                                };
                                LvOrderDetails.Items.Add(new ListViewItem(new string[] { $"{menuitem.itemNummer}", $"{menuitem.naam}", $"{opmerking.opmerking}", $"{opmerking.aantal}" }));
                            }
                       }
                    else
                    {
                        //De opmerkingen en aantal aan de orderdetails toevoegen
                        Orderitems opmerking = new Orderitems()
                        {
                            opmerking = txtOpmerkingBestelling.Text,
                            aantal = int.Parse(cb_Aantal.Text)
                        };
                        LvOrderDetails.Items.Add(new ListViewItem(new string[] { $"{menuitem.itemNummer}", $"{menuitem.naam}", $"{opmerking.opmerking}", $"{opmerking.aantal}" }));
                    }

                        //Cleared de errorbox zodat je niet denk dat het nogsteeds niet lukt.
                        lblErrorMenuBox.Text = "";
                    }
                    else
                    {
                        //Error voor als je geen aantal invuld 
                        lblErrorMenuBox.Text = "Selecteer eerst een aantal!";
                    }
                }
                else
                {
                    //Als er geen item geslecteerd is zal de knop disabled worden en krijgt de gebruiker een error.

                    lblErrorMenuBox.Text = "Klik eerst een item aan in de menulijst!";
                }

            btnDeleteItem.Enabled = true;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            //Checked of er een item is geselecteerd zoniet dan geeft hij een waarschuwing
                if (LvOrderDetails.SelectedItems.Count > 0)
                {
                    //Zorgt ervoor dat het geselecteerde item verwijderd wordt.
                    LvOrderDetails.Items.RemoveAt(LvOrderDetails.SelectedIndices[0]);
                    lblErrorBox.Text = "";
                }
                else
                {
                    //Als er geen item geslecteerd is zal de knop disabled worden en krijgt de gebruiker een error.
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
                LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{menuitems.itemNummer}", $"{menuitems.naam}", $"{menuitems.prijs}" }));
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
                LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{menuitems.itemNummer}", $"{menuitems.naam}", $"{menuitems.prijs}" }));
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
                LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{menuitems.itemNummer}", $"{menuitems.naam}", $"{menuitems.prijs}" }));
            }
        }

        private void MI_terug_Click(object sender, EventArgs e)
        {
            //Terug knop
            this.Close();
        }

        private void plaatsOrderBarBtn_Click(object sender, EventArgs e)
        {
            //voor elk orderitem in de listview
            foreach (ListViewItem item in LvOrderDetails.Items)
            {
                //Aanroepen service layer
                ChapooLogic.Orderitems_Service orderitems_Service = new ChapooLogic.Orderitems_Service();
                
                //Een orderitems aanmaken om deze te kunnen vullen met de ingevulde benodigde velden.
                Orderitems orderitems = new Orderitems()
                {                    
                    aantal = int.Parse(item.SubItems[3].Text),
                    opmerking = item.SubItems[2].Text,
                };

                //Een menuitems aanmaken om deze te kunnen vullen met de ingevulde benodigde velden.
                Menuitems menuitems = new Menuitems()
                {
                    itemNummer = int.Parse(item.SubItems[0].Text),
                };

                //Zorgt ervoor dat er onderscheid komt tussen de opmerkingen omdat we 2 queries gebruiken, 1 met opmerkingen en 1 met lege opmerkingen.
                if (orderitems.opmerking == null)
                {
                    orderitems.opmerking = "";
                }
                //aanroepen van de query om de waardes in de database te zetten.
                orderitems_Service.AddOrderitem(Ordernummer, menuitems.itemNummer, orderitems.aantal, orderitems.opmerking);
                Voorraad_Service.afschrijven(orderitems.aantal, menuitems.itemNummer);


                //De Listvview leegmaken en een melding geven dat het plaatsen van de order gelukt is.
                LvOrderDetails.Clear();

                lblErrorBox.ForeColor = Color.Green;
                lblErrorBox.Text = "Gelukt de order is opgeslagen!";
            }
        }

        private void btn_Clear_List_Click(object sender, EventArgs e)
        {
            LvOrderDetails.Items.Clear();
        }

        private void BTN_plus_Click(object sender, EventArgs e)
        {
            if (LvOrderDetails.SelectedItems.Count != 0)
            {
                int value = int.Parse(LvOrderDetails.SelectedItems[0].SubItems[3].Text);
                LvOrderDetails.SelectedItems[0].SubItems[3].Text = (value  + 1).ToString();
            }
            else
            {
                lblErrorBox.Text = "Klik eerst een item aan in de orderlijst!";
            }
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            if (LvOrderDetails.SelectedItems.Count != 0)
            {
                int value = int.Parse(LvOrderDetails.SelectedItems[0].SubItems[3].Text);
                if (value - 1 > 0)
                {
                    LvOrderDetails.SelectedItems[0].SubItems[3].Text = (value - 1).ToString();
                }
                else
                {
                    lblErrorBox.Text = "Het is niet mogelijk om 0 van een item te bestellen.";
                }
            }
            else
            {
                lblErrorBox.Text = "Klik eerst een item aan in de orderlijst!";
            }
        }
    }
}

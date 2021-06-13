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
        public ChapooLogic.Order_Service Order_Service = new ChapooLogic.Order_Service();
        public int Tafelnummer;
        public int Ordernummer;
        public CurrentUser user;

        public Bestellingen(int Ordernummer, int tafelnummer)
        {
            InitializeComponent();
            this.Tafelnummer = tafelnummer;
            this.Ordernummer = Ordernummer;
            this.user = CurrentUser.Getlnstance();
            lblTafelNummerIn.Text = Tafelnummer.ToString();

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
                // Maakt hij gewoon een nieuwe aan.
                string personeelNummer = this.user.personeelsNummer.ToString();
                Order order = Order_Service.NewOrder(Tafelnummer, personeelNummer);
                this.Ordernummer = order.orderNummer;
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
                    int CbAantal;
                    CbAantal = cb_Aantal.SelectedIndex;

                    //listview geselecteerde items toevoegen aan de orderdetails
                    ListViewItem item = LvEtenMenu.SelectedItems[0];
                    Menuitems menuitem = new Menuitems()
                    {
                        itemNummer = int.Parse(item.SubItems[0].Text),
                        naam = item.SubItems[1].Text,
                        prijs = decimal.Parse(item.SubItems[2].Text),
                    };

                    

                    if (CbAantal > -1 && CbAantal <= 14)
                    {
                        opmerking.aantal = CbAantal + 1;

                        LvOrderDetails.Items.Add(new ListViewItem(new string[] { $"{menuitem.itemNummer}", $"{menuitem.naam}", $"{opmerking.opmerking}", $"{opmerking.aantal}" }));

                        lblErrorMenuBox.Text = "";
                    }
                    else
                    {
                    lblErrorMenuBox.Text = "Selecteer eerst een aantal!";
                    }

                
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
            this.Close();
        }

        private void plaatsOrderBarBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LvOrderDetails.Items)
            {
                ChapooLogic.Orderitems_Service orderitems_Service = new ChapooLogic.Orderitems_Service();
                

                Orderitems orderitems = new Orderitems()
                {                    
                    aantal = int.Parse(item.SubItems[3].Text),
                    opmerking = item.SubItems[2].Text,
                };

                Menuitems menuitems = new Menuitems()
                {
                    itemNummer = int.Parse(item.SubItems[0].Text),
                };


                if (orderitems.opmerking == null)
                {
                    orderitems.opmerking = "";
                }

                orderitems_Service.AddOrderitem(Ordernummer, menuitems.itemNummer, orderitems.aantal, orderitems.opmerking);
                LvOrderDetails.Clear();

                lblErrorBox.ForeColor = Color.Green;
                lblErrorBox.Text = "Gelukt de order is opgeslagen!";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooModel;
using ChapooLogic;

namespace ChapooUI
{
    public partial class KeukenBarSysteemForm : Form
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

        public KeukenBarSysteemForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";

            // Haal de current user op
            CurrentUser user = CurrentUser.Getlnstance();

            // Zet de current user en klok tijd in de labels
            LBL_userdata.Text = user.ToString();
            T_klok.Start();
            TUpdateTimer.Start();
        }

        // Knop type die op hoofdpagina in wordt gedrukt
        private string knopType = "";

        // Alle service references die nodig zijn
        private Order_Service orderService = new Order_Service();
        private Orderitems_Service orderitemService = new Orderitems_Service();

        public void SetKnopType(string knopType)// Krijg het type knop waar in het home menu is aangeklikt doorgestuurd
        {
            this.knopType = knopType;
        }          

        public void showListView()
        {
            List<Order> orderList = orderService.GetOrders();
            // Maak grid
            listViewKeukenBarOpenstaand.Clear();
            listViewKeukenBarOpenstaand.View = View.Details;
            listViewKeukenBarOpenstaand.GridLines = true;
            listViewKeukenBarOpenstaand.FullRowSelect = true;

            // Voeg column header toe
            listViewKeukenBarOpenstaand.Columns.Add("Ordernr:", 60);
            listViewKeukenBarOpenstaand.Columns.Add("Itemnummer HIDDEN:", 0);
            listViewKeukenBarOpenstaand.Columns.Add("Besteltijd:", 100);
            listViewKeukenBarOpenstaand.Columns.Add("Gerecht:", 300);
            listViewKeukenBarOpenstaand.Columns.Add("Aantal:", 60);

            // Maak grid opmerkingen
            listViewKeukenBarOpmerkingen.Clear();
            listViewKeukenBarOpmerkingen.View = View.Details;
            listViewKeukenBarOpmerkingen.GridLines = true;
            listViewKeukenBarOpmerkingen.FullRowSelect = true;
            // Voeg column header toe opmerkingen
            listViewKeukenBarOpmerkingen.Columns.Add("Ordernr:", 50);
            listViewKeukenBarOpmerkingen.Columns.Add("Gerecht:", 60);
            listViewKeukenBarOpmerkingen.Columns.Add("Opmerkingen:", 250);

            // Maak een array voor de openstaande gerechten en opmerkingen listview om het erin te zetten
            string[] item = new string[5];
            string[] itemopmerkingen = new string[3];

            if (knopType == "keuken")
            {                                                       
                foreach (Order order in orderList)
                {
                    foreach (Orderitems orderitem in order.orderItemList)
                    {
                        if (orderitem.menuItem.type == "Lunch" || orderitem.menuItem.type == "Avond")
                        {
                            // Zet de items van de openstaande gerechten in de listview
                            item[0] = orderitem.orderNummer.ToString();
                            item[1] = orderitem.menuItem.itemNummer.ToString();
                            item[2] = orderitem.time.ToString("HH:mm");
                            item[3] = orderitem.menuItem.naam;
                            item[4] = orderitem.aantal.ToString();
                            ListViewItem li = new ListViewItem(item);
                            listViewKeukenBarOpenstaand.Items.Add(li);

                            // Zet de opmerkingen in de opmerkingen listview als het niet null of leeg is
                            if (orderitem.opmerking != null && orderitem.opmerking != "")
                            {
                                itemopmerkingen[0] = orderitem.orderNummer.ToString();
                                itemopmerkingen[1] = orderitem.menuItem.naam;
                                itemopmerkingen[2] = orderitem.opmerking;
                                ListViewItem li2 = new ListViewItem(itemopmerkingen);
                                listViewKeukenBarOpmerkingen.Items.Add(li2);
                            }                            
                        }
                    }
                }
            }
            else if (knopType == "bar")
            {              
                foreach (Order order in orderList)
                {
                    foreach (Orderitems orderitem in order.orderItemList)
                    {
                        if (orderitem.menuItem.type == "Drank")
                        {
                            // Zet de items van de openstaande gerechten in de listview
                            item[0] = orderitem.orderNummer.ToString();
                            item[1] = orderitem.menuItem.itemNummer.ToString();
                            item[2] = orderitem.time.ToString("HH:mm");
                            item[3] = orderitem.menuItem.naam;
                            item[4] = orderitem.aantal.ToString();
                            ListViewItem li = new ListViewItem(item);
                            listViewKeukenBarOpenstaand.Items.Add(li);

                            // Zet de opmerkingen in de opmerkingen listview als het niet null of leeg is
                            if (orderitem.opmerking != null && orderitem.opmerking != "")
                            {
                                itemopmerkingen[0] = orderitem.orderNummer.ToString();
                                itemopmerkingen[1] = orderitem.menuItem.naam;
                                itemopmerkingen[2] = orderitem.opmerking;                               
                                ListViewItem li2 = new ListViewItem(itemopmerkingen);
                                listViewKeukenBarOpmerkingen.Items.Add(li2);
                            }
                        }
                    }
                }
            }
        }

        private void gereedKeukenBarBtn_Click(object sender, EventArgs e)
        {      
            if (listViewKeukenBarOpenstaand.SelectedItems.Count != 0)
            {
                int orderNummer = int.Parse(listViewKeukenBarOpenstaand.SelectedItems[0].SubItems[0].Text);
                int itemNummer = int.Parse(listViewKeukenBarOpenstaand.SelectedItems[0].SubItems[1].Text);
                orderitemService.MeldGereed(orderNummer, itemNummer);
                showListView();
            }
        }

        private void TerugtoolStripMenuItem_Click(object sender, EventArgs e)// Ga terug naar vorige scherm
        {
            this.Close();
        }

        private void UitloggenToolStripMenuItem_Click(object sender, EventArgs e)// Knop om uit te loggen en naar inlog scherm te gaan
        {
            ConfirmLogout confirm = new ConfirmLogout();
            confirm.ShowDialog();
        }

        private void BTN_Update_Click(object sender, EventArgs e)// Knop om te updaten wanneer je dat wilt
        {
            showListView();
        }

        private void T_klok_Tick(object sender, EventArgs e)// Ren timer voor de klok. elke seconde
        {
            LBL_klok.Text = DateTime.Now.ToString(("HH:mm:ss"));
        }

        private void TUpdateTimer_Tick(object sender, EventArgs e)// Update de listview elke minuut
        {
            showListView();
        }
    }
}

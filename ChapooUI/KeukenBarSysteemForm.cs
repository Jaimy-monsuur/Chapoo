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
        }

        // Alle service references die nodig zijn
        Order_Service orderService = new Order_Service();
        Orderitems_Service orderitemService = new Orderitems_Service();
        Menuitems_Service menuitemService = new Menuitems_Service();

        public void showListView(string listName) // Kan makkelijker met current user
        {
            List<Order> orderList = orderService.GetOrders();
            List<Orderitems> orderitems = orderitemService.Db_Get_All_Orderitems();

            foreach (Order order in orderList)
            {
                foreach (Orderitems orderitem in orderitems)
                {
                    if (orderitem.orderNummer == order.orderNummer)
                    {
                        // Sorteert de orderitems per order
                        orderitems.Add(orderitem);
                    }
                }
            }

            List<Menuitems> menuitems = menuitemService.GetMenuitems();

            if (listName == "keuken")
            {                                              
                // Hide bar order knop
                maakOrderBarBtn.Hide();

                // Maak grid
                listViewKeukenBarOpenstaand.Clear();
                listViewKeukenBarOpenstaand.View = View.Details;
                listViewKeukenBarOpenstaand.GridLines = true;
                listViewKeukenBarOpenstaand.FullRowSelect = true;

                // Voeg column header toe
                listViewKeukenBarOpenstaand.Columns.Add("Ordernr:", 60);
                listViewKeukenBarOpenstaand.Columns.Add("itemnummer HIDDEN:", 0);
                listViewKeukenBarOpenstaand.Columns.Add("Gerecht:", 300);
                listViewKeukenBarOpenstaand.Columns.Add("Totaal prijs:", 60);
                listViewKeukenBarOpenstaand.Columns.Add("Aantal:", 60);

                // Maak grid opmerkingen
                listViewKeukenBarOpmerkingen.Clear();
                listViewKeukenBarOpmerkingen.View = View.Details;
                listViewKeukenBarOpmerkingen.GridLines = true;
                listViewKeukenBarOpmerkingen.FullRowSelect = true;
                // Voeg column header toe opmerkingen
                listViewKeukenBarOpmerkingen.Columns.Add("Ordernr:", 50);
                listViewKeukenBarOpmerkingen.Columns.Add("Opmerkingen:", 250);

                string[] item = new string[5];
                string[] itemopmerkingen = new string[2];
                foreach (Order order in orderList)
                {
                    foreach (Orderitems orderitem in orderitems)
                    {
                        foreach (Menuitems menuitem in menuitems)
                        {
                            if (orderitem.itemnummer == menuitem.itemNummer && (menuitem.type == "Avond" || menuitem.type == "Middag"))
                            {
                                // Zet de items, in dit geval de naam en prijs van de openstaande gerechten in de listview
                                item[0] = order.orderNummer.ToString();
                                item[1] = order.tafelNummer.ToString();
                                item[2] = menuitem.naam;
                                item[3] = menuitem.prijs.ToString();
                                item[4] = orderitem.aantal.ToString();
                                ListViewItem li = new ListViewItem(item);
                                listViewKeukenBarOpenstaand.Items.Add(li);

                                // Zet de opermkingen in de opmerkingen listview
                                itemopmerkingen[0] = order.orderNummer.ToString();
                                itemopmerkingen[1] = order.opmerking;
                                ListViewItem li2 = new ListViewItem(itemopmerkingen);
                                listViewKeukenBarOpmerkingen.Items.Add(li2);
                            }
                        }
                    }
                }
            }
            else if (listName == "bar")
            {              

                // Maak grid
                listViewKeukenBarOpenstaand.Clear();
                listViewKeukenBarOpenstaand.View = View.Details;
                listViewKeukenBarOpenstaand.GridLines = true;
                listViewKeukenBarOpenstaand.FullRowSelect = true;
                // Voeg column header toe
                listViewKeukenBarOpenstaand.Columns.Add("Ordernr:", 60);
                listViewKeukenBarOpenstaand.Columns.Add("Tafelnr:", 60);
                listViewKeukenBarOpenstaand.Columns.Add("Drank:", 300);
                listViewKeukenBarOpenstaand.Columns.Add("Prijs:", 60);
                listViewKeukenBarOpenstaand.Columns.Add("Aantal:", 60);

                // Maak grid opmerkingen
                listViewKeukenBarOpmerkingen.Clear();
                listViewKeukenBarOpmerkingen.View = View.Details;
                listViewKeukenBarOpmerkingen.GridLines = true;
                listViewKeukenBarOpmerkingen.FullRowSelect = true;
                // Voeg column header toe opmerkingen
                listViewKeukenBarOpmerkingen.Columns.Add("Ordernr:", 50);
                listViewKeukenBarOpmerkingen.Columns.Add("Opmerkingen:", 250);

                string[] item = new string[5];
                string[] itemopmerkingen = new string[2];
                foreach (Order order in orderList)
                {
                    foreach (Orderitems orderitem in orderitems)
                    {
                        foreach (Menuitems menuitem in menuitems)
                        {
                            if (orderitem.itemnummer == menuitem.itemNummer && (menuitem.type == "Drank"))
                            {
                                // Zet de items, in dit geval de naam en prijs van de openstaande gerechten in de listview
                                item[0] = order.orderNummer.ToString();
                                item[1] = order.tafelNummer.ToString();
                                item[2] = menuitem.naam;
                                item[3] = menuitem.prijs.ToString();
                                item[4] = orderitem.aantal.ToString();
                                ListViewItem li = new ListViewItem(item);
                                listViewKeukenBarOpenstaand.Items.Add(li);

                                // Zet de opermkingen in de opmerkingen listview
                                itemopmerkingen[0] = order.orderNummer.ToString();
                                itemopmerkingen[1] = order.opmerking;
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
                int orderNummer = int.Parse(listViewKeukenBarOpenstaand.SelectedItems[0].Text);
                orderitemService.MeldGereed(orderNummer);
            }
        }

        private void annulerenKeukenBarBtn_Click(object sender, EventArgs e)
        {
            if (listViewKeukenBarOpenstaand.SelectedItems.Count != 0)
            {
                int orderNummer = int.Parse(listViewKeukenBarOpenstaand.SelectedItems[0].Text);
                ConfirmOngereedMelden confirm = new ConfirmOngereedMelden();
                confirm.ShowDialog();
                if (confirm.confirmOngereed() == true)
                {
                    orderitemService.MeldOngereed(orderNummer);
                }          
            }
        }

        private void terugKeukenBarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maakOrderBarBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BarBestelMenu barBestelMenu = new BarBestelMenu();
            barBestelMenu.ShowDialog();
            this.Show();
        }

        private void TerugtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirm = new ConfirmLogout();
            confirm.ShowDialog();
        }
    }
}

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

        public void showListView(string listName)
        {
            if (listName == "keuken")
            {
                ChapooLogic.Order_Service orderService = new ChapooLogic.Order_Service();
                List<Order> orderList = orderService.GetOrders();

                // Hide order knop
                maakOrderBarBtn.Hide();

                // Maak grid
                listViewKeukenBarOpenstaand.Clear();
                listViewKeukenBarOpenstaand.View = View.Details;
                listViewKeukenBarOpenstaand.GridLines = true;
                listViewKeukenBarOpenstaand.FullRowSelect = true;

                // Voeg column header toe
                listViewKeukenBarOpenstaand.Columns.Add("Tafelnr:", 60);
                listViewKeukenBarOpenstaand.Columns.Add("Ordernr:", 60);
                listViewKeukenBarOpenstaand.Columns.Add("Gerecht:", 300);
                listViewKeukenBarOpenstaand.Columns.Add("Prijs:", 60);
                listViewKeukenBarOpenstaand.Columns.Add("Aantal:", 60);

                string[] item = new string[5];
                foreach (ChapooModel.Order order in orderList)
                {
                    if (order.type == "Avond" || order.type == "Middag")
                    {
                        // Zet de items, in dit geval de naam en prijs van de openstaande gerechten in de listview
                        item[0] = order.tafelNummer.ToString();
                        item[1] = order.orderNummer.ToString();
                        item[2] = order.itemNaam;
                        item[3] = order.itemPrijs.ToString();
                        item[4] = order.aantal.ToString();
                        ListViewItem li = new ListViewItem(item);
                        listViewKeukenBarOpenstaand.Items.Add(li);
                    }
                }

                // Maak grid
                listViewKeukenBarOpmerkingen.Clear();
                listViewKeukenBarOpmerkingen.View = View.Details;
                listViewKeukenBarOpmerkingen.GridLines = true;
                listViewKeukenBarOpmerkingen.FullRowSelect = true;
                // Voeg column header toe
                listViewKeukenBarOpmerkingen.Columns.Add("Ordernr:", 50);
                listViewKeukenBarOpmerkingen.Columns.Add("Opmerkingen:", 250);

                string[] item2 = new string[2];
                foreach (ChapooModel.Order order in orderList)
                {
                    if (order.type == "Avond" || order.type == "Middag")
                    {
                        // Zet de opermkingen in de opmerkingen listview
                        item2[0] = order.orderNummer.ToString();
                        item2[1] = order.opmerking;
                        ListViewItem li = new ListViewItem(item2);
                        listViewKeukenBarOpmerkingen.Items.Add(li);
                    }                        
                }
            }
            else if (listName == "bar")
            {
                ChapooLogic.Order_Service orderService = new ChapooLogic.Order_Service();
                List<Order> orderList = orderService.GetOrders();

                // Maak grid
                listViewKeukenBarOpenstaand.Clear();
                listViewKeukenBarOpenstaand.View = View.Details;
                listViewKeukenBarOpenstaand.GridLines = true;
                listViewKeukenBarOpenstaand.FullRowSelect = true;
                // Voeg column header toe
                listViewKeukenBarOpenstaand.Columns.Add("Tafelnr:", 60);
                listViewKeukenBarOpenstaand.Columns.Add("Ordernr:", 60);
                listViewKeukenBarOpenstaand.Columns.Add("Drank:", 300);
                listViewKeukenBarOpenstaand.Columns.Add("Prijs:", 60);
                listViewKeukenBarOpenstaand.Columns.Add("Aantal:", 60);

                string[] item = new string[5];
                foreach (ChapooModel.Order order in orderList)
                {
                    if (order.type == "Drank")
                    {
                        // Zet de items, in dit geval de naam en prijs van de openstaande gerechten in de listview
                        item[0] = order.tafelNummer.ToString();
                        item[1] = order.orderNummer.ToString();
                        item[2] = order.itemNaam;
                        item[3] = order.itemPrijs.ToString();
                        item[4] = order.aantal.ToString();
                        ListViewItem li = new ListViewItem(item);
                        listViewKeukenBarOpenstaand.Items.Add(li);
                    }
                }

                // Maak grid
                listViewKeukenBarOpmerkingen.Clear();
                listViewKeukenBarOpmerkingen.View = View.Details;
                listViewKeukenBarOpmerkingen.GridLines = true;
                listViewKeukenBarOpmerkingen.FullRowSelect = true;
                // Voeg column header toe
                listViewKeukenBarOpmerkingen.Columns.Add("Ordernr:", 50);
                listViewKeukenBarOpmerkingen.Columns.Add("Opmerkingen:", 250);

                string[] item2 = new string[2];
                foreach (ChapooModel.Order order in orderList)
                {
                    if (order.type == "Drank")
                    {
                        // Zet de opermkingen in de opmerkingen listview
                        item2[0] = order.orderNummer.ToString();
                        item2[1] = order.opmerking;
                        ListViewItem li = new ListViewItem(item2);
                        listViewKeukenBarOpmerkingen.Items.Add(li);
                    }                      
                }
            }
        }

        private void gereedKeukenBarBtn_Click(object sender, EventArgs e)
        {

        }

        private void annulerenKeukenBarBtn_Click(object sender, EventArgs e)
        {

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

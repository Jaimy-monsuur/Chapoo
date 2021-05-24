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
        public KeukenBarSysteemForm()
        {
            InitializeComponent();
        }

        private void KeukenSysteemForm_Load(object sender, EventArgs e)
        {
            showListView("keuken");
        }

        private void showListView(string listName)
        {
            if (listName == "keuken")
            {
                ChapooLogic.Order_Service orderService = new ChapooLogic.Order_Service();
                List<Order> orderList = orderService.GetOrders();

                // Maak grid
                listViewKeukenBarOpenstaand.Clear();
                listViewKeukenBarOpenstaand.View = View.Details;
                listViewKeukenBarOpenstaand.GridLines = true;
                listViewKeukenBarOpenstaand.FullRowSelect = true;
                // Voeg column header toe
                listViewKeukenBarOpenstaand.Columns.Add("Gerechtnaam:", 320);
                listViewKeukenBarOpenstaand.Columns.Add("Prijs:", 61);

                string[] item = new string[2];
                foreach (ChapooModel.Order order in orderList)
                {
                    if (order.type == "Avond" || order.type == "Middag")
                    {
                        // Zet de items, in dit geval de naam en prijs van de openstaande gerechten in de listview
                        item[0] = order.itemNaam;
                        item[1] = order.itemPrijs.ToString();
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
                listViewKeukenBarOpmerkingen.Columns.Add("Opmerkingen:", 313);

                string[] item2 = new string[1];
                foreach (ChapooModel.Order order in orderList)
                {
                    // Zet de opermkingen in de opmerkingen listview
                    item2[0] = order.opmerking;
                    ListViewItem li = new ListViewItem(item2);
                    listViewKeukenBarOpmerkingen.Items.Add(li);
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
                listViewKeukenBarOpenstaand.Columns.Add("Drank:", 320);
                listViewKeukenBarOpenstaand.Columns.Add("Prijs:", 61);

                string[] item = new string[2];
                foreach (ChapooModel.Order order in orderList)
                {
                    if (order.type == "Drank")
                    {
                        // Zet de items, in dit geval de naam en prijs van de openstaande gerechten in de listview
                        item[0] = order.itemNaam;
                        item[1] = order.itemPrijs.ToString();
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
                listViewKeukenBarOpmerkingen.Columns.Add("Opmerkingen:", 313);

                string[] item2 = new string[1];
                foreach (ChapooModel.Order order in orderList)
                {
                    // Zet de opermkingen in de opmerkingen listview
                    item2[0] = order.opmerking;
                    ListViewItem li = new ListViewItem(item2);
                    listViewKeukenBarOpmerkingen.Items.Add(li);
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
    }
}

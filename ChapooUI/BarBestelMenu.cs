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
    public partial class BarBestelMenu : Form
    {
        public BarBestelMenu()
        {
            InitializeComponent();
        }

        private void BarBestelMenu_Load(object sender, EventArgs e)
        {
            showListView();
        }

        private void showListView()
        {
            
            ChapooLogic.Order_Service orderService = new ChapooLogic.Order_Service();
            List<Order> orderList = orderService.GetOrders();

            // Maak grid
            drankenKaartListView.Clear();
            drankenKaartListView.View = View.Details;
            drankenKaartListView.GridLines = true;
            drankenKaartListView.FullRowSelect = true;
            // Voeg column header toe
            drankenKaartListView.Columns.Add("Drank:", 320);
            drankenKaartListView.Columns.Add("Prijs:", 61);

            string[] item = new string[2];
            foreach (ChapooModel.Order order in orderList)
            {
                if (order.type == "Drank")
                {
                    // Zet de items, in dit geval de naam en prijs van de openstaande gerechten in de listview
                    item[0] = order.itemNaam;
                    item[1] = order.itemPrijs.ToString();
                    ListViewItem li = new ListViewItem(item);
                    drankenKaartListView.Items.Add(li);
                }
            }
        }

        private void plaatsOrderBarBtn_Click(object sender, EventArgs e)
        {
            
        }      
    }
}

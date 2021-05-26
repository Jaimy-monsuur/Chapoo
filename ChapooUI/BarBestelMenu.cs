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

        public BarBestelMenu()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
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

        private void TerugtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirm = new ConfirmLogout();
            confirm.ShowDialog();
        }

        private void plusOrderBarBtn_Click(object sender, EventArgs e)
        {

        }

        private void minusOrderBarBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

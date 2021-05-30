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
    public partial class BarBestelMenu : Form
    {
        //maakt form movable vanaf elk punt.
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        Order_Service orderService = new Order_Service(); // Order service voor het toevoegen van bestellingen
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

        private List<string> drankenOrder = new List<string>(); // De lijst waar alle itemnummer staan voor de order
        private int tafelnummer;

        private void BarBestelMenu_Load(object sender, EventArgs e)
        {
            showListView();
        }

        private void showListView()
        {
            Voorraad_Service voorraadService = new Voorraad_Service();
            List <Voorraad> voorraadList = voorraadService.GetVoorraad();

            // Maak grid
            drankenKaartListView.Clear();
            drankenKaartListView.View = View.Details;
            drankenKaartListView.GridLines = true;
            drankenKaartListView.FullRowSelect = true;
            // Voeg column header toe
            drankenKaartListView.Columns.Add("Drank:", 255);
            drankenKaartListView.Columns.Add("Itemnr:", 60);            
            drankenKaartListView.Columns.Add("Prijs:", 60);
            drankenKaartListView.Columns.Add("Aantal:", 60);

            string[] item = new string[4];
            foreach (Voorraad voorraad in voorraadList)
            {
                if (voorraad.itemType == "Drank")
                {
                    // Zet de items, in dit geval de naam en prijs van de openstaande gerechten in de listview
                    item[0] = voorraad.itemNaam;
                    item[1] = voorraad.itemNummer.ToString();                   
                    item[2] = voorraad.itemPrijs.ToString();
                    item[3] = voorraad.voorraadAantal.ToString();
                    ListViewItem li = new ListViewItem(item);
                    drankenKaartListView.Items.Add(li);
                }
            }

            // Maak grid
            orderDrankenListView.Clear();
            orderDrankenListView.View = View.Details;
            orderDrankenListView.GridLines = true;
            orderDrankenListView.FullRowSelect = true;
            // Voeg column header toe
            orderDrankenListView.Columns.Add("Drank:", 300);

            string[] item2 = new string[1];
            foreach (String drankNaam in drankenOrder)
            {
                // Zet de items, in dit geval de toegevoegde drankenorder items toe aan de listview
                item2[0] = drankNaam;
                ListViewItem li = new ListViewItem(item2);
                orderDrankenListView.Items.Add(li);
            }
        }

        

        private void plaatsOrderBarBtn_Click(object sender, EventArgs e)
        {
           /* Order order = new Order()
            {
                tafelNummer = tafelnummer,
                itemNaam = drankenOrder[0],
                opmerking = opmerkingBox.Text,
                personeelNummer = 501
            };

            int ordernummer = orderService.NewOrder(order);

            foreach (string itemnaam in drankenOrder)
            {
                order = new Order()
                {
                    orderNummer = ordernummer,
                    tafelNummer = tafelnummer,
                    itemNaam = itemnaam,
                    opmerking = opmerkingBox.Text,
                    personeelNummer = 501
                };

                orderService.AddDrinkOrderitem(order);
            }        

            
            orderDrankenListView.Clear();            
            drankenOrder = new List<string>();
            showListView();*/
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
            if (drankenKaartListView.SelectedItems.Count != 0)
            {
                drankenOrder.Add(drankenKaartListView.SelectedItems[0].Text);        
            }
            showListView();
        }

        private void minusOrderBarBtn_Click(object sender, EventArgs e)
        {
            if (orderDrankenListView.SelectedItems.Count != 0)
            {
                drankenOrder.Remove(orderDrankenListView.SelectedItems[0].Text);
            }
            showListView();
        }

        private void selectTafelBtn_Click(object sender, EventArgs e)
        {
            SelectTableBar selectTable = new SelectTableBar();
            tafelnummer = selectTable.tafelNummer;
        }
    }
}

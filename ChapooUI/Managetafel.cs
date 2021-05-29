﻿using System;
using ChapooUI;
using ChapooLogic;
using ChapooModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
    public partial class Managetafel : Form
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
        public Tafel_Service Tafel_Service = new Tafel_Service();
        public Order_Service Order_Service = new Order_Service();
        public int Tafelnummer { get; set; }
        public string Status { get; set; }
        public Managetafel(int tafelnummer, string status)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";

            //tafel gegevens
            this.Tafelnummer = tafelnummer;
            this.Status = status;
            FormSetings();
        }

        public void FormSetings()
        {
            LBL_tafelnummer.Text = "Tafelnummer: " + Tafelnummer.ToString();
            LBL_Tafelstatus.Text = "Tafel status: " + Status;
            if (Status == "bezet")
            {
                LBL_Managetafel.Text = "Tafel is momenteel bezet";
                BTN_Eddit.Text = "Tafel vrij maken";
                BTN_Eddit.BackColor = Color.LightCoral;

                LBL_aantalmensen.Hide();
                CB_Aantalmensen.Hide();
                GetOrders();
            }
            else if (Status == "gereserveerd")
            {
                LBL_Managetafel.Text = "Tafel is gereserveerd";
                BTN_Eddit.Text = "Toewijzen";


                GBX_ViewOrders.Hide();
            }
            else
            {
                LBL_Managetafel.Text = "Tafel Toewijzen aan klant";
                BTN_Eddit.Text = "Toewijzen";
                GBX_ViewOrders.Hide();
            }
            CB_Aantalmensen.Items.Add("1");
            CB_Aantalmensen.Items.Add("2");
            CB_Aantalmensen.Items.Add("3");
            CB_Aantalmensen.Items.Add("4");
        }

        private void UitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        private void TerugtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Eddit_Click_1(object sender, EventArgs e)
        {
            if (Status == "bezet")
            {
                Tafel_Service.ClearTafel(Tafelnummer);
            }
            else if (Status == "vrij" && CB_Aantalmensen.Text != "" || Status == "gereserveerd" && CB_Aantalmensen.Text != "")
            {
                Tafel_Service.AlterBezetting(Tafelnummer, int.Parse(CB_Aantalmensen.Text));
            }
            Status = "bezet";
            this.Close();
        }

        public void GetOrders()
        {
            List<Order> orderList = Order_Service.Db_Get_All_Orders_FORTable(Tafelnummer);

            // Maak grid
            LF_Orders.Clear();
            LF_Orders.View = View.Details;
            LF_Orders.GridLines = true;
            LF_Orders.FullRowSelect = true;

            // Voeg column header toe
            LF_Orders.Columns.Add("Ordernummer:", 100);
            LF_Orders.Columns.Add("hidden itemnummer:", 0);
            LF_Orders.Columns.Add("Menu item:", 200);
            LF_Orders.Columns.Add("prijs:", 100);
            LF_Orders.Columns.Add("Aantal:", 70);
            LF_Orders.Columns.Add("Bediende:", 100);


            string[] item = new string[6];
            foreach (ChapooModel.Order order in orderList)
            {
                // Zet de items, in dit geval de naam en prijs van de openstaande gerechten in de listview
                item[0] = order.orderNummer.ToString();
                item[1] = order.itemnummer.ToString();
                item[2] = order.itemNaam;
                item[3] = order.itemPrijs.ToString();
                item[4] = order.aantal.ToString();
                item[5] = order.personeelNummer.ToString();

                ListViewItem li = new ListViewItem(item);
                LF_Orders.Items.Add(li);
            }


        }

        private void BTN_ordertoevoegen_Click(object sender, EventArgs e)
        {
            this.Close();
            Bestellingen bestellingen = new Bestellingen();
            bestellingen.ShowDialog();
            this.Show();
        }

        private void BTN_Delete_reservation_Click(object sender, EventArgs e)
        {
            if (LF_Orders.SelectedItems.Count != 0)
            {
                int ordernummer = int.Parse(LF_Orders.SelectedItems[0].SubItems[0].Text);
                int itemnummer = int.Parse(LF_Orders.SelectedItems[0].SubItems[1].Text);
                Order_Service.DeleteOrderitem(ordernummer, itemnummer);
            }
        }
    }
}

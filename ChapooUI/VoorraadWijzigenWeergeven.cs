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
    public partial class VoorraadWijzigenWeergeven : Form
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

        public VoorraadWijzigenWeergeven()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";

            ChapooLogic.Voorraad_Service voorraadService = new ChapooLogic.Voorraad_Service();
            List<Voorraad> voorraadItems = voorraadService.GetVoorraad();

            // Maak grid
            listViewVoorraad.Clear();
            listViewVoorraad.View = View.Details;
            listViewVoorraad.GridLines = true;
            listViewVoorraad.FullRowSelect = true;
            // Voeg column header toe
            listViewVoorraad.Columns.Add("Itemnr:", 50);
            listViewVoorraad.Columns.Add("Itemnaam:", 650);
            listViewVoorraad.Columns.Add("Aantal:", 50);

            string[] item = new string[3];
            foreach (Voorraad voorraad in voorraadItems)
            {
                // Zet de items, in dit geval de naam en prijs van de openstaande gerechten in de listview
                item[0] = voorraad.itemNummer.ToString();
                item[1] = voorraad.itemNaam;
                item[2] = voorraad.voorraadAantal.ToString();
                ListViewItem li = new ListViewItem(item);
                listViewVoorraad.Items.Add(li);

            }
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

        private void wijzigVoorraadBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

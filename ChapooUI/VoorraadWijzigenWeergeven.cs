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

        private Voorraad_Service voorraadService = new Voorraad_Service(); // Voorraad service voor het aanpassen van de voorraad

        public VoorraadWijzigenWeergeven()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";

            showListView();
        }

        private void showListView()
        {
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
            // Haalt de textbox leeg als button wordt ingedrukt, en haalt de eventuele error weg         
            errorAantalLbl.Text = "";

            // Haalt de itemnummer en nieuwe aantal uit de form en stuurt ze naar de Voorraad_Service
            if (listViewVoorraad.SelectedItems.Count != 0 && nieuwAantalBox.Text != "" && int.Parse(nieuwAantalBox.Text) < 5000)
            {
                int itemNummer = int.Parse(listViewVoorraad.SelectedItems[0].Text);
                int nieuwAantal = int.Parse(nieuwAantalBox.Text);
                voorraadService.ChangeVoorraad(itemNummer, nieuwAantal);
            }
            else if (nieuwAantalBox.Text == "")
            {
                errorAantalLbl.Text = "Voer een nieuw aantal in!";
            }
            else if (listViewVoorraad.SelectedItems.Count == 0)
            {
                errorAantalLbl.Text = "Selecteer een voorraad item!";
            }
            else if (int.Parse(nieuwAantalBox.Text) > 5000)
            {
                errorAantalLbl.Text = "Voer een kleiner nieuw aantal in! (Onder 5000)";
            }

            // Refresh de pagina
            nieuwAantalBox.Clear();
            showListView();            
        }

        private void nieuwAantalBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}

using ChapooLogic;
using ChapooModel;
using System;
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
    public partial class MenuitemToevoegen : Form
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

        //Menuitems een voorraad servvice layer aan roepen voor later gebruik.
        public Menuitems_Service menuitemsAdd_Service = new Menuitems_Service();
        public Voorraad_Service voorraadAdd_Service = new Voorraad_Service();

        public MenuitemToevoegen()
        {
            InitializeComponent();
            //zorg er voor dat er geen border is
            this.ControlBox = false;
            this.Text = "";

            //De combo boxen vullen
            cb_Btw.Items.Add("6%");
            cb_Btw.Items.Add("21%");
            cb_TypeSelect.Items.Add("Lunch");
            cb_TypeSelect.Items.Add("Avond");
            cb_TypeSelect.Items.Add("Drank");
        }

        private void BTN_terug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tbx_functie_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void BTN_Toevoegen_Click(object sender, EventArgs e)
        {

            //Error message weghalen.
            lblErrorBox.Text = "";

            // Checken of de data fields zijn ingevuld en per regel zorgen dat er een andere error massage komt.
            if (Tbx_Naam.Text != "")
            {
                if (Tbx_Naam.TextLength < 200)
                {
                    if (Tbx_Prijs.Text != "")
                    {
                        if (cb_Btw.SelectedIndex > -1)
                        {
                            if (cb_TypeSelect.SelectedIndex > -1)
                            {
                                //Een menuitem maken met de gegevens uit de datavelden.
                                Menuitems items = new Menuitems()
                                {
                                    naam = Tbx_Naam.Text,
                                    prijs = decimal.Parse(Tbx_Prijs.Text),
                                    btw = int.Parse(cb_Btw.Text.Replace("%", string.Empty)),
                                    type = cb_TypeSelect.Text,
                                };

                                //De waardes doorsturen naar de Menuitems table van de database.
                                Menuitems newitem = menuitemsAdd_Service.MenuItemToevoegen(items.naam, items.prijs, items.btw, items.type);
                                voorraadAdd_Service.Additem(newitem.itemNummer);
                            }
                            else
                            {
                                lblErrorBox.ForeColor = Color.Red;
                                lblErrorBox.Text = "Selecteer eerst een Type optie!";
                            }
                        }
                        else
                        {
                            lblErrorBox.ForeColor = Color.Red;
                            lblErrorBox.Text = "Selecteer eerst een btw optie!";
                        }
                    }
                    else
                    {
                        lblErrorBox.ForeColor = Color.Red;
                        lblErrorBox.Text = "Voer een getal voor de prijs in!";
                    }
                }
                else
                {
                    lblErrorBox.ForeColor = Color.Red;
                    lblErrorBox.Text = "Voer een kleinere naam voor het menuitem in!";
                }
                
            }
            else
            {
                lblErrorBox.ForeColor = Color.Red;
                lblErrorBox.Text = "Voer een naam voor het menuitem in!";
            }

            this.Close();
        }
    }
}

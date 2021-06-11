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
        public Menuitems_Service menuitemsAdd_Service = new Menuitems_Service();
        public Voorraad_Service voorraadAdd_Service = new Voorraad_Service();

        public MenuitemToevoegen()
        {
            InitializeComponent();
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
            if ((lblMenuitem.Text != "") && (lblPrijs.Text != "") && (int.Parse(lblMenuitem.Text) < 5000) && (int.Parse(lblPrijs.Text) < 5000)) 
            {
                string menuitemNaam = lblMenuitem.Text;
                int prijs = int.Parse(lblPrijs.Text);

                voorraadAdd_Service.;
                menuitemsAdd_Service.;
                
                
            }
        }
    }
}

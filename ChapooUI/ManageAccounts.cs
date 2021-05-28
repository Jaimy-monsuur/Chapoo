using System;
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
    public partial class ManageAccounts : Form
    {
        public ManageAccounts()
        {
            InitializeComponent();

            MakeGrid();
        }

        public void MakeGrid()
        {

            // Maak grid
            LVW_Account.Clear();
            LVW_Account.View = View.Details;
            LVW_Account.GridLines = true;
            LVW_Account.FullRowSelect = true;

            // Voeg column header toe
            LVW_Account.Columns.Add("Ordernummer:", 100);
            LVW_Account.Columns.Add("Menu item:", 200);
            LVW_Account.Columns.Add("prijs:", 100);
            LVW_Account.Columns.Add("Bediende:", 100);

            Account_Service logIn_Service = new Account_Service();
            //Account login = logIn_Service);
            string[] item = new string[4];
            /*foreach ()
            {
                // Zet de items, in dit geval de naam en prijs van de openstaande gerechten in de listview
                item[0] = order.orderNummer.ToString();
                item[1] = order.itemNaam;
                item[2] = order.itemPrijs.ToString(); ;
                item[3] = order.personeelNummer.ToString(); ;
                ListViewItem li = new ListViewItem(item);
                LVW_Account.Items.Add(li);
            }*/
        }
    }
}

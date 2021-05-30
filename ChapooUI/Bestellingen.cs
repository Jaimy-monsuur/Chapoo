using ChapooModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
   
    public partial class Bestellingen : Form
    {
        //Code voor de placeholder.

        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public Bestellingen()
        {
            InitializeComponent();

            //Vul de listview met gerechten.

            ChapooLogic.Menuitems_Service menuServ = new ChapooLogic.Menuitems_Service();
            List<Menuitems> MenuServ = menuServ.GetMenuitems();
            LvEtenMenu.View = View.Details;
            foreach (ChapooModel.Menuitems menuitems in MenuServ)
            {
                LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{menuitems.naam}", $"{menuitems.prijs}", $"{menuitems.type}" }));
            }

            //Vul de listview met dranken.

            /*ChapooLogic.Order_Service orderServ1 = new ChapooLogic.Order_Service();
            List<Order> OrderList1 = orderServ.GetOrders();
            LvDrankenMenu.View = View.Details;
            foreach (ChapooModel.Order order1 in OrderList1)
            {
                LvDrankenMenu.Items.Add(new ListViewItem(new string[] { $"{order1.itemNaam}", $"{order1.itemPrijs}", $"{order1.aantal}" }));
            }
            */
            //Zorgt voor een placeholder "Opmerking:" in de textbox opmerking.

            SendMessage(txtOpmerkingBestelling.Handle, EM_SETCUEBANNER, 0, "Opmerking:");
         
    }
        private void btn_Uitlog_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        private void LBL_klok_Click(object sender, EventArgs e)
        {
           LBL_klokOr.Text = DateTime.Now.ToString(("HH:mm:ss"));
        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void terugKeukenBarBtn_Click(object sender, EventArgs e)
        {

        }        

        private void lblEtenTxt_Click(object sender, EventArgs e)
        {

        }

        private void lblDrankTxt_Click(object sender, EventArgs e)
        {

        }

        private void LvDrankenMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Wanneer een drankje wordt aangeklikt komt deze in textbox 'Drank:' te staan.

            if (LvDrankenMenu.SelectedItems.Count > 0)
            {
                ListViewItem item = LvDrankenMenu.SelectedItems[0];
                txtDrankIn.Text = item.SubItems[0].Text;
            }
            else
            {
                txtDrankIn.Text = string.Empty;
            }
        }

        private void txtOpmerkingBestelling_TextChanged(object sender, EventArgs e)
        {

        }

        private void plaatsOrderBarBtn_Click(object sender, EventArgs e)
        {

        }

        private void LvEtenMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Wanneer een gerecht wordt aangeklikt komt deze in textbox 'Gerecht:' te staan.

            if (LvEtenMenu.SelectedItems.Count > 0)
            {
                ListViewItem item = LvEtenMenu.SelectedItems[0];
                txtGerechtIn.Text = item.SubItems[0].Text;
            }
            else
            {
                txtGerechtIn.Text = string.Empty;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //
            Menuitems menuItem = new Menuitems();
            menuItem.naam = txtGerechtIn.Text;
            menuItem.prijs = int.Parse(txtDrankIn.Text);
            menuItem.type = txtOpmerkingBestelling.Text;

            LvOrderDetails.Items.Add(new ListViewItem(new string[] { $"{menuItem.naam}", $"{menuItem.prijs}", $"{menuItem.type}" }));
        }
    }
}

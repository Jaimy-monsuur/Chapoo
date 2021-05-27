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
    public partial class Bestellingen : Form
    {
        public Bestellingen()
        {
            InitializeComponent();
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

        private void LvEtenMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChapooLogic.Order_Service orderServ = new ChapooLogic.Order_Service();
            List<Order> OrderList = orderServ.GetOrders();
            LvEtenMenu.View = View.Details;
            foreach (ChapooModel.Order order in OrderList)
            {
               LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{order.itemNaam}", $"{order.itemPrijs}", $"{order.aantal}" }));
            }
        }

        private void lblEtenTxt_Click(object sender, EventArgs e)
        {

        }

        private void lblDrankTxt_Click(object sender, EventArgs e)
        {

        }

        private void LvDrankenMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtOpmerkingBestelling_TextChanged(object sender, EventArgs e)
        {

        }

        private void plaatsOrderBarBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

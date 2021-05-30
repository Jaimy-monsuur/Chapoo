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

            //DateTime start = new DateTime(2009, 12, 9, 18, 0, 0); //12 uur 's middags
            //DateTime end = new DateTime(2009, 12, 10, 23, 59, 0); //12 uur 's avonds
            //DateTime now = DateTime.Now;

           // if ((now < start) && (now < end))
           // {
                //Vul de listview met middag menu.

            /*    ChapooLogic.Menuitems_Service menuServMid = new ChapooLogic.Menuitems_Service();
                List<Menuitems> MenuMiddag = menuServMid.GetMenuMiddag();
                LvEtenMenu.View = View.Details;
                foreach (ChapooModel.Menuitems menuitems in MenuMiddag)
                {
                    LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{menuitems.naam}", $"{menuitems.prijs}", $"{menuitems.type}" }));
                } */
           // }
           // else
          //  {
                //Vul de listview met middag menu.

                ChapooLogic.Menuitems_Service menuServAvo = new ChapooLogic.Menuitems_Service();
                List<Menuitems> MenuAvond = menuServAvo.GetMenuAvond();
                LvEtenMenu.View = View.Details;
                foreach (ChapooModel.Menuitems menuitems in MenuAvond)
                {
                    LvEtenMenu.Items.Add(new ListViewItem(new string[] { $"{menuitems.naam}", $"{menuitems.prijs}", $"{menuitems.type}" }));
                }
           // }

            

            //Vul de listview met dranken.

            ChapooLogic.Menuitems_Service menuItems = new ChapooLogic.Menuitems_Service();
            List<Menuitems> drankitems = menuItems.GetMenuDrankItems();
            LvDrankenMenu.View = View.Details;
            foreach (ChapooModel.Menuitems drankItems in drankitems)
            {
                LvDrankenMenu.Items.Add(new ListViewItem(new string[] { $"{drankItems.naam}", $"{drankItems.prijs}", $"{drankItems.type}" }));
            }
            
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
            menuItem.naam = txtDrankIn.Text;
            menuItem.type = txtOpmerkingBestelling.Text;

            LvOrderDetails.Items.Add(new ListViewItem(new string[] { $"{menuItem.naam}", $"{menuItem.naam}", $"{menuItem.type}" }));
        }

        private List<Menuitems> Menuitems;

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int index = LvOrderDetails.SelectedIndices[0];
            Menuitems.RemoveAt(index);
            MenuItems();        
        }

        private void MenuItems()
        {
            LvOrderDetails.Items.Clear();            
        }
    }
}

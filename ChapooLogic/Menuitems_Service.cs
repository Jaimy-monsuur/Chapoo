using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;
using System.Data.SqlClient;
using System.Data;

namespace ChapooLogic
{
    public class Menuitems_Service
    {
        Menuitems_DAO menuitem_db = new Menuitems_DAO();

        public List<Menuitems> GetMenuitems()
        {
            // Vraagt de order lijst aan de DAL laag
            List<Menuitems> menuitems = menuitem_db.Db_Get_All_Menuitems();
            return menuitems;
        }

        public List<Menuitems> GetMenuDrankItems()
        {
            // Vraagt de order lijst aan de DAL laag
            List<Menuitems> menuDrankItems = menuitem_db.ReadMenuItemDrank();
            return menuDrankItems;
        }

        public List<Menuitems> GetMenuMiddag()
        {
            // Vraagt de order lijst aan de DAL laag
            List<Menuitems> menuMiddagItems = menuitem_db.ReadMenuItemMiddagMenu();
            return menuMiddagItems;
        }

        public List<Menuitems> GetMenuAvond()
        {
            // Vraagt de order lijst aan de DAL laag
            List<Menuitems> menuAvondItems = menuitem_db.ReadMenuItemAvondMenu();
            return menuAvondItems;
        }

        public Menuitems MenuItemToevoegen(string naam, decimal prijs, int btw, string type)
        {
            Menuitems itemnummer = menuitem_db.ToevoegenMenuItem(naam, prijs, btw, type);
            return itemnummer;

        }

        public void DeleteMenuItem(int itemNummer)
        {
            menuitem_db.DeleteMenuItem(itemNummer);
        }
    }
}

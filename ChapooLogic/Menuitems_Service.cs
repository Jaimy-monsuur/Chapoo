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
    }
}

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
    public class Orderitems_Service
    {
        Orderitems_DAO orderitem_db = new Orderitems_DAO();

        public List<Orderitems> Db_Get_All_Orderitems_for_Order(int ordernummer)
        {
            return orderitem_db.Db_Get_All_Orderitems_for_Order(ordernummer);
        }

        public List<Orderitems> Db_Get_All_Orderitems()
        {
            return orderitem_db.Db_Get_All_Orderitems();
        }

        public void DeleteOrderitem(int ordernummer, int itemnummer)
        {
            orderitem_db.DeleteOrderitem(ordernummer, itemnummer);
        }

        public void MeldGereed(int orderNummer)
        {
            // Stuurt het itemnummer wat gereed gemeld moet worden naar de DAL laag
            orderitem_db.MeldGereed(orderNummer);
        }
    }
}

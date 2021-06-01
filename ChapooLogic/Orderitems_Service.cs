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


       /* public void AddDrinkOrderitem(Orderitems orderitem)
        {
            // Stuurt de aangevraagde dranken order naar de DAL laag
            orderitem_db.AddDrinkOrderitem(orderitem);
        }*/

        public void DeleteOrderitem(int ordernummer, int itemnummer)
        {
            orderitem_db.DeleteOrderitem(ordernummer, itemnummer);
        }
    }
}

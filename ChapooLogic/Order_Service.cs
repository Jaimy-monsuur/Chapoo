using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooLogic;
using ChapooModel;

namespace ChapooLogic
{
    public class Order_Service
    {
        Order_DAO order_db = new Order_DAO();

        public List<Order> GetOrders()
        {
            // Vraagt de order lijst aan de DAL laag
            List<Order> orders = order_db.Db_Get_All_Orders();
            return orders;
        }

        public void AddDrinkOrder(List<Order> drankenOrder)
        {
            // Stuurt de aangevraagde dranken order naar de database
            order_db.AddDrinkOrder(drankenOrder);
        }
    }
}

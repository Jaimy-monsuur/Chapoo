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

        public List<Order> GetOrders_ThatAreTrue()
        {
            // Vraagt de order lijst aan de DAL laag
            List<Order> orders = order_db.GetOrders_ThatAreTrue();
            return orders;
        }
        public List<Order> GetOrderss()
        {
            // Vraagt de order lijst aan de DAL laag

            return order_db.GetOrders();
        }

        public Order NewOrder(int tafelnummer, string personeelsnummer)
        {
            return order_db.NewOrder(tafelnummer, personeelsnummer);
        }

        public List<Order> Db_Get_All_Orders_FORTable(int tafelnummer)
        {
            // Vraagt de order lijst aan de DAL laag
            return order_db.GetOrders_For_Table(tafelnummer);

        }
    }
}

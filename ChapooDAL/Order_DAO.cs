using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;
using System.Data.SqlClient;
using System.Data;

namespace ChapooDAL
{
    public class Order_DAO : Base
    {
        Orderitems_DAO Orderitems_DAO = new Orderitems_DAO();// voor nu. is misschien niet zo mooi
        public List<Order> GetOrders()
        {
            string query = $"SELECT [ordernummer], [tafelnummer], [personeelnummer], [opmerking], [gereed] FROM [Orders]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Order> orders = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            foreach (Order O in orders)
            {
              O.orderItemList = Orderitems_DAO.Db_Get_All_Orderitems_for_Order(O.orderNummer);
            }
            return orders;
        }
        public List<Order> GetOrders_For_Table(int tafelnummer)
        {
            string query = $"SELECT [ordernummer], [tafelnummer], [personeelnummer], [opmerking], [gereed] FROM [Orders] WHERE [tafelnummer] = '{tafelnummer}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Order> orders = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            foreach (Order O in orders)
            {
                //O.orderItemList = Orderitems_DAO.
            }
            return orders;
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    // Alle members van class order worden uit de database opgehaald uit de rijen
                    orderNummer = (int)dr["ordernummer"],
                    tafelNummer = (int)dr["tafelnummer"],
                    personeelNummer = (int)dr["personeelnummer"],
                    opmerking = (string)dr["opmerking"],
                    gereed = (bool)dr["gereed"]
                };
                orders.Add(order);
            }

            return orders;
        }

        public void MeldGereed(int orderNummer)
        {
            string query = $"UPDATE Orders SET gereed = 1 WHERE Orders.ordernummer = {orderNummer}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void MeldOngereed(int orderNummer)
        {
            string query = $"UPDATE Orders SET gereed = 0 WHERE Orders.ordernummer = {orderNummer}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}

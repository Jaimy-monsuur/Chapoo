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
        public List<Order> Db_Get_All_Orders()
        {
            // Hier staat de query die naar de database gaat voor het ophalen van de juiste gegevens
            string query = "SELECT * FROM Orders JOIN Orderitems ON Orderitems.ordernummer = Orders.ordernummer JOIN Menuitems ON Orderitems.itemnummer = Menuitems.itemnummer";// geen select * gebruiken
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> Db_Get_All_Orders_FORTable(int tafelnummer)
        {
            // Hier staat de query die naar de database gaat voor het ophalen van de juiste gegevens
            string query = $"SELECT Orders.[ordernummer],Orders.tafelnummer,Orders.[personeelnummer],Orders.[opmerking],Menuitems.naam,Menuitems.prijs, aantal, gereed FROM Orders JOIN Orderitems ON Orderitems.ordernummer = Orders.ordernummer JOIN Menuitems ON Orderitems.itemnummer = Menuitems.itemnummer WHERE Orders.tafelnummer = '{tafelnummer}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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
                    itemNaam = (string)dr["naam"],
                    itemPrijs = (decimal)dr["prijs"],
                    type = (string)dr["type"],
                    aantal = (int)dr["aantal"],
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

        public int NewOrder(Order order)
        {
            string query = $"INSERT INTO Orders (tafelnummer, personeelnummer, opmerking, gereed) VALUES ({order.tafelNummer}, {order.personeelNummer}, {order.opmerking}, gereed = 0);";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

            string query2 = $"SELECT ordernummer FROM Orders ORDER BY ordernummer DESC LIMIT 1";
            SqlParameter[] sqlParameters2 = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query2, sqlParameters2);

            int ordernummer = 0;
            foreach (DataRow dr in dataTable.Rows)
            {
                ordernummer = (int)dr["ordernummer"];
            }
            return ordernummer;
        }

        public void AddDrinkOrderitem(Order order)
        {
            string query = $"SELECT Menuitems.itemnummer FROM Menuitems JOIN Menuitems ON {order.itemNaam} = menuitems.naam";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            int itemNummer = 0;
            foreach (DataRow dr in dataTable.Rows)
            {
                itemNummer = (int)dr["itemnummer"];
            }
            
            string query2 = $"INSERT INTO Orderitems (ordernummer, itemnummer, aantal) VALUES ({order.orderNummer}, {itemNummer}), 1)";
            SqlParameter[] sqlParameters2 = new SqlParameter[0];
            ExecuteSelectQuery(query2, sqlParameters2);
        }
    }
}

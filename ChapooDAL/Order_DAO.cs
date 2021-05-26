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
            string query = $"SELECT  Orders.[ordernummer],Menuitems.naam,Menuitems.prijs,[opmerking],[personeelnummer] FROM Orders JOIN Orderitems ON Orderitems.ordernummer = Orders.ordernummer JOIN Menuitems ON Orderitems.itemnummer = Menuitems.itemnummer WHERE Orders.tafelnummer = '{tafelnummer}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables_noDetail(ExecuteSelectQuery(query, sqlParameters));
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
                    type = (string)dr["type"]
                };
                orders.Add(order);
            }

            return orders;
        }
        private List<Order> ReadTables_noDetail(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    // Alle members van class order worden uit de database opgehaald uit de rijen
                    orderNummer = (int)dr["ordernummer"],
                    personeelNummer = (int)dr["personeelnummer"],
                    opmerking = (string)dr["opmerking"],
                    itemNaam = (string)dr["naam"],
                    itemPrijs = (decimal)dr["prijs"],
                };
                orders.Add(order);
            }

            return orders;
        }
        public void AddDrinkOrder(List<Order> drankenOrder)
        {

        }
    }
}

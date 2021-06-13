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
    public class Orderitems_DAO : Base
    {
        Menuitems_DAO menuitems_db = new Menuitems_DAO();

        public List<Orderitems> Db_Get_All_Orderitems_for_Order(int ordernummer)
        {
            // Hier staat de query die naar de database gaat voor het ophalen van de juiste gegevens
            string query = $"SELECT ordernummer, itemnummer, aantal, gereed, [time], Opmerking FROM Orderitems WHERE Orderitems.[ordernummer] = '{ordernummer}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Orderitems> Db_Get_All_Orderitems()
        {
            // Hier staat de query die naar de database gaat voor het ophalen van de juiste gegevens
            string query = $"SELECT ordernummer, itemnummer, aantal, gereed, [time], Opmerking FROM Orderitems ORDER BY [time] DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddOrderitem(int orderNummer,int itemnummer, int aantal,string opmerking)
        {
            string query = "";
            if (opmerking == "")
            {
                query = $"INSERT INTO Orderitems (ordernummer, itemnummer, aantal, gereed, [time]) VALUES ({orderNummer}, {itemnummer}, {aantal}, 0, SYSDATETIMEOFFSET() AT TIME ZONE 'Central European Standard Time'))";
            }
            else
            {
                query = $"INSERT INTO Orderitems VALUES ({orderNummer}, {itemnummer}, {aantal}, 0, SYSDATETIMEOFFSET() AT TIME ZONE 'Central European Standard Time'), '{opmerking})'";
            }
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Orderitems> ReadTables(DataTable dataTable)
        {
            List<Orderitems> orderitems = new List<Orderitems>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int itemNummer = (int)dr["itemnummer"];
                List<Menuitems> menuitems = menuitems_db.Db_Get_All_Menuitems_for_Orderitem(itemNummer);
                Menuitems menuitem = menuitems[0];

                Orderitems orderitem = new Orderitems();
                    // Alle members van class order worden uit de database opgehaald uit de rijen
                orderitem.orderNummer = (int)dr["ordernummer"];
                orderitem.aantal = (int)dr["aantal"];
                orderitem.gereed = (bool)dr["gereed"];
                orderitem.menuItem = menuitem;
                orderitem.time = (DateTime)dr["time"];
                if (dr["Opmerking"] != DBNull.Value)
                {
                    orderitem.opmerking = (string)dr["Opmerking"];
                }            
                orderitems.Add(orderitem);
            }

            return orderitems;
        }

        public void MeldGereed(int orderNummer)
        {
            string query = $"UPDATE Orderitems SET gereed = 1 WHERE Orderitems.ordernummer = {orderNummer}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void MeldOngereed(int orderNummer)
        {
            string query = $"UPDATE Orders SET gereed = 0 WHERE Orders.ordernummer = {orderNummer}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void DeleteOrderitem(int ordernummer, int itemnummer)
        {
            string query = $"DELETE FROM [Orderitems] WHERE [ordernummer] = '{ordernummer}' AND itemnummer = '{itemnummer}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}

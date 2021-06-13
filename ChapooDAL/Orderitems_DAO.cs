﻿using System;
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
            string query = $"SELECT ordernummer, itemnummer, aantal, gereed, [time] FROM Orderitems WHERE Orderitems.[ordernummer] = '{ordernummer}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Orderitems> Db_Get_All_Orderitems()
        {
            // Hier staat de query die naar de database gaat voor het ophalen van de juiste gegevens
            string query = $"SELECT ordernummer, itemnummer, aantal, gereed, [time] FROM Orderitems JOIN Orders ON Orders.ordernummer = Orderitems.ordernummer ORDER BY besteltijd DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Orderitems> ReadTables(DataTable dataTable)
        {
            List<Orderitems> orderitems = new List<Orderitems>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int itemNummer = (int)dr["itemnummer"];
                List<Menuitems> menuitems = menuitems_db.Db_Get_All_Menuitems_for_Orderitem(itemNummer);
                Menuitems menuitem = menuitems[0];

                Orderitems orderitem = new Orderitems()
                {
                    // Alle members van class order worden uit de database opgehaald uit de rijen
                    orderNummer = (int)dr["ordernummer"],
                    aantal = (int)dr["aantal"],
                    gereed = (bool)dr["gereed"],
                    menuItem = menuitem,
                    time = (DateTime)(dr["time"])
                };
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

        /*public void AddDrinkOrderitem(Orderitems orderitem)
        {
            /*string query = $"SELECT Menuitems.itemnummer FROM Menuitems JOIN Menuitems ON {orderitem.itemNaam} = menuitems.naam"; // werkt niet
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            int itemNummer = 0;
            foreach (DataRow dr in dataTable.Rows)
            {
                itemNummer = (int)dr["itemnummer"];
            }

            string query2 = $"INSERT INTO Orderitems (ordernummer, itemnummer, aantal) VALUES ({orderitem.orderNummer}, {itemNummer}), 1)";
            SqlParameter[] sqlParameters2 = new SqlParameter[0];
            ExecuteSelectQuery(query2, sqlParameters2);
        }*/
        public void DeleteOrderitem(int ordernummer, int itemnummer)
        {
            string query = $"DELETE FROM [Orderitems] WHERE [ordernummer] = '{ordernummer}' AND itemnummer = '{itemnummer}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}

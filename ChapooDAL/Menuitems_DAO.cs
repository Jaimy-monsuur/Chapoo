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
    public class Menuitems_DAO : Base
    {
        public List<Menuitems> Db_Get_All_Menuitems()
        {
            // Hier staat de query die naar de database gaat voor het ophalen van de juiste gegevens
            string query = "SELECT itemnummer, naam, prijs, btw, type FROM Menuitems";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Menuitems> Db_Get_All_Menuitems_for_Orderitem(int itemNummer)
        {
            // Hier staat de query die naar de database gaat voor het ophalen van de juiste gegevens
            string query = $"SELECT itemnummer, naam, prijs, btw, type FROM Menuitems WHERE itemnummer = {itemNummer}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Menuitems> ReadMenuItemDrank()
        {
            string query = "SELECT itemnummer, naam, prijs, btw, type FROM Menuitems WHERE type='Drank' AND itemnummer IN (SELECT itemnummer FROM Voorraad WHERE voorraadaantal > 0)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Menuitems> ReadMenuItemMiddagMenu()
        {
            string query = "SELECT itemnummer, naam, prijs, btw, type FROM Menuitems WHERE type='Lunch' AND itemnummer IN (SELECT itemnummer FROM Voorraad WHERE voorraadaantal > 0)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Menuitems> ReadMenuItemAvondMenu()
        {
            string query = "SELECT itemnummer, naam, prijs, btw, type FROM Menuitems WHERE type='Avond' AND itemnummer IN (SELECT itemnummer FROM Voorraad WHERE voorraadaantal > 0)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DeleteMenuItem(int itemNummer)
        {
            string query = $"DELETE FROM [Menuitems] WHERE [itemnummer] = '{itemNummer}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public Menuitems ToevoegenMenuItem(string naam, decimal prijs, int btw, string type)
        {
            string query = $"INSERT INTO [Menuitems] VALUES ('{naam}', '{prijs}', '{btw}', '{type}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
            return GetMenuitemsByName(naam);
        }
        public Menuitems GetMenuitemsByName(string naam)
        {
            // Hier staat de query die naar de database gaat voor het ophalen van de juiste gegevens
            string query = $"SELECT itemnummer, naam, prijs, btw, type FROM Menuitems WHERE naam = '{naam}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Menuitems> ReadTables(DataTable dataTable)
        {
            List<Menuitems> menuitems = new List<Menuitems>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Menuitems menuitem = new Menuitems()
                {
                    // Alle members voor class menuitems worden uit de database opgehaald uit de rijen
                    itemNummer = (int)dr["itemnummer"],
                    naam = (string)dr["naam"],
                    prijs = (decimal)dr["prijs"],
                    btw = (int)dr["btw"],
                    type = (string)dr["type"]
                };
                menuitems.Add(menuitem);
            }

            return menuitems;
        }
        private Menuitems ReadTable(DataTable dataTable)
        {
            Menuitems menuitem = new Menuitems();

            foreach (DataRow dr in dataTable.Rows)
            {
                Menuitems m = new Menuitems()
                {
                    // Alle members voor class menuitems worden uit de database opgehaald uit de rijen
                    itemNummer = (int)dr["itemnummer"],
                    naam = (string)dr["naam"],
                    prijs = (decimal)dr["prijs"],
                    btw = (int)dr["btw"],
                    type = (string)dr["type"]
                };
                menuitem = m;
            }

            return menuitem;
        }
    }
}

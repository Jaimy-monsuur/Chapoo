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
    public class Voorraad_DAO : Base
    {
        public List<Voorraad> Db_Get_Voorraad()
        {
            // Hier staat de query die naar de database gaat voor het ophalen van de juiste gegevens
            string query = "SELECT Voorraad.itemnummer, Voorraad.voorraadaantal, Menuitems.prijs, Menuitems.naam, Menuitems.[type] FROM Voorraad JOIN Menuitems ON Voorraad.itemnummer = Menuitems.itemnummer ORDER BY voorraadaantal ASC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void DeleteMenuItem(int itemNummer)
        {
            string query = $"DELETE FROM [Voorraad] WHERE [itemnummer] = '{itemNummer}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Voorraad> ReadTables(DataTable dataTable)
        {
            List<Voorraad> voorraadItems = new List<Voorraad>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Voorraad voorraadItem = new Voorraad()
                {
                    // Alle members van class order worden uit de database opgehaald uit de rijen
                    itemNummer = (int)dr["itemnummer"],
                    itemNaam = (string)dr["naam"],
                    itemPrijs = (decimal)dr["prijs"],
                    voorraadAantal = (int)dr["voorraadaantal"],
                    itemType = (string)dr["type"]
                };
                voorraadItems.Add(voorraadItem);
            }

            return voorraadItems;
        }

        public void ChangeVoorraad(int itemNummer, int nieuwAantal)
        {
            // Verandert de voorraad in de database
            string query = $"UPDATE Voorraad SET voorraadaantal={nieuwAantal} WHERE itemnummer={itemNummer}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}

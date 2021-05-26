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
            string query = "SELECT * FROM Orderitems JOIN Menuitems ON Orderitems.itemnummer = Menuitems.itemnummer";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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
                    voorraadAantal = (int)dr["aantal"]
                };
                voorraadItems.Add(voorraadItem);
            }

            return voorraadItems;
        }
    }
}

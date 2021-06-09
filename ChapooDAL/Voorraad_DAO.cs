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
        public List<Voorraad_item> Db_Get_Voorraad()
        {
            // Hier staat de query die naar de database gaat voor het ophalen van de juiste gegevens
            string query = "SELECT Voorraad.itemnummer, Voorraad.voorraadaantal, Menuitems.prijs, Menuitems.naam, Menuitems.[type] FROM Voorraad JOIN Menuitems ON Voorraad.itemnummer = Menuitems.itemnummer ORDER BY voorraadaantal ASC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Voorraad_item> ReadTables(DataTable dataTable)
        {
            List<Voorraad_item> voorraadItems = new List<Voorraad_item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Voorraad_item voorraadItem = new Voorraad_item();
                voorraadItem.menuitem = new Menuitems();
                // Alle members van class order worden uit de database opgehaald uit de rijen
                voorraadItem.menuitem.itemNummer = (int)dr["itemnummer"];
                voorraadItem.menuitem.naam = (string)dr["naam"];
                voorraadItem.menuitem.prijs = (decimal)dr["prijs"];
                voorraadItem.voorraadAantal = (int)dr["voorraadaantal"];
                voorraadItem.menuitem.type = (string)dr["type"];
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;

using ChapooModel;

namespace ChapooDAL
{
    public class Tafel_DAO : Base
    {
        public List<Tafel> GetTafels()
        {
            string query = $"SELECT tafelnummer, zitplekken, bezeting FROM [Tafels]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Tafel> ReadTables(DataTable dataTable)
        {
            List<Tafel> Tafels = new List<Tafel>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Tafel t = new Tafel();
                t.tafelnummer = (int)(dr["tafelnummer"]);
                t.zitplekken = (int)(dr["zitplekken"]);
                t.bezeting = (int)(dr["bezeting"]);
                Tafels.Add(t);
            }
            return Tafels;
        }
    }
}

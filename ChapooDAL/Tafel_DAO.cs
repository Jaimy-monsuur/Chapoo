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
        public List<Tafel> GetTafels()// haalt alle tafels
        {
            string query = $"SELECT tafelnummer, zitplekken, bezeting FROM [Tafels]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Tafel GetTafels_by_tablenumber(int tafelnummer)//haalt 1 tafel
        {
            string query = $"SELECT tafelnummer, zitplekken, bezeting FROM [Tafels] WHERE tafelnummer = {tafelnummer}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Tafel> GetTafel_for_Order(int tafelNummer)// haalt de tafel voor een order,  gaat naar order DAO
        {
            string query = $"SELECT tafelnummer, zitplekken, bezeting FROM [Tafels] WHERE tafelnummer = {tafelNummer}";
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

        public void ClearTafel(int tafelnummer)// zet bezetting naar 0
        {
            string query = $"UPDATE Tafels SET bezeting = '0' WHERE tafelnummer = '{tafelnummer}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void AlterBezetting(int tafelnummer,int Personen)// plaatst mensen aan tafel
        {
            string query = $"UPDATE Tafels SET bezeting = '{Personen}' WHERE tafelnummer = '{tafelnummer}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        private Tafel ReadTable(DataTable dataTable)
        {
            Tafel Tafel = new Tafel();
            foreach (DataRow dr in dataTable.Rows)
            {
                Tafel t = new Tafel();
                t.tafelnummer = (int)(dr["tafelnummer"]);
                t.zitplekken = (int)(dr["zitplekken"]);
                t.bezeting = (int)(dr["bezeting"]);
                Tafel = t;
            }
            return Tafel;
        }
    }
}

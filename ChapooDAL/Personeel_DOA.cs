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
    public class Personeel_DOA : Base
    {
        public List<Personeels_Lid> GetPersoneel()
        {
            string query = $"SELECT [personeelnummer],[voornaam],[achternaam],[functie],[username],[password],[type] FROM [Personeel]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
         public void Addpersonle()
        {

        }

        public void DeletePersonel()
        {

        }
        private List<Personeels_Lid> ReadTables(DataTable dataTable)
        {
            List<Personeels_Lid> personeels_Lid = new List<Personeels_Lid>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Personeels_Lid p = new Personeels_Lid();
                p.Nummer = (int)(dr["personeelnummer"]);
                p.Voornaam = (String)(dr["voornaam"].ToString());
                p.Achternaam = (String)(dr["achternaam"].ToString());
                p.functie = (String)(dr["functie"].ToString());
                p.UserName = (String)(dr["username"].ToString());
                p.Password = (String)(dr["password"].ToString());
                p.Type = (String)(dr["type"].ToString());

                personeels_Lid.Add(p);
            }
            return personeels_Lid;
        }
    }
}

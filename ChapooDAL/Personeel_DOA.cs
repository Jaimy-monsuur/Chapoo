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
        public List<Personeels_Lid> GetPersoneel()// haalt al het personeel
        {
            string query = $"SELECT [personeelnummer],[voornaam],[achternaam],[functie],[username],[password],[type] FROM [Personeel]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Personeels_Lid> GetPersoneel_for_Order(int personeelNummer) // haalt 1 personeels lis
        {
            string query = $"SELECT [personeelnummer],[voornaam],[achternaam],[functie],[username],[password],[type] FROM [Personeel] WHERE [personeelnummer] = {personeelNummer}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void Addpersonle(string voornaam, string achternaam,string functie,string username,string password,string type)// voegt nieuw personeels lid toe,
        {
            string query = $"INSERT INTO[Personeel] VALUES('{voornaam}', '{achternaam}', '{functie}', '{username}', '{password}', '{type}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeletePersonel(int personeelnummer)// verwijderd een personeels lid
        {
            string query = $"DELETE FROM [Personeel] WHERE [personeelnummer] = '{personeelnummer}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        private List<Personeels_Lid> ReadTables(DataTable dataTable)
        {
            List<Personeels_Lid> personeels_Lid = new List<Personeels_Lid>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Personeels_Lid p = new Personeels_Lid();
                p.account = new Account();//het account van personeels lid
                p.Nummer = (int)(dr["personeelnummer"]);
                p.Voornaam = (String)(dr["voornaam"].ToString());
                p.Achternaam = (String)(dr["achternaam"].ToString());
                p.functie = (String)(dr["functie"].ToString());
                p.account.UserName = (String)(dr["username"].ToString());
                p.account.Password = (String)(dr["password"].ToString());
                p.account.Type = (String)(dr["type"].ToString());

                personeels_Lid.Add(p);
            }
            return personeels_Lid;
        }
    }
}

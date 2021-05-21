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
    public class Tafel_Reservering_DAO : Base
    {
        public List<Tafel_Reservering> GetTafelReservering()
        {
            string query = $"SELECT voornaam,achternaam,tafelnummer,datum,[vanaf(tijd)],[tot(tijd)] FROM TafelReservering JOIN Klant ON Klant.klantnummer = TafelReservering.klantnummer WHERE datum = CAST (GETDATE() AS DATE)"; 
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Tafel_Reservering> ReadTables(DataTable dataTable)
        {
            List<Tafel_Reservering> reservations = new List<Tafel_Reservering>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Tafel_Reservering t = new Tafel_Reservering();
                t.naam = (string)(dr["voornaam"]) + (string)(dr["achternaam"]);
                t.tafelnummer = (int)(dr["tafelnummer"]);
                t.Datum = (DateTime)(dr["datum"]);
                t.startTijd = (TimeSpan)(dr["vanaf(tijd)"]);
                t.eindTijd = (TimeSpan)(dr["tot(tijd)"]);
                reservations.Add(t);
            }
            return reservations;
        }
    }
}


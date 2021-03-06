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
        public Tafel_DAO Tafel_DAO = new Tafel_DAO();
        public List<Tafel_Reservering> Get_All_Table_reservationsfortoday()//haalt de reserveringen voor vandaag
        {
            string query = $"SELECT [reserveringsnummer],voornaam,achternaam,tafelnummer,datum,[vanaf(tijd)],[tot(tijd)] FROM TafelReservering JOIN Klant ON Klant.klantnummer = TafelReservering.klantnummer WHERE datum = CAST (GETDATE() AS DATE)"; 
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Tafel_Reservering> reserveringen = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return reserveringen;
        }

        public List<Tafel_Reservering> Get_Current_Futere_Reservations_ForTable(int tafelnummer)// haalt alle toekomstige reserveringen
        {
            string query = $"SELECT [reserveringsnummer],voornaam,achternaam,tafelnummer,datum,[vanaf(tijd)],[tot(tijd)] FROM TafelReservering JOIN Klant ON Klant.klantnummer = TafelReservering.klantnummer WHERE datum >= CAST (GETDATE() AS DATE) AND TafelReservering.tafelnummer = '{tafelnummer}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Tafel_Reservering> reserveringen = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return reserveringen;
        }
        public void Deletereservation(int reserveringsnummer)// verwijderd een reservering
        {
            string query = $"DELETE FROM [TafelReservering] WHERE [reserveringsnummer] = '{reserveringsnummer}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Newreseration(int Klantnummer, int tafelnummer, string date, string begin, string eind)//maakt een nieuwe reservering
        {
            string query = $"INSERT INTO [TafelReservering] VALUES(@KlantID, @TafelID, @Date, CAST(@Start AS smalldatetime), CAST(@Eind AS smalldatetime));;";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@KlantID", SqlDbType.Int) {Value = Klantnummer},
                new SqlParameter("@TafelID", SqlDbType.Int){Value = tafelnummer},
                new SqlParameter("@Date", SqlDbType.Date){Value = date},
                new SqlParameter("@Start", SqlDbType.SmallDateTime){Value = begin},
                new SqlParameter("@Eind",SqlDbType.SmallDateTime){Value = eind},
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Tafel_Reservering> ReadTables(DataTable dataTable)
        {
            List<Tafel_Reservering> reservations = new List<Tafel_Reservering>();
            foreach (DataRow dr in dataTable.Rows)
            {
                int tafelnummer = (int)dr["tafelnummer"];

                Tafel_Reservering t = new Tafel_Reservering();
                t.reserveringsnummer = (int)(dr["reserveringsnummer"]);
                t.naam = (string)(dr["voornaam"]) + "" + (string)(dr["achternaam"]);
                t.tafel = Tafel_DAO.GetTafels_by_tablenumber(tafelnummer);
                t.Datum = (DateTime)(dr["datum"]);
                DateTime temp1 = (DateTime)(dr["vanaf(tijd)"]);
                DateTime temp2 = (DateTime)(dr["tot(tijd)"]);
                t.startTijd = TimeSpan.Parse(temp1.ToString("HH:mm"));
                t.eindTijd = TimeSpan.Parse(temp2.ToString("HH:mm"));
                reservations.Add(t);
            }
            return reservations;
        }
    }
}


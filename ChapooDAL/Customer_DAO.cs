using System;
using ChapooModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;

namespace ChapooDAL
{
    public class Customer_DAO : Base
    {
        public List<Customer> GetALLCUstomers()
        {
            string query = $"SELECT [klantnummer], [voornaam], [achternaam] FROM [Klant] ORDER BY voornaam ASC;";// ordered op voornaam
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddCustomer(string naam, string achternaam, string email, string telefoonnummer)
        {
            string query = "";// hier word gekeken naar de gegevens om te bebalen welke query ndoig is
            if (email == "" && telefoonnummer == "")
            {
                query = $"INSERT INTO [klant] ([voornaam], [achternaam]) VALUES ('{naam}', '{achternaam}')";
            }
            else if (email == "" && telefoonnummer != "")
            {
                query = $"INSERT INTO [klant] ([voornaam], [achternaam], [telefoonnummer]) VALUES ('{naam}', '{achternaam}', '{telefoonnummer}')";
            }
            else if (telefoonnummer == "" && email != "")
            {
                query = $"INSERT INTO [klant] ([voornaam], [achternaam], [email]) VALUES ('{naam}', '{achternaam}', '{email}')";
            }
            else
            {
                query = $"INSERT INTO [klant] VALUES ({naam}, {achternaam}, {email}, {telefoonnummer})";
            }
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        private List<Customer> ReadTables(DataTable dataTable)
        {
            List<Customer> customers = new List<Customer>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Customer k = new Customer();
                k.klantennummer = (int)(dr["klantnummer"]);
                k.name = (string)(dr["voornaam"].ToString()) + " " + (string)(dr["achternaam"].ToString());

                customers.Add(k);
            }
            return customers;
        }
    }
}

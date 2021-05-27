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
            string query = $"SELECT [klantnummer], [voornaam], [achternaam] FROM [Klant]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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

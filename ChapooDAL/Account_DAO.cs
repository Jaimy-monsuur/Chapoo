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
    public class Account_DAO : Base
    {

        public Account DB_Login(string username, string password)
        {
            string query = $"SELECT username, password, type FROM [Account] WHERE username = '{username}' AND password = '{password}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private Account ReadTables(DataTable dataTable)
        {
            Account login = new Account();
            foreach (DataRow dr in dataTable.Rows)
            {
                Account logintemp = new Account();
                logintemp.UserName = (String)(dr["username"].ToString());
                logintemp.Password = (String)(dr["password"].ToString());
                //logintemp.Type = (String)(dr["adminStatus"].ToString());
                login = logintemp;
            }
            return login;
        }
    }
}

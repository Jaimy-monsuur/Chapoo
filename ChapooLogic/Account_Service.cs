using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;


namespace ChapooLogic
{
    public class Account_Service
    {
        Account_DAO Account_DAO = new Account_DAO();
        public Account Login(string username, string password)// logt in
        {
            return Account_DAO.DB_Login(username, password);
        }

    }
}

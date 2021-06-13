using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class Customer_Service
    {
        Customer_DAO Customer_DAO = new Customer_DAO();
        public List<Customer> GetALLCUstomers()// haaly klanten
        {
            return Customer_DAO.GetALLCUstomers();
        }
        public void AddCustomer(string naam, string achternaam, string email, string telefoonnummer)// add klant
        {
            Customer_DAO.AddCustomer(naam, achternaam, email, telefoonnummer);
        }

    }
}

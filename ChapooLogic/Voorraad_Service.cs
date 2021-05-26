using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class Voorraad_Service
    {
        Voorraad_DAO voorraad_db = new Voorraad_DAO();

        public List<Voorraad> GetVoorraad()
        {
            // Vraagt aan de DAL laag om de voorraad uit de database te halen
            List<Voorraad> voorraadItems = voorraad_db.Db_Get_Voorraad();
            return voorraadItems;
        }
    }
}

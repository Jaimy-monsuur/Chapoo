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

        public List<Voorraad_item> GetVoorraad()
        {
            // Vraagt aan de DAL laag om de voorraad uit de database te halen
            List<Voorraad_item> voorraadItems = voorraad_db.Db_Get_Voorraad();
            return voorraadItems;
        }

        public void ChangeVoorraad(int itemNummer, int nieuwAantal)
        {
            // Stuurt itemnummer en het nieuwe aantal door naar de DAL laag
            voorraad_db.ChangeVoorraad(itemNummer, nieuwAantal);
        }

        public void Additem(int itemNummer)
        {
            voorraad_db.AddItem(itemNummer);
        }

        public void DeleteMenuItem(int itemNummer)
        {
            voorraad_db.DeleteMenuItem(itemNummer);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;
using ChapooDAL;

namespace ChapooLogic
{
    public class Tafel_Service
    {
        Tafel_DAO Tafel_DAO = new Tafel_DAO();
        
        public List<Tafel> Tafels()
        {
            return Tafel_DAO.GetTafels();
        }

        public void ClearTafel(int tafelnummer)
        {
            Tafel_DAO.ClearTafel(tafelnummer);
        }

        public void AlterBezetting(int tafelnummer, int Personen)
        {
            Tafel_DAO.AlterBezetting(tafelnummer, Personen);
        }
    }
}

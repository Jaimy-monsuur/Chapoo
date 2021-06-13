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
        
        public List<Tafel> Tafels()// haalte alle tafels
        {
            return Tafel_DAO.GetTafels();
        }

        public void ClearTafel(int tafelnummer)// ze bezetting naar 0
        {
            Tafel_DAO.ClearTafel(tafelnummer);
        }

        public void AlterBezetting(int tafelnummer, int Personen)// plaatst klanten
        {
            Tafel_DAO.AlterBezetting(tafelnummer, Personen);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;
using ChapooDAL;

namespace ChapooLogic
{
    public class Tafel_Reservation_service
    {
        Tafel_Reservering_DAO Tafel_Reservering_DAO = new Tafel_Reservering_DAO();

        public List<Tafel_Reservering> GetTableReservations()
        {
            return Tafel_Reservering_DAO.GetTafelReservering();
        }
    }
}

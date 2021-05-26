﻿using System;
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

        public List<Tafel_Reservering> Get_All_Table_reservationsfortoday()
        {
            return Tafel_Reservering_DAO.Get_All_Table_reservationsfortoday();
        }

        public List<Tafel_Reservering> Get_Current_Futere_Reservations_ForTable(int tafelnummer)
        {
            return Tafel_Reservering_DAO.Get_Current_Futere_Reservations_ForTable(tafelnummer);
        }

        public void Deletereservation(int reserveringsnummer)
        {
            Tafel_Reservering_DAO.Deletereservation(reserveringsnummer);
        }
    }
}

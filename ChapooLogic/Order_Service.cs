﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooLogic;
using ChapooModel;

namespace ChapooLogic
{
    public class Order_Service
    {
        Order_DAO order_db = new Order_DAO();

        public List<Order> GetOrders()
        {
            // Vraagt de order lijst aan de DAL laag
            List<Order> orders = order_db.Db_Get_All_Orders();
            return orders;
        }

        public void MeldGereed(int orderNummer)
        {
            // Stuurt het itemnummer wat gereed gemeld moet worden naar de DAL laag
            order_db.MeldGereed(orderNummer);
        }

        public void MeldOngereed(int orderNummer)
        {
            // Stuurt het itemnummer wat ongereed gemeld moet worden naar de DAL laag
            order_db.MeldOngereed(orderNummer);
        }

        public void AddDrinkOrderitem(Order order)
        {
            // Stuurt de aangevraagde dranken order naar de DAL laag
            order_db.AddDrinkOrderitem(order);
        }

        public int NewOrder(Order order)
        {          
            return order_db.NewOrder(order);
        }
        public List<Order> Db_Get_All_Orders_FORTable(int tafelnummer)
        {
            // Vraagt de order lijst aan de DAL laag
            return order_db.Db_Get_All_Orders_FORTable(tafelnummer);
        }


    }
}

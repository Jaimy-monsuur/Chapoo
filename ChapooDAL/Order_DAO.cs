using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;
using System.Data.SqlClient;
using System.Data;

namespace ChapooDAL
{
    public class Order_DAO : Base
    {
        Tafel_DAO tafel_db = new Tafel_DAO();
        Personeel_DOA personeel_db = new Personeel_DOA();
        Orderitems_DAO Orderitems_DAO = new Orderitems_DAO();

        public List<Order> GetOrders()
        {
            string query = $"SELECT [ordernummer], [tafelnummer], [personeelnummer], [opmerking], [datum] FROM [Orders] WHERE datum >= CAST (GETDATE() AS DATE)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Order> orders = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            foreach (Order O in orders)
            {
              O.orderItemList = Orderitems_DAO.Db_Get_All_Orderitems_for_Order(O.orderNummer);
            }
            return orders;
        }
        public List<Order> GetOrders_For_Table(int tafelnummer)
        {
            string query = $"SELECT [ordernummer], [tafelnummer], [personeelnummer], [opmerking], [datum] FROM [Orders] WHERE [tafelnummer] = '{tafelnummer}' AND datum >= CAST (GETDATE() AS DATE)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Order> orders = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            foreach (Order O in orders)
            {
                O.orderItemList = Orderitems_DAO.Db_Get_All_Orderitems_for_Order(O.orderNummer);
            }
            return orders;
        }


        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int tafelnummer = (int)dr["tafelnummer"];
                int personeelnummer = (int)dr["personeelnummer"];
                List<Tafel> tafels = tafel_db.GetTafel_for_Order(tafelnummer);
                List<Personeels_Lid> personeelsleden = personeel_db.GetPersoneel_for_Order(personeelnummer);
                Tafel Tafel = tafels[0];
                Personeels_Lid Personeel = personeelsleden[0];

                Order order = new Order()
                {
                    // Alle members van class order worden uit de database opgehaald uit de rijen
                    orderNummer = (int)dr["ordernummer"],
                    personeel = Personeel,
                    tafel = Tafel,
                    datum = (DateTime)dr["datum"]
                };
                orders.Add(order);
            }

            return orders;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class OrderDao: BaseDao
    {
        public void CreateOrder(Student student, Drink drink)
        {
            OpenConnection();
            string query = $"INSERT INTO Buy (StudentNumber, DrinkID, DrinkPrice) VALUES ({student.Number}, {drink.ID}, {drink.Price})";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

            CloseConnection();
        }

        public List<Order> GetAllOrders()
        {
            string query = "SELECT OrderID, DrinkID, DrinkPrice FROM Buy";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadOrders(DataTable dataTable)
        {
            List<Order> orderList = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order orders = new Order()
                {
                    OrderId = (int)dr["OrderID"],
                    DrinkID = (int)(dr["DrinkID"]),
                    Price = (int)(dr["DrinkPrice"]),

                };
                orderList.Add(orders);
            }
            return orderList;
        }
    }
}

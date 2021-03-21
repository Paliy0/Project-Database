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
            string query = $"INSERT INTO Buy (StudentNumber, DrinkID) VALUES ({student.Number}, {drink.ID})";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

            CloseConnection();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class DrinksDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT DrinkName, DrinkPrice, DrinkStock FROM [DRINKS] " +
                           "WHERE DrinkStock > 1 AND DrinkPrice > 1 " +
                           "ORDER BY DrinkStock, DrinkPrice";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinkList = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drinks = new Drink()
                {
                    Token = (int)dr["DrinkPrice"],
                    Name = (String)(dr["DrinkName"]),
                    Stock = (int)dr["DrinkStock"],

                };
                drinkList.Add(drinks);
            }
            return drinkList;
        }
    }
}
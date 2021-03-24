using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace SomerenDAL
{
    public class ActivitiesDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT ActivityID, ActivityDescription, StartDateTime, EndDateTime FROM [ACTIVITIES]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> ActivityList = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {

                Activity activities = new Activity()
                {
                    ID = (int)dr["DrinkID"],
                    Description = (string)dr["DrinkPrice"],
                    StartDate = (DateTime)(dr["DrinkName"]),
                    EndDate = (DateTime)(dr["DrinkName"]),

                };
                ActivityList.Add(activities);
            }
            return ActivityList;
        }



    }
}

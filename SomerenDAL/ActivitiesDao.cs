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
                    ID = (int)dr["ActivityID"],
                    Description = (string)dr["ActivityDescription"],
                    StartDate = (DateTime)(dr["StartDateTime"]),
                    EndDate = (DateTime)(dr["EndDateTime"]),

                };
                ActivityList.Add(activities);
            }
            return ActivityList;
        }

        public void Change(Activity activities)
        {
            string query = ("UPDATE ACTIVITIES SET ActivityDescription = @ActivityDescription, StartDateTime = @StartDateTime," +
                "EndDateTime = @EndDateTime WHERE ActivityID =@ActivityID ");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Delete(Activity activities)
        {
            string query = ("DELETE FROM ACTIVITIES WHERE ActivityID =@ActivityID ");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Add(Activity activities)
        {
            string query = ("INSERT INTO ACTIVITIES (ActivityDescription, StartDateTime, EndDateTime)" +
                "VALUES (@ActivityDescription, @StartDateTime, @EndDateTime) ");
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}

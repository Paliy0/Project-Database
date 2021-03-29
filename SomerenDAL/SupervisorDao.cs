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
    public class SupervisorDao : BaseDao
    {
        public List<Supervisor> GetAllSupervisors()
        {
            string query = "SELECT activityID, ActivitySupervisor.TeacherID, TEACHERS.TeacherName, TEACHERS.TeacherLastName FROM ActivitySupervisor JOIN TEACHERS ON TEACHERS.TeacherID = ActivitySupervisor.TeacherID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Supervisor> ReadTables(DataTable dataTable)
        {
            List<Supervisor> SupervisorList = new List<Supervisor>();

            foreach (DataRow dr in dataTable.Rows)
            {

                Supervisor supervisor = new Supervisor()
                {
                    ActivityId = (int)dr["ActivityID"],
                    TeacherID = (int)dr["TeacherID"],
                    FirstName = (string)(dr["TeacherName"]),
                    LastName = (string)(dr["TeacherLastName"]),

                };
                SupervisorList.Add(supervisor);
            }
            return SupervisorList;
        }

        public void AddSupervisor(Teacher supervisor, Activity activity)
        {
            string query = "INSERT INTO [ActivitySupervisor] (ActivityID, TeacherID) Values(@activity_Id, @teacher_Id)";

            SqlParameter[] paramaters = {
                new SqlParameter("ActivityID", activity.ID),
                new SqlParameter("TeacherID", supervisor.Supervisor),
            };
            ExecuteEditQuery(query, paramaters);
        }

        public void RemoveSupervisor(Supervisor supervisor, Activity activity)
        {
            string query = "DELETE FROM [ActivitySupervisor] WHERE ActivityID = @teacher_Id AND TeacherID = @teacher_Id";
            SqlParameter[] parameters =
            {
                new SqlParameter("ActivityID", activity.ID),
                new SqlParameter("TeacherID", supervisor.TeacherID),
            };
            ExecuteEditQuery(query, parameters);

        }
    }
}

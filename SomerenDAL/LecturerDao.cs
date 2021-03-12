using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class LecturerDao : BaseDao
    {
        public List<Teacher> GetAllLecturers()
        {
            string query = "SELECT TeacherID, TeacherName, TeacherLastName, TeacherSupervisor FROM [TEACHERS]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    Number = (int)dr["TeacherID"],
                    Name = (String)(dr["TeacherName"]),
                    LastName = (String)(dr["TeacherLastName"]),
                    Supervisor = (String)(dr["TeacherSupervisor"])
                };
                teachers.Add(teacher);
            }
            return teachers;
        }

    }
}

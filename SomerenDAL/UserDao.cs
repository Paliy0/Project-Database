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
    public class UserDao : BaseDao
    {
        public List<User> GetAllUsers()
        {
            User user = new User();

            string query = "SELECT userName, password FROM [User]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }


        private List<User> ReadTables(DataTable dataTable)
        {
            List<User> users = new List<User>();

            foreach (DataRow dr in dataTable.Rows)
            {
                User user = new User()
                {
                    Username = (string)dr["userName"],
                    Password = (string)(dr["password"]),
                    SecretQuestion = (string)(dr["secretQuestion"]),
                    SecretAnswer = (string)(dr["secretAnswer"]),
                    Admin = (bool)(dr["Admin"])
                };
                users.Add(user);
            }
            return users;
        }

        public User userLogin(string username, string password)
        {
            string query = "SELECT userName, password, secretQuestion, secretAnswer, Admin FROM [User] " +
                           "WHERE userName = @username, password = @password";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("username", username),
                new SqlParameter("password", password)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public void AddUser(User user)
        {
            string query = "INSERT INTO [Users] (Username, Password, SecretQuestion, SecretAnswer, Admin) " +
                            "Values (@username, @password, @salt, @secretQuestion, @secretAnswer, @Admin) ";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("username", user.Username),
                new SqlParameter("password", user.Password),
                new SqlParameter("salt", user.Salt),
                new SqlParameter("secretQuestion", user.SecretQuestion),
                new SqlParameter("secretAnswer", user.SecretAnswer),
                new SqlParameter("Admin", user.Admin)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void EditPassword(string userName, string password)
        {
            string query = "UPDATE [Users] SET Password = @password, WHERE Username = @username";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("username", userName),
                new SqlParameter("password", password)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void ForgotPassword(string userName, string password)
        {

        }
    }
}

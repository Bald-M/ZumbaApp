using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZumbaApp.Models;

namespace ZumbaApp.DataAccess
{
    class ReadDB
    {
        public static List<UserCredentials> ReadUserCredentials()
        {
            List<UserCredentials> results = new List<UserCredentials>();
            string query = "SELECT * FROM UserCredentials";
            OdbcConnection connection = Utils.DBConnection();
            OdbcCommand command = new OdbcCommand(query, connection);
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Utils.GetInt(reader["ID"]);
                string username = Utils.GetString(reader["UserName"]);
                string password = Utils.GetString(reader["Password"]);
                results.Add(new UserCredentials(id, username, password));
            }
            return results;
        }

        public static List<Member> ReadMember()
        {
            List<Member> results = new List<Member>();
            string query = "SELECT * FROM Member";
            OdbcConnection connection = Utils.DBConnection();
            OdbcCommand command = new OdbcCommand(query, connection);
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Utils.GetInt(reader["ID"]);
                string name = Utils.GetString(reader["FullName"]);
                string dob = Utils.GetString(reader["DOB"]);
                results.Add(new Member(id, name, dob));
            }
            return results;
        }

        public static List<Class> ReadClass()
        {
            List<Class> results = new List<Class>();
            string query = "SELECT * FROM Class";
            


            return results;
        }
    }
}

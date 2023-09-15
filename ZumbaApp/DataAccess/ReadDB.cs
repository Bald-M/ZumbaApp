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
            OdbcConnection connection = Utils.DBConnection();
            OdbcCommand command = new OdbcCommand(query, connection);
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Utils.GetInt(reader["ID"]);
                string type = Utils.GetString(reader["Type"]);
                string address = Utils.GetString(reader["Address"]);
                int danceLevel = Utils.GetInt(reader["DanceLevel"]);
                int workoutLevel = Utils.GetInt(reader["WorkoutLevel"]);
                string musicStyle = Utils.GetString(reader["MusicStyle"]);
                results.Add(new Class(id, type, address, danceLevel,workoutLevel,musicStyle));
            }
            return results;
        }

        public static List<Attendance> ReadAttendance()
        {
            List<Attendance> results = new List<Attendance>();
            string query = "SELECT * FROM Attendance";
            OdbcConnection connection = Utils.DBConnection();
            OdbcCommand command = new OdbcCommand(query, connection);
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Utils.GetInt(reader["ID"]);
                int memberId = Utils.GetInt(reader["Member_ID"]);
                int classId = Utils.GetInt(reader["Class_ID"]);
                string attendanceDate = Utils.GetString(reader["AttendanceDate"]);
                bool attended = Utils.GetBool(reader["Attended"]);
                
                results.Add(new Attendance(id,memberId, classId, attendanceDate, attended));
            }
            return results;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZumbaApp.DataAccess
{
    class WriteDB
    {
        public static void WriteToUserTable(int userCredentialsId)
        {
            OdbcConnection connection = Utils.DBConnection();
            string query = $"INSERT INTO User(FullName,DOB,Selfie,UserCredential_ID) VALUES(?,?,?,?)";
            OdbcCommand command = new OdbcCommand(query, connection);
            command.Parameters.AddWithValue(@"FullName", "ZihanZhang");
            command.Parameters.AddWithValue(@"DOB", "2002/06/28");
            command.Parameters.AddWithValue(@"Selfie", "/img.png");
            command.Parameters.AddWithValue(@"UserCredential_ID", userCredentialsId);
            

            command.ExecuteNonQuery();
        }
    }
}

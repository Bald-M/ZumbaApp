using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZumbaApp.Models;


namespace ZumbaApp.DataAccess
{
    class Utils
    {
        
        public static readonly string BAD_STRING = string.Empty;
        public static readonly int BAD_INT = Int32.MinValue;
        public static readonly double BAD_DOUBLE = Double.MinValue;

        public static int GetInt(object o)
        {
            if (o == null) return BAD_INT;
            int n;
            if (int.TryParse(o.ToString(), out n) == false)
            {
                return BAD_INT;
            }
            return n;
        }

        public static double GetDouble(object o)
        {
            if (o == null) return BAD_DOUBLE;
            double n;
            if (double.TryParse(o.ToString(), out n) == false)
            {
                return BAD_DOUBLE;
            }
            return n;
        }

        public static string GetString(object o)
        {
            if (o != null)
            {
                string? n = o.ToString();
                if (n != null)
                {
                    return n;
                }
            }

            return BAD_STRING;
        }

        public static bool GetBool(object o)
        {
            if (o == null) return false;
            bool result;

            if (bool.TryParse(o.ToString(), out result))
            {
                return result;
            }

            return false; 
        }

        public static OdbcConnection DBConnection()
        {
            string? dbStr = ConfigurationManager.AppSettings.Get("odbcString");
            string dbPath = "../../../Zumba.accdb";
            string connectionString = dbStr + dbPath;
            try
            {
                OdbcConnection connection = new OdbcConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (OdbcException e)
            {
                Console.WriteLine("Connection Failure.Error message below:");
                Console.WriteLine(e.Message);
                return null;
            }
        }

        
    }
}

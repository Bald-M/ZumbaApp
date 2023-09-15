using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ZumbaApp.DataAccess;
using ZumbaApp.Models;

namespace ZumbaApp.Tests
{
    class App
    {
        public static List<UserCredentials> userCredentials = new List<UserCredentials>();
        public static List<Member> members = new List<Member>();
        public static List<Class> classes = new List<Class>();
        public static List<Attendance> attendances = new List<Attendance>();
        public App() 
        {
            userCredentials = ReadDB.ReadUserCredentials();
            members = ReadDB.ReadMember();
            classes = ReadDB.ReadClass();
            attendances = ReadDB.ReadAttendance();
        }

        // Validation
        public static bool ValidateCredentials(string inputUsername, string inputPassword)
        {
            foreach (var credential in userCredentials)
            {
                if (credential.UserName == inputUsername && credential.Password == inputPassword)
                {
                    // 验证成功，返回true
                    return true;
                } else
                {
                    Console.WriteLine(credential.UserName);
                }
            }

            // 验证失败，返回false
            
            return false;
        }

        // Instancing all member
        public static void InstanceMembersObj()
        {
            for (int i = 0; i < attendances.Count; i++)
            {
                Console.WriteLine($"{attendances[i].Id} {attendances[i].MemberID} {attendances[i].ClassID} {attendances[i].Date} {attendances[i].Attended}");
            }
        }
    }
}

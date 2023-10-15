using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZumbaApp.Models
{
    internal class Attendance
    {
        public int Id { get; set; }
        public int MemberID { get; set; }
        public int ClassID { get; set; }
        public string Date { get; set; }
        public bool Attended { get; set; }
        

        // Assoicate with Member class
        public Member Member { get; set; }
        // Associate with Class class
        public Class Class { get; set; }

        public Attendance(int id,int memberid,int classid,string date,bool attended,Member member,Class classIns) 
        { 
            this.Id = id;
            this.MemberID = memberid;
            this.ClassID = classid;
            this.Date = date;
            this.Attended = attended;
            this.Member = member;
            this.Class = classIns;
        }

        public Attendance(int id, int memberid, int classid, string date, bool attended)
        {
            this.Id = id;
            this.MemberID = memberid;
            this.ClassID = classid;
            this.Date = date;
            this.Attended = attended;
        }
    }
}

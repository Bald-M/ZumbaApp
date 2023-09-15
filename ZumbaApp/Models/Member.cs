using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZumbaApp.Models
{
    class Member
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string DOB { get; set; }
        public string Selfie { get; set; }
        public Member(int id,string name,string dob)
        {
            this.Id = id;
            this.FullName = name;
            this.DOB = dob;
            this.Selfie = "placeholder";
        }

    }
}

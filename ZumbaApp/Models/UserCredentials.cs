using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZumbaApp.Models
{
    class UserCredentials
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserCredentials(int id, string name, string passwd)
        {
            this.Id = id;
            this.UserName = name;
            this.Password = passwd;
        }
    }
}

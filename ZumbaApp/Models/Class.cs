using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZumbaApp.Models
{
    internal class Class
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public int DanceLevel { get; set; }
        public int WorkoutLevel { get; set; }
        public string MusicStyle { get; set; }
        public Class(int id,string type,string address,int dancelevel,int workoutlevel,string musicstyle)
        {
            this.Id = id;
            this.Type = type;
            this.Address = address;
            this.DanceLevel = dancelevel;
            this.WorkoutLevel = workoutlevel;
            this.MusicStyle = musicstyle;
        }
    }
}

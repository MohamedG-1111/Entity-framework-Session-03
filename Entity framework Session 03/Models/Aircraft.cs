using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_framework_Session_03.Models
{
    public class Aircraft
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string Model { get; set; }
        public int AL_Id { get; set; }
        public Airline Airline { get; set; } = null!;

        public Crew Crew { get; set; }= null!;

        public ICollection<Aircraft_Route> Air_Routes= new List<Aircraft_Route>();
    }
}

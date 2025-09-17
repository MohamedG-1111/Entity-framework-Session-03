using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_framework_Session_03.Models
{
    public class Aircraft_Route
    {
        public int AC_Id { get; set; }
        public int Route_Id { get; set; }
        public DateTime Departure { get; set; }
        public int Num_Of_Pass { get; set; }
        public decimal Price { get; set; }
        public DateTime Arrival { get; set; }

        public Aircraft aircraft { get; set; } = null!;
        public Route route { get; set; } = null!;
    }

}

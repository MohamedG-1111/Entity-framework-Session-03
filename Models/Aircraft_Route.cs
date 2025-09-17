using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineEF.Models
{
    public class Aircraft_Route
    {
        [Key]
        public int AC_Id { get; set; }
        public int Route_Id { get; set; }
        public DateTime Departure { get; set; }
        public int Num_Of_Pass { get; set; }
        public decimal Price { get; set; }
        public DateTime Arrival { get; set; }
    }

}

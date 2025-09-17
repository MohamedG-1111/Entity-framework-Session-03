using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineEF.Models
{
    public class Airline
    {
        [Key]
        public int AirLineId { get; set; }
        [MinLength(5)]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Cont_person { get; set; }
    }
}

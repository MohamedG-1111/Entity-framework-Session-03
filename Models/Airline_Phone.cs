using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineEF.Models
{
    public class Airline_Phone
    {
        [Key]
        public int AL_Id { get; set; }
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string Phones { get; set; }
    }

}

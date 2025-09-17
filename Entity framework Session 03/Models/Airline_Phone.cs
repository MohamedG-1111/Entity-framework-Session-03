using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entity_framework_Session_03.Models
{
    [PrimaryKey(nameof(AL_Id),nameof(Phones))]
    public class Airline_Phone
    {
        [ForeignKey(nameof(Airline))]
        public int AL_Id { get; set; }
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string Phones { get; set; }
        [InverseProperty(nameof(Airline.airline_Phones))]
        public Airline Airline { get; set; } = null!;

    }

}

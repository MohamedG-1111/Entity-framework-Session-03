using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_framework_Session_03.Models
{
    public class Airline
    {
        [Key]
        public int AirLineId { get; set; }
        [MinLength(5)]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Cont_person { get; set; }


        public ICollection<Aircraft> Aircrafts { get; set; } =new List<Aircraft>();   
        public ICollection<Employee> Employees { get; set; } =new List<Employee>();

        [InverseProperty(nameof(Transaction.Airline))]
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

        [InverseProperty(nameof(Airline_Phone.Airline))]
       public ICollection<Airline_Phone> airline_Phones { get; set; } =new List<Airline_Phone>();
    }
}

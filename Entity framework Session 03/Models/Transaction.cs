using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_framework_Session_03.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public string Description { get; set; }
        public decimal Amout { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey(nameof(Airline))]
        public int AL_Id { get; set; }

        [InverseProperty(nameof(Airline.Transactions))]
        public Airline Airline { get; set; } = null!;
    }
}

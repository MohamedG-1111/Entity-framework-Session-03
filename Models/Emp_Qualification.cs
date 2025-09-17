using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineEF.Models
{
    public class Emp_Qualification
        {
        [Key]
        public int Emp_Id { get; set; }
 
        public string Qualifications { get; set; }
    }

}

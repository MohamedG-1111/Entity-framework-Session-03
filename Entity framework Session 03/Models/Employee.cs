using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_framework_Session_03.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public int BD_Year { get; set; }
        public int BD_Month { get; set; }
        public int BD_Day { get; set; }
        public int AL_Id { get; set; }

        public Airline Airline { get; set; } = null!;
        [InverseProperty(nameof(Emp_Qualification.Employee))]
        public ICollection<Emp_Qualification> EmpQualifications { get; set; }=new HashSet<Emp_Qualification>();
    }
}

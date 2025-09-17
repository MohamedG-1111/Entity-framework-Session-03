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
    [PrimaryKey(nameof(Emp_Id),nameof(Qualifications))]
    public class Emp_Qualification
    {
        [ForeignKey(nameof(Employee))]
        public int Emp_Id { get; set; }

        public string Qualifications { get; set; } = null!;
        [InverseProperty(nameof(Employee.EmpQualifications))]   
        public Employee Employee { get; set; } = null!;

    }

}

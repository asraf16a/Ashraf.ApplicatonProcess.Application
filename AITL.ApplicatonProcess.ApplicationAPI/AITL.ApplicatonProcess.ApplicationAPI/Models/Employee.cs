using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AITL.ApplicatonProcess.ApplicationAPI.Models
{
    public class Employee
    {
        [Key]
        public int EmpoyeeId { get; set; }
        [Column(TypeName="nvarchar(100)")]
        public string EmployeeName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string FamilyName { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Address { get; set; }
        [Column(TypeName = "nvarchar(60)")]
        public string CountryOfOrigin { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string EmailAddress { get; set; }
        public int Age { get; set; }
        public bool Hired { get; set; }

    }
}

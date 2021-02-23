using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AITL.ApplicatonProcess.ApplicationAPI.Models
{
    public class EmployeeDetailsContext:DbContext
    {
        public EmployeeDetailsContext(DbContextOptions<EmployeeDetailsContext> option):base(option)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}

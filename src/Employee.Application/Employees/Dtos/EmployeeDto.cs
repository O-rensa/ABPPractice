using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Employees.Dtos
{
    public class EmployeeDto: Entity<int?>
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Position { get; set; }
        public int DRate { get; set; }
    }
}

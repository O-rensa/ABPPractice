using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Employees
{
    [Table("EmployeeTable")]
    public class EmployeeEntity: FullAuditedEntity<int>
    {
        public virtual string FName { get; set; }
        public virtual string LName { get; set; }
        public virtual string Position { get; set; }
        public virtual int DRate { get; set;}
    }
}

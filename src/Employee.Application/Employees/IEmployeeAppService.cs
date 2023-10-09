using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Employees.Dtos;

namespace Employee.Employees
{
    public interface IEmployeeAppService
    {
        Task<List<EmployeeDto>> GetAll();
        Task<int> Create(EmployeeDto input);
        Task<int> Update(EmployeeDto input);
        Task Delete(int id);
    }
}

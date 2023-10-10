using Abp.Authorization;
using Abp.Domain.Repositories;
using Employee.Authorization;
using Employee.Employees.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Employees
{
    //[AbpAuthorize(PermissionNames.Pages_Employees)]
    public class EmployeeAppService: EmployeeAppServiceBase, IEmployeeAppService
    {
        private readonly IRepository<EmployeeEntity, int> _employeeRepository;

        public EmployeeAppService(IRepository<EmployeeEntity, int> employeeRepository)
        {
            this._employeeRepository = employeeRepository;

        }
       public async Task<List<EmployeeDto>> GetAll()
        {
            var employees = await _employeeRepository.GetAll().ToListAsync();
            var show = new List<EmployeeDto>();
            foreach (var employee in employees)
            {
                show.Add(this.ObjectMapper.Map<EmployeeDto>(employee));
            }
            return show;
        }

        public async Task<EmployeeDto> GetEmployeeById(int input)
        {
            var employee = await this._employeeRepository.FirstOrDefaultAsync(input);
            var result = this.ObjectMapper.Map<EmployeeDto>(employee);
            return result;
        }
    
        public async Task<int> Create(EmployeeDto input) 
        {
            var employee = this.ObjectMapper.Map<EmployeeEntity>(input);
            return await _employeeRepository.InsertAndGetIdAsync(employee);
        }
        public async Task<int> Update(EmployeeDto input)
        { 
            // The var employee came from Database so it is EmployeeEntity Datatype
            var copy = this.ObjectMapper.Map<EmployeeEntity>(input);
            var result = await _employeeRepository.InsertOrUpdateAndGetIdAsync(copy);
            return result;
        }
        public async Task Delete(int id)
        {
            await this._employeeRepository.DeleteAsync(id);
        }
    }
}

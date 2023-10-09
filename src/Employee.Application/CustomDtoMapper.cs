using AutoMapper;
using Employee.Employees;
using Employee.Employees.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<EmployeeEntity, EmployeeDto>().ReverseMap();
            //configuration.CreateMap<EmployeeDto, EmployeeEntity>();
        }
    }
}

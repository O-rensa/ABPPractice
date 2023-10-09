using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Employee.Authorization.Roles;
using Employee.Authorization.Users;
using Employee.MultiTenancy;
using Employee.Employees;

namespace Employee.EntityFrameworkCore
{
    public class EmployeeDbContext : AbpZeroDbContext<Tenant, Role, User, EmployeeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<EmployeeEntity> Employees { get; set; }
        
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }
    }
}

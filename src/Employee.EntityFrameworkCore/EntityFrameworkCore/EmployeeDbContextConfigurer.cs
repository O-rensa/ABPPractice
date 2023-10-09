using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Employee.EntityFrameworkCore
{
    public static class EmployeeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EmployeeDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EmployeeDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

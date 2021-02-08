using EmployeeControl.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeControl.Data
{
    public class AppContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmployeeControlDB;Integrated Security=True;");
        }
    }
}

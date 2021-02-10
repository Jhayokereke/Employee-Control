using EmployeeControl.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeControl.Data
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmployeeControlDB;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>()
                .HasOne<Department>(d => d.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(fk => fk.DepartmentId);


            #region Properties
            builder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(32);

            builder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(32);

            builder.Entity<Employee>()
                .Property(e => e.State)
                .IsRequired()
                .HasMaxLength(32);

            builder.Entity<Employee>()
                .Property(e => e.Email)
                .IsRequired();

            builder.Entity<Employee>()
                .Property(e => e.Phonenumber)
                .IsRequired()
                .HasMaxLength(14);
            #endregion
        }
    }
}

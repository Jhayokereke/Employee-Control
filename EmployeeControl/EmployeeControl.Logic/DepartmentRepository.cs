using EmployeeControl.Data;
using EmployeeControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeControl.Logic
{
    class DepartmentRepository : IDepartmentRepository
    {
        private readonly EmployeeContext context;

        public DepartmentRepository()
        {
            context = new EmployeeContext();
        }

        public List<Department> GetAllDepartments()
        {
            List<Department> departments = context.Departments.ToList();
            return departments;
        }

        public List<Department> GetAllUnassignedDepartments()
        {
            List<Department> departments = context.Departments.Where(d => d.Employees.Count == 0).ToList();
            return departments;
        }

        public void SetDepartment(Department department)
        {
            context.Departments.Add(department);
            context.SaveChanges();
        }

        public Department GetDepartment(string departmentname)
        {
            Department department = context.Departments.Where(d => d.DepartmentName == departmentname).FirstOrDefault();
            return department;
        }
    }
}

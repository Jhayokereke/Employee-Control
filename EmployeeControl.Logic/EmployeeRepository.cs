using EmployeeControl.Data;
using EmployeeControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeControl.Logic
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext context;

        public EmployeeRepository()
        {
            context = new EmployeeContext();
        }

        public void CreateNewEmployee(string firstname, string lastname, string email, string phonenumber, 
                                         DateTime hiredate, Department department, int salary, string state)
        {
            Employee employee = new Employee()
            {
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Phonenumber = phonenumber,
                HireDate = hiredate,
                Department = department,
                DepartmentId = department.DepartmentId,
                Salary = salary,
                State = state
            };
            context.Employees.Add(employee);
            context.SaveChanges();
        }
        public List<Employee> GetStaffsByDepartment(string department)
        {
            List<Employee> employees;
            employees = context.Employees.Where(e => e.Department.DepartmentName == department).ToList();
            return employees;
        }

        public Employee GetEmployee(int employeeid)
        {
            Employee employee = context.Employees.Where(e => e.EmployeeId == employeeid).FirstOrDefault();
            return employee;
        }

        public void UpdateEmployee(int employeeid, string firstname, string lastname, string email, string phonenumber,
                                         DateTime hiredate, Department department, int salary, string state)
        {
            Employee employee = GetEmployee(employeeid);
            if (!string.IsNullOrWhiteSpace(firstname))
            {
                employee.FirstName = firstname;
            }
            if (!string.IsNullOrWhiteSpace(lastname))
            {
                employee.LastName = lastname;
            }
            
            employee.Email = email;
            employee.Phonenumber = phonenumber;
            employee.HireDate = hiredate;
            employee.Department = department;
            employee.DepartmentId = department.DepartmentId;
            employee.Salary = salary;
            employee.State = state;
            context.SaveChanges();
        }

        public void DeleteEmployee(int employeeid)
        {
            Employee employee = context.Employees.Where(e => e.EmployeeId == employeeid).FirstOrDefault();
            context.Remove(employee);
            context.SaveChanges();
        }

        public List<Employee> GetEmployeesBySalaryRange(int upper, int lower)
        {
            List<Employee> employees;
            employees = context.Employees.Where(e => e.Salary >= lower && e.Salary <= upper).ToList();
            return employees;
        }

        public Dictionary<string, List<Employee>> GetEmployeesInGroup()
        {
            Dictionary<string, List<Employee>> employeesInDept = new Dictionary<string, List<Employee>>();
            List<Employee> employees = GetAllEmployees();
            foreach (var employee in employees)
            {
                if (employeesInDept.ContainsKey(employee.Department.DepartmentName))
                {
                    employeesInDept[employee.Department.DepartmentName].Add(employee);
                }
                else
                {
                    employeesInDept.Add(employee.Department.DepartmentName, new List<Employee>() { employee });
                }
            }
            return employeesInDept;
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees;
            employees = context.Employees.ToList();
            return employees;
        }
    }
}

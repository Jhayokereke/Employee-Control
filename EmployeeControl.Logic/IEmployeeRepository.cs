using EmployeeControl.Model;
using System;
using System.Collections.Generic;

namespace EmployeeControl.Logic
{
    public interface IEmployeeRepository
    {
        void CreateNewEmployee(string firstname, string lastname, string email, string phonenumber, DateTime hiredate, Department department, int salary, string state);
        void DeleteEmployee(int employeeid);
        List<Employee> GetAllEmployees();
        Employee GetEmployee(int employeeid);
        List<Employee> GetEmployeesBySalaryRange(int upper, int lower);
        Dictionary<string, List<Employee>> GetEmployeesInGroup();
        List<Employee> GetStaffsByDepartment(string department);
        void UpdateEmployee(int employeeid, string firstname, string lastname, string email, string phonenumber, DateTime hiredate, Department department, int salary, string state);
    }
}
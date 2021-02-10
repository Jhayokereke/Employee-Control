using EmployeeControl.Model;
using System.Collections.Generic;

namespace EmployeeControl.Logic
{
    public interface IDepartmentRepository
    {
        List<Department> GetAllDepartments();
        List<Department> GetAllUnassignedDepartments();
        Department GetDepartment(string departmentname);
    }
}
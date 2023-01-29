using EmployeeControl.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeControl.Logic
{
    public static class GlobalConfig
    {
        private static Dictionary<string, object> InstantiatedClasses { get; set; } = new Dictionary<string, object>
        {
            { "@EmployeeRepository", new EmployeeRepository()},
            { "@DepartmentRepository", new DepartmentRepository() },
            { "@Employee", new Employee() },
            { "@Department", new Department() }
        };
        public static object NewObject(string objectType)
        {
            var newInstance = InstantiatedClasses[objectType];
            return newInstance;
        }
    }
}

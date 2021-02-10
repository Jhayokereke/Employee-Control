using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeControl.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [MinLength(1, ErrorMessage = "Field cannot be empty")]
        public string FirstName { get; set; }
        [MinLength(1, ErrorMessage = "Field cannot be empty")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Not a valid email address.")]
        public string Email { get; set; }
        public string State { get; set; }
        [RegularExpression(@"^\+234\{10}$", ErrorMessage = "Number must be 14 digits with a countrycode affixed to it.")]
        public string Phonenumber { get; set; }
        public DateTime HireDate { get; set; }
        public double Salary { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
}

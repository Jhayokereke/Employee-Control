using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeControl.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Phonenumber { get; set; }
        public DateTime HireDate { get; set; }
        public double Salary { get; set; }
        public int DepartmentId { get; set; }
    }
}

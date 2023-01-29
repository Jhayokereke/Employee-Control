using EmployeeControl.Logic;
using EmployeeControl.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeeControl.UI
{
    public partial class View : Form
    {
        public IEmployeeRepository employeeRepository;
        public IDepartmentRepository departmentRepository;
        public View()
        {
            InitializeComponent();
            employeeRepository = (IEmployeeRepository)GlobalConfig.NewObject("@EmployeeRepository");
            departmentRepository = (IDepartmentRepository)GlobalConfig.NewObject("@DepartmentRepository");
        }

        public static string OutputSchema1(Employee employee)
        {
            string output = $"Employee ID: {employee.EmployeeId}" +
                $"\nName: {employee.FirstName} {employee.LastName}." +
                $"\nEmail: {employee.Email}" +
                $"\nState: {employee.State}" +
                $"\nPhoneNumber: {employee.Phonenumber}" +
                $"\nHire Date: {employee.HireDate}" +
                $"\nSalary: {employee.Salary}" +
                $"\nDepartment: {employee.Department.DepartmentName}" +
                $"\n===============================================================" +
                $"\n";
            return output;
        }

        private void view_all_emp_Click(object sender, EventArgs e)
        {
            List<Employee> employees = employeeRepository.GetAllEmployees();
            foreach (var employee in employees)
            {
                richTextBox1.Text += OutputSchema1(employee);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void view_by_dept_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<Employee>> employeesByDept = employeeRepository.GetEmployeesInGroup();
            foreach (var pair in employeesByDept)
            {
                richTextBox1.Text += $"Department: {pair.Key}\n";
                foreach (var employee in pair.Value)
                {
                    richTextBox1.Text += OutputSchema1(employee);
                }
            }
        }

        private void view_by_salary_Click(object sender, EventArgs e)
        {
            List<Employee> employeesInRange = employeeRepository.GetEmployeesBySalaryRange(150000, 300000);
            foreach (var employee in employeesInRange)
            {
                richTextBox1.Text += OutputSchema1(employee);
            }
        }

        private void view_all_everything_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Departments:\n" +
                "-----------\n";
            List<Department> departments = departmentRepository.GetAllDepartments();
            foreach (var department in departments)
            {
                richTextBox1.Text += $"{department.DepartmentName}\n";
            }
            richTextBox1.Text += "\nEmployees:\n" +
                "---------";
            List<Employee> employees = employeeRepository.GetAllEmployees();
            foreach (var employee in employees)
            {
                richTextBox1.Text += OutputSchema1(employee);
            }
        }

        private void view_unassigned_Click(object sender, EventArgs e)
        {
            List<Department> departments = departmentRepository.GetAllUnassignedDepartments();
            richTextBox1.Text = "Unassigned Departments:\n";
            foreach (var department in departments)
            {
                richTextBox1.Text += $"{department.DepartmentName}\n";
            }
        }

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}

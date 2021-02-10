using EmployeeControl.Logic;
using EmployeeControl.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeControl.UI
{
    public partial class UpdateOld : Form
    {
        public IEmployeeRepository employeeRepository;
        public IDepartmentRepository departmentRepository;
        public UpdateOld()
        {
            InitializeComponent();
            employeeRepository = (IEmployeeRepository)GlobalConfig.NewObject("@EmployeeRepository");
            departmentRepository = (IDepartmentRepository)GlobalConfig.NewObject("@DepartmentRepository");
        }

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Department department = departmentRepository.GetDepartment(dept.SelectedItem.ToString());
            employeeRepository.UpdateEmployee(fname.Text, lname.Text, email.Text, pnumber.Text, hiredate.Value, department, int.Parse(salary.Text), state.Text);
        }
    }
}

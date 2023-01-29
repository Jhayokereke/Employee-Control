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
    public partial class Settings : Form
    {
        public IDepartmentRepository departmentRepository;
        public Settings()
        {
            InitializeComponent();
            departmentRepository = (IDepartmentRepository)GlobalConfig.NewObject("@DepartmentRepository");
        }

        private void add_new_Click(object sender, EventArgs e)
        {
            Department department = new Department()
            {
                DepartmentName = dept.Text
            };
            departmentRepository.SetDepartment(department);
        }

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}

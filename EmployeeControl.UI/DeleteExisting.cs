using EmployeeControl.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeControl.UI
{
    public partial class DeleteExisting : Form
    {
        public IEmployeeRepository employeeRepository;
        public DeleteExisting()
        {
            InitializeComponent();
            employeeRepository = (IEmployeeRepository)GlobalConfig.NewObject("@EmployeeRepository");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            employeeRepository.DeleteEmployee(int.Parse(id.Text));
        }

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}

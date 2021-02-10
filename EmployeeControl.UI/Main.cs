using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeControl.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void view_Click(object sender, EventArgs e)
        {
            View v = new View();
            Hide();
            v.ShowDialog();
            Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            UpdateOld u = new UpdateOld();
            Hide();
            u.ShowDialog();
            Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteExisting d = new DeleteExisting();
            Hide();
            d.ShowDialog();
            Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, we are yet to implement this function");
        }
    }
}

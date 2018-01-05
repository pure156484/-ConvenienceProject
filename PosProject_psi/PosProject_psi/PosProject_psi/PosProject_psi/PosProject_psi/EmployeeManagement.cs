using PosProject_psi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonProject
{
    public partial class EmployeeManagement : Form
    {
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            employeeGridView.ColumnCount = 6;
            employeeGridView.Columns[0].Name = "NO";
            employeeGridView.Columns[1].Name = "직원명";
            employeeGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            employeeGridView.Columns[2].Name = "직책";
            employeeGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            employeeGridView.Columns[3].Name = "주소";
            employeeGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            employeeGridView.Columns[4].Name = "전화번호";
            employeeGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            employeeGridView.Columns[5].Name = "주민번호";
            employeeGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            EmployeeAdd ea = new EmployeeAdd();
            ea.Show();
        }
    }
}
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
            EmployeeGridView.ColumnCount = 6;
            EmployeeGridView.Columns[0].Name = "NO";
            EmployeeGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeGridView.Columns[1].Name = "직원명";
            EmployeeGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeGridView.Columns[2].Name = "직책";
            EmployeeGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeGridView.Columns[3].Name = "주소";
            EmployeeGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeGridView.Columns[4].Name = "전화번호";
            EmployeeGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmployeeGridView.Columns[5].Name = "주민번호";
            EmployeeGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            EmployeeAdd ea = new EmployeeAdd();
            ea.Show();
        }
    }
}
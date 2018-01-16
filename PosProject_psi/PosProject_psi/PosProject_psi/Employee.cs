using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProject
{
    class Employee
    {
        private int employee_num;

        public int Employee_Num
        {
            get { return employee_num; }
            set { employee_num = value; }
        }

        private string employee_name;

        public string Employee_Name
        {
            get { return employee_name; }
            set { employee_name = value; }
        }

        private string employee_phone;

        public string Employee_Phone
        {
            get { return employee_phone; }
            set { employee_phone = value; }
        }

        private string employee_position;

        public string Employee_Position
        {
            get { return employee_position; }
            set { employee_position = value; }
        }

        private string employee_address;

        public string Employee_Address
        {
            get { return employee_address; }
            set { employee_address = value; }
        }

        private int employee_salary;

        public int Employee_Salary
        {
            get { return employee_salary; }
            set { employee_salary = value; }
        }

        private int employee_hours;

        public int Employee_Hours
        {
            get { return employee_hours; }
            set { employee_hours = value; }
        }

        private int myemployee_total_salary;

        public int Employee_Total_Salary
        {
            get { return myemployee_total_salary; }
            set { myemployee_total_salary = value; }
        }

        private string employee_pk;

        public string Employee_Pk
        {
            get { return employee_pk; }
            set { employee_pk = value; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProject
{
    class Employee
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string position;

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        private string securitynum;

        public string SecurityNum
        {
            get { return securitynum; }
            set { securitynum = value; }
        }
    }
}
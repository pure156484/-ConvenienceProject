using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonProject
{
    class Membership
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        private string birth;

        public string Birth
        {
            get { return birth; }
            set { birth = value; }
        }
    }
}
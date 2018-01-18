using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosProject_psi
{
    class productAdd
    {
        private string barcode;
        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int select;
        public int Select
        {
            get { return select; }
            set { select = value; }
        }

        private int unit_price;
        public int Unit_price
        {
            get { return unit_price; }
            set { unit_price = value; }
        }

        private int cust_price;
        public int Cust_price
        {
            get { return cust_price; }
            set { cust_price = value; }
        }

        

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private Bitmap img;
        public Bitmap Img
        {
            get { return img; }
            set { img = value; }
        }

        private int event_num;
        public int Event_num
        {
            get { return event_num; }
            set { event_num = value; }
        }
    }
}

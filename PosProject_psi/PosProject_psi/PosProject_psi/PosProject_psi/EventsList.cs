using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosProject_psi
{
    class EventsList
    {
        private int event_num;

        public int Event_Num
        {
            get { return event_num; }
            set { event_num = value; }
        }

        private string event_name;

        public string Event_Name
        {
            get { return event_name; }
            set { event_name = value; }
        }

        private DateTime event_start;

        public DateTime Event_Start
        {
            get { return event_start; }
            set { event_start = value; }
        }

        private DateTime event_end;

        public DateTime Event_End
        {
            get { return event_end; }
            set { event_end = value; }
        }

        private string event_summary;

        public string Event_Summary
        {
            get { return event_summary; }
            set { event_summary = value; }
        }

        private int event_add;

        public int Event_Add
        {
            get { return event_add; }
            set { event_add = value; }
        }

        private int event_discount;

        public int Event_Discount
        {
            get { return event_discount; }
            set { event_discount = value; }
        }
    }
}

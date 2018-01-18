using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosProject_psi
{
    class Sales
    {
        // 판매 날짜
        private DateTime sell_date;

        public DateTime Sell_Date
        {
            get { return sell_date; }
            set { sell_date = value; }
        }

        // 판매 총액
        private int sell_all_amount;

        public int Sell_All_Amount
        {
            get { return sell_all_amount; }
            set { sell_all_amount = value; }
        }

        // 판매 순수익
        private int sell_pure_money;

        public int Sell_pure_Money
        {
            get { return sell_pure_money; }
            set { sell_pure_money = value; }
        }

        // 결제 수단
        private string sell_select;

        public string Sell_Select
        {
            get { return sell_select; }
            set { sell_select = value; }
        }

    }
}

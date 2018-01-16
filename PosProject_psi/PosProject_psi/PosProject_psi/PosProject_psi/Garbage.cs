using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosProject_psi
{
    class Garbage
    {
        /// <summary>
        /// 폐기번호
        /// </summary>
        private int product_disposal_num;
        public int Product_disposal_num
        {
            get { return product_disposal_num; }
            set { product_disposal_num = value; }
        }

        /// <summary>
        /// 폐기 상품명
        /// </summary>
        private string product_name;
        public string Product_name
        {
            get { return product_name; }
            set { product_name = value; }
        }


        /// <summary>
        /// 폐기품목바코드
        /// </summary>
        private string product_barcode;
        public string Product_barcode
        {
            get { return product_barcode; }
            set { product_barcode = value; }
        }

        /// <summary>
        /// 폐기 날짜
        /// </summary>
        private string product_disposal_date;
        public string Product_disposal_date
        {
            get { return product_disposal_date; }
            set { product_disposal_date = value; }
        }

        /// <summary>
        /// 폐기 수량
        /// </summary>
        private int product_disposal_count;
        public int Product_disposal_count
        {
            get { return product_disposal_count; }
            set { product_disposal_count = value; }
        }



    }
}

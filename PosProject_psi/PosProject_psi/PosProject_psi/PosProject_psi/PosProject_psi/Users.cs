using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosProject_psi
{
    class Users
    {
        /// <summary>
        /// 회원 번호
        /// </summary>
        private int userNum;
        public int UserNum
        {
            get { return userNum; }
            set { userNum = value; }
        }

        /// <summary>
        /// 회원 이름
        /// </summary>
        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        /// <summary>
        /// 회원 전화번호
        /// </summary>
        private string userPhone;
        public string UserPhone
        {
            get { return userPhone; }
            set { userPhone = value; }
        }

        /// <summary>
        /// 회원 생일
        /// </summary>
        private string userDate;
        public string UserDate
        {
            get { return userDate; }
            set { userDate = value; }
        }
    }
}

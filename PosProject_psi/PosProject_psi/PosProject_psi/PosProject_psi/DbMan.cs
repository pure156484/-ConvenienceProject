using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosProject_psi
{
    class DbMan
    {
        public static SqlConnection Dbcon(SqlConnection con)
        {
            if(con == null)
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString);
                return con;
            }
            else
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConvenienceStore"].ConnectionString);
                return con;
            }
        }

        public static DataSet DbDs(DataSet con)
        {
            if (con == null)
            {
                con = new DataSet();
                return con;
            }
            else
            {
                con = new DataSet();
                return con;
            }
        }

        public static SqlDataAdapter DbAdap(SqlDataAdapter con)
        {
            if (con == null)
            {
                con = new SqlDataAdapter();
                return con;
            }
            else
            {
                con = new SqlDataAdapter();
                return con;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
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
                return con;
            }
        }
    }
}

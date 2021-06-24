using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Amazon2077.Models
{
    public class DBcommon
    {

        public static string MyConn = @"Data Source=.;Initial Catalog=dbAmazon2077;Integrated Security=True";


        public static IDbConnection conexion()
        {
            
            return new SqlConnection (MyConn);
        }
    }
}

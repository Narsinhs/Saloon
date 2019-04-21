using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Saloon
{
    public class Connection
    {
        static public SqlConnection sc;
        static public SqlConnection Get()
        {
            if (sc == null)
            {
                sc = new SqlConnection();
                sc.ConnectionString = "Data Source =DESKTOP-RU9DS6J; Integrated Security = SSPI; Initial Catalog = Saloon";
                sc.Open();
            }
            return sc;
        }
    }
}
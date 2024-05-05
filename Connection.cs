using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace apotek_app
{
    class Connection
    {
        public SqlConnection GetSqlConnection()
        {
            string connectionString = "Data Source=DESKTOP-MPAV480;Initial Catalog=DB_APOTEK_APP;integrated security=true; TrustServerCertificate=true";

            return new SqlConnection(connectionString);
        }
    }
}

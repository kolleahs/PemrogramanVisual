using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiketkeretaapi
{
    class koneksi
    {
        private static string connectionString = @"Data Source=LAPTOP-2A7QU8GB;Initial Catalog=tiketkeretaapi;TrustServerCertificate=True;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}

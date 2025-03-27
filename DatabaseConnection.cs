using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Supermarket_Management_System
{
    internal class DatabaseConnection
    {
        private SqlConnection conn;

        public DatabaseConnection()
        {
            String connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Marketdb;Integrated Security=True;TrustServerCertificate=True";
            conn = new SqlConnection(connectionString);
        }
        public SqlConnection GetSqlConnection()
        {
            return conn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDAL.Services
{
    public class DbService
    {
        private readonly string _connectionString;

        public DbService()
        {
            _connectionString = "Server=.\\SQLEXPRESS;Database=DesignPatterns;Trusted_Connection=True;";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary.DatabaseHelpers
{
    public class SqlService
    {
        private readonly string connectionString = "Server=localhost;Database=individual_project_semester2;Trusted_Connection=True;";
        public SqlConnection connectionFactory()
        {
            return new SqlConnection(connectionString);
        }
    }
}

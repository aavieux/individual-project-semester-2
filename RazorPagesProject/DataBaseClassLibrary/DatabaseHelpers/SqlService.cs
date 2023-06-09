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
        private readonly string connectionString = "Server=mssqlstud.fhict.local;Database=dbi501079_individual;User Id=dbi501079_individual;Password=password;";
        public SqlConnection connectionFactory()
        {
            return new SqlConnection(connectionString);
        }
    }
}

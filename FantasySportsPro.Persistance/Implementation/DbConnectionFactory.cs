using FantasySportsPro.Persistance.Abstraction;
using System.Data;
using System.Data.SqlClient;

namespace FantasySportsPro.Persistance.Implementation
{
    internal class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public DbConnectionFactory(string connectionString) =>
            _connectionString = connectionString;

        public IDbConnection CreateConnection() =>
             new SqlConnection(_connectionString);
    }
}

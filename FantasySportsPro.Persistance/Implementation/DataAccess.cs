using Dapper;
using FantasySportsPro.Persistance.Abstraction;

namespace FantasySportsPro.Persistance.Implementation
{
    internal class DataAccess : IDataAccess
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;

        public DataAccess(IDbConnectionFactory dbConnectionFactory) => _dbConnectionFactory = dbConnectionFactory;
        public async Task<int> ExecuteAsync(IDataExecute request)
        {
            using var connection = _dbConnectionFactory.CreateConnection();

            connection.Open();

            return await connection.ExecuteAsync(request.GetSql(), request.GetParameters());
        }

        public async Task<T?> FetchAsync<T>(IDataFetch<T> request)
        {
            using var connection = _dbConnectionFactory.CreateConnection();

            connection.Open();

            return await connection.QueryFirstOrDefaultAsync<T>(request.GetSql(), request.GetParameters());
        }

        public async Task<IEnumerable<T>> FetchListAsync<T>(IDataFetch<T> request)
        {
            using var connection = _dbConnectionFactory.CreateConnection();

            connection.Open();

            return await connection.QueryAsync<T>(request.GetSql(), request.GetParameters());
        }
    }
}

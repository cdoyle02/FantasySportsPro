using System.Data;

namespace FantasySportsPro.Persistance.Abstraction
{
    internal interface IDbConnectionFactory
    {
        public IDbConnection CreateConnection();
    }
}

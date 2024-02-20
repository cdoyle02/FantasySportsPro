using FantasySportsPro.Persistance.Abstraction;
using FantasySportsPro.Persistance.Implementation;

namespace FantasySportsPro.Persistence.Tests
{
    public abstract class DataRequestTest
    {
        protected readonly IDataAccess _dataAccess;

        public DataRequestTest()
        {
            _dataAccess = new DataAccess(new DbConnectionFactory(Hidden.ConnectionString));
        }
    }
}

using FantasySportsPro.Application.Abstraction;
using FantasySportsPro.Persistance.Abstraction;

namespace FantasySportsPro.Application.BaseObjects.BaseHandlers
{
    internal abstract class DataRequestHandler<TRequest> : BaseRequestHandler<TRequest> where TRequest : IRequest
    {
        protected readonly IDataAccess _dataAccess;

        protected DataRequestHandler(IDataAccess dataAccess) =>
            _dataAccess = dataAccess;

        public abstract override Task ExecuteRequestAsync(TRequest request);
    }
}

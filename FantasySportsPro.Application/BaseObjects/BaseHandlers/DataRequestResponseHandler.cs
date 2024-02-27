using FantasySportsPro.Application.Abstraction;
using FantasySportsPro.Persistance.Abstraction;

namespace FantasySportsPro.Application.BaseObjects.BaseHandlers
{
    internal abstract class DataRequestResponseHandler<TRequest, TResponse> : BaseRequestResponseHandler<TRequest, TResponse> where TRequest : IRequestWithResponse<TResponse>
    {
        protected readonly IDataAccess _dataAccess;

        protected DataRequestResponseHandler(IDataAccess dataAccess) =>
            _dataAccess = dataAccess;

        public abstract override Task<TResponse> GetResponseAsync(TRequest request);
    }
}

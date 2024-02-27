namespace FantasySportsPro.Application.Abstraction
{
    internal interface IOrchestrator
    {
        public Task ExecuteRequestAsync<TRequest>(TRequest request) where TRequest : IRequest;

        public Task<TResponse> GetResponseAsync<TResponse>(IRequestWithResponse<TResponse> requestResponse);
    }
}

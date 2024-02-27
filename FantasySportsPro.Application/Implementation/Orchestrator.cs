using FantasySportsPro.Application.Abstraction;
using FantasySportsPro.Domain.Exceptions;

namespace FantasySportsPro.Application.Implementation
{
    internal class Orchestrator : IOrchestrator
    {
        private readonly IHandlerFactory _handlerFactory;

        public Orchestrator(IHandlerFactory handlerFactory) => _handlerFactory = handlerFactory;

        public async Task ExecuteRequestAsync<TRequest>(TRequest request) where TRequest : IRequest
        {
            var handler = _handlerFactory.NewHandler(request);

            await handler.HandleAsync(request);
        }

        public async Task<TResponse> GetResponseAsync<TResponse>(IRequestWithResponse<TResponse> requestResponse)
        {
            var handler = _handlerFactory.NewHandler(requestResponse);

            if (await handler.HandleAsync(requestResponse) is TResponse response)
                return response;

            throw new OperationFailedException();
        }
    }
}

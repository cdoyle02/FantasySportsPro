namespace FantasySportsPro.Application.Abstraction
{
    internal interface IRequestHandler<TRequest> : IBaseHandler where TRequest : IRequest
    {
        public Task ExecuteRequestAsync(TRequest request);
    }
}

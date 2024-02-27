namespace FantasySportsPro.Application.Abstraction
{
    internal interface IRequestResponseHandler<TRequest, TResponse> : IBaseHandler where TRequest : IRequestWithResponse<TResponse>
    {
        public Task<TResponse> GetResponseAsync(TRequest request);
    }
}

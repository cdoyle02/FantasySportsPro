namespace FantasySportsPro.Application.Abstraction
{
    internal interface IBaseHandler
    {
        public Task<object?> HandleAsync(object request);
    }
}

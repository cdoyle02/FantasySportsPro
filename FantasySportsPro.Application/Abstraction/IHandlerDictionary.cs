namespace FantasySportsPro.Application.Abstraction
{
    internal interface IHandlerDictionary
    {
        public Type? GetHandlerType(Type requestType);
    }
}

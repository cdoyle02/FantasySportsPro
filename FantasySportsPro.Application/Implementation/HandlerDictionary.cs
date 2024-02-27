using FantasySportsPro.Application.Abstraction;
using FantasySportsPro.Domain.Exceptions;

namespace FantasySportsPro.Application.Implementation
{
    internal class HandlerDictionary : IHandlerDictionary
    {
        private readonly Dictionary<Type, Type> _handlerDictionary;

        public HandlerDictionary(IEnumerable<Type> handlers)
        {
            _handlerDictionary = GetHandlersDictionary(handlers);
        }

        public HandlerDictionary()
        {
            var handlers = GetType().Assembly.GetTypes().Where(_ => _.IsClass && typeof(IBaseHandler).IsAssignableFrom(_));

            _handlerDictionary = GetHandlersDictionary(handlers);
        }

        public Type? GetHandlerType(Type requestType) =>
            _handlerDictionary.TryGetValue(requestType, out var handlerType)
                ? handlerType
                : null;

        private static Dictionary<Type, Type> GetHandlersDictionary(IEnumerable<Type> handlers) =>
            handlers.ToDictionary(_ => _.GetInterfaces()
                                           .FirstOrDefault(_ => _.GenericTypeArguments.Any())?
                                                .GenericTypeArguments.First() ?? throw new DoesNotExistException("Request Object", (_, _.Name)));
    }
}

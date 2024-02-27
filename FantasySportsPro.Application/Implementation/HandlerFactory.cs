using FantasySportsPro.Application.Abstraction;
using FantasySportsPro.Domain.Exceptions;

namespace FantasySportsPro.Application.Implementation
{
    internal class HandlerFactory : IHandlerFactory
    {
        private readonly IHandlerDictionary _handlerDictionary;

        private readonly ITypeActivator _typeActivator;

        public HandlerFactory(IHandlerDictionary handlerDictionary, ITypeActivator typeActivator)
        {
            _handlerDictionary = handlerDictionary;
            _typeActivator = typeActivator;
        }

        public IBaseHandler NewHandler<TRequest>(TRequest request)
        {
            if(request == null) 
                throw new ArgumentNullException(nameof(request));

            var handlerType = _handlerDictionary.GetHandlerType(request.GetType());

            if (handlerType == null)
                throw new DoesNotExistException("Request Handler", (request, nameof(request)));

            return _typeActivator.Instantiate<IBaseHandler>(handlerType);
        }
    }
}

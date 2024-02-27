using FantasySportsPro.Application.Abstraction;
using Microsoft.Extensions.DependencyInjection;

namespace FantasySportsPro.Application.Implementation
{
    internal class TypeActivator : ITypeActivator
    {
        private readonly IServiceProvider _serviceProvidor;

        public TypeActivator(IServiceProvider serviceProvider) => _serviceProvidor = serviceProvider;

        public TResponse Instantiate<TResponse>(Type typeToInstantiate) => (TResponse)ActivatorUtilities.CreateInstance(_serviceProvidor, typeToInstantiate);
    }
}

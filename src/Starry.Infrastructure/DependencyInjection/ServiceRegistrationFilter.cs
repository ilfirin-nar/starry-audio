using System;
using Starry.Common.Extensions;

namespace Starry.Infrastructure.DependencyInjection
{
    public static class ServiceRegistrationFilter
    {
        public static bool ShouldImplements<TInterface>(Type interfaceType, Type implementingType)
        {
            var type = typeof(TInterface);
            return (interfaceType == type || interfaceType.IsImplements<TInterface>()) && implementingType.IsImplements<TInterface>();
        }
    }
}
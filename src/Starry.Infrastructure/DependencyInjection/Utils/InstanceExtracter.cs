using System;
using LightInject;

namespace Starry.Infrastructure.DependencyInjection.Utils
{
    public static class InstanceExtracter
    {
        public static void ForEachInstanceOf<TService>(Action<TService> action, IServiceContainer container)
        {
            foreach (var serviceInstance in container.GetAllInstances<TService>())
            {
                action(serviceInstance);
            }
        }
    }
}
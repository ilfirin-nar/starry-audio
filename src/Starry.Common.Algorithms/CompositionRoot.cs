using System.Reflection;
using LightInject;
using Starry.Infrastructure.DependencyInjection;
using Starry.Infrastructure.Interfaces;

namespace Starry.Common.Algorithms
{
    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IService>(Assemblies.This);
        }

        private static class Assemblies
        {
            public static readonly Assembly This = typeof(CompositionRoot).Assembly;
        }
    }
}
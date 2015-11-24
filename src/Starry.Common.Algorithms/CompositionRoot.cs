using System.Reflection;
using LightInject;
using Starry.Common.Algorithms.Sorting;
using Starry.Infrastructure.DependencyInjection;

namespace Starry.Common.Algorithms
{
    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<ISorter>(Assemblies.This);
        }

        private static class Assemblies
        {
            public static readonly Assembly This = typeof(CompositionRoot).Assembly;
        }
    }
}
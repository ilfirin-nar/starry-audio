using System.Reflection;
using LightInject;
using Starry.Common.Algorithms.Sorting;
using Starry.Infrastructure.DependencyInjection;

namespace Starry.Common.Tests
{
    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<ISorter>(Assemblies.Common);
        }

        private static class Assemblies
        {
            public static readonly Assembly Common = typeof (Common.CompositionRoot).Assembly;
        }
    }
}
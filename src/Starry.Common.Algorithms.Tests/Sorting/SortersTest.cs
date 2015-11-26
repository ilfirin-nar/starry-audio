using LightInject;
using LightInject.xUnit2;
using Starry.Common.Algorithms.Sorting;
using Starry.Common.Extensions;
using Xunit;
using static Starry.Common.Utils.RandomArrayProvider;
using static Starry.Infrastructure.DependencyInjection.Utils.InstanceExtracter;

namespace Starry.Common.Algorithms.Tests.Sorting
{
    public class SortersTest
    {
        private static IServiceContainer Container { get; set; }

        public static void Configure(IServiceContainer container)
        {
            Container = container;
            container.Register<ISorter>();
        }

        [Theory, Scoped, InjectData]
        public void AscendingSort_SimpleValidArray_IsNotEmpty()
        {
            ForEachInstanceOf<ISorter<int>>(instance =>
            {
                var array = GetRandomIntegerArray();
                instance.AscendingSort(array);
                Assert.NotEmpty(array);
            }, Container);
        }

        [Theory, Scoped, InjectData]
        public void DescendingSort_SimpleValidArray_IsNotEmpty()
        {
            ForEachInstanceOf<ISorter<int>>(instance =>
            {
                var array = GetRandomIntegerArray();
                instance.DescendingSort(array);
                Assert.NotEmpty(array);
            }, Container);
        }

        [Theory, Scoped, InjectData]
        public void AscendingSort_SimpleValidArray_ValidResult()
        {
            ForEachInstanceOf<ISorter<int>>(instance =>
            {
                var array = GetRandomIntegerArray();
                instance.AscendingSort(array);
                (array.Length - 1).Times(index => Assert.True(array[index] <= array[index + 1]));
            }, Container);
        }

        [Theory, Scoped, InjectData]
        public void DescendingSort_SimpleValidArray_ValidResult()
        {
            ForEachInstanceOf<ISorter<int>>(instance =>
            {
                var array = GetRandomIntegerArray();
                instance.DescendingSort(array);
                (array.Length - 1).Times(index => Assert.True(array[index] >= array[index + 1]));
            }, Container);
        }
    }
}
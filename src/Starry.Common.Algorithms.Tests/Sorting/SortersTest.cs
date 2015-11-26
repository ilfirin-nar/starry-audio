using System;
using LightInject;
using LightInject.xUnit2;
using Starry.Common.Algorithms.Sorting;
using Starry.Common.Extensions;
using Starry.Infrastructure.DependencyInjection;
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
            container.Register<ISorter>(typeof(ISorter).Assembly, LifeTimeFactory.PerRequest);
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

        [Theory, Scoped, InjectData]
        public void AscendingSort_SimpleValidStringArray_ValidResult()
        {
            ForEachInstanceOf<ISorter<string>>(instance =>
            {
                var array = GetRandomStringArray();
                instance.AscendingSort(array);
                (array.Length - 1).Times(index => Assert.True(string.Compare(array[index], array[index + 1], StringComparison.Ordinal) <= 0));
            }, Container);
        }

        [Theory, Scoped, InjectData]
        public void DescendingSort_SimpleValidStringArray_ValidResult()
        {
            ForEachInstanceOf<ISorter<string>>(instance =>
            {
                var array = GetRandomStringArray();
                instance.DescendingSort(array);
                (array.Length - 1).Times(index => Assert.True(string.Compare(array[index], array[index + 1], StringComparison.Ordinal) >= 0));
            }, Container);
        }
    }
}
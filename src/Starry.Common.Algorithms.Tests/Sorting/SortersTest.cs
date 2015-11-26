using System;
using System.Collections.Generic;
using LightInject;
using LightInject.xUnit2;
using Starry.Common.Algorithms.Sorting;
using Starry.Common.Algorithms.Sorting.Bubble;
using Starry.Common.Extensions;
using Starry.Infrastructure.DependencyInjection;
using Xunit;

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
            ForEachInstanceOf<ISorter<int>>(sorter =>
            {
                var array = GetRandomIntegerArray();
                sorter.AscendingSort(array);
                Assert.NotEmpty(array);
            });
        }

        [Theory, Scoped, InjectData]
        public void DescendingSort_SimpleValidArray_IsNotEmpty()
        {
            ForEachInstanceOf<ISorter<int>>(sorter =>
            {
                var array = GetRandomIntegerArray();
                sorter.DescendingSort(array);
                Assert.NotEmpty(array);
            });
        }

        [Theory, Scoped, InjectData]
        public void AscendingSort_SimpleValidArray_ValidResult()
        {
            ForEachInstanceOf<ISorter<int>>(sorter =>
            {
                var array = GetRandomIntegerArray();
                sorter.AscendingSort(array);
                (array.Length - 1).Times(index => Assert.True(array[index] <= array[index + 1]));
            });
        }

        [Theory, Scoped, InjectData]
        public void DescendingSort_SimpleValidArray_ValidResult()
        {
            ForEachInstanceOf<ISorter<int>>(sorter =>
            {
                var array = GetRandomIntegerArray();
                sorter.DescendingSort(array);
                (array.Length - 1).Times(index => Assert.True(array[index] >= array[index + 1]));
            });
        }

        private static void ForEachInstanceOf<TService>(Action<TService> action)
        {
            foreach (var service in Container.GetAllInstances<TService>())
            {
                action(service);
            }
        }

        private static int[] GetRandomIntegerArray()
        {
            var array = new int[100];
            var random = new Random();
            for (var index = 0; index < array.Length; index++)
            {
                array[index] = random.Next(-100, 100);
            }
            return array;
        }
    }
}
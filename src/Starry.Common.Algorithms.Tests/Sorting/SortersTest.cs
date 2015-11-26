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
            container.Register<ISorter>(typeof(ISorter).Assembly, LifeTimeFactory.PerRequest);
        }

        [Theory, Scoped, InjectData]
        public void AscendingSort_SimpleValidArray_IsNotEmpty()
        {
            foreach (var sorter in Container.GetAllInstances<ISorter<int>>())
            {
                var array = GetRandomIntegerArray();
                sorter.AscendingSort(array);
                Assert.NotEmpty(array);
            }
        }

        [Theory, Scoped, InjectData]
        public void DescendingSort_SimpleValidArray_IsNotEmpty()
        {
            var array = GetRandomIntegerArray();
            sorter.DescendingSort(array);
            Assert.NotEmpty(array);
        }

        [Theory, Scoped, InjectData]
        public void AscendingSort_SimpleValidArray_ValidResult(IBubbleSorter<int> sorter)
        {
            var array = GetRandomIntegerArray();
            sorter.AscendingSort(array);
            (array.Length - 1).Times(index => Assert.True(array[index] <= array[index + 1]));
        }

        [Theory, Scoped, InjectData]
        public void DescendingSort_SimpleValidArray_ValidResult(IBubbleSorter<int> sorter)
        {
            var array = GetRandomIntegerArray();
            sorter.DescendingSort(array);
            (array.Length - 1).Times(index => Assert.True(array[index] >= array[index + 1]));
        }

        private static 

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
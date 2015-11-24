using System;
using Starry.Common.Algorithms.Sorting;
using Starry.Common.Extensions;
using Xunit;

namespace Starry.Common.Algorithms.Tests.Sorting
{
    public static class SorterTestMethods
    {
        public static void Sort_SimpleValidArrayAscendingSort_IsNotEmpty(ISorter<int> sorter)
        {
            var array = GetRandomIntegerArray();
            sorter.AscendingSort(array);
            Assert.NotEmpty(array);
        }

        public static void Sort_SimpleValidArrayDescendingSort_IsNotEmpty(ISorter<int> sorter)
        {
            var array = GetRandomIntegerArray();
            sorter.AscendingSort(array);
            Assert.NotEmpty(array);
        }

        public static void Sort_SimpleValidArrayAscendingSort_ValidResult(ISorter<int> sorter)
        {
            var array = GetRandomIntegerArray();
            sorter.AscendingSort(array);
            (array.Length - 1).Times(index => Assert.True(array[index] <= array[index + 1]));
        }

        public static void Sort_SimpleValidArrayDescendingSort_ValidResult(ISorter<int> sorter)
        {
            var array = GetRandomIntegerArray();
            sorter.DescendingSort(array);
            (array.Length - 1).Times(index => Assert.True(array[index] >= array[index + 1]));
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
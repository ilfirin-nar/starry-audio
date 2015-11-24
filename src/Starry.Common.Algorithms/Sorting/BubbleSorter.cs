using System;
using Starry.Common.Utils;

namespace Starry.Common.Algorithms.Sorting
{
    public class BubbleSorter<T> : IBubbleSorter<T>
        where T : IComparable, IComparable<T>, IEquatable<T>
    {
        public void AscendingSort(T[] array)
        {
            BubbleSort(array, index => array[index].CompareTo(array[index + 1]) > 0);
        }

        public void DescendingSort(T[] array)
        {
            BubbleSort(array, index => array[index].CompareTo(array[index + 1]) < 0);
        }

        private static void BubbleSort(T[] array, Func<int, bool> compareMethod)
        {
            for (var index1 = 0; index1 < array.Length; index1++)
            {
                for (var index2 = 0; index2 < array.Length - 1; index2++)
                {
                    if (compareMethod(index2))
                    {
                        ValuesSwapper.Swap(ref array[index2], ref array[index2 + 1]);
                    }
                }
            }
        }
    }
}
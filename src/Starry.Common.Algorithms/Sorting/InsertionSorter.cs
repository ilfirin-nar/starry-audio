using System;
using System.Collections.Generic;

namespace Starry.Common.Algorithms.Sorting
{
    internal class InsertionSorter<T> : IInsertionSorter<T>
        where T : IComparable, IComparable<T>, IEquatable<T>
    {
        public void AscendingSort(T[] array)
        {
            SortByInserts(array, (element, key) => element.CompareTo(key) > 0);
        }

        public void DescendingSort(T[] array)
        {
            SortByInserts(array, (element, key) => element.CompareTo(key) < 0);
        }

        private static void SortByInserts(IList<T> array, Func<T, T, bool> compareMethod)
        {
            for (var index = 1; index < array.Count; index++)
            {
                var selectedElement = array[index];
                var innerIndex = index;
                while (innerIndex > 0 && compareMethod(array[innerIndex - 1], selectedElement))
                {
                    array[innerIndex] = array[innerIndex - 1];
                    innerIndex--;
                }
                array[innerIndex] = selectedElement;
            }
        }
    }
}
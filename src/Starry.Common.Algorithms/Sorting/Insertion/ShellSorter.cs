using System;
using System.Collections.Generic;

namespace Starry.Common.Algorithms.Sorting.Insertion
{
    internal class ShellSorter<T> : IShellSorter<T>
        where T : IComparable, IComparable<T>, IEquatable<T>
    {
        public void AscendingSort(T[] array)
        {
            Sort(array, (element, selectedElement) => element.CompareTo(selectedElement) > 0);
        }

        public void DescendingSort(T[] array)
        {
            Sort(array, (element, selectedElement) => element.CompareTo(selectedElement) < 0);
        }

        private static void Sort(IList<T> array, Func<T, T, bool> compareMethod)
        {
            var step = array.Count / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < array.Count; i++)
                {
                    var selectedElement = array[i];
                    for (j = i - step; (j >= 0) && (compareMethod(array[j], selectedElement)); j -= step)
                        array[j + step] = array[j];
                    array[j + step] = selectedElement;
                }
                step /= 2;
            }
        }
    }
}
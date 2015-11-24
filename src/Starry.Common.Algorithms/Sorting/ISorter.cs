using System;
using Starry.Infrastructure.Interfaces;

namespace Starry.Common.Algorithms.Sorting
{
    public interface ISorter : IService {}

    public interface ISorter<in T> : ISorter
        where T : IComparable, IComparable<T>, IEquatable<T>
    {
        void AscendingSort(T[] array);

        void DescendingSort(T[] array);
    }
}
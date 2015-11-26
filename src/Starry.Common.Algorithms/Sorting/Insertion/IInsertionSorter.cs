using System;

namespace Starry.Common.Algorithms.Sorting.Insertion
{
    public interface IInsertionSorter<T> : ISorter<T>
        where T : IComparable, IComparable<T>, IEquatable<T> {}
}
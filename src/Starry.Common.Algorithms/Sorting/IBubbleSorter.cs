using System;

namespace Starry.Common.Algorithms.Sorting
{
    public interface IBubbleSorter<T> : ISorter<T>
        where T : IComparable, IComparable<T>, IEquatable<T> {}
}
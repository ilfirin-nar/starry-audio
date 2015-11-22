namespace Starry.Common.Algorithms.Sorting
{
    public interface ISorter {}

    public interface ISorter<in T> : ISorter
    {
        void Sort(T[] array);
    }
}
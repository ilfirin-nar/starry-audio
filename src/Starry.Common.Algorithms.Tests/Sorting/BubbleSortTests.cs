using LightInject.xUnit2;
using Starry.Common.Algorithms.Sorting;
using Xunit;

namespace Starry.Common.Algorithms.Tests.Sorting
{
    public class BubbleSortTests
    {
        [Theory, Scoped, InjectData]
        public void Sort_SimpleValidArrayAscendingSort_IsNotEmpty(IBubbleSorter<int> sorter)
        {
            SorterTestMethods.Sort_SimpleValidArrayAscendingSort_IsNotEmpty(sorter);
        }

        [Theory, Scoped, InjectData]
        public void Sort_SimpleValidArrayDescendingSort_IsNotEmpty(IBubbleSorter<int> sorter)
        {
            SorterTestMethods.Sort_SimpleValidArrayDescendingSort_IsNotEmpty(sorter);
        }

        [Theory, Scoped, InjectData]
        public void Sort_SimpleValidArrayAscendingSort_ValidResult(IBubbleSorter<int> sorter)
        {
            SorterTestMethods.Sort_SimpleValidArrayAscendingSort_ValidResult(sorter);
        }

        [Theory, Scoped, InjectData]
        public void Sort_SimpleValidArrayDescendingSort_ValidResult(IBubbleSorter<int> sorter)
        {
            SorterTestMethods.Sort_SimpleValidArrayDescendingSort_ValidResult(sorter);
        }
    }
}
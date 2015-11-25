using LightInject.xUnit2;
using Starry.Common.Algorithms.Sorting;
using Xunit;

namespace Starry.Common.Algorithms.Tests.Sorting
{
    public class BubbleSorterTests
    {
        [Theory, Scoped, InjectData]
        public void AscendingSort_SimpleValidArray_IsNotEmpty(IBubbleSorter<int> sorter)
        {
            SorterCommonTestMethods.AscendingSort_SimpleValidArray_IsNotEmpty(sorter);
        }

        [Theory, Scoped, InjectData]
        public void DescendingSort_SimpleValidArray_IsNotEmpty(IBubbleSorter<int> sorter)
        {
            SorterCommonTestMethods.DescendingSort_SimpleValidArray_IsNotEmpty(sorter);
        }

        [Theory, Scoped, InjectData]
        public void AscendingSort_SimpleValidArray_ValidResult(IBubbleSorter<int> sorter)
        {
            SorterCommonTestMethods.AscendingSort_SimpleValidArray_ValidResult(sorter);
        }

        [Theory, Scoped, InjectData]
        public void DescendingSort_SimpleValidArray_ValidResult(IBubbleSorter<int> sorter)
        {
            SorterCommonTestMethods.DescendingSort_SimpleValidArray_ValidResult(sorter);
        }
    }
}
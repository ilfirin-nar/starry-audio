using LightInject.xUnit2;
using Starry.Common.Algorithms.Sorting;
using Xunit;

namespace Starry.Common.Algorithms.Tests.Sorting
{
    public class InsertionSorterTests
    {
        [Theory, Scoped, InjectData]
        public void AscendingSort_SimpleValidArray_IsNotEmpty(IInsertionSorter<int> sorter)
        {
            SorterCommonTestMethods.AscendingSort_SimpleValidArray_IsNotEmpty(sorter);
        }

        [Theory, Scoped, InjectData]
        public void DescendingSort_SimpleValidArray_IsNotEmpty(IInsertionSorter<int> sorter)
        {
            SorterCommonTestMethods.DescendingSort_SimpleValidArray_IsNotEmpty(sorter);
        }

        [Theory, Scoped, InjectData]
        public void AscendingSort_SimpleValidArray_ValidResult(IInsertionSorter<int> sorter)
        {
            SorterCommonTestMethods.AscendingSort_SimpleValidArray_ValidResult(sorter);
        }

        [Theory, Scoped, InjectData]
        public void DescendingSort_SimpleValidArray_ValidResult(IInsertionSorter<int> sorter)
        {
            SorterCommonTestMethods.DescendingSort_SimpleValidArray_ValidResult(sorter);
        }
    }
}
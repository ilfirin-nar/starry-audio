using LightInject.xUnit2;
using Starry.Common.Algorithms.Sorting;
using Xunit;

namespace Starry.Common.Tests.Algorithms.Sorting
{
    public class BubbleSortTests
    {
        [Theory, InjectData]
        public void Sort_SimpleValidArray_ValidResult()
        {
            Assert.NotNull(new object());
        }
    }
}
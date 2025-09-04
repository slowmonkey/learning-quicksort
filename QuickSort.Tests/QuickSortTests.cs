namespace QuickSort.Tests;

public class QuickSortTests
{
    [Theory]
    [InlineData(new int[] { 5, 2, 9, 1, 7 }, new int[] { 1, 2, 5, 7, 9 })]
    [InlineData(new int[] { -1, 1, 1, 2, 9, 5, 1, 7 }, new int[] { -1, 1, 1, 1, 2, 5, 7, 9 })]
    [InlineData(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
    [InlineData(new int[] { 42, 7, 19, 3, 88, 54, 23, 16, 71, 5, 30, 12, 91, 2, 67, 49, 81, 14, 60, 35 }, new int[] {2, 3, 5, 7, 12, 14, 16, 19, 23, 30, 35, 42, 49, 54, 60, 67, 71, 81, 88, 91})]
    public void QuickSort_UnsortedItems_SortedItemsExpected(int[] items, int[] expectedResult)
{
    Console.WriteLine("Before: " + string.Join(", ", items));
    QuickSortLearnings.QuickSort(items, 0, items.Length - 1);
    Console.WriteLine("After: " + string.Join(", ", items));

    Assert.Equal(expectedResult, items);
}
}

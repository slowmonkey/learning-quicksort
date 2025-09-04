namespace QuickSort;

public class QuickSortLearnings
{
    public static void QuickSort(int[] items, int leftIndex, int rightIndex)
    {
        Console.WriteLine($"QuickSort: items: {string.Join(", ", items)}, leftIndex: {leftIndex}, rightIndex: {rightIndex}");

        if (leftIndex < rightIndex)
        {
            int pivotIndex = Partition(items, leftIndex, rightIndex);

            // Sort the left side

            Console.WriteLine($"QuickSort: Sort Left Side of {items[pivotIndex]}");

            QuickSort(items, leftIndex, pivotIndex - 1);

            // Sort the right side

            Console.WriteLine($"QuickSort: Sort Right Side of {items[pivotIndex]}");

            QuickSort(items, pivotIndex + 1, rightIndex);
        }
    }

    public static int Partition(int[] items, int leftIndex, int rightIndex)
    {
        // Taking the right index value as the pivot number.

        int pivot = items[rightIndex];

        Console.WriteLine($"QuickSort: pivot value: {pivot}");

        int index = leftIndex - 1;

        for (int counter = leftIndex; counter <= rightIndex - 1; counter++)
        {
            Console.WriteLine($"Compare: {items[counter]} with Pivot: {pivot}");

            if (items[counter] < pivot)
            {
                index++;

                Console.WriteLine($"Swap: {items[index]} at {index} with {items[counter]} at {counter}");

                Swap(items, index, counter);

            }
        }

        Console.WriteLine($"Swap: {items[index + 1]} at {index + 1} with {items[rightIndex]} at {rightIndex}");

        Swap(items, index + 1, rightIndex);
        
        return index + 1;
    }

    public static void Swap(int[] items, int leftIndex, int rightIndex)
    {

        int temp = items[leftIndex];
        items[leftIndex] = items[rightIndex];
        items[rightIndex] = temp;

        Console.WriteLine("Now: " + string.Join(", ", items));
    }
}

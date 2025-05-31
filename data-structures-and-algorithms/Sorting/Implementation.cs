
using System.Diagnostics;

public static class Sorting
{
    public static void Print(int[] array)
    {
        Console.WriteLine("ARRAY PRINTING");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}, ");
        }
    }
    public static void BubbleSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (array[i] > array[j])
                {
                    //swap
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
    public static void SelectionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n; i++)
        {
            int smallestNumberIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[smallestNumberIndex] > array[j])
                {
                    smallestNumberIndex = j;
                }
            }

            if (smallestNumberIndex != i)
            {
                var temp = array[i];
                array[i] = array[smallestNumberIndex];
                array[smallestNumberIndex] = temp;
            }
        }
    }
    public static void InsertionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && key < array[j])
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }
    }

    public static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = (right - left) / 2 + left;

            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);

            Merge(array, left, middle, right);
        }
    }

    private static void Merge(int[] array, int left, int middle, int right)
    {
        int sizeArrayLeft = middle - left + 1;
        int sizeArrayRight = right - middle;

        int[] aLeft = new int[sizeArrayLeft];
        int[] aRight = new int[sizeArrayRight];
        int i, j;

        for (i = 0; i < sizeArrayLeft; ++i)
            aLeft[i] = array[left + i];
        for (j = 0; j < sizeArrayRight; ++j)
            aRight[j] = array[middle + 1 + j];

        i = 0;
        j = 0;

        int k = left;
        while (i < sizeArrayLeft && j < sizeArrayRight) {
            if (aLeft[i] <= aRight[j]) {
                array[k] = aLeft[i];
                i++;
            }
            else {
                array[k] = aRight[j];
                j++;
            }
            k++;
        }

        while (i < sizeArrayLeft) {
            array[k] = aLeft[i];
            i++;
            k++;
        }

        while (j < sizeArrayRight) {
            array[k] = aRight[j];
            j++;
            k++;
        }
    }
}
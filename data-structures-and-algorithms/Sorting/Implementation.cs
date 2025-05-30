
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
}
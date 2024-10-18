using System;

class Sorting
{
    public static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
            return;

        int mid = arr.Length / 2;

        int[] left_side = new int[mid];
        int[] right_side = new int[mid];

        for (int i = 0; i < mid; i++)
        {

            left_side[i] = arr[i];

        }

        for (int i = mid; i < arr.Length; i++)
        {
            right_side[i - mid] = arr[i];
        }

        MergeSort(left_side);
        MergeSort(right_side);

        Merge(arr, left_side, right_side);

    }

    public static void Merge(int[] arr, int[] left_side, int[] right_side)
    {
        int i = 0, j = 0, k = 0;

        while (i < left_side.Length && j < right_side.Length)
        {
            if (left_side[i] <= right_side[j])
                arr[k++] = left_side[i++];
            else
                arr[k++] = right_side[j++];
        }

        while (i < left_side.Length)
            arr[k++] = left_side[i++];

        while (j < right_side.Length)
            arr[k++] = right_side[j++];

    }

    static void Main()
    {
        int[] arr = { 56, 12, 9, 14, 865, 782, 67, 987 };

        MergeSort(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

    }



}
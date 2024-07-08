

using System.Security.Cryptography.X509Certificates;

class MergeSort
{
    public static void mergeSort(int[] arr)
    {
        int length = arr.Length;
        if (length <= 1) return; // base case

        int mid = length / 2;
        int[] leftArr = new int[mid];
        int[] rightArr = new int[length - mid];

        // Copy elements to the left array
        for (int i = 0; i < mid; i++)
        {
            leftArr[i] = arr[i];
        }

        // Copy elements to the right array
        for (int i = mid; i < length; i++)
        {
            rightArr[i - mid] = arr[i];
        }

        // Recursively sort both halves
        mergeSort(leftArr);
        mergeSort(rightArr);

        // Merge sorted halves
        merge(arr, leftArr, rightArr);
    }

    public static void merge(int[] arr, int[] left, int[] right)
    {
        int leftSize = left.Length;
        int rightSize = right.Length;
        int i = 0, l = 0, r = 0;

        // Merge the two arrays into the original array
        while (l < leftSize && r < rightSize)
        {
            if (left[l] < right[r])
            {
                arr[i] = left[l];
                l++;
            }
            else
            {
                arr[i] = right[r];
                r++;
            }
            i++;
        }

        // Copy remaining elements of left array
        while (l < leftSize)
        {
            arr[i] = left[l];
            l++;
            i++;
        }

        // Copy remaining elements of right array
        while (r < rightSize)
        {
            arr[i] = right[r];
            r++;
            i++;
        }
    }
}

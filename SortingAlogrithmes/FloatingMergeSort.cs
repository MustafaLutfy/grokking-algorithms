

using System.Security.Cryptography.X509Certificates;

class FloatingMergeSort
{
    public static void floatMergeSort(double[] arr)
    {
        int length = arr.Length;
        if (length <= 1) return; // base case

        int mid = length / 2;
        double[] leftArr = new double[mid];
        double[] rightArr = new double[length - mid];

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
        floatMergeSort(leftArr);
        floatMergeSort(rightArr);

        // Merge sorted halves
        merge(arr, leftArr, rightArr);
    }

    public static void merge(double[] arr, double[] left, double[] right)
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

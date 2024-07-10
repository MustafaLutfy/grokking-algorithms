

using System.Security.Cryptography.X509Certificates;


class Book{
    public string title {set; get;}
    public int year {set; get;}

    public Book(string title, int year){
        this.title = title;
        this.year = year;
    }
}
class ObjectMergeSort
{
    public static void objectMergeSort(Book[] arr)
    {
        int length = arr.Length;
        if (length <= 1) return; // base case

        int mid = length / 2;
        Book[] leftArr = new Book[mid];
        Book[] rightArr = new Book[length - mid];

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
        objectMergeSort(leftArr);
        objectMergeSort(rightArr);

        // Merge sorted halves
        merge(arr, leftArr, rightArr);
    }

    public static void merge(Book[] arr, Book[] left, Book[] right)
    {
        int leftSize = left.Length;
        int rightSize = right.Length;
        int i = 0, l = 0, r = 0;

        // Merge the two arrays into the original array
        while (l < leftSize && r < rightSize)
        {
            if (left[l].year < right[r].year)
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

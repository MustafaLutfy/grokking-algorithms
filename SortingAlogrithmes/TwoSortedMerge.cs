
class TwoSortedMerge{

    public static List<int> mergeSort(int[] left, int[] right){
        List<int> sorted = new List<int>();
        int leftSize = left.Length;
        int rightSize = right.Length;
        int i = 0, l = 0, r = 0;

        // Merge the two arrays into the original array
        while (l < leftSize && r < rightSize)
        {
            if (left[l] < right[r])
            {
               sorted.Add(left[l]);
                l++;
            }
            else
            {
                sorted.Add(right[r]);
                r++;
            }
            i++;
        }

        // Copy remaining elements of left array
        while (l < leftSize)
        {
            sorted.Add(left[l]);
            l++;
            i++;
        }

        // Copy remaining elements of right array
        while (r < rightSize)
        {
            sorted.Add(right[r]);
            r++;
            i++;
        }
    
    return sorted;
    }

}
public class SearchAlgorithems
{
    public static int BinarySearch(int searchFor)
    {
        int[] inputArray = [1, 2, 4, 6, 7, 8, 9];
        int min = 0;
        int max = inputArray.Length-1;


        while (min <=max)
            {
            int mid = (min + max) / 2;
            if (searchFor == inputArray[mid])
            {
                    return mid;
            }
            else if (searchFor < inputArray[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }
        return 0;
    }
}
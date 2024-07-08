

class QuickSort
{
    public static void Quick_Sort(int[] arr, int left,int right){
        if(left < right){
            int index = Partition(arr, left, right);

            Quick_Sort(arr, left, index-1);
            Quick_Sort(arr, index+1, right);
        }
    }

    public static int Partition(int[] arr, int left,int right){
       int pivot = arr[right];
       int index = left - 1;
        for (int i = left; i < right; i++)
        {
        if(arr[i] <= pivot){
            index++;
            swap(arr, i, index);
            
        }
     }
        index++;
        swap(arr, index, right);
        return index;
    }


    public static void swap(int[] arr, int a, int b){
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

}


public class ArraySheet1
{
    public static void DrivingCode()
    {
        //https://practice.geeksforgeeks.org/problems/sort-an-array-of-0s-1s-and-2s4231/1?page=1&company[]=Microsoft&sortBy=submissions
        int[] arr= {0, 2, 1, 2, 0};
        sort012(arr, arr.Length);
        Console.WriteLine();
        //https://practice.geeksforgeeks.org/problems/minimize-the-heights3351/1?page=1&company[]=Microsoft&sortBy=submissions
        //Input:

        Console.WriteLine("GetMinDiff");
        int k = 3; int n = 5;
        int[] arr1 = {1, 5, 8, 10};
        int[] arr2 = {3, 9, 12, 16, 20};
        
        int ans = GetMinDiff(arr1, n, k);
        Console.WriteLine(ans);
    }
    static int GetMinDiff(int[] arr, int n, int k) {
        // code here
        Array.Sort(arr);

            return 1;
        }
    


    
    static void sort012(int[] arr, int n)
    {
        // code here
        int low = 0;
        int high = n-1;
        int mid =0;
        int temp =0;
      while(mid <= high)
      {        
        switch(arr[mid])
        {
            case 0:
                //Swap(arr, arr[low], arr[mid]);
                temp = arr[low];
                arr[low] = arr[mid];
                arr[mid] = temp;
                low++;
                mid++;
                break;
            case 1:
                mid++;
                break;
            case 2:
                //Swap(arr, arr[mid], arr[high]);
                temp = arr[mid];
                arr[mid] = arr[high];
                arr[high] = temp;
                high--;
                break;
        }
      }        

      for (int i = 0; i < n; i++)
      {
        Console.Write(" " + arr[i]);
      }
    }
    

    static void Swap(int[] arr, int a, int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
}
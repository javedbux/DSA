
public class ArraySheet3
{
    public static void DrivingCode()
    {
        //
        int[] arr = {22, 14, 8, 17, 35, 3};
        MinMaxNumber(arr);
        MinMaxNumberRecur(arr, 1, arr[0], arr[0]);

        Console.WriteLine("Bubble");
        BubbleSort(arr);
        
        //https://practice.geeksforgeeks.org/problems/max-min/1?utm_source=gfg&utm_medium=article&utm_campaign=bottom_sticky_on_article
        
        Console.WriteLine("Find Sum ");
        int[] arr1 = {-2, 1, -4, 5, 3};
        int[] arr2 = {1, 3, 4, 1};
        int ans = findSum(arr2, 4);
        Console.WriteLine(ans);
        Console.WriteLine();
        //https://practice.geeksforgeeks.org/problems/sort-an-array-of-0s-1s-and-2s4231/1

        int[] sortArr = {0, 2, 1, 2, 0};
        int sortSize = 5;

        sort012(sortArr, sortSize);
        Console.WriteLine("ColorSort");

        int[] sortArr1 = {0, 2, 1, 2, 0};
        int sortSize1 = 5;

        SortColor(sortArr1, sortSize1);
    }
    static void SortColor(int[] arr, int n)
    {
        int one =0; int two =0; int zero =0;

        for (int i = 0; i < n; i++)
        {
            if(arr[i] == 0)
            {
                zero++;
            }
            if(arr[i] == 1)
                one++;
            if(arr[i] == 2)
                two++;
        }

        for (int i = 0; i < zero; i++)
        {
            arr[i] = 0;
        }
        for (int i = zero; i < one+zero; i++)
        {
            arr[i] = 1;
        }
        for (int i = one+zero; i < n; i++)
        {
            arr[i] = 2;
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(" " + arr[i]);
        }
        Console.WriteLine();
    }


    public static void sort012(int[] arr, int n)
    {
        // code here
        int low =0;
        int high = n-1;
        int mid =0;
        int temp =0;
        while(low < high)
        {
            if(arr[mid] ==0)
            {
                temp = arr[low];
                arr[low] = arr[mid];
                arr[mid] = temp;
                low++;
                mid++;
            }
            if(arr[mid] == 1)
            {
                mid++;
            }
            if(arr[mid] ==2)
            {
                temp = arr[mid];
                arr[mid] = arr[high];
                arr[high] = temp;

                high--;
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(" " + arr[i]);
        }
        Console.WriteLine();
    }

    public static int findSum(int[] arr,int n) 
    {
        //code here
        int min = arr[0];
        int max = arr[0];

        return findSum(arr, 0, n, min, max);
    }

    static int findSum(int[] arr, int index, int n, int min, int max)
    {
        if(index == n)
        {
            return min + max;
        }
        min = Math.Min(min, arr[index]);
        max = Math.Max(max, arr[index]);

        return findSum(arr, index +1, n, min, max);
    }


    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            //Console.WriteLine(n - i -1);
            for (int j = 0; j < n - i -1; j++)
            {
                if(arr[j] > arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
        //print sort array
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" " + arr[i]);
        }

        Console.WriteLine();
    }

    static void MinMaxNumberRecur(int[] arr, int index, int min, int max)
    {
        if(index == arr.Length)
        {
            Console.WriteLine("Min " + min);
            Console.WriteLine("Max " + max);
            return;
        }
        
        min = Math.Min(min, arr[index]);
        max = Math.Max(max, arr[index]);
        

        MinMaxNumberRecur(arr, index+1, min, max);
    }


    static void MinMaxNumber(int[] arr)
    {
        int min =arr[0];
        int max =arr[0];
        for (int i = 1; i < arr.Length; i++)
        {            
            // if(arr[i] < min)
            // {
            //     min = arr[i];
            // }
            
            // if(arr[i] > max)
            // {
            //     max = arr[i];
            // }

            min = Math.Min(min, arr[i]);

            max = Math.Max(max, arr[i]);
        }       

        Console.WriteLine("Min = " + min);
        Console.WriteLine("Max = " + max);
    }
}
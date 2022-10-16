
public class Array3
{
    public static void DrivingCode()
    {
        Console.WriteLine();
        //Buy Sell
        Console.WriteLine("Buy sell");
        int[] arr3 = {3,1,4,8,7,2,5};
        int[] arr4 = {5,2,6,1,4};
        int ans3 = BuySellStock(arr4);
        Console.WriteLine(ans3);
        
        Console.WriteLine();
        //Buy Sell
        Console.WriteLine("Buy sell Every Day");
        int[] arr33 = {5,2,6,1,4,7,3,6};
        
        int ans33 = BuySellStockEveryDay(arr33);
        Console.WriteLine(ans33);

        int[] arr = {5,1 ,5,5,4 ,1 , 5,5, 1,1};

        Console.WriteLine("MaxNumber");
        int ans = MaxNumber(arr);
        Console.WriteLine(ans);


        //MaxSumSubArray
        Console.WriteLine("MaxSumSubArray");
        int[] arr1 = {5, -4, -2, 6, -1};

         int ans1 = MaxSumSubArray(arr1);
         Console.WriteLine(ans1);

    }

    static int MaxSumSubArray(int[] arr)
    {
        int n= arr.Length;
        int cur = 0;
        int max = 0;

        for (int i = 0; i < n; i++)
        {
            cur =  cur + arr[i];

            if(cur > max)
            {
                max = cur;
            }

            if(cur < 0)
            {
                cur =0;
            }
        }

        return max;


    }

    static int MaxNumber(int[] arr)
    {
        int ansindex =0;
        int count = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if(arr[i] == arr[ansindex])
            {
                count++;
            }
            else
                count--;
            
            if(count == 0)
            {
                ansindex = i;
                count =1;
            }
        }

        return ansindex;
    }


    static int BuySellStockEveryDay(int[] arr)
    {
        int n = arr.Length;
        int profit = 0;

        for (int i = 1; i < n-1; i++)
        {
            if(arr[i] < arr[i + 1])
            {
                profit += arr[i + 1] - arr[i];
            }
        }

        return profit;
    }
    static int BuySellStock(int[] arr)
    {
        int n = arr.Length -1;
        int minSoFor = arr[0];
        int maxval =0;

        for (int i = 1; i < n -1; i++)
        {
            minSoFor = Math.Min(minSoFor, arr[i]);

            maxval = Math.Max(maxval, arr[i]);
        }

        return maxval - minSoFor;
    }
}

public class MaxElement
{
    public static void DrivingCode()
    {
        int[] arr = {5,1 ,4 ,1 , 5,5};

        int ans = MaxNumber(arr);
        Console.WriteLine(ans);


        //MaxSumSubArray
        Console.WriteLine("MaxSumSubArray");
        int[] arr1 = {5, -4, -2, 6, -1};

        int ans1 = MaxSumSubArray(arr1);
        Console.WriteLine(ans1);


        Console.WriteLine();
        //Buy Sell
        Console.WriteLine("Buy sell");
        int[] arr3 = {3,1,4,8,7,2,5};
        int[] arr4 = {5,2,6,1,4};
        int ans3 = BuySellStock(arr4);
        Console.WriteLine(ans3);

        Console.WriteLine();
        int ans4 = BuySellStockMethod2(arr4);
        Console.WriteLine(ans4);

    }

    static int BuySellStockMethod2(int[] arr)
    {
        int minSoFor = arr[0];
        int maxProfit = 0;

        for (int i = 0; i < arr.Length -1; i++)
        {
            minSoFor = Math.Min(minSoFor, arr[i]);

            int profit = arr[i] - minSoFor;

            maxProfit = Math.Max(maxProfit, profit);
        }

        return maxProfit;
    }


    static int BuySellStock(int[] arr)
    {
        int minSoFor = arr[0];
        int maxProfit = 0;

        for (int i = 0; i <= arr.Length -1; i++)
        {   
            //int maxSum =  0;
            if(minSoFor > arr[i])
            {
                minSoFor = arr[i];                
            }

            //Console.WriteLine(minSoFor);

            if(maxProfit < arr[i] - minSoFor)
            {
                maxProfit =  arr[i] - minSoFor;
                //maxProfit = maxSum;
            }

            //Console.WriteLine(minSoFor);
        }

        return maxProfit;
    }

    static int MaxSumSubArray(int[] arr)
    {
        int cur = 0;
        int max = 0;

        for (int i = 0; i <= arr.Length -1; i++)
        {
            cur = cur + arr[i];

            if(cur > max)
            {
                max = cur;
            }

            if(cur < 0)
            {
                cur = 0;
                //max = 0;
            }
        }

        return max;
    }

    static int MaxNumber(int[] arr)
    {
        int ans = 0;
        int count = 1;

        for (int i = 0; i <= arr.Length -1; i++)
        {
            if(ans == arr[i])
            {
                count++;
            }
            else
                count--;
            
            if(count != 0)
            {
                ans = arr[i];
            }
        }

        return ans;
    }  
}
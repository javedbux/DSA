
public class ArrayMax
{
    public static void DrivingCode()
    {
        //int[] arr = {5,1 ,4 ,1 , 5,5, 1,1};
        int[] arr = {5,1 ,5,5,4 ,1 , 5,5, 1,1};

        Console.WriteLine("MaxNumber");
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
        //Buy Sell
        Console.WriteLine("Buy sell Every Day");
        int[] arr33 = {5,2,6,1,4,7,3,6};
        int[] arr44 = {5,2,6,1,4};
        int ans33 = BuySellStockEveryDay(arr33);
        Console.WriteLine(ans33);

    }

    static int BuySellStockEveryDay(int[] arr)
    {
        int profit = 0;

        for (int i = 1; i <= arr.Length -1; i++)
        {
            if(arr[i] > arr[i-1])
            {
                profit += arr[i] - arr[i-1]; 
            }
        }

        return profit;
    }

    static int BuySellStock(int[] arr)
    {
        int minSofor = arr[0];
        int maxProfit = 0;

        for (int i = 0; i <= arr.Length -1 ; i++)
        {
            minSofor = Math.Min(minSofor, arr[i]);

            int profit = arr[i] - minSofor;

            maxProfit = Math.Max(maxProfit, profit);
        }

        return maxProfit;
    }


    static int MaxSumSubArray(int[] arr)
    {
        int cur = 0;
        int max = 0;
        //Console.WriteLine("Max val");
        for (int i = 0; i <=arr.Length -1; i++)
        {
            cur = cur + arr[i];
            if(cur > max)
            {
                max =cur;
            }

            if(cur < 0)
            {
                cur = 0;
            }
        }

        return max;
    }

    static int MaxNumber(int[] arr)
    {
        int count = 1;
        int cur = 0;

        for (int i = 0; i <= arr.Length - 1; i++)
        {
          if(cur == arr[i])
          {            
            count++;
          }  
          else
            count--;

            if(count < 0)
            {
                //count = 0;
                cur = arr[i];
            }

        }

        return cur;
    }
}
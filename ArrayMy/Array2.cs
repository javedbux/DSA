

public class Array2
{
    public static void DrivingCode()
    {
        int[] arr = {3,1,2,4,0,1,3,2};

        RainWaterTrapping(arr);
        Console.WriteLine();
        RainWaterTrapping2(arr);
    }
    static void RainWaterTrapping2(int[] arr)
    {
        int n = arr.Length;
        int[] left = new int[n];
        int[] right = new int[n];

        left[0] = arr[0];
        
        for(int i =1; i < n -1; i++)
        {
            left[i] = Math.Max(left[i - 1], arr[i]);
        }

        right[n-1] = arr[n-1];
        for(int i = n -2; i >= 0; i--)
        {
            right[i] = Math.Max(right[i +1], arr[i]);
        }

        int ans = 0;

        for(int i =0; i < n-1; i++)
        {
            ans += Math.Min(left[i], right[i]) - arr[i];
        }

        Console.WriteLine(ans);

        for (int i = 0; i < right.Length-1; i++)
        {
            Console.Write(" " + right[i]);
        }

        Console.WriteLine();

        for (int i = 0; i < left.Length -1; i++)
        {
            Console.Write(" " + left[i]);
        }
    }
    static void RainWaterTrapping(int[] arr)
    {
        int n = arr.Length;        
        int[] leftVal = new int[n];
        int[] rightVal = new int[n];

        leftVal[0] = arr[0];

        for (int i = 1; i < n -1; i++)
        {
            leftVal[i] = Math.Max(leftVal[i -1], arr[i]);
        }

        rightVal[n-1] = arr[n-1];

        for(int i= n -2; i >= 0; i -- )
        {
            rightVal[i] = Math.Max(rightVal[i + 1], arr[i]);
        }

        int ans =0;

        for (int i = 0; i < n -1; i++)
        {
            ans += Math.Min(leftVal[i], rightVal[i]) - arr[i] ;
        }

        Console.WriteLine("Total :- " + ans);

        Console.WriteLine();
        
        for (int i = 0; i < leftVal.Length -1; i++)
        {
            Console.Write(" " + leftVal[i]);
        }

        Console.WriteLine();
        for (int i = 0; i < rightVal.Length -1; i++)
        {
            Console.Write(" " + rightVal[i]);
        }
        Console.WriteLine();
    }
}
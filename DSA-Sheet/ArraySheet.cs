
public class ArraySheet
{
    public static void DrivingCode()
    {
        //https://practice.geeksforgeeks.org/problems/missing-number-in-array1416/1?page=1&company[]=Microsoft&sortBy=submissions
        int[] arr = {6,1,2,8,3,4,7,10,5};
        int ans = MissingNumber(arr, 10);
        Console.WriteLine(ans);

        //https://practice.geeksforgeeks.org/problems/kadanes-algorithm-1587115620/1?page=1&company[]=Microsoft&sortBy=submissions

        Console.WriteLine("Max SubArray");
        int[] arr1 = {1,2,3,-2,5};
        int[] arr2 = {-1,-2,-3,-4};
        long ans1 = MaxSubarraySum(arr1, 5);
        Console.WriteLine(ans1);

        //https://practice.geeksforgeeks.org/problems/minimum-number-of-jumps-1587115620/1?page=1&company[]=Microsoft&sortBy=submissions
        // check video so;ution at https://www.youtube.com/watch?v=Yrw3MNh_368  
        Console.WriteLine("Min Jump");
        int[] arr3 = {1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9}; 
        int[] arr4 = {2, 3, 1, 1, 2, 4, 2, 0, 1, 1};
        int[] arr5 = {0, 1, 1, 1, 1};
        
        int ans2 = MinJumps(arr5);
        Console.WriteLine(ans2);
 
    }

    static int MinJumps(int[] arr){
        // your code here

        int jump = 0;
        int pos = 0;
        int des = 0;

        for (int i = 0; i < arr.Length -1; i++)
        {
            des = Math.Max(des, arr[i]+i);
            if(pos == i)
            {
                pos = des;
                jump++;
            }
        }
        return jump;
    }

    // arr: input array
    // n: size of array
    //Function to find the sum of contiguous subarray with maximum sum.
    public static long MaxSubarraySum(int[] arr, int n)
    {
        int curSum = 0;
        int maxSum = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            curSum += arr[i];
            //Console.WriteLine(curSum);
            if(curSum > maxSum)
            {
                maxSum = curSum;
            }

            if(curSum < 0)
            {
                curSum =0;
            }
        }

        return maxSum;
    }

    static int MissingNumber(int[] arr, int n)
    {
        HashSet<int> set1 =new HashSet<int>();
        for (int i = 0; i < n-1; i++)
        {
            set1.Add(arr[i]);
        }

        for (int i = 1; i < n; i++)
        {
            if(!set1.Contains(i))
                return i;
        }

        ///HashSet<int> set2 =new HashSet<int>();


        return n;
    }
}